namespace dsBackup
{
    public class BackupSettings
    {
        public string? ServerName { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public bool WinAuth { get; set; }
        public List<string>? Databases { get; set; }
        public string? Path { get; set; }

        public int IntValTime { get; set; }
        public string? IntValDely { get; set; }
        public bool IntValAuto { get; set; }
        public int KeepBackupFile { get; set; }
    }
}
