using Microsoft.Win32;
using System.Security.Principal;

namespace dsBackup
{
    public static class AutoStartService
    {
        private const string RunKeyPath = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";

        public static bool IsElevated()
        {
            return new WindowsPrincipal(WindowsIdentity.GetCurrent())
                .IsInRole(WindowsBuiltInRole.Administrator);
        }

        public static bool IsRegistered(string appName)
        {
            using RegistryKey? key = Registry.LocalMachine.OpenSubKey(RunKeyPath, false);
            return key?.GetValue(appName) != null;
        }

        public static void Register(string appName, string exePath)
        {
            using RegistryKey? key = Registry.LocalMachine.OpenSubKey(RunKeyPath, true);
            key?.SetValue(appName, exePath);
        }

        public static void Unregister(string appName)
        {
            using RegistryKey? key = Registry.LocalMachine.OpenSubKey(RunKeyPath, true);
            key?.DeleteValue(appName, false);
        }
    }
}
