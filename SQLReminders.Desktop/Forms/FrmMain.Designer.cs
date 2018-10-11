namespace SQLReminders.Desktop.Forms
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CmdOpenAuditTrail = new System.Windows.Forms.ToolStripMenuItem();
            this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CmdOpenSchedule = new System.Windows.Forms.ToolStripMenuItem();
            this.CmdOpenLookup = new System.Windows.Forms.ToolStripMenuItem();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CmdOpenSystemPreferences = new System.Windows.Forms.ToolStripMenuItem();
            this.importExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Audit = new System.Windows.Forms.DataGridView();
            this.TimeNow = new System.Windows.Forms.Label();
            this.TimerControl = new System.Windows.Forms.Timer(this.components);
            this.LabelTimer = new System.Windows.Forms.Timer(this.components);
            this.warning = new System.Windows.Forms.Label();
            this.lblLicence = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.NextTick = new System.Windows.Forms.Label();
            this.CmdTickNow = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Audit)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.configToolStripMenuItem,
            this.systemToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CmdOpenAuditTrail});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // CmdOpenAuditTrail
            // 
            this.CmdOpenAuditTrail.Name = "CmdOpenAuditTrail";
            this.CmdOpenAuditTrail.Size = new System.Drawing.Size(128, 22);
            this.CmdOpenAuditTrail.Text = "Audit Trail";
            this.CmdOpenAuditTrail.Click += new System.EventHandler(this.CmdOpenAuditTrail_Click);
            // 
            // configToolStripMenuItem
            // 
            this.configToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CmdOpenSchedule,
            this.CmdOpenLookup});
            this.configToolStripMenuItem.Name = "configToolStripMenuItem";
            this.configToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.configToolStripMenuItem.Text = "Config";
            // 
            // CmdOpenSchedule
            // 
            this.CmdOpenSchedule.Name = "CmdOpenSchedule";
            this.CmdOpenSchedule.Size = new System.Drawing.Size(213, 22);
            this.CmdOpenSchedule.Text = "Email Reminders Schedule";
            this.CmdOpenSchedule.Click += new System.EventHandler(this.CmdOpenReminder_Click);
            // 
            // CmdOpenLookup
            // 
            this.CmdOpenLookup.Name = "CmdOpenLookup";
            this.CmdOpenLookup.Size = new System.Drawing.Size(213, 22);
            this.CmdOpenLookup.Text = "Lookups";
            this.CmdOpenLookup.Click += new System.EventHandler(this.CmdOpenLookups_Click);
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CmdOpenSystemPreferences,
            this.importExportToolStripMenuItem});
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.systemToolStripMenuItem.Text = "System";
            // 
            // CmdOpenSystemPreferences
            // 
            this.CmdOpenSystemPreferences.Name = "CmdOpenSystemPreferences";
            this.CmdOpenSystemPreferences.Size = new System.Drawing.Size(176, 22);
            this.CmdOpenSystemPreferences.Text = "System Preferences";
            this.CmdOpenSystemPreferences.Click += new System.EventHandler(this.CmdOpenSystemPreferences_Click);
            // 
            // importExportToolStripMenuItem
            // 
            this.importExportToolStripMenuItem.Name = "importExportToolStripMenuItem";
            this.importExportToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.importExportToolStripMenuItem.Text = "Import/Export";
            this.importExportToolStripMenuItem.Click += new System.EventHandler(this.ImportExportToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // Audit
            // 
            this.Audit.AllowUserToAddRows = false;
            this.Audit.AllowUserToDeleteRows = false;
            this.Audit.AllowUserToResizeRows = false;
            this.Audit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Audit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Audit.Location = new System.Drawing.Point(12, 27);
            this.Audit.Name = "Audit";
            this.Audit.ReadOnly = true;
            this.Audit.Size = new System.Drawing.Size(760, 404);
            this.Audit.TabIndex = 1;
            // 
            // TimeNow
            // 
            this.TimeNow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeNow.AutoSize = true;
            this.TimeNow.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TimeNow.Location = new System.Drawing.Point(716, 439);
            this.TimeNow.Name = "TimeNow";
            this.TimeNow.Size = new System.Drawing.Size(35, 13);
            this.TimeNow.TabIndex = 2;
            this.TimeNow.Text = "label1";
            this.TimeNow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TimerControl
            // 
            this.TimerControl.Enabled = true;
            this.TimerControl.Interval = 60000;
            this.TimerControl.Tick += new System.EventHandler(this.TimerControl_Tick);
            // 
            // LabelTimer
            // 
            this.LabelTimer.Enabled = true;
            this.LabelTimer.Interval = 1000;
            this.LabelTimer.Tick += new System.EventHandler(this.LabelTimer_Tick);
            // 
            // warning
            // 
            this.warning.AutoSize = true;
            this.warning.Location = new System.Drawing.Point(12, 27);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(638, 13);
            this.warning.TabIndex = 3;
            this.warning.Text = "EREMINDERS IS NOT SET UP OR THE CONNECTION WITH THE DATABASE IS BROKEN PLEASE CON" +
    "FIGURE THE SYSTEM";
            // 
            // lblLicence
            // 
            this.lblLicence.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLicence.AutoSize = true;
            this.lblLicence.Location = new System.Drawing.Point(12, 439);
            this.lblLicence.Name = "lblLicence";
            this.lblLicence.Size = new System.Drawing.Size(51, 13);
            this.lblLicence.TabIndex = 4;
            this.lblLicence.Text = "Licence: ";
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(241, 439);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(43, 13);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Status: ";
            // 
            // NextTick
            // 
            this.NextTick.AutoSize = true;
            this.NextTick.Location = new System.Drawing.Point(441, 439);
            this.NextTick.Name = "NextTick";
            this.NextTick.Size = new System.Drawing.Size(52, 13);
            this.NextTick.TabIndex = 6;
            this.NextTick.Text = "Next tick:";
            // 
            // CmdTickNow
            // 
            this.CmdTickNow.Location = new System.Drawing.Point(360, 437);
            this.CmdTickNow.Name = "CmdTickNow";
            this.CmdTickNow.Size = new System.Drawing.Size(75, 23);
            this.CmdTickNow.TabIndex = 7;
            this.CmdTickNow.Text = "Tick Now";
            this.CmdTickNow.UseVisualStyleBackColor = true;
            this.CmdTickNow.Click += new System.EventHandler(this.CmdTickNow_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.CmdTickNow);
            this.Controls.Add(this.NextTick);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblLicence);
            this.Controls.Add(this.TimeNow);
            this.Controls.Add(this.Audit);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.warning);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FrmMain";
            this.Text = "Ereminders";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Audit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CmdOpenAuditTrail;
        private System.Windows.Forms.ToolStripMenuItem CmdOpenSchedule;
        private System.Windows.Forms.DataGridView Audit;
        private System.Windows.Forms.Label TimeNow;
        private System.Windows.Forms.Timer TimerControl;
        private System.Windows.Forms.ToolStripMenuItem CmdOpenSystemPreferences;
        private System.Windows.Forms.Timer LabelTimer;
        private System.Windows.Forms.ToolStripMenuItem CmdOpenLookup;
        private System.Windows.Forms.Label warning;
        private System.Windows.Forms.Label lblLicence;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ToolStripMenuItem importExportToolStripMenuItem;
        private System.Windows.Forms.Label NextTick;
        private System.Windows.Forms.Button CmdTickNow;
    }
}

