using System.Security.Cryptography;
using Newtonsoft.Json;

namespace dsBackup
{
    public class ConfigService(string appPath, clsLog log, string fileName = "dsConfig.json")
    {
        private string FilePath => System.IO.Path.Combine(appPath, fileName);

        public bool Exists => File.Exists(FilePath);

        public BackupSettings? Load()
        {
            log.LogEntry(nameof(ConfigService), "Loading Default Config");
            string json = File.ReadAllText(FilePath);
            BackupSettings? settings = JsonConvert.DeserializeObject<BackupSettings>(json);
            if (settings != null)
            {
                settings.Password = UnprotectPassword(settings.Password);
            }
            return settings;
        }

        public void Save(BackupSettings settings)
        {
            BackupSettings toSave = new()
            {
                ServerName = settings.ServerName,
                UserName = settings.UserName,
                Password = ProtectPassword(settings.Password ?? ""),
                WinAuth = settings.WinAuth,
                Databases = settings.Databases,
                Path = settings.Path,
                IntValTime = settings.IntValTime,
                IntValDely = settings.IntValDely,
                IntValAuto = settings.IntValAuto,
                KeepBackupFile = settings.KeepBackupFile,
            };
            string json = JsonConvert.SerializeObject(toSave);
            File.WriteAllText(FilePath, json);
            log.LogEntry(nameof(ConfigService), "Config Saved");
        }

        private static string ProtectPassword(string plain)
        {
            if (string.IsNullOrEmpty(plain)) return plain;
            byte[] cipher = ProtectedData.Protect(System.Text.Encoding.UTF8.GetBytes(plain), null, DataProtectionScope.LocalMachine);
            return Convert.ToBase64String(cipher);
        }

        private static string UnprotectPassword(string? stored)
        {
            if (string.IsNullOrEmpty(stored)) return stored ?? "";
            try
            {
                byte[] plainBytes = ProtectedData.Unprotect(Convert.FromBase64String(stored), null, DataProtectionScope.LocalMachine);
                return System.Text.Encoding.UTF8.GetString(plainBytes);
            }
            catch (Exception)
            {
                // Not a DPAPI blob yet (legacy plaintext config) - use as-is; next Save() encrypts it.
                return stored;
            }
        }
    }
}
