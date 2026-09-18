namespace dsBackup
{
    partial class frmBkp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBkp));
            toolTip1 = new ToolTip(components);
            lblBkpPath = new Label();
            lblPath = new Label();
            lblServer = new Label();
            chkAutoStart = new CheckBox();
            label13 = new Label();
            pictureBox7 = new PictureBox();
            btnRunAdm = new Button();
            lblStatusAutoStart = new Label();
            lblStatusBackup = new Label();
            lblStatusAdmin = new Label();
            pnlData = new Panel();
            btnReload = new Button();
            label21 = new Label();
            numBkpNoFile = new NumericUpDown();
            label20 = new Label();
            label19 = new Label();
            chkAuto = new CheckBox();
            cboTime = new ComboBox();
            numTime = new NumericUpDown();
            pictureBox1 = new PictureBox();
            label17 = new Label();
            label18 = new Label();
            lblDatabase = new Label();
            pictureBox5 = new PictureBox();
            picPath = new PictureBox();
            label6 = new Label();
            label7 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            picDB = new PictureBox();
            label4 = new Label();
            label5 = new Label();
            picSql = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnRun = new Button();
            lblBkpFile = new Label();
            pBar = new ProgressBar();
            pnlSql = new Panel();
            optAuthSql = new RadioButton();
            optAuthWin = new RadioButton();
            chkPwd = new CheckBox();
            btnSrvrL = new Button();
            cboSrvr = new ComboBox();
            label11 = new Label();
            btnConnect = new Button();
            txtPwd = new TextBox();
            lblPwd = new Label();
            txtUser = new TextBox();
            lblUser = new Label();
            label8 = new Label();
            pnlDatabase = new Panel();
            chkLDB = new CheckedListBox();
            label12 = new Label();
            label14 = new Label();
            pnlPath = new Panel();
            btnOpnFile = new Button();
            txtPath = new TextBox();
            label15 = new Label();
            fbd = new FolderBrowserDialog();
            tmrRef = new System.Windows.Forms.Timer(components);
            pBarTmr = new ProgressBar();
            lblDueIn = new Label();
            label16 = new Label();
            pnlTmDue = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numBkpNoFile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picPath).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSql).BeginInit();
            pnlSql.SuspendLayout();
            pnlDatabase.SuspendLayout();
            pnlPath.SuspendLayout();
            pnlTmDue.SuspendLayout();
            SuspendLayout();
            // 
            // lblBkpPath
            // 
            lblBkpPath.AutoEllipsis = true;
            lblBkpPath.Cursor = Cursors.Hand;
            lblBkpPath.ForeColor = Color.Blue;
            lblBkpPath.Location = new Point(140, 224);
            lblBkpPath.Margin = new Padding(4, 0, 4, 0);
            lblBkpPath.Name = "lblBkpPath";
            lblBkpPath.Size = new Size(208, 21);
            lblBkpPath.TabIndex = 24;
            lblBkpPath.Text = "Backup Path";
            toolTip1.SetToolTip(lblBkpPath, "Double-click to open this folder in File Explorer.");
            lblBkpPath.DoubleClick += lblBkpPath_DoubleClick;
            // 
            // lblPath
            // 
            lblPath.AutoEllipsis = true;
            lblPath.Cursor = Cursors.Hand;
            lblPath.ForeColor = Color.Blue;
            lblPath.Location = new Point(140, 245);
            lblPath.Margin = new Padding(4, 0, 4, 0);
            lblPath.Name = "lblPath";
            lblPath.Size = new Size(208, 21);
            lblPath.TabIndex = 9;
            lblPath.Text = "Path";
            toolTip1.SetToolTip(lblPath, "Double-click to open this folder in File Explorer.");
            lblPath.DoubleClick += lblPath_DoubleClick;
            // 
            // lblServer
            // 
            lblServer.AutoSize = true;
            lblServer.Cursor = Cursors.Hand;
            lblServer.ForeColor = Color.Blue;
            lblServer.Location = new Point(55, 73);
            lblServer.Margin = new Padding(4, 0, 4, 0);
            lblServer.Name = "lblServer";
            lblServer.Size = new Size(39, 15);
            lblServer.TabIndex = 3;
            lblServer.Text = "Server";
            toolTip1.SetToolTip(lblServer, "Click to open SQL Server connection settings.");
            lblServer.Click += picSql_Click;
            // 
            // chkAutoStart
            // 
            chkAutoStart.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            chkAutoStart.AutoSize = true;
            chkAutoStart.Location = new Point(15, 439);
            chkAutoStart.Name = "chkAutoStart";
            chkAutoStart.Size = new Size(167, 19);
            chkAutoStart.TabIndex = 28;
            chkAutoStart.Text = "Load on Windows Start-up";
            toolTip1.SetToolTip(chkAutoStart, "Check to start this app automatically when Windows starts. Uncheck to remove it from startup.");
            chkAutoStart.UseVisualStyleBackColor = true;
            chkAutoStart.CheckedChanged += chkAutoStart_CheckedChanged;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Cursor = Cursors.Hand;
            label13.Font = new Font("Arial", 14F, FontStyle.Bold);
            label13.ImageAlign = ContentAlignment.MiddleLeft;
            label13.Location = new Point(609, 27);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(104, 22);
            label13.TabIndex = 17;
            label13.Text = "Data Spec";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            toolTip1.SetToolTip(label13, "Visit www.dataspec.info");
            label13.Click += OpenDataSpecWebsite;
            // 
            // pictureBox7
            // 
            pictureBox7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox7.Cursor = Cursors.Hand;
            pictureBox7.Image = Properties.Resources.dslogo;
            pictureBox7.Location = new Point(721, 12);
            pictureBox7.Margin = new Padding(4, 3, 4, 3);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(43, 40);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 3;
            pictureBox7.TabStop = false;
            toolTip1.SetToolTip(pictureBox7, "Visit www.dataspec.info");
            pictureBox7.Click += OpenDataSpecWebsite;
            // 
            // btnRunAdm
            // 
            btnRunAdm.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRunAdm.Location = new Point(12, 456);
            btnRunAdm.Name = "btnRunAdm";
            btnRunAdm.Size = new Size(147, 23);
            btnRunAdm.TabIndex = 29;
            btnRunAdm.Text = "Run as Administrator";
            toolTip1.SetToolTip(btnRunAdm, "Relaunches this app with Administrator rights so you can enable or disable autostart.");
            btnRunAdm.UseVisualStyleBackColor = true;
            btnRunAdm.Click += btnRunAdm_Click;
            // 
            // lblStatusAutoStart
            // 
            lblStatusAutoStart.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblStatusAutoStart.Location = new Point(319, 457);
            lblStatusAutoStart.Margin = new Padding(4, 0, 4, 0);
            lblStatusAutoStart.Name = "lblStatusAutoStart";
            lblStatusAutoStart.Size = new Size(130, 21);
            lblStatusAutoStart.TabIndex = 30;
            lblStatusAutoStart.Text = "Auto-Start: Off";
            toolTip1.SetToolTip(lblStatusAutoStart, "Whether this app launches automatically when Windows starts.");
            // 
            // lblStatusBackup
            // 
            lblStatusBackup.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblStatusBackup.Location = new Point(459, 457);
            lblStatusBackup.Margin = new Padding(4, 0, 4, 0);
            lblStatusBackup.Name = "lblStatusBackup";
            lblStatusBackup.Size = new Size(110, 21);
            lblStatusBackup.TabIndex = 31;
            lblStatusBackup.Text = "Backup: Manual";
            toolTip1.SetToolTip(lblStatusBackup, "Whether backups run on a schedule (Auto) or only when you click \"Backup Now\" (Manual).");
            // 
            // lblStatusAdmin
            // 
            lblStatusAdmin.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblStatusAdmin.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            lblStatusAdmin.ForeColor = Color.FromArgb(0, 120, 0);
            lblStatusAdmin.Location = new Point(189, 456);
            lblStatusAdmin.Margin = new Padding(4, 0, 4, 0);
            lblStatusAdmin.Name = "lblStatusAdmin";
            lblStatusAdmin.Size = new Size(81, 21);
            lblStatusAdmin.TabIndex = 32;
            lblStatusAdmin.Text = "Admin";
            toolTip1.SetToolTip(lblStatusAdmin, "This app is running with Administrator rights.");
            lblStatusAdmin.Visible = false;
            // 
            // pnlData
            // 
            pnlData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pnlData.Controls.Add(btnReload);
            pnlData.Controls.Add(label21);
            pnlData.Controls.Add(numBkpNoFile);
            pnlData.Controls.Add(label20);
            pnlData.Controls.Add(label19);
            pnlData.Controls.Add(lblBkpPath);
            pnlData.Controls.Add(chkAuto);
            pnlData.Controls.Add(cboTime);
            pnlData.Controls.Add(numTime);
            pnlData.Controls.Add(pictureBox1);
            pnlData.Controls.Add(label17);
            pnlData.Controls.Add(label18);
            pnlData.Controls.Add(lblPath);
            pnlData.Controls.Add(lblDatabase);
            pnlData.Controls.Add(lblServer);
            pnlData.Controls.Add(pictureBox5);
            pnlData.Controls.Add(picPath);
            pnlData.Controls.Add(label6);
            pnlData.Controls.Add(label7);
            pnlData.Controls.Add(pictureBox4);
            pnlData.Controls.Add(pictureBox3);
            pnlData.Controls.Add(picDB);
            pnlData.Controls.Add(label4);
            pnlData.Controls.Add(label5);
            pnlData.Controls.Add(picSql);
            pnlData.Controls.Add(label3);
            pnlData.Controls.Add(label2);
            pnlData.Controls.Add(label1);
            pnlData.Location = new Point(13, 12);
            pnlData.Margin = new Padding(4, 3, 4, 3);
            pnlData.Name = "pnlData";
            pnlData.Size = new Size(375, 421);
            pnlData.TabIndex = 1;
            // 
            // btnReload
            // 
            btnReload.Location = new Point(233, 2);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(127, 23);
            btnReload.TabIndex = 27;
            btnReload.Text = "Reload Settings";
            btnReload.UseVisualStyleBackColor = true;
            btnReload.Click += btnStop_Click;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Arial", 12F, FontStyle.Bold);
            label21.Location = new Point(273, 293);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(98, 19);
            label21.TabIndex = 28;
            label21.Text = "No. to Keep";
            // 
            // numBkpNoFile
            // 
            numBkpNoFile.Font = new Font("Arial", 9.75F);
            numBkpNoFile.Location = new Point(294, 315);
            numBkpNoFile.Margin = new Padding(4, 3, 4, 3);
            numBkpNoFile.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            numBkpNoFile.Name = "numBkpNoFile";
            numBkpNoFile.Size = new Size(66, 22);
            numBkpNoFile.TabIndex = 27;
            numBkpNoFile.TextAlign = HorizontalAlignment.Center;
            numBkpNoFile.Value = new decimal(new int[] { 5, 0, 0, 0 });
            numBkpNoFile.Leave += numBkpNoFile_Leave;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(55, 243);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new Size(54, 15);
            label20.TabIndex = 26;
            label20.Text = "Zip Path:";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(55, 224);
            label19.Margin = new Padding(4, 0, 4, 0);
            label19.Name = "label19";
            label19.Size = new Size(76, 15);
            label19.TabIndex = 25;
            label19.Text = "Backup Path:";
            // 
            // chkAuto
            // 
            chkAuto.AutoSize = true;
            chkAuto.Location = new Point(57, 355);
            chkAuto.Margin = new Padding(4, 3, 4, 3);
            chkAuto.Name = "chkAuto";
            chkAuto.Size = new Size(132, 19);
            chkAuto.TabIndex = 18;
            chkAuto.Text = "Enable Auto Backup";
            chkAuto.UseVisualStyleBackColor = true;
            chkAuto.CheckedChanged += chkAuto_CheckedChanged;
            // 
            // cboTime
            // 
            cboTime.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboTime.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboTime.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTime.Font = new Font("Arial", 9.75F);
            cboTime.FormattingEnabled = true;
            cboTime.Items.AddRange(new object[] { "Min", "Hrs" });
            cboTime.Location = new Point(151, 316);
            cboTime.Margin = new Padding(4, 3, 4, 3);
            cboTime.Name = "cboTime";
            cboTime.Size = new Size(87, 24);
            cboTime.TabIndex = 13;
            cboTime.SelectedIndexChanged += cboTime_SelectedIndexChanged;
            cboTime.Leave += cboTime_Leave;
            // 
            // numTime
            // 
            numTime.Font = new Font("Arial", 9.75F);
            numTime.Location = new Point(55, 317);
            numTime.Margin = new Padding(4, 3, 4, 3);
            numTime.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            numTime.Name = "numTime";
            numTime.Size = new Size(90, 22);
            numTime.TabIndex = 12;
            numTime.TextAlign = HorizontalAlignment.Center;
            numTime.ValueChanged += numTime_ValueChanged;
            numTime.Leave += numTime_Leave;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.sand_timer;
            pictureBox1.Location = new Point(4, 273);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // label17
            // 
            label17.BorderStyle = BorderStyle.FixedSingle;
            label17.Location = new Point(1, 267);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(385, 2);
            label17.TabIndex = 10;
            label17.Text = "label17";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Arial", 12F, FontStyle.Bold);
            label18.ImageAlign = ContentAlignment.MiddleLeft;
            label18.Location = new Point(44, 293);
            label18.Margin = new Padding(4, 0, 4, 0);
            label18.Name = "label18";
            label18.Size = new Size(187, 19);
            label18.TabIndex = 11;
            label18.Text = "Set Interval For Backup";
            label18.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDatabase
            // 
            lblDatabase.AutoEllipsis = true;
            lblDatabase.ForeColor = Color.Blue;
            lblDatabase.Location = new Point(55, 150);
            lblDatabase.Margin = new Padding(4, 0, 4, 0);
            lblDatabase.Name = "lblDatabase";
            lblDatabase.Size = new Size(264, 15);
            lblDatabase.TabIndex = 6;
            lblDatabase.Text = "Database";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.cloud_backup;
            pictureBox5.Location = new Point(4, 197);
            pictureBox5.Margin = new Padding(4, 3, 4, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(32, 32);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 13;
            pictureBox5.TabStop = false;
            // 
            // picPath
            // 
            picPath.Image = Properties.Resources.settings;
            picPath.Location = new Point(336, 194);
            picPath.Margin = new Padding(4, 3, 4, 3);
            picPath.Name = "picPath";
            picPath.Size = new Size(24, 24);
            picPath.SizeMode = PictureBoxSizeMode.StretchImage;
            picPath.TabIndex = 12;
            picPath.TabStop = false;
            picPath.Click += picPath_Click;
            // 
            // label6
            // 
            label6.BorderStyle = BorderStyle.FixedSingle;
            label6.Location = new Point(4, 190);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(385, 2);
            label6.TabIndex = 7;
            label6.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Bold);
            label7.ImageAlign = ContentAlignment.MiddleLeft;
            label7.Location = new Point(44, 197);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(272, 19);
            label7.TabIndex = 8;
            label7.Text = "Store Backup In Selected Location";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.database;
            pictureBox4.Location = new Point(4, 122);
            pictureBox4.Margin = new Padding(4, 3, 4, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(32, 32);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.mssql;
            pictureBox3.Location = new Point(4, 47);
            pictureBox3.Margin = new Padding(4, 3, 4, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // picDB
            // 
            picDB.Image = Properties.Resources.settings;
            picDB.Location = new Point(336, 122);
            picDB.Margin = new Padding(4, 3, 4, 3);
            picDB.Name = "picDB";
            picDB.Size = new Size(24, 24);
            picDB.SizeMode = PictureBoxSizeMode.StretchImage;
            picDB.TabIndex = 7;
            picDB.TabStop = false;
            picDB.Click += picDB_Click;
            // 
            // label4
            // 
            label4.BorderStyle = BorderStyle.FixedSingle;
            label4.Location = new Point(4, 115);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(385, 2);
            label4.TabIndex = 4;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Bold);
            label5.ImageAlign = ContentAlignment.MiddleLeft;
            label5.Location = new Point(44, 122);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(132, 19);
            label5.TabIndex = 5;
            label5.Text = "Select Database";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // picSql
            // 
            picSql.Image = Properties.Resources.settings;
            picSql.Location = new Point(336, 47);
            picSql.Margin = new Padding(4, 3, 4, 3);
            picSql.Name = "picSql";
            picSql.Size = new Size(24, 24);
            picSql.SizeMode = PictureBoxSizeMode.StretchImage;
            picSql.TabIndex = 4;
            picSql.TabStop = false;
            picSql.Click += picSql_Click;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.Control;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(2, 42);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(385, 2);
            label3.TabIndex = 1;
            label3.Text = "label3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Bold);
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(44, 47);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(255, 19);
            label2.TabIndex = 2;
            label2.Text = "Connect To Microsoft Sql Server";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold);
            label1.Location = new Point(12, 8);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(177, 24);
            label1.TabIndex = 0;
            label1.Text = "Automatic Backup";
            // 
            // btnRun
            // 
            btnRun.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRun.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            btnRun.Image = Properties.Resources.play;
            btnRun.ImageAlign = ContentAlignment.MiddleLeft;
            btnRun.Location = new Point(607, 430);
            btnRun.Margin = new Padding(4, 3, 4, 3);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(157, 45);
            btnRun.TabIndex = 14;
            btnRun.Text = "Backup Now";
            btnRun.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRun.Click += btnRun_Click;
            // 
            // lblBkpFile
            // 
            lblBkpFile.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblBkpFile.ForeColor = Color.Blue;
            lblBkpFile.Location = new Point(477, 332);
            lblBkpFile.Margin = new Padding(4, 0, 4, 0);
            lblBkpFile.Name = "lblBkpFile";
            lblBkpFile.Size = new Size(229, 54);
            lblBkpFile.TabIndex = 15;
            lblBkpFile.Text = "File";
            lblBkpFile.TextAlign = ContentAlignment.TopCenter;
            lblBkpFile.Visible = false;
            // 
            // pBar
            // 
            pBar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pBar.Location = new Point(479, 309);
            pBar.Margin = new Padding(4, 3, 4, 3);
            pBar.Name = "pBar";
            pBar.Size = new Size(227, 20);
            pBar.TabIndex = 16;
            pBar.Visible = false;
            // 
            // pnlSql
            // 
            pnlSql.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlSql.BackColor = Color.FromArgb(255, 224, 192);
            pnlSql.Controls.Add(optAuthSql);
            pnlSql.Controls.Add(optAuthWin);
            pnlSql.Controls.Add(chkPwd);
            pnlSql.Controls.Add(btnSrvrL);
            pnlSql.Controls.Add(cboSrvr);
            pnlSql.Controls.Add(label11);
            pnlSql.Controls.Add(btnConnect);
            pnlSql.Controls.Add(txtPwd);
            pnlSql.Controls.Add(lblPwd);
            pnlSql.Controls.Add(txtUser);
            pnlSql.Controls.Add(lblUser);
            pnlSql.Controls.Add(label8);
            pnlSql.Font = new Font("Arial", 10F);
            pnlSql.Location = new Point(396, 60);
            pnlSql.Margin = new Padding(4, 3, 4, 3);
            pnlSql.Name = "pnlSql";
            pnlSql.Size = new Size(368, 202);
            pnlSql.TabIndex = 4;
            // 
            // optAuthSql
            // 
            optAuthSql.AutoSize = true;
            optAuthSql.Location = new Point(179, 36);
            optAuthSql.Name = "optAuthSql";
            optAuthSql.Size = new Size(184, 20);
            optAuthSql.TabIndex = 10;
            optAuthSql.TabStop = true;
            optAuthSql.Text = "Sql Server Authentication";
            optAuthSql.UseVisualStyleBackColor = true;
            // 
            // optAuthWin
            // 
            optAuthWin.AutoSize = true;
            optAuthWin.Location = new Point(8, 36);
            optAuthWin.Name = "optAuthWin";
            optAuthWin.Size = new Size(174, 20);
            optAuthWin.TabIndex = 10;
            optAuthWin.TabStop = true;
            optAuthWin.Text = "Windows Authentication";
            optAuthWin.UseVisualStyleBackColor = true;
            optAuthWin.CheckedChanged += optAuthWin_CheckedChanged;
            // 
            // chkPwd
            // 
            chkPwd.Appearance = Appearance.Button;
            chkPwd.Font = new Font("Microsoft Sans Serif", 11F);
            chkPwd.Location = new Point(259, 122);
            chkPwd.Margin = new Padding(4, 3, 4, 3);
            chkPwd.Name = "chkPwd";
            chkPwd.Size = new Size(33, 27);
            chkPwd.TabIndex = 8;
            chkPwd.TabStop = false;
            chkPwd.Text = "👁";
            chkPwd.UseVisualStyleBackColor = true;
            chkPwd.CheckedChanged += chkPwd_CheckedChanged;
            // 
            // btnSrvrL
            // 
            btnSrvrL.Location = new Point(259, 70);
            btnSrvrL.Margin = new Padding(4, 3, 4, 3);
            btnSrvrL.Name = "btnSrvrL";
            btnSrvrL.Size = new Size(51, 27);
            btnSrvrL.TabIndex = 3;
            btnSrvrL.TabStop = false;
            btnSrvrL.Text = "Load";
            btnSrvrL.UseVisualStyleBackColor = true;
            btnSrvrL.Click += btnSrvrL_Click;
            // 
            // cboSrvr
            // 
            cboSrvr.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboSrvr.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboSrvr.FormattingEnabled = true;
            cboSrvr.Location = new Point(85, 70);
            cboSrvr.Margin = new Padding(4, 3, 4, 3);
            cboSrvr.Name = "cboSrvr";
            cboSrvr.Size = new Size(166, 24);
            cboSrvr.TabIndex = 2;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 12F, FontStyle.Bold);
            label11.ImageAlign = ContentAlignment.MiddleLeft;
            label11.Location = new Point(8, 6);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(179, 19);
            label11.TabIndex = 0;
            label11.Text = "Sql Server Credentials";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnConnect
            // 
            btnConnect.Image = Properties.Resources.connect;
            btnConnect.ImageAlign = ContentAlignment.MiddleLeft;
            btnConnect.Location = new Point(248, 162);
            btnConnect.Margin = new Padding(4, 3, 4, 3);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(115, 33);
            btnConnect.TabIndex = 9;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // txtPwd
            // 
            txtPwd.Location = new Point(85, 124);
            txtPwd.Margin = new Padding(4, 3, 4, 3);
            txtPwd.Name = "txtPwd";
            txtPwd.Size = new Size(166, 23);
            txtPwd.TabIndex = 7;
            txtPwd.UseSystemPasswordChar = true;
            // 
            // lblPwd
            // 
            lblPwd.AutoSize = true;
            lblPwd.Location = new Point(11, 127);
            lblPwd.Margin = new Padding(4, 0, 4, 0);
            lblPwd.Name = "lblPwd";
            lblPwd.Size = new Size(68, 16);
            lblPwd.TabIndex = 6;
            lblPwd.Text = "Password";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(85, 98);
            txtUser.Margin = new Padding(4, 3, 4, 3);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(166, 23);
            txtUser.TabIndex = 5;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(11, 101);
            lblUser.Margin = new Padding(4, 0, 4, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(36, 16);
            lblUser.TabIndex = 4;
            lblUser.Text = "User";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 75);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(49, 16);
            label8.TabIndex = 1;
            label8.Text = "Server";
            // 
            // pnlDatabase
            // 
            pnlDatabase.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlDatabase.BackColor = Color.FromArgb(0, 192, 192);
            pnlDatabase.Controls.Add(chkLDB);
            pnlDatabase.Controls.Add(label12);
            pnlDatabase.Font = new Font("Arial", 8.25F);
            pnlDatabase.Location = new Point(396, 129);
            pnlDatabase.Margin = new Padding(4, 3, 4, 3);
            pnlDatabase.Name = "pnlDatabase";
            pnlDatabase.Size = new Size(368, 168);
            pnlDatabase.TabIndex = 6;
            // 
            // chkLDB
            // 
            chkLDB.FormattingEnabled = true;
            chkLDB.Location = new Point(13, 33);
            chkLDB.Margin = new Padding(4, 3, 4, 3);
            chkLDB.Name = "chkLDB";
            chkLDB.Size = new Size(187, 124);
            chkLDB.TabIndex = 1;
            chkLDB.ItemCheck += chkLDB_ItemCheck;
            chkLDB.Leave += chkLDB_Leave;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 12F, FontStyle.Bold);
            label12.ImageAlign = ContentAlignment.MiddleLeft;
            label12.Location = new Point(8, 7);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(90, 19);
            label12.TabIndex = 0;
            label12.Text = "Databases";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.ForeColor = Color.FromArgb(80, 80, 80);
            label14.Location = new Point(602, 12);
            label14.Margin = new Padding(4, 0, 4, 0);
            label14.Name = "label14";
            label14.Size = new Size(78, 15);
            label14.TabIndex = 15;
            label14.Text = "Software By...";
            // 
            // pnlPath
            // 
            pnlPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlPath.BackColor = Color.FromArgb(192, 192, 255);
            pnlPath.Controls.Add(btnOpnFile);
            pnlPath.Controls.Add(txtPath);
            pnlPath.Controls.Add(label15);
            pnlPath.Location = new Point(396, 206);
            pnlPath.Margin = new Padding(4, 3, 4, 3);
            pnlPath.Name = "pnlPath";
            pnlPath.Size = new Size(368, 62);
            pnlPath.TabIndex = 5;
            // 
            // btnOpnFile
            // 
            btnOpnFile.BackColor = Color.FromArgb(0, 192, 192);
            btnOpnFile.Location = new Point(328, 25);
            btnOpnFile.Margin = new Padding(4, 3, 4, 3);
            btnOpnFile.Name = "btnOpnFile";
            btnOpnFile.Size = new Size(36, 30);
            btnOpnFile.TabIndex = 2;
            btnOpnFile.Text = "...";
            btnOpnFile.UseVisualStyleBackColor = false;
            btnOpnFile.Click += btnOpnFile_Click;
            // 
            // txtPath
            // 
            txtPath.Location = new Point(10, 29);
            txtPath.Margin = new Padding(4, 3, 4, 3);
            txtPath.Name = "txtPath";
            txtPath.Size = new Size(313, 23);
            txtPath.TabIndex = 1;
            txtPath.TextChanged += txtPath_TextChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Arial", 12F, FontStyle.Bold);
            label15.ImageAlign = ContentAlignment.MiddleLeft;
            label15.Location = new Point(6, 5);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(202, 19);
            label15.TabIndex = 0;
            label15.Text = "Path for Compressed File";
            label15.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tmrRef
            // 
            tmrRef.Interval = 1000;
            tmrRef.Tick += tmrRef_Tick;
            // 
            // pBarTmr
            // 
            pBarTmr.Location = new Point(128, 39);
            pBarTmr.Margin = new Padding(4, 3, 4, 3);
            pBarTmr.Name = "pBarTmr";
            pBarTmr.Size = new Size(236, 18);
            pBarTmr.TabIndex = 2;
            pBarTmr.Visible = false;
            // 
            // lblDueIn
            // 
            lblDueIn.AutoSize = true;
            lblDueIn.Font = new Font("Arial", 16F, FontStyle.Bold);
            lblDueIn.ForeColor = Color.Teal;
            lblDueIn.Location = new Point(4, 31);
            lblDueIn.Margin = new Padding(4, 0, 4, 0);
            lblDueIn.Name = "lblDueIn";
            lblDueIn.Size = new Size(77, 26);
            lblDueIn.TabIndex = 3;
            lblDueIn.Text = "Due In";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Arial", 12F, FontStyle.Bold);
            label16.ForeColor = Color.Blue;
            label16.Location = new Point(5, 7);
            label16.Margin = new Padding(4, 0, 4, 0);
            label16.Name = "label16";
            label16.Size = new Size(131, 19);
            label16.TabIndex = 24;
            label16.Text = "Next Back Up In";
            // 
            // pnlTmDue
            // 
            pnlTmDue.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pnlTmDue.Controls.Add(lblDueIn);
            pnlTmDue.Controls.Add(label16);
            pnlTmDue.Controls.Add(pBarTmr);
            pnlTmDue.Location = new Point(396, 356);
            pnlTmDue.Margin = new Padding(4, 3, 4, 3);
            pnlTmDue.Name = "pnlTmDue";
            pnlTmDue.Size = new Size(368, 68);
            pnlTmDue.TabIndex = 25;
            // 
            // frmBkp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 487);
            Controls.Add(lblStatusAutoStart);
            Controls.Add(lblStatusBackup);
            Controls.Add(lblStatusAdmin);
            Controls.Add(btnRunAdm);
            Controls.Add(pnlTmDue);
            Controls.Add(chkAutoStart);
            Controls.Add(pnlPath);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(lblBkpFile);
            Controls.Add(pBar);
            Controls.Add(pictureBox7);
            Controls.Add(pnlData);
            Controls.Add(pnlDatabase);
            Controls.Add(pnlSql);
            Controls.Add(btnRun);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "frmBkp";
            Text = "Automatic Backup by Data Spec";
            Load += frmBkp_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            pnlData.ResumeLayout(false);
            pnlData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numBkpNoFile).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)picPath).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDB).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSql).EndInit();
            pnlSql.ResumeLayout(false);
            pnlSql.PerformLayout();
            pnlDatabase.ResumeLayout(false);
            pnlDatabase.PerformLayout();
            pnlPath.ResumeLayout(false);
            pnlPath.PerformLayout();
            pnlTmDue.ResumeLayout(false);
            pnlTmDue.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlData;
        private Button btnRun;
        private Label label1;
        private Label label2;
        private Label label3;
        private PictureBox picSql;
        private PictureBox picDB;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private PictureBox picPath;
        private Label label6;
        private Label label7;
        private Panel pnlSql;
        private Panel pnlDatabase;
        private TextBox txtPwd;
        private Label lblPwd;
        private TextBox txtUser;
        private Label lblUser;
        private Label label8;
        private Button btnConnect;
        private Label label11;
        private Label label12;
        private CheckedListBox chkLDB;
        private PictureBox pictureBox7;
        private Label label13;
        private Label label14;
        private Label lblDatabase;
        private Label lblServer;
        private Label lblPath;
        private ComboBox cboSrvr;
        private Button btnSrvrL;
        private Panel pnlPath;
        private Label label15;
        private TextBox txtPath;
        internal Button btnOpnFile;
        internal FolderBrowserDialog fbd;
        internal CheckBox chkPwd;
        internal ProgressBar pBar;
        private Label lblBkpFile;
        private PictureBox pictureBox1;
        private Label label17;
        private Label label18;
        private NumericUpDown numTime;
        private ComboBox cboTime;
        internal System.Windows.Forms.Timer tmrRef;
        internal ProgressBar pBarTmr;
        private Label lblDueIn;
        private CheckBox chkAuto;
        private Panel pnlTmDue;
        private Label label16;
        private Label lblBkpPath;
        private Label label20;
        private Label label19;
        private Label label21;
        private NumericUpDown numBkpNoFile;
        private Button btnReload;
        private CheckBox chkAutoStart;
        private Button btnRunAdm;
        private RadioButton optAuthSql;
        private RadioButton optAuthWin;
        private Label lblStatusAutoStart;
        private Label lblStatusBackup;
        private Label lblStatusAdmin;
        private ToolTip toolTip1;
    }
}

