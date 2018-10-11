namespace SQLReminders.Desktop.Forms
{
    partial class FrmAuditTrail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAuditTrail));
            this.AuditTrailList = new System.Windows.Forms.DataGridView();
            this.FromDate = new System.Windows.Forms.DateTimePicker();
            this.ToDate = new System.Windows.Forms.DateTimePicker();
            this.lblDateFrom = new System.Windows.Forms.Label();
            this.lblDateTo = new System.Windows.Forms.Label();
            this.CmdFilter = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.CmdRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AuditTrailList)).BeginInit();
            this.SuspendLayout();
            // 
            // AuditTrailList
            // 
            this.AuditTrailList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AuditTrailList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AuditTrailList.Location = new System.Drawing.Point(220, 12);
            this.AuditTrailList.Name = "AuditTrailList";
            this.AuditTrailList.ReadOnly = true;
            this.AuditTrailList.Size = new System.Drawing.Size(952, 437);
            this.AuditTrailList.TabIndex = 0;
            // 
            // FromDate
            // 
            this.FromDate.CustomFormat = "dd/MM/yyyy";
            this.FromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FromDate.Location = new System.Drawing.Point(12, 28);
            this.FromDate.Name = "FromDate";
            this.FromDate.Size = new System.Drawing.Size(200, 20);
            this.FromDate.TabIndex = 1;
            // 
            // ToDate
            // 
            this.ToDate.CustomFormat = "dd/MM/yyyy";
            this.ToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ToDate.Location = new System.Drawing.Point(12, 67);
            this.ToDate.Name = "ToDate";
            this.ToDate.Size = new System.Drawing.Size(200, 20);
            this.ToDate.TabIndex = 2;
            // 
            // lblDateFrom
            // 
            this.lblDateFrom.AutoSize = true;
            this.lblDateFrom.Location = new System.Drawing.Point(12, 12);
            this.lblDateFrom.Name = "lblDateFrom";
            this.lblDateFrom.Size = new System.Drawing.Size(56, 13);
            this.lblDateFrom.TabIndex = 3;
            this.lblDateFrom.Text = "From Date";
            // 
            // lblDateTo
            // 
            this.lblDateTo.AutoSize = true;
            this.lblDateTo.Location = new System.Drawing.Point(12, 51);
            this.lblDateTo.Name = "lblDateTo";
            this.lblDateTo.Size = new System.Drawing.Size(46, 13);
            this.lblDateTo.TabIndex = 4;
            this.lblDateTo.Text = "To Date";
            // 
            // CmdFilter
            // 
            this.CmdFilter.Location = new System.Drawing.Point(12, 156);
            this.CmdFilter.Name = "CmdFilter";
            this.CmdFilter.Size = new System.Drawing.Size(75, 23);
            this.CmdFilter.TabIndex = 4;
            this.CmdFilter.Text = "Filter";
            this.CmdFilter.UseVisualStyleBackColor = true;
            this.CmdFilter.Click += new System.EventHandler(this.CmdFilter_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(12, 90);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(56, 13);
            this.lblType.TabIndex = 6;
            this.lblType.Text = "Type (like)";
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(15, 106);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(200, 20);
            this.txtType.TabIndex = 3;
            // 
            // CmdRefresh
            // 
            this.CmdRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CmdRefresh.Location = new System.Drawing.Point(12, 426);
            this.CmdRefresh.Name = "CmdRefresh";
            this.CmdRefresh.Size = new System.Drawing.Size(75, 23);
            this.CmdRefresh.TabIndex = 8;
            this.CmdRefresh.Text = "Refresh";
            this.CmdRefresh.UseVisualStyleBackColor = true;
            this.CmdRefresh.Click += new System.EventHandler(this.CmdRefresh_Click);
            // 
            // FrmAuditTrail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 461);
            this.Controls.Add(this.CmdRefresh);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.CmdFilter);
            this.Controls.Add(this.lblDateTo);
            this.Controls.Add(this.lblDateFrom);
            this.Controls.Add(this.ToDate);
            this.Controls.Add(this.FromDate);
            this.Controls.Add(this.AuditTrailList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1200, 500);
            this.Name = "FrmAuditTrail";
            this.Text = "Audit Trail";
            this.Load += new System.EventHandler(this.AuditTrail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AuditTrailList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView AuditTrailList;
        private System.Windows.Forms.DateTimePicker FromDate;
        private System.Windows.Forms.DateTimePicker ToDate;
        private System.Windows.Forms.Label lblDateFrom;
        private System.Windows.Forms.Label lblDateTo;
        private System.Windows.Forms.Button CmdFilter;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.Button CmdRefresh;
    }
}