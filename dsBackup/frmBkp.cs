using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using System.Data;
using System.IO.Compression;
using System.IO;
using Microsoft.Win32;
using System.Security.Principal;
using System.Diagnostics;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace dsBackup
{
    public partial class frmBkp : Form
    {

        bool Loaded, Logged;

        ServerConnection? Srvr;
        Server? SqSr;
        readonly clsLog Log;
        readonly RegistryKey? rkApp = null;

        readonly string AppPath, ProgName;
        readonly string xFile = "dsConfig.json";

        int tmrDue;
        int tmrCnt;


        public frmBkp()
        {
            InitializeComponent();
            cboTime.SelectedIndex=0;
            AppPath = Application.CommonAppDataPath;
            lblConfigPath.Text = AppPath;
            ProgName = (typeof(Program).Assembly.GetName().Name ?? "");
            Log = new clsLog();
            numTime.Value = 60;
            try
            {
                chkAutoStart.Visible = IsAdministrator();
                btnRunAdm.Visible = !IsAdministrator();
                rkApp = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                if (rkApp != null)
                {
                    chkAutoStart.Checked = rkApp.GetValue(ProgName) != null;
                }

            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }

        private void frmBkp_Load(object sender, EventArgs e)
        {
            Loaded= false;
           
           if (System.IO.File.Exists(AppPath + @"\" + xFile)) 
            {
                
                LoadConfig(); 
                HidePanel();

            }
           else
            {
                picSql_Click(sender, e);
                cboSrvr.Text = System.Environment.MachineName;
                txtUser.Text = "sa";
                optAuthWin.Checked = true;
                cboSrvr.Focus();
               }
           Loaded =true;
        }

        private void btnSrvrL_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            DataTable DT  = SmoApplication.EnumAvailableSqlServers(true);
            cboSrvr.ValueMember = "Name";
            cboSrvr.DataSource = DT;
            Cursor = Cursors.Default;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            LoginServer();
            SaveConfig();
            LoadDatabases();
        }

        private void btnOpnFile_Click(object sender, EventArgs e)
        {
            fbd.SelectedPath = txtPath.Text;
            if (fbd.ShowDialog()==DialogResult.OK)
            {
                txtPath.Text = fbd.SelectedPath;
                lblPath.Text = txtPath.Text;
                SaveConfig();
            }
        }

        private void chkLDB_Leave(object sender, EventArgs e)
        {
            if (Loaded)
            { 
            SaveConfig();
            GetDatabaseString();
            }
        }

        private void chkPwd_CheckedChanged(object sender, EventArgs e)
        {
            if (Loaded)
            {
                txtPwd.UseSystemPasswordChar = !chkPwd.Checked;
            }
        }

        private void picSql_Click(object sender, EventArgs e)
        {
            HidePanel();
            pnlSql.Visible = true;
        }

        private void picDB_Click(object sender, EventArgs e)
        {
            HidePanel();
            pnlDatabase.Visible= true;
            //LoadDatabases();

        }

        private void picPath_Click(object sender, EventArgs e)
        {
            HidePanel();
            pnlPath.Visible= true;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Log.LogEntry(this.Name, "Backup Start");
            pBar.Visible = true;
            lblBkpFile.Visible = true;
            pnlData.Enabled= false;
            pnlSql.Enabled= false;
            pnlDatabase.Enabled= false;
            pnlPath.Enabled= false;
            int i;
            for (i = 0; i <= (chkLDB.Items.Count - 1); i++)
            {
                if (chkLDB.GetItemChecked(i))
                {
                    string dbName = (string) chkLDB.Items[i];
                    lblBkpFile.Text = "Backup " + dbName +" Started";
                    Application.DoEvents();
                    BackupDeviceItem bdi;
                    string NewDbName = dbName + "_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");
                    string xBakFile = SqSr?.BackupDirectory + @"\" + NewDbName + ".DS";
                    string xZipFile = txtPath.Text + @"\" + NewDbName + ".zip";

                    bdi = new BackupDeviceItem(xBakFile, DeviceType.File);
                    Backup? Bk = new();
                    Bk = new Backup()
                    {
                        Action = BackupActionType.Database,
                        BackupSetDescription = "Full backup of " + dbName,
                        BackupSetName = dbName + " Backup",
                        Database = dbName,
                        ExpirationDate = DateTime.Today.AddMonths(1),
                        LogTruncation = BackupTruncateLogType.Truncate
                    };
                    Bk.Devices.Add(bdi);
                    Bk.Incremental = false;
                    Bk.PercentCompleteNotification = 5;
                    Bk.PercentComplete += pctComplete;
                    pBar.Visible = true;
                    pBar.Value = 0;
                    lblBkpFile.Visible = true;
                    Bk.SqlBackup(SqSr);
                    Log.LogEntry(this.Name, "Backup", xBakFile);

                    lblBkpFile.Text = "Backup " + dbName + " Completed.";
                    Application.DoEvents();

                    using (var archive = ZipFile.Open(xZipFile, ZipArchiveMode.Create))
                    {
                        lblBkpFile.Text = "Compressing \n"  + Path.GetFileName(xBakFile) + "\nPlease Wait...";
                        Application.DoEvents();
                        archive.CreateEntryFromFile(xBakFile, Path.GetFileName(xBakFile), CompressionLevel.Fastest);
                    }
                    Application.DoEvents();
                    Log.LogEntry(this.Name, "Compressed",xZipFile);

                    DeleteBackupFile(dbName);
                    lblBkpFile.Text = "Cache Cleared\n" + dbName + "\nPlease Wait...";

                    Application.DoEvents();
                }
            }
            lblBkpFile.Text = "Process Completed.";
            pBar.Visible = false;
            pnlData.Enabled = true;
            pnlSql.Enabled = true;
            pnlDatabase.Enabled = true;
            pnlPath.Enabled = true;
            ResetTimer();
        }

        void pctComplete(object server, PercentCompleteEventArgs e)
        {
            pBar.Value = e.Percent;
        }

        private void numTime_Leave(object sender, EventArgs e)
        {
            if (Loaded)
            {
                SaveConfig();
            }
        }

        private void cboTime_Leave(object sender, EventArgs e)
        {
            if (Loaded)
            {
                SaveConfig();
            }
        }

        private void tmrRef_Tick(object sender, EventArgs e)
        {
           tmrCnt += 1;
            if(tmrCnt >= tmrDue)
              {
                if (!Logged )
                {
                    LoginServer();
                    LoadDatabases();
                }
                btnRun.Enabled =true;
                pBarTmr.Value = 0;
                tmrRef.Enabled = false;
                lblDueIn.Text = "Backup Process";
                tmrCnt = 0;
                btnRun_Click(sender, e);
              }
            else
                {
                    btnRun.Enabled = false;
                    //tmrRef.Enabled = false;
                    lblDueIn.Text = SecToHrs(tmrDue - tmrCnt);
                    pBarTmr.Value = tmrCnt;// Convert.ToInt32(tmrDue - tmrCnt);
                    tmrRef.Enabled = true;
                }
        }

        private void numTime_ValueChanged(object sender, EventArgs e)
        {
            ResetTimer();
        }

        private void cboTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetTimer();
        }


        private void chkAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (Loaded)
            {
                SaveConfig();
                ResetTimer();
                tmrRef.Enabled = chkAuto.Checked;
                btnRun.Enabled = !chkAuto.Checked;
            }
        }

        private void numBkpNoFile_Leave(object sender, EventArgs e)
        {
            if (Loaded)
            {
                SaveConfig();
            }
        }


        private void btnStop_Click(object sender, EventArgs e)
        {
           LoadConfig();
            
        }

        private void chkAutoStart_CheckedChanged(object sender, EventArgs e)
        {
            if (rkApp != null)
            {
                if (chkAutoStart.Checked)
                {
                    rkApp.SetValue(ProgName, Application.ExecutablePath.ToString());
                }
                else
                {
                    rkApp.DeleteValue(ProgName, false);
                }
            }
        }

        private void HidePanel()
        {
            pnlSql.Visible = false;
            pnlDatabase.Visible = false;
            pnlPath.Visible = false;
        }

        private void GetServerString()
        {
            lblServer.Text = "Server:" + cboSrvr.Text + (optAuthWin.Checked ? ", Windows Authentication" : ", User:" + txtUser.Text + ", Pwd:*****");
        }

        private void GetDatabaseString()
        {
            string xTxt = "";
            int i;
            for (i = 0; i <= (chkLDB.Items.Count - 1); i++)
            {
                if (chkLDB.GetItemChecked(i))
                {
                    xTxt += chkLDB.Items[i].ToString() + " ";
                }
            }
            lblDatabase.Text = xTxt;
        }


        class configInfo
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

        private void SaveConfig()
        {
            List<string> DbList = new();
            int i;
            for (i = 0; i <= (chkLDB.Items.Count - 1); i++)
            {
                if (chkLDB.GetItemChecked(i))
                {
                    DbList.Add((string)chkLDB.Items[i]);
                }
            }

            configInfo CnfInfo = new()
            {
                ServerName = cboSrvr.Text,
                UserName = txtUser.Text,
                Password = txtPwd.Text,
                WinAuth = optAuthWin.Checked,
                Databases = DbList,
                Path = txtPath.Text,
                IntValTime = (int)numTime.Value,
                IntValDely = cboTime.Text,
                IntValAuto = chkAuto.Checked,
                KeepBackupFile = (int)numBkpNoFile.Value,

            };
            string Txtjson = JsonConvert.SerializeObject(CnfInfo);
            System.IO.File.WriteAllText(AppPath + @"\" + xFile, Txtjson);
            Log.LogEntry(this.Name, "Config Saved");
        }

        private void LoadConfig()
        {
            Log.LogEntry(this.Name, "Loading Default Config");
            int i;

            string? Jsontext = File.ReadAllText(AppPath + @"\" + xFile);
            
            configInfo? CnfgDate = JsonConvert.DeserializeObject<configInfo>(Jsontext);

            if (CnfgDate != null)
            {
                cboSrvr.Text = CnfgDate.ServerName;
                txtUser.Text = CnfgDate.UserName;
                txtPwd.Text = CnfgDate.Password;
                optAuthWin.Checked = CnfgDate.WinAuth;
                optAuthSql.Checked = !optAuthWin.Checked; 
                GetServerString();
                LoginServer();
                LoadDatabases();

                if (CnfgDate.Databases != null)
                { 
                    for (int j = 0; j <= (CnfgDate.Databases.Count - 1); j++)
                        {
                            for (i = 0; i <= (chkLDB.Items.Count - 1); i++)
                            {
                                if (chkLDB.Items[i].ToString() == CnfgDate.Databases[j].ToString())
                                {
                                    chkLDB.SetItemChecked(i, true);
                                    break;
                                }
                            }
                        }
                }
                GetDatabaseString();

                txtPath.Text = CnfgDate.Path ;
                lblPath.Text = CnfgDate.Path;

                numTime.Value = (int)CnfgDate.IntValTime;
                cboTime.Text = CnfgDate.IntValDely;
                chkAuto.Checked = (bool)CnfgDate.IntValAuto;

                numBkpNoFile.Value = (int)CnfgDate.KeepBackupFile;
            }

            if (numBkpNoFile.Value <= 0)
            {
                numBkpNoFile.Value = 5;
            }
        }

       
        private void LoginServer()
        {
            if (Logged)
            {
                Srvr?.Disconnect();
                SqSr = null;
                Srvr = null;
                Logged = false;
                btnConnect.Text = "Connect";
                lblServer.ForeColor = Color.Red;
                lblBkpPath.Text = "";
                GetDatabaseString();
            }
            else
            {
                if (optAuthWin.Checked )
                {
                    Srvr = new ServerConnection()
                    {
                        LoginSecure = false,
                        ServerInstance = cboSrvr.Text,
                        Login = txtUser.Text,
                        Authentication = (SqlConnectionInfo.AuthenticationMethod)AuthenticationType.Windows,
                    };
                }
                else
                {
                    Srvr = new ServerConnection()
                    {
                        LoginSecure = false,
                        ServerInstance = cboSrvr.Text,
                        Login = txtUser.Text,
                        Password = txtPwd.Text,
                    };
                }
                try
                {
                    Srvr.Connect();
                    SqSr = new Server(Srvr);
                    Logged = true;
                    btnConnect.Text = "Disconnect";
                    lblServer.ForeColor = Color.Blue;
                    lblBkpPath.Text = SqSr.BackupDirectory;
                }
                catch (SystemException Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
            txtPwd.ReadOnly = Logged;
            txtUser.ReadOnly = Logged;
            optAuthWin.Enabled = !Logged;
            optAuthSql.Enabled = !Logged;
            cboSrvr.Enabled = !Logged; 
            GetServerString();
        }

        private void LoadDatabases()
        {
            chkLDB.Items.Clear();
            if (Logged)
            {
                try
                {
                    //btnSetPath.Enabled = false;
                    //txtPath.Text = Sqr.BackupDirectory;
                    if (SqSr != null)
                    {
                        foreach (Database database in SqSr.Databases) { 
                        chkLDB.Items.Add(database.Name);
                                                }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void DeleteBackupFile(String xFileName)
        {
            Int32 xCnt = 0;
            if (SqSr != null)
            {
                DirectoryInfo info = new(SqSr.BackupDirectory);
                FileInfo[] files = info.GetFiles().OrderByDescending(p => p.CreationTime).Where(p => p.Name.StartsWith(xFileName)).ToArray();
                foreach (FileInfo file in files)
                {
                    xCnt += 1;
                    if (xCnt > numBkpNoFile.Value)
                    {
                        if (File.Exists(file.ToString()))
                        {
                            File.Delete(file.ToString());
                            Log.LogEntry(this.Name, "Deleted.", file.ToString());
                        }
                    }
                }
            }
        }

        private static string SecToHrs(int Sec)
        {
            int s = Sec % 60;
            int min = Sec / 60;
            int m = min % 60;
            int h = min / 60;

            return $"{h:00}:{m:00}:{s:00}";

        }

        private void btnRunAdm_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new()
            {
                UseShellExecute = true,
                WorkingDirectory = Environment.CurrentDirectory,
                FileName = Application.ExecutablePath,
                Verb = "runas"
            };
            try
            {
                Process? p = Process.Start(startInfo);
            }
            catch (System.ComponentModel.Win32Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return;
            }

            Application.Exit();
        }

        private void optAuthWin_CheckedChanged(object sender, EventArgs e)
        {
            lblUser.Visible = !optAuthWin.Checked;
            txtUser.Visible = !optAuthWin.Checked;
            lblPwd.Visible = !optAuthWin.Checked;
            txtPwd.Visible = !optAuthWin.Checked;
            chkPwd.Visible = !optAuthWin.Checked;
        }

        private void ResetTimer()
        {
            if (numTime.Value > 0 && Logged && chkAuto.Checked)
            {
                pnlTmDue.Visible = true;
                if (cboTime.Text == "Hrs")
                {
                    tmrDue = Convert.ToInt32(numTime.Value * 60 * 60);
                }
                else
                {
                    tmrDue = Convert.ToInt32(numTime.Value * 60);
                }
                pBarTmr.Visible = true;
                pBarTmr.Value = 0;
                pBarTmr.Maximum = tmrDue;
                tmrRef.Enabled = true;
            }
            else
            {
                pnlTmDue.Visible = false;
                lblDueIn.Text = "";
                pBarTmr.Visible = false;
                pBarTmr.Value = 0;
                pBarTmr.Maximum = tmrDue;
                tmrRef.Enabled = false;
            }
        }

        public static bool IsAdministrator()
        {
            return (new WindowsPrincipal(WindowsIdentity.GetCurrent()))
                      .IsInRole(WindowsBuiltInRole.Administrator);
        }
    }
}
