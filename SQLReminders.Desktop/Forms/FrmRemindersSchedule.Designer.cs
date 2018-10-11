
namespace SQLReminders.Desktop.Forms
{
    partial class FrmRemindersSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRemindersSchedule));
            this.CmdAdd = new System.Windows.Forms.Button();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.CmdEdit = new System.Windows.Forms.Button();
            this.CmdCopy = new System.Windows.Forms.Button();
            this.CmdClose = new System.Windows.Forms.Button();
            this.DgvReminderList = new System.Windows.Forms.DataGridView();
            this.CmdRefresh = new System.Windows.Forms.Button();
            this.xbShowActive = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgvReminderList)).BeginInit();
            this.SuspendLayout();
            // 
            // CmdAdd
            // 
            this.CmdAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdAdd.Location = new System.Drawing.Point(689, 35);
            this.CmdAdd.Name = "CmdAdd";
            this.CmdAdd.Size = new System.Drawing.Size(75, 23);
            this.CmdAdd.TabIndex = 1;
            this.CmdAdd.Text = "Add";
            this.CmdAdd.UseVisualStyleBackColor = true;
            this.CmdAdd.Click += new System.EventHandler(this.CmdAdd_Click);
            // 
            // cmdDelete
            // 
            this.cmdDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdDelete.Location = new System.Drawing.Point(689, 64);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(75, 23);
            this.cmdDelete.TabIndex = 2;
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.CmdDelete_Click);
            // 
            // CmdEdit
            // 
            this.CmdEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdEdit.Location = new System.Drawing.Point(689, 93);
            this.CmdEdit.Name = "CmdEdit";
            this.CmdEdit.Size = new System.Drawing.Size(75, 23);
            this.CmdEdit.TabIndex = 3;
            this.CmdEdit.Text = "Edit";
            this.CmdEdit.UseVisualStyleBackColor = true;
            this.CmdEdit.Click += new System.EventHandler(this.CmdEdit_Click);
            // 
            // CmdCopy
            // 
            this.CmdCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdCopy.Location = new System.Drawing.Point(689, 122);
            this.CmdCopy.Name = "CmdCopy";
            this.CmdCopy.Size = new System.Drawing.Size(75, 23);
            this.CmdCopy.TabIndex = 4;
            this.CmdCopy.Text = "Copy";
            this.CmdCopy.UseVisualStyleBackColor = true;
            this.CmdCopy.Click += new System.EventHandler(this.CmdCopy_Click);
            // 
            // CmdClose
            // 
            this.CmdClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdClose.Location = new System.Drawing.Point(689, 406);
            this.CmdClose.Name = "CmdClose";
            this.CmdClose.Size = new System.Drawing.Size(75, 43);
            this.CmdClose.TabIndex = 6;
            this.CmdClose.Text = "Close";
            this.CmdClose.UseVisualStyleBackColor = true;
            this.CmdClose.Click += new System.EventHandler(this.CmdClose_Click);
            // 
            // DgvReminderList
            // 
            this.DgvReminderList.AllowUserToAddRows = false;
            this.DgvReminderList.AllowUserToDeleteRows = false;
            this.DgvReminderList.AllowUserToResizeRows = false;
            this.DgvReminderList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvReminderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvReminderList.Location = new System.Drawing.Point(12, 35);
            this.DgvReminderList.MultiSelect = false;
            this.DgvReminderList.Name = "DgvReminderList";
            this.DgvReminderList.ReadOnly = true;
            this.DgvReminderList.Size = new System.Drawing.Size(671, 414);
            this.DgvReminderList.TabIndex = 6;
            this.DgvReminderList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvReminderList_CellDoubleClick);
            // 
            // CmdRefresh
            // 
            this.CmdRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CmdRefresh.Location = new System.Drawing.Point(689, 357);
            this.CmdRefresh.Name = "CmdRefresh";
            this.CmdRefresh.Size = new System.Drawing.Size(75, 43);
            this.CmdRefresh.TabIndex = 5;
            this.CmdRefresh.Text = "Refresh";
            this.CmdRefresh.UseVisualStyleBackColor = true;
            this.CmdRefresh.Click += new System.EventHandler(this.CmdRefresh_Click);
            // 
            // xbShowActive
            // 
            this.xbShowActive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.xbShowActive.AutoSize = true;
            this.xbShowActive.Checked = true;
            this.xbShowActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.xbShowActive.Location = new System.Drawing.Point(658, 12);
            this.xbShowActive.Name = "xbShowActive";
            this.xbShowActive.Size = new System.Drawing.Size(106, 17);
            this.xbShowActive.TabIndex = 7;
            this.xbShowActive.Text = "Acive Reminders";
            this.xbShowActive.UseVisualStyleBackColor = true;
            this.xbShowActive.CheckedChanged += new System.EventHandler(this.XbShowActive_CheckedChanged);
            // 
            // FrmRemindersSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.xbShowActive);
            this.Controls.Add(this.CmdRefresh);
            this.Controls.Add(this.DgvReminderList);
            this.Controls.Add(this.CmdClose);
            this.Controls.Add(this.CmdCopy);
            this.Controls.Add(this.CmdEdit);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.CmdAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FrmRemindersSchedule";
            this.Text = "Reminders Schedule";
            this.Load += new System.EventHandler(this.FrmRemindersSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvReminderList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CmdAdd;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button CmdEdit;
        private System.Windows.Forms.Button CmdCopy;
        private System.Windows.Forms.Button CmdClose;
        private System.Windows.Forms.DataGridView DgvReminderList;
        private System.Windows.Forms.Button CmdRefresh;
        private System.Windows.Forms.CheckBox xbShowActive;
    }
}