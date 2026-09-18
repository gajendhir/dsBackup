using System.Data;
using System.Diagnostics;

namespace dsBackup
{
    public partial class frmBkp : Form
    {

        bool Loaded;

        readonly clsLog Log;
        readonly ConfigService ConfigSvc;
        readonly BackupService BackupSvc;

        readonly string AppPath, ProgName;

        int tmrDue;
        int tmrCnt;


        public frmBkp()
        {
            InitializeComponent();
            cboTime.SelectedIndex = 0;
            AppPath = Application.CommonAppDataPath;
            ProgName = (typeof(Program).Assembly.GetName().Name ?? "");
            Log = new clsLog();
            ConfigSvc = new ConfigService(AppPath, Log);
            BackupSvc = new BackupService(AppPath, Log);
            numTime.Value = 60;
            try
            {
                bool elevated = AutoStartService.IsElevated();
                if (elevated) Text += " (Administrator)";
                btnRunAdm.Visible = !elevated;
                chkAutoStart.Checked = AutoStartService.IsRegistered(ProgName);
                chkAutoStart.Enabled = elevated;
                toolTip1.SetToolTip(chkAutoStart, elevated
                    ? "Check to start this app automatically when Windows starts. Uncheck to remove it from startup."
                    : "Requires Administrator rights to change. Click \"Run as Administrator\" below, then use this checkbox to add or remove this app from Windows startup.");

            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }

        private void frmBkp_Load(object sender, EventArgs e)
        {
            Loaded = false;

            if (ConfigSvc.Exists)
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
            UpdateStatusBar();
            Loaded = true;
        }

        private void btnSrvrL_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            DataTable DT = BackupService.EnumerateAvailableServers();
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
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = fbd.SelectedPath;
                SaveConfig();
            }
        }

        private void txtPath_TextChanged(object sender, EventArgs e)
        {
            lblPath.Text = txtPath.Text;
        }

        private void chkLDB_Leave(object sender, EventArgs e)
        {
            if (Loaded)
            {
                SaveConfig();
                GetDatabaseString();
            }
        }

        private void chkLDB_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // ItemCheck fires before the new check state is applied, so defer
            // until it has actually taken effect and GetItemChecked() is accurate.
            BeginInvoke(new Action(GetDatabaseString));
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
            pnlDatabase.Visible = true;
            //LoadDatabases();

        }

        private void picPath_Click(object sender, EventArgs e)
        {
            HidePanel();
            pnlPath.Visible = true;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Log.LogEntry(this.Name, "Backup Start");
            pBar.Visible = true;
            lblBkpFile.Visible = true;
            pnlData.Enabled = false;
            pnlSql.Enabled = false;
            pnlDatabase.Enabled = false;
            pnlPath.Enabled = false;

            List<string> databases = [];
            for (int i = 0; i <= (chkLDB.Items.Count - 1); i++)
            {
                if (chkLDB.GetItemChecked(i))
                {
                    databases.Add((string)chkLDB.Items[i]);
                }
            }

            BackupSvc.RunBackup(
                databases,
                txtPath.Text,
                (int)numBkpNoFile.Value,
                onStatus: text => { lblBkpFile.Text = text; Application.DoEvents(); },
                onPercent: percent => pBar.Value = percent);

            lblBkpFile.Text = "Process Completed.";
            pBar.Visible = false;
            pnlData.Enabled = true;
            pnlSql.Enabled = true;
            pnlDatabase.Enabled = true;
            pnlPath.Enabled = true;
            ResetTimer();
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
            if (tmrCnt >= tmrDue)
            {
                if (!BackupSvc.Connected)
                {
                    LoginServer();
                    LoadDatabases();
                }
                btnRun.Enabled = true;
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
                lblDueIn.Text = ScheduleHelper.SecToHrs(tmrDue - tmrCnt);
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
            UpdateStatusBar();
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
            if (Loaded)
            {
                if (chkAutoStart.Checked)
                {
                    AutoStartService.Register(ProgName, Application.ExecutablePath);
                }
                else
                {
                    AutoStartService.Unregister(ProgName);
                }
            }
            UpdateStatusBar();
        }

        private void UpdateStatusBar()
        {
            lblStatusAutoStart.Text = chkAutoStart.Checked ? "Auto-Start: On" : "Auto-Start: Off";
            lblStatusBackup.Text = chkAuto.Checked ? "Backup: Auto" : "Backup: Manual";
            lblStatusAdmin.Visible = AutoStartService.IsElevated();
        }

        private void lblBkpPath_DoubleClick(object sender, EventArgs e)
        {
            OpenInExplorer(lblBkpPath.Text);
        }

        private void lblPath_DoubleClick(object sender, EventArgs e)
        {
            OpenInExplorer(lblPath.Text);
        }

        private static void OpenInExplorer(string path)
        {
            if (string.IsNullOrWhiteSpace(path) || !Directory.Exists(path)) return;
            Process.Start(new ProcessStartInfo
            {
                FileName = "explorer.exe",
                Arguments = "\"" + path + "\"",
                UseShellExecute = true
            });
        }

        private void OpenDataSpecWebsite(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.dataspec.info",
                UseShellExecute = true
            });
        }

        private void OpenUserGuide(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/gajendhir/dsBackup/blob/master/docs/userguide.md",
                UseShellExecute = true
            });
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

        private void SaveConfig()
        {
            List<string> DbList = [];
            for (int i = 0; i <= (chkLDB.Items.Count - 1); i++)
            {
                if (chkLDB.GetItemChecked(i))
                {
                    DbList.Add((string)chkLDB.Items[i]);
                }
            }

            BackupSettings settings = new()
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
            ConfigSvc.Save(settings);
        }

        private void LoadConfig()
        {
            BackupSettings? settings = ConfigSvc.Load();

            if (settings != null)
            {
                cboSrvr.Text = settings.ServerName;
                txtUser.Text = settings.UserName;
                txtPwd.Text = settings.Password;
                optAuthWin.Checked = settings.WinAuth;
                optAuthSql.Checked = !optAuthWin.Checked;
                GetServerString();
                LoginServer();
                LoadDatabases();

                if (settings.Databases != null)
                {
                    for (int j = 0; j <= (settings.Databases.Count - 1); j++)
                    {
                        for (int i = 0; i <= (chkLDB.Items.Count - 1); i++)
                        {
                            if (chkLDB.Items[i].ToString() == settings.Databases[j].ToString())
                            {
                                chkLDB.SetItemChecked(i, true);
                                break;
                            }
                        }
                    }
                }
                GetDatabaseString();

                txtPath.Text = settings.Path;

                numTime.Value = (int)settings.IntValTime;
                cboTime.Text = settings.IntValDely;
                chkAuto.Checked = settings.IntValAuto;

                numBkpNoFile.Value = (int)settings.KeepBackupFile;
            }

            if (numBkpNoFile.Value <= 0)
            {
                numBkpNoFile.Value = 5;
            }
        }


        private void LoginServer()
        {
            if (BackupSvc.Connected)
            {
                BackupSvc.Disconnect();
                btnConnect.Text = "Connect";
                lblServer.ForeColor = Color.Red;
                lblBkpPath.Text = "";
                GetDatabaseString();
            }
            else
            {
                try
                {
                    BackupSvc.Connect(cboSrvr.Text, optAuthWin.Checked, txtUser.Text, txtPwd.Text);
                    btnConnect.Text = "Disconnect";
                    lblServer.ForeColor = Color.Blue;
                    lblBkpPath.Text = BackupSvc.BackupDirectory;
                }
                catch (SystemException Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
            txtPwd.ReadOnly = BackupSvc.Connected;
            txtUser.ReadOnly = BackupSvc.Connected;
            optAuthWin.Enabled = !BackupSvc.Connected;
            optAuthSql.Enabled = !BackupSvc.Connected;
            cboSrvr.Enabled = !BackupSvc.Connected;
            GetServerString();
        }

        private void LoadDatabases()
        {
            chkLDB.Items.Clear();
            if (BackupSvc.Connected)
            {
                try
                {
                    foreach (string name in BackupSvc.GetDatabaseNames())
                    {
                        chkLDB.Items.Add(name);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
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
            if (numTime.Value > 0 && BackupSvc.Connected && chkAuto.Checked)
            {
                pnlTmDue.Visible = true;
                tmrDue = ScheduleHelper.ToSeconds(numTime.Value, cboTime.Text);
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

    }
}
