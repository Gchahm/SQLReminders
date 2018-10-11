namespace SQLReminders.Desktop.Forms
{
    partial class FrmInExport
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
            this.CmdExport = new System.Windows.Forms.Button();
            this.DgvReminders = new System.Windows.Forms.DataGridView();
            this.CmdImport = new System.Windows.Forms.Button();
            this.FileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.DgvReminders)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdExport
            // 
            this.CmdExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CmdExport.Location = new System.Drawing.Point(12, 315);
            this.CmdExport.Name = "CmdExport";
            this.CmdExport.Size = new System.Drawing.Size(75, 34);
            this.CmdExport.TabIndex = 1;
            this.CmdExport.Text = "Export";
            this.CmdExport.UseVisualStyleBackColor = true;
            this.CmdExport.Click += new System.EventHandler(this.CmdSetExportPath_Click);
            // 
            // DgvReminders
            // 
            this.DgvReminders.AllowUserToAddRows = false;
            this.DgvReminders.AllowUserToDeleteRows = false;
            this.DgvReminders.AllowUserToResizeRows = false;
            this.DgvReminders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvReminders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvReminders.Location = new System.Drawing.Point(12, 12);
            this.DgvReminders.Name = "DgvReminders";
            this.DgvReminders.Size = new System.Drawing.Size(660, 297);
            this.DgvReminders.TabIndex = 2;
            // 
            // CmdImport
            // 
            this.CmdImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CmdImport.Location = new System.Drawing.Point(93, 315);
            this.CmdImport.Name = "CmdImport";
            this.CmdImport.Size = new System.Drawing.Size(75, 34);
            this.CmdImport.TabIndex = 3;
            this.CmdImport.Text = "Import";
            this.CmdImport.UseVisualStyleBackColor = true;
            this.CmdImport.Click += new System.EventHandler(this.CmdImport_Click);
            // 
            // FrmInExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.CmdImport);
            this.Controls.Add(this.DgvReminders);
            this.Controls.Add(this.CmdExport);
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "FrmInExport";
            this.Text = "Import / Export";
            ((System.ComponentModel.ISupportInitialize)(this.DgvReminders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button CmdExport;
        private System.Windows.Forms.DataGridView DgvReminders;
        private System.Windows.Forms.Button CmdImport;
        private System.Windows.Forms.SaveFileDialog FileDialog;
    }
}