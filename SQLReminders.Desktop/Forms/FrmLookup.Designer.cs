namespace SQLReminders.Desktop.Forms
{
    partial class FrmLookup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLookup));
            this.lbltable = new System.Windows.Forms.Label();
            this.lblSetName = new System.Windows.Forms.Label();
            this.lblLookup = new System.Windows.Forms.Label();
            this.SetName = new System.Windows.Forms.TextBox();
            this.Lookup = new System.Windows.Forms.TextBox();
            this.CmdSave = new System.Windows.Forms.Button();
            this.CmdClose = new System.Windows.Forms.Button();
            this.Tablename = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbltable
            // 
            this.lbltable.AutoSize = true;
            this.lbltable.Location = new System.Drawing.Point(12, 9);
            this.lbltable.Name = "lbltable";
            this.lbltable.Size = new System.Drawing.Size(65, 13);
            this.lbltable.TabIndex = 0;
            this.lbltable.Text = "Table Name";
            // 
            // lblSetName
            // 
            this.lblSetName.AutoSize = true;
            this.lblSetName.Location = new System.Drawing.Point(12, 37);
            this.lblSetName.Name = "lblSetName";
            this.lblSetName.Size = new System.Drawing.Size(54, 13);
            this.lblSetName.TabIndex = 1;
            this.lblSetName.Text = "Set Name";
            // 
            // lblLookup
            // 
            this.lblLookup.AutoSize = true;
            this.lblLookup.Location = new System.Drawing.Point(12, 63);
            this.lblLookup.Name = "lblLookup";
            this.lblLookup.Size = new System.Drawing.Size(60, 13);
            this.lblLookup.TabIndex = 2;
            this.lblLookup.Text = "Field Name";
            // 
            // SetName
            // 
            this.SetName.Location = new System.Drawing.Point(83, 34);
            this.SetName.Name = "SetName";
            this.SetName.Size = new System.Drawing.Size(121, 20);
            this.SetName.TabIndex = 4;
            this.SetName.TextChanged += new System.EventHandler(this.SetName_TextChanged);
            // 
            // Lookup
            // 
            this.Lookup.Location = new System.Drawing.Point(83, 60);
            this.Lookup.Name = "Lookup";
            this.Lookup.Size = new System.Drawing.Size(121, 20);
            this.Lookup.TabIndex = 5;
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(12, 109);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(75, 23);
            this.CmdSave.TabIndex = 6;
            this.CmdSave.Text = "Save";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // CmdClose
            // 
            this.CmdClose.Location = new System.Drawing.Point(108, 109);
            this.CmdClose.Name = "CmdClose";
            this.CmdClose.Size = new System.Drawing.Size(75, 23);
            this.CmdClose.TabIndex = 7;
            this.CmdClose.Text = "Close";
            this.CmdClose.UseVisualStyleBackColor = true;
            this.CmdClose.Click += new System.EventHandler(this.CmdClose_Click);
            // 
            // Tablename
            // 
            this.Tablename.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Tablename.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Tablename.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Tablename.FormattingEnabled = true;
            this.Tablename.Items.AddRange(new object[] {
            "LOOKUP",
            "LUORG"});
            this.Tablename.Location = new System.Drawing.Point(83, 9);
            this.Tablename.Name = "Tablename";
            this.Tablename.Size = new System.Drawing.Size(121, 21);
            this.Tablename.TabIndex = 8;
            // 
            // FrmLookup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(209, 141);
            this.Controls.Add(this.Tablename);
            this.Controls.Add(this.CmdClose);
            this.Controls.Add(this.CmdSave);
            this.Controls.Add(this.Lookup);
            this.Controls.Add(this.SetName);
            this.Controls.Add(this.lblLookup);
            this.Controls.Add(this.lblSetName);
            this.Controls.Add(this.lbltable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(225, 180);
            this.MinimumSize = new System.Drawing.Size(225, 180);
            this.Name = "FrmLookup";
            this.Text = "Lookup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltable;
        private System.Windows.Forms.Label lblSetName;
        private System.Windows.Forms.Label lblLookup;
        private System.Windows.Forms.TextBox SetName;
        private System.Windows.Forms.TextBox Lookup;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.Button CmdClose;
        private System.Windows.Forms.ComboBox Tablename;
    }
}