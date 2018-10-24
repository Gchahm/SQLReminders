namespace SQLReminders.Desktop.Forms
{
    partial class FrmReminder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReminder));
            this.gbGeneralDetails = new System.Windows.Forms.GroupBox();
            this.DateCreated = new System.Windows.Forms.DateTimePicker();
            this.CreatedBy = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.RichTextBox();
            this.ReminderName = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCreator = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.gbSchedule = new System.Windows.Forms.GroupBox();
            this.NextRunDate = new System.Windows.Forms.DateTimePicker();
            this.RunFrequency = new System.Windows.Forms.NumericUpDown();
            this.ActiveReminder = new System.Windows.Forms.CheckBox();
            this.RepeatedRunTime = new System.Windows.Forms.DateTimePicker();
            this.lblNextRun = new System.Windows.Forms.Label();
            this.lblDays = new System.Windows.Forms.Label();
            this.lblFrequency = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.Repeated = new System.Windows.Forms.CheckBox();
            this.RunOnce = new System.Windows.Forms.CheckBox();
            this.cmdSQLBuilder = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdClose = new System.Windows.Forms.Button();
            this.gbGeneralDetails.SuspendLayout();
            this.gbSchedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RunFrequency)).BeginInit();
            this.SuspendLayout();
            // 
            // gbGeneralDetails
            // 
            this.gbGeneralDetails.Controls.Add(this.DateCreated);
            this.gbGeneralDetails.Controls.Add(this.CreatedBy);
            this.gbGeneralDetails.Controls.Add(this.Description);
            this.gbGeneralDetails.Controls.Add(this.ReminderName);
            this.gbGeneralDetails.Controls.Add(this.lblDate);
            this.gbGeneralDetails.Controls.Add(this.lblCreator);
            this.gbGeneralDetails.Controls.Add(this.lblDescription);
            this.gbGeneralDetails.Controls.Add(this.lblName);
            this.gbGeneralDetails.Location = new System.Drawing.Point(27, 18);
            this.gbGeneralDetails.Name = "gbGeneralDetails";
            this.gbGeneralDetails.Size = new System.Drawing.Size(438, 207);
            this.gbGeneralDetails.TabIndex = 0;
            this.gbGeneralDetails.TabStop = false;
            this.gbGeneralDetails.Text = "General Details";
            // 
            // DateCreated
            // 
            this.DateCreated.CustomFormat = "dd/MM/yyyy";
            this.DateCreated.Enabled = false;
            this.DateCreated.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateCreated.Location = new System.Drawing.Point(126, 173);
            this.DateCreated.Name = "DateCreated";
            this.DateCreated.Size = new System.Drawing.Size(109, 20);
            this.DateCreated.TabIndex = 7;
            // 
            // CreatedBy
            // 
            this.CreatedBy.Location = new System.Drawing.Point(126, 147);
            this.CreatedBy.Name = "CreatedBy";
            this.CreatedBy.Size = new System.Drawing.Size(296, 20);
            this.CreatedBy.TabIndex = 6;
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(126, 45);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(296, 96);
            this.Description.TabIndex = 5;
            this.Description.Text = "";
            // 
            // ReminderName
            // 
            this.ReminderName.Location = new System.Drawing.Point(126, 19);
            this.ReminderName.Name = "ReminderName";
            this.ReminderName.Size = new System.Drawing.Size(296, 20);
            this.ReminderName.TabIndex = 4;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(21, 179);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "Date";
            // 
            // lblCreator
            // 
            this.lblCreator.AutoSize = true;
            this.lblCreator.Location = new System.Drawing.Point(21, 150);
            this.lblCreator.Name = "lblCreator";
            this.lblCreator.Size = new System.Drawing.Size(59, 13);
            this.lblCreator.TabIndex = 2;
            this.lblCreator.Text = "Created By";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(21, 48);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Description";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(21, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(83, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Reminder Name";
            // 
            // gbSchedule
            // 
            this.gbSchedule.Controls.Add(this.NextRunDate);
            this.gbSchedule.Controls.Add(this.RunFrequency);
            this.gbSchedule.Controls.Add(this.ActiveReminder);
            this.gbSchedule.Controls.Add(this.RepeatedRunTime);
            this.gbSchedule.Controls.Add(this.lblNextRun);
            this.gbSchedule.Controls.Add(this.lblDays);
            this.gbSchedule.Controls.Add(this.lblFrequency);
            this.gbSchedule.Controls.Add(this.lblTime);
            this.gbSchedule.Controls.Add(this.Repeated);
            this.gbSchedule.Controls.Add(this.RunOnce);
            this.gbSchedule.Location = new System.Drawing.Point(471, 18);
            this.gbSchedule.Name = "gbSchedule";
            this.gbSchedule.Size = new System.Drawing.Size(243, 207);
            this.gbSchedule.TabIndex = 1;
            this.gbSchedule.TabStop = false;
            this.gbSchedule.Text = "Schedule";
            // 
            // NextRunDate
            // 
            this.NextRunDate.CustomFormat = "dd/MM/yyyy";
            this.NextRunDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.NextRunDate.Location = new System.Drawing.Point(9, 95);
            this.NextRunDate.Name = "NextRunDate";
            this.NextRunDate.Size = new System.Drawing.Size(109, 20);
            this.NextRunDate.TabIndex = 10;
            // 
            // RunFrequency
            // 
            this.RunFrequency.Location = new System.Drawing.Point(61, 148);
            this.RunFrequency.Maximum = new decimal(new int[] {
            365,
            0,
            0,
            0});
            this.RunFrequency.Name = "RunFrequency";
            this.RunFrequency.Size = new System.Drawing.Size(57, 20);
            this.RunFrequency.TabIndex = 12;
            // 
            // ActiveReminder
            // 
            this.ActiveReminder.AutoSize = true;
            this.ActiveReminder.Location = new System.Drawing.Point(6, 18);
            this.ActiveReminder.Name = "ActiveReminder";
            this.ActiveReminder.Size = new System.Drawing.Size(56, 17);
            this.ActiveReminder.TabIndex = 3;
            this.ActiveReminder.Text = "Active";
            this.ActiveReminder.UseVisualStyleBackColor = true;
            // 
            // RepeatedRunTime
            // 
            this.RepeatedRunTime.CustomFormat = "HH:mm";
            this.RepeatedRunTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.RepeatedRunTime.Location = new System.Drawing.Point(124, 95);
            this.RepeatedRunTime.Name = "RepeatedRunTime";
            this.RepeatedRunTime.ShowUpDown = true;
            this.RepeatedRunTime.Size = new System.Drawing.Size(94, 20);
            this.RepeatedRunTime.TabIndex = 11;
            // 
            // lblNextRun
            // 
            this.lblNextRun.AutoSize = true;
            this.lblNextRun.Location = new System.Drawing.Point(6, 79);
            this.lblNextRun.Name = "lblNextRun";
            this.lblNextRun.Size = new System.Drawing.Size(78, 13);
            this.lblNextRun.TabIndex = 6;
            this.lblNextRun.Text = "Next Run Date";
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(124, 150);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(31, 13);
            this.lblDays.TabIndex = 5;
            this.lblDays.Text = "Days";
            // 
            // lblFrequency
            // 
            this.lblFrequency.AutoSize = true;
            this.lblFrequency.Location = new System.Drawing.Point(3, 150);
            this.lblFrequency.Name = "lblFrequency";
            this.lblFrequency.Size = new System.Drawing.Size(57, 13);
            this.lblFrequency.TabIndex = 4;
            this.lblFrequency.Text = "Run Every";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(120, 79);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(30, 13);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "Time";
            // 
            // Repeated
            // 
            this.Repeated.AutoSize = true;
            this.Repeated.Location = new System.Drawing.Point(111, 48);
            this.Repeated.Name = "Repeated";
            this.Repeated.Size = new System.Drawing.Size(73, 17);
            this.Repeated.TabIndex = 1;
            this.Repeated.Text = "Repeated";
            this.Repeated.UseVisualStyleBackColor = true;
            this.Repeated.CheckedChanged += new System.EventHandler(this.XbRepeated_CheckedChanged);
            // 
            // RunOnce
            // 
            this.RunOnce.AutoSize = true;
            this.RunOnce.Checked = true;
            this.RunOnce.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RunOnce.Location = new System.Drawing.Point(6, 48);
            this.RunOnce.Name = "RunOnce";
            this.RunOnce.Size = new System.Drawing.Size(99, 17);
            this.RunOnce.TabIndex = 0;
            this.RunOnce.Text = "Run Once Only";
            this.RunOnce.UseVisualStyleBackColor = true;
            this.RunOnce.CheckedChanged += new System.EventHandler(this.xbRunOnce_CheckedChanged);
            // 
            // cmdSQLBuilder
            // 
            this.cmdSQLBuilder.Location = new System.Drawing.Point(527, 231);
            this.cmdSQLBuilder.Name = "cmdSQLBuilder";
            this.cmdSQLBuilder.Size = new System.Drawing.Size(75, 25);
            this.cmdSQLBuilder.TabIndex = 3;
            this.cmdSQLBuilder.Text = "SQL Builder";
            this.cmdSQLBuilder.UseVisualStyleBackColor = true;
            this.cmdSQLBuilder.Click += new System.EventHandler(this.CmdSQLBuilder_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdSave.Location = new System.Drawing.Point(608, 231);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(50, 25);
            this.cmdSave.TabIndex = 5;
            this.cmdSave.Text = "Save";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdClose.Location = new System.Drawing.Point(664, 231);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(50, 25);
            this.cmdClose.TabIndex = 6;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.cmdClose_Click);
            // 
            // FrmReminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 261);
            this.Controls.Add(this.cmdClose);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.cmdSQLBuilder);
            this.Controls.Add(this.gbSchedule);
            this.Controls.Add(this.gbGeneralDetails);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(750, 300);
            this.MinimumSize = new System.Drawing.Size(750, 300);
            this.Name = "FrmReminder";
            this.Text = "Reminder";
            this.gbGeneralDetails.ResumeLayout(false);
            this.gbGeneralDetails.PerformLayout();
            this.gbSchedule.ResumeLayout(false);
            this.gbSchedule.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RunFrequency)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGeneralDetails;
        private System.Windows.Forms.TextBox CreatedBy;
        private System.Windows.Forms.RichTextBox Description;
        private System.Windows.Forms.TextBox ReminderName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCreator;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox gbSchedule;
        private System.Windows.Forms.DateTimePicker RepeatedRunTime;
        private System.Windows.Forms.Label lblNextRun;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Label lblFrequency;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.CheckBox Repeated;
        private System.Windows.Forms.CheckBox RunOnce;
        private System.Windows.Forms.CheckBox ActiveReminder;
        private System.Windows.Forms.DateTimePicker NextRunDate;
        private System.Windows.Forms.NumericUpDown RunFrequency;
        private System.Windows.Forms.Button cmdSQLBuilder;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.DateTimePicker DateCreated;
    }
}