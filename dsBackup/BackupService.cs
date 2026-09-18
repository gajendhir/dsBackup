using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using System.Data;
using System.IO.Compression;
using Newtonsoft.Json;

namespace dsBackup
{
    public record DatabaseBackupResult(string Database, bool Success, string Error);

    public class BackupService(string appPath, clsLog log, string statusFileName = "dsStatus.json")
    {
        private ServerConnection? connection;
        private Server? server;

        public bool Connected { get; private set; }
        public string? BackupDirectory => server?.BackupDirectory;

        public static DataTable EnumerateAvailableServers() => SmoApplication.EnumAvailableSqlServers(true);

        public void Connect(string serverInstance, bool windowsAuth, string user, string password)
        {
            connection = windowsAuth
                ? new ServerConnection
                {
                    LoginSecure = false,
                    ServerInstance = serverInstance,
                    Login = user,
                    Authentication = (SqlConnectionInfo.AuthenticationMethod)AuthenticationType.Windows,
                }
                : new ServerConnection
                {
                    LoginSecure = false,
                    ServerInstance = serverInstance,
                    Login = user,
                    Password = password,
                };

            connection.Connect();
            server = new Server(connection);
            Connected = true;
        }

        public void Disconnect()
        {
            connection?.Disconnect();
            connection = null;
            server = null;
            Connected = false;
        }

        public IEnumerable<string> GetDatabaseNames()
        {
            List<string> names = [];
            if (Connected && server != null)
            {
                foreach (Database database in server.Databases)
                {
                    names.Add(database.Name);
                }
            }
            return names;
        }

        public IReadOnlyList<DatabaseBackupResult> RunBackup(IEnumerable<string> databases, string destinationPath, int retentionCount, Action<string>? onStatus = null, Action<int>? onPercent = null)
        {
            List<DatabaseBackupResult> results = [];
            foreach (string dbName in databases)
            {
                try
                {
                    onStatus?.Invoke("Backup " + dbName + " Started");
                    onPercent?.Invoke(0);

                    string newDbName = dbName + "_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");
                    string bakFile = server?.BackupDirectory + @"\" + newDbName + ".DS";
                    string zipFile = destinationPath + @"\" + newDbName + ".zip";

                    BackupDeviceItem bdi = new(bakFile, DeviceType.File);
                    Backup bk = new()
                    {
                        Action = BackupActionType.Database,
                        BackupSetDescription = "Full backup of " + dbName,
                        BackupSetName = dbName + " Backup",
                        Database = dbName,
                        ExpirationDate = DateTime.Today.AddMonths(1),
                        LogTruncation = BackupTruncateLogType.Truncate
                    };
                    bk.Devices.Add(bdi);
                    bk.Incremental = false;
                    bk.PercentCompleteNotification = 5;
                    if (onPercent != null)
                    {
                        bk.PercentComplete += (sender, e) => onPercent(e.Percent);
                    }
                    bk.SqlBackup(server);
                    log.LogEntry(nameof(BackupService), "Backup", bakFile);

                    onStatus?.Invoke("Backup " + dbName + " Completed.");

                    long bakLength = new FileInfo(bakFile).Length;
                    string entryName = Path.GetFileName(bakFile);

                    using (var archive = ZipFile.Open(zipFile, ZipArchiveMode.Create))
                    {
                        onStatus?.Invoke("Compressing \n" + entryName + "\nPlease Wait...");
                        archive.CreateEntryFromFile(bakFile, entryName, CompressionLevel.Fastest);
                    }
                    log.LogEntry(nameof(BackupService), "Compressed", zipFile);

                    if (VerifyZipEntry(zipFile, entryName, bakLength))
                    {
                        DeleteBackupFile(dbName, retentionCount);
                        onStatus?.Invoke("Cache Cleared\n" + dbName + "\nPlease Wait...");
                        results.Add(new DatabaseBackupResult(dbName, true, ""));
                    }
                    else
                    {
                        log.LogEntry(nameof(BackupService), "ERROR", "Zip verification failed, raw file kept: " + zipFile);
                        onStatus?.Invoke("Zip verification failed for\n" + dbName);
                        results.Add(new DatabaseBackupResult(dbName, false, "Zip verification failed: " + zipFile));
                    }
                }
                catch (Exception ex)
                {
                    log.LogEntry(nameof(BackupService), "ERROR", "Backup failed for " + dbName + ": " + ex.Message);
                    onStatus?.Invoke("Backup failed for\n" + dbName);
                    results.Add(new DatabaseBackupResult(dbName, false, ex.Message));
                }
            }
            WriteStatusFile(results);
            return results;
        }

        private static bool VerifyZipEntry(string zipPath, string entryName, long expectedLength)
        {
            try
            {
                using var archive = ZipFile.OpenRead(zipPath);
                var entry = archive.GetEntry(entryName);
                if (entry == null || entry.Length != expectedLength) return false;
                using var stream = entry.Open();
                stream.CopyTo(Stream.Null);
                return true;
            }
            catch (InvalidDataException)
            {
                return false;
            }
        }

        private void DeleteBackupFile(string fileNamePrefix, int retentionCount)
        {
            if (server == null) return;
            DirectoryInfo info = new(server.BackupDirectory);
            FileInfo[] files = [.. info.GetFiles().OrderByDescending(p => p.CreationTime).Where(p => p.Name.StartsWith(fileNamePrefix))];
            int count = 0;
            foreach (FileInfo file in files)
            {
                count += 1;
                if (count > retentionCount && File.Exists(file.ToString()))
                {
                    File.Delete(file.ToString());
                    log.LogEntry(nameof(BackupService), "Deleted.", file.ToString());
                }
            }
        }

        private void WriteStatusFile(IReadOnlyList<DatabaseBackupResult> results)
        {
            var status = new
            {
                LastRun = DateTime.Now,
                Success = results.All(r => r.Success),
                Databases = results.Select(r => new { r.Database, r.Success, r.Error }).ToList()
            };
            string json = JsonConvert.SerializeObject(status, Formatting.Indented);
            File.WriteAllText(Path.Combine(appPath, statusFileName), json);
            log.LogEntry(nameof(BackupService), "Status Written", statusFileName);
        }
    }
}
