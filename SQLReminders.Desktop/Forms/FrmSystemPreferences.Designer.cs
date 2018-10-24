namespace SQLReminders.Desktop.Forms
{
    partial class FrmSystemPreferences
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
            System.Windows.Forms.Button button1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSystemPreferences));
            this.TabControl = new System.Windows.Forms.TabControl();
            this.TabGeneral = new System.Windows.Forms.TabPage();
            this.GBActivation = new System.Windows.Forms.GroupBox();
            this.CmdApply = new System.Windows.Forms.Button();
            this.TxtCompanyName = new System.Windows.Forms.TextBox();
            this.CmdSave = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BoxLicence = new System.Windows.Forms.TextBox();
            this.BoxActive = new System.Windows.Forms.CheckBox();
            this.TabSMTPSettings = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtBody = new System.Windows.Forms.RichTextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblBody = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblToAddress = new System.Windows.Forms.Label();
            this.CmdTestEmail = new System.Windows.Forms.Button();
            this.GBEmailsSettings = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BoxAuto = new System.Windows.Forms.RadioButton();
            this.BoxTls = new System.Windows.Forms.RadioButton();
            this.BoxSSL = new System.Windows.Forms.RadioButton();
            this.BoxSecureConnection = new System.Windows.Forms.CheckBox();
            this.gpAuthentication = new System.Windows.Forms.GroupBox();
            this.BoxAuthenticaton = new System.Windows.Forms.CheckBox();
            this.TxtSmtpUser = new System.Windows.Forms.TextBox();
            this.TxtSmtpPass = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtSmtpPort = new System.Windows.Forms.NumericUpDown();
            this.CmdSabeSMTPSettings = new System.Windows.Forms.Button();
            this.TxtSmtpServer = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SQLSettings = new System.Windows.Forms.TabPage();
            this.CmdCreateTables = new System.Windows.Forms.Button();
            this.cmdTest = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.TxtDatabase = new System.Windows.Forms.TextBox();
            this.TextSqlServer = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblDatabse = new System.Windows.Forms.Label();
            this.lblServer = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            this.TabControl.SuspendLayout();
            this.TabGeneral.SuspendLayout();
            this.GBActivation.SuspendLayout();
            this.TabSMTPSettings.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.GBEmailsSettings.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gpAuthentication.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSmtpPort)).BeginInit();
            this.SQLSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(6, 155);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(75, 23);
            button1.TabIndex = 23;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(this.CmdSaveSQL_Click);
            // 
            // TabControl
            // 
            this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl.Controls.Add(this.TabGeneral);
            this.TabControl.Controls.Add(this.TabSMTPSettings);
            this.TabControl.Controls.Add(this.SQLSettings);
            this.TabControl.Location = new System.Drawing.Point(12, 12);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(760, 437);
            this.TabControl.TabIndex = 0;
            // 
            // TabGeneral
            // 
            this.TabGeneral.BackColor = System.Drawing.Color.Transparent;
            this.TabGeneral.Controls.Add(this.GBActivation);
            this.TabGeneral.Location = new System.Drawing.Point(4, 22);
            this.TabGeneral.Name = "TabGeneral";
            this.TabGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.TabGeneral.Size = new System.Drawing.Size(752, 411);
            this.TabGeneral.TabIndex = 0;
            this.TabGeneral.Text = "General";
            // 
            // GBActivation
            // 
            this.GBActivation.Controls.Add(this.CmdApply);
            this.GBActivation.Controls.Add(this.TxtCompanyName);
            this.GBActivation.Controls.Add(this.CmdSave);
            this.GBActivation.Controls.Add(this.label8);
            this.GBActivation.Controls.Add(this.label7);
            this.GBActivation.Controls.Add(this.BoxLicence);
            this.GBActivation.Controls.Add(this.BoxActive);
            this.GBActivation.Location = new System.Drawing.Point(6, 6);
            this.GBActivation.Name = "GBActivation";
            this.GBActivation.Size = new System.Drawing.Size(411, 183);
            this.GBActivation.TabIndex = 6;
            this.GBActivation.TabStop = false;
            this.GBActivation.Text = "Activation";
            // 
            // CmdApply
            // 
            this.CmdApply.Location = new System.Drawing.Point(306, 94);
            this.CmdApply.Name = "CmdApply";
            this.CmdApply.Size = new System.Drawing.Size(75, 23);
            this.CmdApply.TabIndex = 4;
            this.CmdApply.Text = "Aplly";
            this.CmdApply.UseVisualStyleBackColor = true;
            this.CmdApply.Click += new System.EventHandler(this.CmdApply_Click);
            // 
            // TxtCompanyName
            // 
            this.TxtCompanyName.Location = new System.Drawing.Point(9, 58);
            this.TxtCompanyName.Name = "TxtCompanyName";
            this.TxtCompanyName.Size = new System.Drawing.Size(293, 20);
            this.TxtCompanyName.TabIndex = 0;
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(308, 56);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(75, 23);
            this.CmdSave.TabIndex = 5;
            this.CmdSave.Text = "Save";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Licence String";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Company Name";
            // 
            // BoxLicence
            // 
            this.BoxLicence.Location = new System.Drawing.Point(9, 97);
            this.BoxLicence.Name = "BoxLicence";
            this.BoxLicence.Size = new System.Drawing.Size(290, 20);
            this.BoxLicence.TabIndex = 3;
            // 
            // BoxActive
            // 
            this.BoxActive.AutoSize = true;
            this.BoxActive.Location = new System.Drawing.Point(9, 152);
            this.BoxActive.Name = "BoxActive";
            this.BoxActive.Size = new System.Drawing.Size(56, 17);
            this.BoxActive.TabIndex = 4;
            this.BoxActive.Text = "Active";
            this.BoxActive.UseVisualStyleBackColor = true;
            this.BoxActive.CheckedChanged += new System.EventHandler(this.BoxActive_CheckedChanged);
            // 
            // TabSMTPSettings
            // 
            this.TabSMTPSettings.BackColor = System.Drawing.Color.Transparent;
            this.TabSMTPSettings.Controls.Add(this.groupBox3);
            this.TabSMTPSettings.Controls.Add(this.GBEmailsSettings);
            this.TabSMTPSettings.Location = new System.Drawing.Point(4, 22);
            this.TabSMTPSettings.Name = "TabSMTPSettings";
            this.TabSMTPSettings.Padding = new System.Windows.Forms.Padding(3);
            this.TabSMTPSettings.Size = new System.Drawing.Size(752, 411);
            this.TabSMTPSettings.TabIndex = 1;
            this.TabSMTPSettings.Text = "SMTP Settings";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtBody);
            this.groupBox3.Controls.Add(this.txtSubject);
            this.groupBox3.Controls.Add(this.txtAddress);
            this.groupBox3.Controls.Add(this.lblBody);
            this.groupBox3.Controls.Add(this.lblSubject);
            this.groupBox3.Controls.Add(this.lblToAddress);
            this.groupBox3.Controls.Add(this.CmdTestEmail);
            this.groupBox3.Location = new System.Drawing.Point(371, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(378, 399);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Test Email";
            // 
            // txtBody
            // 
            this.txtBody.Location = new System.Drawing.Point(97, 71);
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(275, 96);
            this.txtBody.TabIndex = 68;
            this.txtBody.Text = "";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(97, 45);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(275, 20);
            this.txtSubject.TabIndex = 67;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(97, 19);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(275, 20);
            this.txtAddress.TabIndex = 66;
            // 
            // lblBody
            // 
            this.lblBody.AutoSize = true;
            this.lblBody.Location = new System.Drawing.Point(10, 74);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(59, 13);
            this.lblBody.TabIndex = 65;
            this.lblBody.Text = "Email Body";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Location = new System.Drawing.Point(10, 48);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(43, 13);
            this.lblSubject.TabIndex = 64;
            this.lblSubject.Text = "Subject";
            // 
            // lblToAddress
            // 
            this.lblToAddress.AutoSize = true;
            this.lblToAddress.Location = new System.Drawing.Point(10, 22);
            this.lblToAddress.Name = "lblToAddress";
            this.lblToAddress.Size = new System.Drawing.Size(61, 13);
            this.lblToAddress.TabIndex = 63;
            this.lblToAddress.Text = "To Address";
            // 
            // CmdTestEmail
            // 
            this.CmdTestEmail.Location = new System.Drawing.Point(6, 144);
            this.CmdTestEmail.Name = "CmdTestEmail";
            this.CmdTestEmail.Size = new System.Drawing.Size(75, 23);
            this.CmdTestEmail.TabIndex = 69;
            this.CmdTestEmail.Text = "Send Email";
            this.CmdTestEmail.UseVisualStyleBackColor = true;
            this.CmdTestEmail.Click += new System.EventHandler(this.CmdTestEmail_Click);
            // 
            // GBEmailsSettings
            // 
            this.GBEmailsSettings.Controls.Add(this.groupBox1);
            this.GBEmailsSettings.Controls.Add(this.gpAuthentication);
            this.GBEmailsSettings.Controls.Add(this.TxtSmtpPort);
            this.GBEmailsSettings.Controls.Add(this.CmdSabeSMTPSettings);
            this.GBEmailsSettings.Controls.Add(this.TxtSmtpServer);
            this.GBEmailsSettings.Controls.Add(this.lblPort);
            this.GBEmailsSettings.Controls.Add(this.label12);
            this.GBEmailsSettings.Location = new System.Drawing.Point(6, 6);
            this.GBEmailsSettings.Name = "GBEmailsSettings";
            this.GBEmailsSettings.Size = new System.Drawing.Size(359, 399);
            this.GBEmailsSettings.TabIndex = 7;
            this.GBEmailsSettings.TabStop = false;
            this.GBEmailsSettings.Text = "SMTP Settings";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BoxAuto);
            this.groupBox1.Controls.Add(this.BoxTls);
            this.groupBox1.Controls.Add(this.BoxSSL);
            this.groupBox1.Controls.Add(this.BoxSecureConnection);
            this.groupBox1.Location = new System.Drawing.Point(6, 275);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 95);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection Security";
            // 
            // BoxAuto
            // 
            this.BoxAuto.AutoSize = true;
            this.BoxAuto.Location = new System.Drawing.Point(120, 72);
            this.BoxAuto.Name = "BoxAuto";
            this.BoxAuto.Size = new System.Drawing.Size(47, 17);
            this.BoxAuto.TabIndex = 4;
            this.BoxAuto.TabStop = true;
            this.BoxAuto.Text = "Auto";
            this.BoxAuto.UseVisualStyleBackColor = true;
            // 
            // BoxTls
            // 
            this.BoxTls.AutoSize = true;
            this.BoxTls.Location = new System.Drawing.Point(69, 72);
            this.BoxTls.Name = "BoxTls";
            this.BoxTls.Size = new System.Drawing.Size(45, 17);
            this.BoxTls.TabIndex = 2;
            this.BoxTls.TabStop = true;
            this.BoxTls.Text = "TLS";
            this.BoxTls.UseVisualStyleBackColor = true;
            // 
            // BoxSSL
            // 
            this.BoxSSL.AutoSize = true;
            this.BoxSSL.Location = new System.Drawing.Point(18, 72);
            this.BoxSSL.Name = "BoxSSL";
            this.BoxSSL.Size = new System.Drawing.Size(45, 17);
            this.BoxSSL.TabIndex = 1;
            this.BoxSSL.TabStop = true;
            this.BoxSSL.Text = "SSL";
            this.BoxSSL.UseVisualStyleBackColor = true;
            // 
            // BoxSecureConnection
            // 
            this.BoxSecureConnection.AutoSize = true;
            this.BoxSecureConnection.Location = new System.Drawing.Point(9, 20);
            this.BoxSecureConnection.Name = "BoxSecureConnection";
            this.BoxSecureConnection.Size = new System.Drawing.Size(145, 17);
            this.BoxSecureConnection.TabIndex = 0;
            this.BoxSecureConnection.Text = "Use a secure connection";
            this.BoxSecureConnection.UseVisualStyleBackColor = true;
            this.BoxSecureConnection.CheckedChanged += new System.EventHandler(this.BoxSecureConnection_CheckedChanged);
            // 
            // gpAuthentication
            // 
            this.gpAuthentication.Controls.Add(this.BoxAuthenticaton);
            this.gpAuthentication.Controls.Add(this.TxtSmtpUser);
            this.gpAuthentication.Controls.Add(this.TxtSmtpPass);
            this.gpAuthentication.Controls.Add(this.label11);
            this.gpAuthentication.Controls.Add(this.label10);
            this.gpAuthentication.Location = new System.Drawing.Point(6, 153);
            this.gpAuthentication.Name = "gpAuthentication";
            this.gpAuthentication.Size = new System.Drawing.Size(347, 107);
            this.gpAuthentication.TabIndex = 45;
            this.gpAuthentication.TabStop = false;
            this.gpAuthentication.Text = "Authentication";
            // 
            // BoxAuthenticaton
            // 
            this.BoxAuthenticaton.AutoSize = true;
            this.BoxAuthenticaton.Location = new System.Drawing.Point(6, 19);
            this.BoxAuthenticaton.Name = "BoxAuthenticaton";
            this.BoxAuthenticaton.Size = new System.Drawing.Size(115, 17);
            this.BoxAuthenticaton.TabIndex = 44;
            this.BoxAuthenticaton.Text = "Use authentication";
            this.BoxAuthenticaton.UseVisualStyleBackColor = true;
            this.BoxAuthenticaton.CheckedChanged += new System.EventHandler(this.BoxAuthenticaton_CheckedChanged);
            // 
            // TxtSmtpUser
            // 
            this.TxtSmtpUser.Location = new System.Drawing.Point(109, 58);
            this.TxtSmtpUser.Name = "TxtSmtpUser";
            this.TxtSmtpUser.Size = new System.Drawing.Size(238, 20);
            this.TxtSmtpUser.TabIndex = 42;
            // 
            // TxtSmtpPass
            // 
            this.TxtSmtpPass.Location = new System.Drawing.Point(109, 81);
            this.TxtSmtpPass.Name = "TxtSmtpPass";
            this.TxtSmtpPass.Size = new System.Drawing.Size(238, 20);
            this.TxtSmtpPass.TabIndex = 43;
            this.TxtSmtpPass.UseSystemPasswordChar = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "From Email Address:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "SMTP password:";
            // 
            // TxtSmtpPort
            // 
            this.TxtSmtpPort.Location = new System.Drawing.Point(98, 46);
            this.TxtSmtpPort.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.TxtSmtpPort.Name = "TxtSmtpPort";
            this.TxtSmtpPort.Size = new System.Drawing.Size(120, 20);
            this.TxtSmtpPort.TabIndex = 41;
            // 
            // CmdSabeSMTPSettings
            // 
            this.CmdSabeSMTPSettings.Location = new System.Drawing.Point(6, 376);
            this.CmdSabeSMTPSettings.Name = "CmdSabeSMTPSettings";
            this.CmdSabeSMTPSettings.Size = new System.Drawing.Size(75, 23);
            this.CmdSabeSMTPSettings.TabIndex = 44;
            this.CmdSabeSMTPSettings.Text = "Save";
            this.CmdSabeSMTPSettings.UseVisualStyleBackColor = true;
            this.CmdSabeSMTPSettings.Click += new System.EventHandler(this.CmdSaveSMTP_Click);
            // 
            // TxtSmtpServer
            // 
            this.TxtSmtpServer.Location = new System.Drawing.Point(98, 19);
            this.TxtSmtpServer.Name = "TxtSmtpServer";
            this.TxtSmtpServer.Size = new System.Drawing.Size(238, 20);
            this.TxtSmtpServer.TabIndex = 40;
            this.TxtSmtpServer.Text = " ";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(33, 48);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(62, 13);
            this.lblPort.TabIndex = 34;
            this.lblPort.Text = "SMTP Port:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 13);
            this.label12.TabIndex = 33;
            this.label12.Text = "SMTP Server:";
            // 
            // SQLSettings
            // 
            this.SQLSettings.BackColor = System.Drawing.Color.Transparent;
            this.SQLSettings.Controls.Add(this.CmdCreateTables);
            this.SQLSettings.Controls.Add(button1);
            this.SQLSettings.Controls.Add(this.cmdTest);
            this.SQLSettings.Controls.Add(this.lblStatus);
            this.SQLSettings.Controls.Add(this.TxtPassword);
            this.SQLSettings.Controls.Add(this.TxtUsername);
            this.SQLSettings.Controls.Add(this.TxtDatabase);
            this.SQLSettings.Controls.Add(this.TextSqlServer);
            this.SQLSettings.Controls.Add(this.lblPassword);
            this.SQLSettings.Controls.Add(this.lblUserName);
            this.SQLSettings.Controls.Add(this.lblDatabse);
            this.SQLSettings.Controls.Add(this.lblServer);
            this.SQLSettings.Location = new System.Drawing.Point(4, 22);
            this.SQLSettings.Name = "SQLSettings";
            this.SQLSettings.Size = new System.Drawing.Size(752, 411);
            this.SQLSettings.TabIndex = 2;
            this.SQLSettings.Text = "SQL Settings";
            // 
            // CmdCreateTables
            // 
            this.CmdCreateTables.Location = new System.Drawing.Point(6, 225);
            this.CmdCreateTables.Name = "CmdCreateTables";
            this.CmdCreateTables.Size = new System.Drawing.Size(75, 52);
            this.CmdCreateTables.TabIndex = 24;
            this.CmdCreateTables.Text = "Create Tables";
            this.CmdCreateTables.UseVisualStyleBackColor = true;
            this.CmdCreateTables.Click += new System.EventHandler(this.CmdCreateTables_Click);
            // 
            // cmdTest
            // 
            this.cmdTest.Location = new System.Drawing.Point(6, 126);
            this.cmdTest.Name = "cmdTest";
            this.cmdTest.Size = new System.Drawing.Size(75, 23);
            this.cmdTest.TabIndex = 22;
            this.cmdTest.Text = "Test";
            this.cmdTest.UseVisualStyleBackColor = true;
            this.cmdTest.Click += new System.EventHandler(this.CmdTest_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(156, 131);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(53, 13);
            this.lblStatus.TabIndex = 21;
            this.lblStatus.Text = "Un-tested";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(159, 87);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(100, 20);
            this.TxtPassword.TabIndex = 20;
            this.TxtPassword.UseSystemPasswordChar = true;
            // 
            // TxtUsername
            // 
            this.TxtUsername.Location = new System.Drawing.Point(159, 61);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(100, 20);
            this.TxtUsername.TabIndex = 19;
            // 
            // TxtDatabase
            // 
            this.TxtDatabase.Location = new System.Drawing.Point(159, 35);
            this.TxtDatabase.Name = "TxtDatabase";
            this.TxtDatabase.Size = new System.Drawing.Size(100, 20);
            this.TxtDatabase.TabIndex = 18;
            // 
            // TextSqlServer
            // 
            this.TextSqlServer.Location = new System.Drawing.Point(159, 9);
            this.TextSqlServer.Name = "TextSqlServer";
            this.TextSqlServer.Size = new System.Drawing.Size(206, 20);
            this.TextSqlServer.TabIndex = 17;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(3, 90);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 16;
            this.lblPassword.Text = "Password";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(3, 64);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(61, 13);
            this.lblUserName.TabIndex = 15;
            this.lblUserName.Text = "Username: ";
            // 
            // lblDatabse
            // 
            this.lblDatabse.AutoSize = true;
            this.lblDatabse.Location = new System.Drawing.Point(3, 38);
            this.lblDatabse.Name = "lblDatabse";
            this.lblDatabse.Size = new System.Drawing.Size(56, 13);
            this.lblDatabse.TabIndex = 14;
            this.lblDatabse.Text = "Database:";
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(3, 12);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(75, 13);
            this.lblServer.TabIndex = 13;
            this.lblServer.Text = "Server Name: ";
            // 
            // FrmSystemPreferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.TabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FrmSystemPreferences";
            this.Text = "SystemPreferences";
            this.Load += new System.EventHandler(this.SystemPreferences_Load);
            this.TabControl.ResumeLayout(false);
            this.TabGeneral.ResumeLayout(false);
            this.GBActivation.ResumeLayout(false);
            this.GBActivation.PerformLayout();
            this.TabSMTPSettings.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.GBEmailsSettings.ResumeLayout(false);
            this.GBEmailsSettings.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpAuthentication.ResumeLayout(false);
            this.gpAuthentication.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSmtpPort)).EndInit();
            this.SQLSettings.ResumeLayout(false);
            this.SQLSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage TabGeneral;
        private System.Windows.Forms.TabPage TabSMTPSettings;
        private System.Windows.Forms.GroupBox GBActivation;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox BoxLicence;
        private System.Windows.Forms.CheckBox BoxActive;
        private System.Windows.Forms.TabPage SQLSettings;
        private System.Windows.Forms.Button cmdTest;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.TextBox TxtDatabase;
        private System.Windows.Forms.TextBox TextSqlServer;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblDatabse;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox txtBody;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblBody;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.Label lblToAddress;
        private System.Windows.Forms.Button CmdTestEmail;
        private System.Windows.Forms.GroupBox GBEmailsSettings;
        private System.Windows.Forms.NumericUpDown TxtSmtpPort;
        private System.Windows.Forms.Button CmdSabeSMTPSettings;
        private System.Windows.Forms.TextBox TxtSmtpPass;
        private System.Windows.Forms.TextBox TxtSmtpUser;
        private System.Windows.Forms.TextBox TxtSmtpServer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtCompanyName;
        private System.Windows.Forms.Button CmdApply;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button CmdCreateTables;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton BoxAuto;
        private System.Windows.Forms.RadioButton BoxTls;
        private System.Windows.Forms.RadioButton BoxSSL;
        private System.Windows.Forms.CheckBox BoxSecureConnection;
        private System.Windows.Forms.GroupBox gpAuthentication;
        private System.Windows.Forms.CheckBox BoxAuthenticaton;
    }
}