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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBkp));
            this.pnlData = new System.Windows.Forms.Panel();
            this.btnReload = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.numBkpNoFile = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblBkpPath = new System.Windows.Forms.Label();
            this.chkAuto = new System.Windows.Forms.CheckBox();
            this.cboTime = new System.Windows.Forms.ComboBox();
            this.numTime = new System.Windows.Forms.NumericUpDown();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.lblServer = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.picPath = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.picDB = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.picSql = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chkAutoStart = new System.Windows.Forms.CheckBox();
            this.lblBkpFile = new System.Windows.Forms.Label();
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.pnlSql = new System.Windows.Forms.Panel();
            this.optAuthSql = new System.Windows.Forms.RadioButton();
            this.optAuthWin = new System.Windows.Forms.RadioButton();
            this.chkPwd = new System.Windows.Forms.CheckBox();
            this.btnSrvrL = new System.Windows.Forms.Button();
            this.cboSrvr = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.lblPwd = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlDatabase = new System.Windows.Forms.Panel();
            this.chkLDB = new System.Windows.Forms.CheckedListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.pnlPath = new System.Windows.Forms.Panel();
            this.btnOpnFile = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.tmrRef = new System.Windows.Forms.Timer(this.components);
            this.pBarTmr = new System.Windows.Forms.ProgressBar();
            this.lblDueIn = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.pnlTmDue = new System.Windows.Forms.Panel();
            this.btnRunAdm = new System.Windows.Forms.Button();
            this.lblConfigPath = new System.Windows.Forms.Label();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBkpNoFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSql)).BeginInit();
            this.pnlSql.SuspendLayout();
            this.pnlDatabase.SuspendLayout();
            this.pnlPath.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.pnlTmDue.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlData
            // 
            this.pnlData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlData.Controls.Add(this.btnReload);
            this.pnlData.Controls.Add(this.label21);
            this.pnlData.Controls.Add(this.numBkpNoFile);
            this.pnlData.Controls.Add(this.label20);
            this.pnlData.Controls.Add(this.label19);
            this.pnlData.Controls.Add(this.lblBkpPath);
            this.pnlData.Controls.Add(this.chkAuto);
            this.pnlData.Controls.Add(this.cboTime);
            this.pnlData.Controls.Add(this.numTime);
            this.pnlData.Controls.Add(this.pictureBox1);
            this.pnlData.Controls.Add(this.label17);
            this.pnlData.Controls.Add(this.label18);
            this.pnlData.Controls.Add(this.lblPath);
            this.pnlData.Controls.Add(this.lblDatabase);
            this.pnlData.Controls.Add(this.lblServer);
            this.pnlData.Controls.Add(this.pictureBox5);
            this.pnlData.Controls.Add(this.picPath);
            this.pnlData.Controls.Add(this.label6);
            this.pnlData.Controls.Add(this.label7);
            this.pnlData.Controls.Add(this.pictureBox4);
            this.pnlData.Controls.Add(this.pictureBox3);
            this.pnlData.Controls.Add(this.picDB);
            this.pnlData.Controls.Add(this.label4);
            this.pnlData.Controls.Add(this.label5);
            this.pnlData.Controls.Add(this.picSql);
            this.pnlData.Controls.Add(this.label3);
            this.pnlData.Controls.Add(this.label2);
            this.pnlData.Controls.Add(this.btnRun);
            this.pnlData.Controls.Add(this.label1);
            this.pnlData.Location = new System.Drawing.Point(13, 12);
            this.pnlData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(375, 504);
            this.pnlData.TabIndex = 1;
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(233, 2);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(127, 23);
            this.btnReload.TabIndex = 27;
            this.btnReload.Text = "Reload Settings";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(44, 342);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(189, 19);
            this.label21.TabIndex = 28;
            this.label21.Text = "No. of Backups to Keep";
            // 
            // numBkpNoFile
            // 
            this.numBkpNoFile.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numBkpNoFile.Location = new System.Drawing.Point(55, 365);
            this.numBkpNoFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numBkpNoFile.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numBkpNoFile.Name = "numBkpNoFile";
            this.numBkpNoFile.Size = new System.Drawing.Size(66, 22);
            this.numBkpNoFile.TabIndex = 27;
            this.numBkpNoFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numBkpNoFile.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numBkpNoFile.Leave += new System.EventHandler(this.numBkpNoFile_Leave);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(55, 243);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(54, 15);
            this.label20.TabIndex = 26;
            this.label20.Text = "Zip Path:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(55, 224);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(76, 15);
            this.label19.TabIndex = 25;
            this.label19.Text = "Backup Path:";
            // 
            // lblBkpPath
            // 
            this.lblBkpPath.AutoEllipsis = true;
            this.lblBkpPath.ForeColor = System.Drawing.Color.Blue;
            this.lblBkpPath.Location = new System.Drawing.Point(140, 224);
            this.lblBkpPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBkpPath.Name = "lblBkpPath";
            this.lblBkpPath.Size = new System.Drawing.Size(208, 21);
            this.lblBkpPath.TabIndex = 24;
            this.lblBkpPath.Text = "Backup Path";
            // 
            // chkAuto
            // 
            this.chkAuto.AutoSize = true;
            this.chkAuto.Location = new System.Drawing.Point(296, 279);
            this.chkAuto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkAuto.Name = "chkAuto";
            this.chkAuto.Size = new System.Drawing.Size(52, 19);
            this.chkAuto.TabIndex = 18;
            this.chkAuto.Text = "Auto";
            this.chkAuto.UseVisualStyleBackColor = true;
            this.chkAuto.CheckedChanged += new System.EventHandler(this.chkAuto_CheckedChanged);
            // 
            // cboTime
            // 
            this.cboTime.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboTime.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTime.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboTime.FormattingEnabled = true;
            this.cboTime.Items.AddRange(new object[] {
            "Min",
            "Hrs"});
            this.cboTime.Location = new System.Drawing.Point(151, 300);
            this.cboTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboTime.Name = "cboTime";
            this.cboTime.Size = new System.Drawing.Size(87, 24);
            this.cboTime.TabIndex = 13;
            this.cboTime.SelectedIndexChanged += new System.EventHandler(this.cboTime_SelectedIndexChanged);
            this.cboTime.Leave += new System.EventHandler(this.cboTime_Leave);
            // 
            // numTime
            // 
            this.numTime.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numTime.Location = new System.Drawing.Point(55, 301);
            this.numTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.numTime.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numTime.Name = "numTime";
            this.numTime.Size = new System.Drawing.Size(90, 22);
            this.numTime.TabIndex = 12;
            this.numTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numTime.ValueChanged += new System.EventHandler(this.numTime_ValueChanged);
            this.numTime.Leave += new System.EventHandler(this.numTime_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::dsBackup.Properties.Resources.sand_timer;
            this.pictureBox1.Location = new System.Drawing.Point(4, 273);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // label17
            // 
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Location = new System.Drawing.Point(1, 267);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(385, 2);
            this.label17.TabIndex = 10;
            this.label17.Text = "label17";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label18.Location = new System.Drawing.Point(44, 277);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(187, 19);
            this.label18.TabIndex = 11;
            this.label18.Text = "Set Interval For Backup";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPath
            // 
            this.lblPath.AutoEllipsis = true;
            this.lblPath.ForeColor = System.Drawing.Color.Blue;
            this.lblPath.Location = new System.Drawing.Point(140, 245);
            this.lblPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(208, 21);
            this.lblPath.TabIndex = 9;
            this.lblPath.Text = "Path";
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoEllipsis = true;
            this.lblDatabase.ForeColor = System.Drawing.Color.Blue;
            this.lblDatabase.Location = new System.Drawing.Point(55, 150);
            this.lblDatabase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(264, 15);
            this.lblDatabase.TabIndex = 6;
            this.lblDatabase.Text = "Database";
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.ForeColor = System.Drawing.Color.Blue;
            this.lblServer.Location = new System.Drawing.Point(55, 73);
            this.lblServer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(39, 15);
            this.lblServer.TabIndex = 3;
            this.lblServer.Text = "Server";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::dsBackup.Properties.Resources.cloud_backup;
            this.pictureBox5.Location = new System.Drawing.Point(4, 197);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(32, 32);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            // 
            // picPath
            // 
            this.picPath.Image = global::dsBackup.Properties.Resources.settings;
            this.picPath.Location = new System.Drawing.Point(336, 194);
            this.picPath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picPath.Name = "picPath";
            this.picPath.Size = new System.Drawing.Size(24, 24);
            this.picPath.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPath.TabIndex = 12;
            this.picPath.TabStop = false;
            this.picPath.Click += new System.EventHandler(this.picPath_Click);
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(4, 190);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(385, 2);
            this.label6.TabIndex = 7;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Location = new System.Drawing.Point(44, 197);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(272, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Store Backup In Selected Location";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::dsBackup.Properties.Resources.database;
            this.pictureBox4.Location = new System.Drawing.Point(4, 122);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 32);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::dsBackup.Properties.Resources.mssql;
            this.pictureBox3.Location = new System.Drawing.Point(4, 47);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // picDB
            // 
            this.picDB.Image = global::dsBackup.Properties.Resources.settings;
            this.picDB.Location = new System.Drawing.Point(336, 122);
            this.picDB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picDB.Name = "picDB";
            this.picDB.Size = new System.Drawing.Size(24, 24);
            this.picDB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDB.TabIndex = 7;
            this.picDB.TabStop = false;
            this.picDB.Click += new System.EventHandler(this.picDB_Click);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(4, 115);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(385, 2);
            this.label4.TabIndex = 4;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(44, 122);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Select Database";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picSql
            // 
            this.picSql.Image = global::dsBackup.Properties.Resources.settings;
            this.picSql.Location = new System.Drawing.Point(336, 47);
            this.picSql.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picSql.Name = "picSql";
            this.picSql.Size = new System.Drawing.Size(24, 24);
            this.picSql.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSql.TabIndex = 4;
            this.picSql.TabStop = false;
            this.picSql.Click += new System.EventHandler(this.picSql_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(2, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(385, 2);
            this.label3.TabIndex = 1;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(44, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Connect To Microsoft Sql Server";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRun
            // 
            this.btnRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRun.Image = global::dsBackup.Properties.Resources.play;
            this.btnRun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRun.Location = new System.Drawing.Point(4, 447);
            this.btnRun.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(186, 53);
            this.btnRun.TabIndex = 14;
            this.btnRun.Text = "Backup Now";
            this.btnRun.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Automatic Backup";
            // 
            // chkAutoStart
            // 
            this.chkAutoStart.AutoSize = true;
            this.chkAutoStart.Location = new System.Drawing.Point(396, 15);
            this.chkAutoStart.Name = "chkAutoStart";
            this.chkAutoStart.Size = new System.Drawing.Size(167, 19);
            this.chkAutoStart.TabIndex = 28;
            this.chkAutoStart.Text = "Load on Windows Start-up";
            this.chkAutoStart.UseVisualStyleBackColor = true;
            this.chkAutoStart.CheckedChanged += new System.EventHandler(this.chkAutoStart_CheckedChanged);
            // 
            // lblBkpFile
            // 
            this.lblBkpFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblBkpFile.ForeColor = System.Drawing.Color.Blue;
            this.lblBkpFile.Location = new System.Drawing.Point(475, 329);
            this.lblBkpFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBkpFile.Name = "lblBkpFile";
            this.lblBkpFile.Size = new System.Drawing.Size(229, 54);
            this.lblBkpFile.TabIndex = 15;
            this.lblBkpFile.Text = "File";
            this.lblBkpFile.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblBkpFile.Visible = false;
            // 
            // pBar
            // 
            this.pBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pBar.Location = new System.Drawing.Point(477, 306);
            this.pBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(227, 20);
            this.pBar.TabIndex = 16;
            this.pBar.Visible = false;
            // 
            // pnlSql
            // 
            this.pnlSql.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSql.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pnlSql.Controls.Add(this.optAuthSql);
            this.pnlSql.Controls.Add(this.optAuthWin);
            this.pnlSql.Controls.Add(this.chkPwd);
            this.pnlSql.Controls.Add(this.btnSrvrL);
            this.pnlSql.Controls.Add(this.cboSrvr);
            this.pnlSql.Controls.Add(this.label11);
            this.pnlSql.Controls.Add(this.btnConnect);
            this.pnlSql.Controls.Add(this.txtPwd);
            this.pnlSql.Controls.Add(this.lblPwd);
            this.pnlSql.Controls.Add(this.txtUser);
            this.pnlSql.Controls.Add(this.lblUser);
            this.pnlSql.Controls.Add(this.label8);
            this.pnlSql.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlSql.Location = new System.Drawing.Point(396, 60);
            this.pnlSql.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlSql.Name = "pnlSql";
            this.pnlSql.Size = new System.Drawing.Size(368, 202);
            this.pnlSql.TabIndex = 4;
            // 
            // optAuthSql
            // 
            this.optAuthSql.AutoSize = true;
            this.optAuthSql.Location = new System.Drawing.Point(184, 36);
            this.optAuthSql.Name = "optAuthSql";
            this.optAuthSql.Size = new System.Drawing.Size(184, 20);
            this.optAuthSql.TabIndex = 10;
            this.optAuthSql.TabStop = true;
            this.optAuthSql.Text = "Sql Server Authentication";
            this.optAuthSql.UseVisualStyleBackColor = true;
            // 
            // optAuthWin
            // 
            this.optAuthWin.AutoSize = true;
            this.optAuthWin.Location = new System.Drawing.Point(13, 36);
            this.optAuthWin.Name = "optAuthWin";
            this.optAuthWin.Size = new System.Drawing.Size(174, 20);
            this.optAuthWin.TabIndex = 10;
            this.optAuthWin.TabStop = true;
            this.optAuthWin.Text = "Windows Authentication";
            this.optAuthWin.UseVisualStyleBackColor = true;
            this.optAuthWin.CheckedChanged += new System.EventHandler(this.optAuthWin_CheckedChanged);
            // 
            // chkPwd
            // 
            this.chkPwd.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkPwd.Location = new System.Drawing.Point(259, 122);
            this.chkPwd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkPwd.Name = "chkPwd";
            this.chkPwd.Size = new System.Drawing.Size(33, 27);
            this.chkPwd.TabIndex = 8;
            this.chkPwd.TabStop = false;
            this.chkPwd.Text = "👁";
            this.chkPwd.UseVisualStyleBackColor = true;
            this.chkPwd.CheckedChanged += new System.EventHandler(this.chkPwd_CheckedChanged);
            // 
            // btnSrvrL
            // 
            this.btnSrvrL.Location = new System.Drawing.Point(259, 70);
            this.btnSrvrL.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSrvrL.Name = "btnSrvrL";
            this.btnSrvrL.Size = new System.Drawing.Size(51, 27);
            this.btnSrvrL.TabIndex = 3;
            this.btnSrvrL.TabStop = false;
            this.btnSrvrL.Text = "Load";
            this.btnSrvrL.UseVisualStyleBackColor = true;
            this.btnSrvrL.Click += new System.EventHandler(this.btnSrvrL_Click);
            // 
            // cboSrvr
            // 
            this.cboSrvr.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboSrvr.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboSrvr.FormattingEnabled = true;
            this.cboSrvr.Location = new System.Drawing.Point(85, 70);
            this.cboSrvr.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboSrvr.Name = "cboSrvr";
            this.cboSrvr.Size = new System.Drawing.Size(166, 24);
            this.cboSrvr.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label11.Location = new System.Drawing.Point(8, 6);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(179, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "Sql Server Credentials";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnConnect
            // 
            this.btnConnect.Image = global::dsBackup.Properties.Resources.connect;
            this.btnConnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConnect.Location = new System.Drawing.Point(248, 162);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(115, 33);
            this.btnConnect.TabIndex = 9;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(85, 124);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(166, 23);
            this.txtPwd.TabIndex = 7;
            this.txtPwd.UseSystemPasswordChar = true;
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(11, 127);
            this.lblPwd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(68, 16);
            this.lblPwd.TabIndex = 6;
            this.lblPwd.Text = "Password";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(85, 98);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(166, 23);
            this.txtUser.TabIndex = 5;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(11, 101);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(36, 16);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "User";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 75);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Server";
            // 
            // pnlDatabase
            // 
            this.pnlDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlDatabase.Controls.Add(this.chkLDB);
            this.pnlDatabase.Controls.Add(this.label12);
            this.pnlDatabase.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pnlDatabase.Location = new System.Drawing.Point(396, 129);
            this.pnlDatabase.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlDatabase.Name = "pnlDatabase";
            this.pnlDatabase.Size = new System.Drawing.Size(368, 168);
            this.pnlDatabase.TabIndex = 6;
            // 
            // chkLDB
            // 
            this.chkLDB.FormattingEnabled = true;
            this.chkLDB.Location = new System.Drawing.Point(13, 33);
            this.chkLDB.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkLDB.Name = "chkLDB";
            this.chkLDB.Size = new System.Drawing.Size(187, 124);
            this.chkLDB.TabIndex = 1;
            this.chkLDB.Leave += new System.EventHandler(this.chkLDB_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label12.Location = new System.Drawing.Point(8, 7);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 19);
            this.label12.TabIndex = 0;
            this.label12.Text = "Databases";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label13.Location = new System.Drawing.Point(609, 20);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 22);
            this.label13.TabIndex = 17;
            this.label13.Text = "Data Spec";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.label14.Location = new System.Drawing.Point(602, 5);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 15);
            this.label14.TabIndex = 15;
            this.label14.Text = "Software By...";
            // 
            // pnlPath
            // 
            this.pnlPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pnlPath.Controls.Add(this.btnOpnFile);
            this.pnlPath.Controls.Add(this.txtPath);
            this.pnlPath.Controls.Add(this.label15);
            this.pnlPath.Location = new System.Drawing.Point(396, 206);
            this.pnlPath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlPath.Name = "pnlPath";
            this.pnlPath.Size = new System.Drawing.Size(368, 62);
            this.pnlPath.TabIndex = 5;
            // 
            // btnOpnFile
            // 
            this.btnOpnFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnOpnFile.Location = new System.Drawing.Point(328, 25);
            this.btnOpnFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnOpnFile.Name = "btnOpnFile";
            this.btnOpnFile.Size = new System.Drawing.Size(36, 30);
            this.btnOpnFile.TabIndex = 2;
            this.btnOpnFile.Text = "...";
            this.btnOpnFile.UseVisualStyleBackColor = false;
            this.btnOpnFile.Click += new System.EventHandler(this.btnOpnFile_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(10, 29);
            this.txtPath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(313, 23);
            this.txtPath.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label15.Location = new System.Drawing.Point(6, 5);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(202, 19);
            this.label15.TabIndex = 0;
            this.label15.Text = "Path for Compressed File";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox7.Image = global::dsBackup.Properties.Resources.dslogo;
            this.pictureBox7.Location = new System.Drawing.Point(721, 5);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(43, 40);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 3;
            this.pictureBox7.TabStop = false;
            // 
            // tmrRef
            // 
            this.tmrRef.Interval = 1000;
            this.tmrRef.Tick += new System.EventHandler(this.tmrRef_Tick);
            // 
            // pBarTmr
            // 
            this.pBarTmr.Location = new System.Drawing.Point(128, 39);
            this.pBarTmr.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pBarTmr.Name = "pBarTmr";
            this.pBarTmr.Size = new System.Drawing.Size(236, 18);
            this.pBarTmr.TabIndex = 2;
            this.pBarTmr.Visible = false;
            // 
            // lblDueIn
            // 
            this.lblDueIn.AutoSize = true;
            this.lblDueIn.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDueIn.ForeColor = System.Drawing.Color.Teal;
            this.lblDueIn.Location = new System.Drawing.Point(5, 27);
            this.lblDueIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDueIn.Name = "lblDueIn";
            this.lblDueIn.Size = new System.Drawing.Size(77, 26);
            this.lblDueIn.TabIndex = 3;
            this.lblDueIn.Text = "Due In";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.Color.Blue;
            this.label16.Location = new System.Drawing.Point(5, 7);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(131, 19);
            this.label16.TabIndex = 24;
            this.label16.Text = "Next Back Up In";
            // 
            // pnlTmDue
            // 
            this.pnlTmDue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTmDue.Controls.Add(this.lblDueIn);
            this.pnlTmDue.Controls.Add(this.label16);
            this.pnlTmDue.Controls.Add(this.pBarTmr);
            this.pnlTmDue.Location = new System.Drawing.Point(396, 447);
            this.pnlTmDue.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlTmDue.Name = "pnlTmDue";
            this.pnlTmDue.Size = new System.Drawing.Size(368, 68);
            this.pnlTmDue.TabIndex = 25;
            // 
            // btnRunAdm
            // 
            this.btnRunAdm.Location = new System.Drawing.Point(397, 14);
            this.btnRunAdm.Name = "btnRunAdm";
            this.btnRunAdm.Size = new System.Drawing.Size(147, 23);
            this.btnRunAdm.TabIndex = 29;
            this.btnRunAdm.Text = "Run as Adminstrator";
            this.btnRunAdm.UseVisualStyleBackColor = true;
            this.btnRunAdm.Click += new System.EventHandler(this.btnRunAdm_Click);
            // 
            // lblConfigPath
            // 
            this.lblConfigPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConfigPath.AutoEllipsis = true;
            this.lblConfigPath.ForeColor = System.Drawing.Color.Blue;
            this.lblConfigPath.Location = new System.Drawing.Point(15, 520);
            this.lblConfigPath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblConfigPath.Name = "lblConfigPath";
            this.lblConfigPath.Size = new System.Drawing.Size(749, 21);
            this.lblConfigPath.TabIndex = 29;
            this.lblConfigPath.Text = "Config Path";
            // 
            // frmBkp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 539);
            this.Controls.Add(this.lblConfigPath);
            this.Controls.Add(this.btnRunAdm);
            this.Controls.Add(this.pnlTmDue);
            this.Controls.Add(this.chkAutoStart);
            this.Controls.Add(this.pnlPath);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblBkpFile);
            this.Controls.Add(this.pBar);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.pnlDatabase);
            this.Controls.Add(this.pnlSql);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmBkp";
            this.Text = "Backup System by Data Spec";
            this.Load += new System.EventHandler(this.frmBkp_Load);
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBkpNoFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSql)).EndInit();
            this.pnlSql.ResumeLayout(false);
            this.pnlSql.PerformLayout();
            this.pnlDatabase.ResumeLayout(false);
            this.pnlDatabase.PerformLayout();
            this.pnlPath.ResumeLayout(false);
            this.pnlPath.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.pnlTmDue.ResumeLayout(false);
            this.pnlTmDue.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picSql;
        private System.Windows.Forms.PictureBox picDB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox picPath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlSql;
        private System.Windows.Forms.Panel pnlDatabase;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckedListBox chkLDB;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.ComboBox cboSrvr;
        private System.Windows.Forms.Button btnSrvrL;
        private System.Windows.Forms.Panel pnlPath;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPath;
        internal System.Windows.Forms.Button btnOpnFile;
        internal System.Windows.Forms.FolderBrowserDialog fbd;
        internal System.Windows.Forms.CheckBox chkPwd;
        internal System.Windows.Forms.ProgressBar pBar;
        private System.Windows.Forms.Label lblBkpFile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown numTime;
        private System.Windows.Forms.ComboBox cboTime;
        internal System.Windows.Forms.Timer tmrRef;
        internal System.Windows.Forms.ProgressBar pBarTmr;
        private System.Windows.Forms.Label lblDueIn;
        private System.Windows.Forms.CheckBox chkAuto;
        private System.Windows.Forms.Panel pnlTmDue;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblBkpPath;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private Label label21;
        private NumericUpDown numBkpNoFile;
        private Button btnReload;
        private CheckBox chkAutoStart;
        private Button btnRunAdm;
        private RadioButton optAuthSql;
        private RadioButton optAuthWin;
        private Label lblConfigPath;
    }
}

