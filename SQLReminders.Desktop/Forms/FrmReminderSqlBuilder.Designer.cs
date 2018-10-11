
namespace SQLReminders.Desktop.Forms
{
    partial class FrmReminderSqlBuilder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReminderSqlBuilder));
            this.gbTableSel = new System.Windows.Forms.GroupBox();
            this.BoxTableRelations = new System.Windows.Forms.RichTextBox();
            this.CmdRemove = new System.Windows.Forms.Button();
            this.BoxTablesUsed = new System.Windows.Forms.ListBox();
            this.CmdAddTable = new System.Windows.Forms.Button();
            this.BoxAvailableTables = new System.Windows.Forms.ComboBox();
            this.gbSubject = new System.Windows.Forms.GroupBox();
            this.Subject8B = new System.Windows.Forms.ComboBox();
            this.Subject7B = new System.Windows.Forms.ComboBox();
            this.Subject6B = new System.Windows.Forms.ComboBox();
            this.Subject5B = new System.Windows.Forms.ComboBox();
            this.Subject4B = new System.Windows.Forms.ComboBox();
            this.Subject3B = new System.Windows.Forms.ComboBox();
            this.Subject2B = new System.Windows.Forms.ComboBox();
            this.Subject1B = new System.Windows.Forms.ComboBox();
            this.Subject8A = new System.Windows.Forms.TextBox();
            this.Subject7A = new System.Windows.Forms.TextBox();
            this.Subject6A = new System.Windows.Forms.TextBox();
            this.Subject5A = new System.Windows.Forms.TextBox();
            this.Subject4A = new System.Windows.Forms.TextBox();
            this.Subject3A = new System.Windows.Forms.TextBox();
            this.Subject2A = new System.Windows.Forms.TextBox();
            this.Subject1A = new System.Windows.Forms.TextBox();
            this.gbMessage = new System.Windows.Forms.GroupBox();
            this.Message8B = new System.Windows.Forms.ComboBox();
            this.Message7B = new System.Windows.Forms.ComboBox();
            this.Message6B = new System.Windows.Forms.ComboBox();
            this.Message5B = new System.Windows.Forms.ComboBox();
            this.Message4B = new System.Windows.Forms.ComboBox();
            this.Message3B = new System.Windows.Forms.ComboBox();
            this.Message2B = new System.Windows.Forms.ComboBox();
            this.Message1B = new System.Windows.Forms.ComboBox();
            this.Message8A = new System.Windows.Forms.TextBox();
            this.Message7A = new System.Windows.Forms.TextBox();
            this.Message6A = new System.Windows.Forms.TextBox();
            this.Message5A = new System.Windows.Forms.TextBox();
            this.Message4A = new System.Windows.Forms.TextBox();
            this.Message3A = new System.Windows.Forms.TextBox();
            this.Message2A = new System.Windows.Forms.TextBox();
            this.Message1A = new System.Windows.Forms.TextBox();
            this.gbFieldSelection = new System.Windows.Forms.GroupBox();
            this.ShowHideResults = new System.Windows.Forms.Button();
            this.RemoveField = new System.Windows.Forms.Button();
            this.AddField = new System.Windows.Forms.Button();
            this.lblCondition = new System.Windows.Forms.Label();
            this.LblFieldsUsed = new System.Windows.Forms.Label();
            this.lblSelectedStatements = new System.Windows.Forms.Label();
            this.BoxCondition = new System.Windows.Forms.RichTextBox();
            this.BoxSelectionCriteria = new System.Windows.Forms.RichTextBox();
            this.BoxFieldsUsed = new System.Windows.Forms.ListBox();
            this.AvailableSelection = new System.Windows.Forms.ListBox();
            this.gbFieldsToUpdate = new System.Windows.Forms.GroupBox();
            this.UpdateField5 = new System.Windows.Forms.ComboBox();
            this.UpdateField4 = new System.Windows.Forms.ComboBox();
            this.UpdateField3 = new System.Windows.Forms.ComboBox();
            this.UpdateField1 = new System.Windows.Forms.ComboBox();
            this.UpdateTo5 = new System.Windows.Forms.TextBox();
            this.UpdateField2 = new System.Windows.Forms.ComboBox();
            this.UpdateTo4 = new System.Windows.Forms.TextBox();
            this.UpdateTo3 = new System.Windows.Forms.TextBox();
            this.UpdateTo2 = new System.Windows.Forms.TextBox();
            this.UpdateTo1 = new System.Windows.Forms.TextBox();
            this.QueryResult = new System.Windows.Forms.DataGridView();
            this.gbEmailFooter = new System.Windows.Forms.GroupBox();
            this.EmailMessageFooter = new System.Windows.Forms.RichTextBox();
            this.AppendEmailFooter = new System.Windows.Forms.CheckBox();
            this.CmdSave = new System.Windows.Forms.Button();
            this.cmdClose = new System.Windows.Forms.Button();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.GBSendTo = new System.Windows.Forms.GroupBox();
            this.BoxSpecificAddress = new System.Windows.Forms.RichTextBox();
            this.BoxType = new System.Windows.Forms.ComboBox();
            this.BoxFieldForEmail = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gbTableSel.SuspendLayout();
            this.gbSubject.SuspendLayout();
            this.gbMessage.SuspendLayout();
            this.gbFieldSelection.SuspendLayout();
            this.gbFieldsToUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QueryResult)).BeginInit();
            this.gbEmailFooter.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.GBSendTo.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTableSel
            // 
            this.gbTableSel.Controls.Add(this.BoxTableRelations);
            this.gbTableSel.Controls.Add(this.CmdRemove);
            this.gbTableSel.Controls.Add(this.BoxTablesUsed);
            this.gbTableSel.Controls.Add(this.CmdAddTable);
            this.gbTableSel.Controls.Add(this.BoxAvailableTables);
            this.gbTableSel.Location = new System.Drawing.Point(6, 6);
            this.gbTableSel.Name = "gbTableSel";
            this.gbTableSel.Size = new System.Drawing.Size(383, 169);
            this.gbTableSel.TabIndex = 0;
            this.gbTableSel.TabStop = false;
            this.gbTableSel.Text = "Table Selection";
            // 
            // BoxTableRelations
            // 
            this.BoxTableRelations.Location = new System.Drawing.Point(7, 121);
            this.BoxTableRelations.Name = "BoxTableRelations";
            this.BoxTableRelations.Size = new System.Drawing.Size(288, 40);
            this.BoxTableRelations.TabIndex = 4;
            this.BoxTableRelations.Text = "";
            this.BoxTableRelations.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TableRelation_KeyUp);
            // 
            // CmdRemove
            // 
            this.CmdRemove.Location = new System.Drawing.Point(300, 46);
            this.CmdRemove.Name = "CmdRemove";
            this.CmdRemove.Size = new System.Drawing.Size(75, 23);
            this.CmdRemove.TabIndex = 2;
            this.CmdRemove.Text = "Remove";
            this.CmdRemove.UseVisualStyleBackColor = true;
            this.CmdRemove.Click += new System.EventHandler(this.CmdRemove_Click);
            // 
            // BoxTablesUsed
            // 
            this.BoxTablesUsed.FormattingEnabled = true;
            this.BoxTablesUsed.Location = new System.Drawing.Point(6, 46);
            this.BoxTablesUsed.Name = "BoxTablesUsed";
            this.BoxTablesUsed.Size = new System.Drawing.Size(288, 69);
            this.BoxTablesUsed.TabIndex = 3;
            this.BoxTablesUsed.SelectedValueChanged += new System.EventHandler(this.TablesUsed_SelectedValueChanged);
            // 
            // CmdAddTable
            // 
            this.CmdAddTable.Location = new System.Drawing.Point(301, 19);
            this.CmdAddTable.Name = "CmdAddTable";
            this.CmdAddTable.Size = new System.Drawing.Size(75, 23);
            this.CmdAddTable.TabIndex = 1;
            this.CmdAddTable.Text = "Add";
            this.CmdAddTable.UseVisualStyleBackColor = true;
            this.CmdAddTable.Click += new System.EventHandler(this.CmdAddTable_Click);
            // 
            // BoxAvailableTables
            // 
            this.BoxAvailableTables.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.BoxAvailableTables.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.BoxAvailableTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BoxAvailableTables.FormattingEnabled = true;
            this.BoxAvailableTables.Location = new System.Drawing.Point(6, 19);
            this.BoxAvailableTables.Name = "BoxAvailableTables";
            this.BoxAvailableTables.Size = new System.Drawing.Size(289, 21);
            this.BoxAvailableTables.Sorted = true;
            this.BoxAvailableTables.TabIndex = 0;
            // 
            // gbSubject
            // 
            this.gbSubject.Controls.Add(this.Subject8B);
            this.gbSubject.Controls.Add(this.Subject7B);
            this.gbSubject.Controls.Add(this.Subject6B);
            this.gbSubject.Controls.Add(this.Subject5B);
            this.gbSubject.Controls.Add(this.Subject4B);
            this.gbSubject.Controls.Add(this.Subject3B);
            this.gbSubject.Controls.Add(this.Subject2B);
            this.gbSubject.Controls.Add(this.Subject1B);
            this.gbSubject.Controls.Add(this.Subject8A);
            this.gbSubject.Controls.Add(this.Subject7A);
            this.gbSubject.Controls.Add(this.Subject6A);
            this.gbSubject.Controls.Add(this.Subject5A);
            this.gbSubject.Controls.Add(this.Subject4A);
            this.gbSubject.Controls.Add(this.Subject3A);
            this.gbSubject.Controls.Add(this.Subject2A);
            this.gbSubject.Controls.Add(this.Subject1A);
            this.gbSubject.Location = new System.Drawing.Point(6, 181);
            this.gbSubject.Name = "gbSubject";
            this.gbSubject.Size = new System.Drawing.Size(382, 239);
            this.gbSubject.TabIndex = 1;
            this.gbSubject.TabStop = false;
            this.gbSubject.Text = "Subject ";
            // 
            // Subject8B
            // 
            this.Subject8B.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Subject8B.FormattingEnabled = true;
            this.Subject8B.Location = new System.Drawing.Point(251, 200);
            this.Subject8B.Name = "Subject8B";
            this.Subject8B.Size = new System.Drawing.Size(121, 21);
            this.Subject8B.TabIndex = 15;
            // 
            // Subject7B
            // 
            this.Subject7B.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Subject7B.FormattingEnabled = true;
            this.Subject7B.Location = new System.Drawing.Point(251, 174);
            this.Subject7B.Name = "Subject7B";
            this.Subject7B.Size = new System.Drawing.Size(121, 21);
            this.Subject7B.TabIndex = 13;
            // 
            // Subject6B
            // 
            this.Subject6B.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Subject6B.FormattingEnabled = true;
            this.Subject6B.Location = new System.Drawing.Point(251, 148);
            this.Subject6B.Name = "Subject6B";
            this.Subject6B.Size = new System.Drawing.Size(121, 21);
            this.Subject6B.TabIndex = 11;
            // 
            // Subject5B
            // 
            this.Subject5B.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Subject5B.FormattingEnabled = true;
            this.Subject5B.Location = new System.Drawing.Point(251, 122);
            this.Subject5B.Name = "Subject5B";
            this.Subject5B.Size = new System.Drawing.Size(121, 21);
            this.Subject5B.TabIndex = 9;
            // 
            // Subject4B
            // 
            this.Subject4B.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Subject4B.FormattingEnabled = true;
            this.Subject4B.Location = new System.Drawing.Point(251, 96);
            this.Subject4B.Name = "Subject4B";
            this.Subject4B.Size = new System.Drawing.Size(121, 21);
            this.Subject4B.TabIndex = 7;
            // 
            // Subject3B
            // 
            this.Subject3B.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Subject3B.FormattingEnabled = true;
            this.Subject3B.Location = new System.Drawing.Point(251, 70);
            this.Subject3B.Name = "Subject3B";
            this.Subject3B.Size = new System.Drawing.Size(121, 21);
            this.Subject3B.TabIndex = 5;
            // 
            // Subject2B
            // 
            this.Subject2B.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Subject2B.FormattingEnabled = true;
            this.Subject2B.Location = new System.Drawing.Point(251, 44);
            this.Subject2B.Name = "Subject2B";
            this.Subject2B.Size = new System.Drawing.Size(121, 21);
            this.Subject2B.TabIndex = 3;
            // 
            // Subject1B
            // 
            this.Subject1B.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Subject1B.FormattingEnabled = true;
            this.Subject1B.Location = new System.Drawing.Point(251, 19);
            this.Subject1B.Name = "Subject1B";
            this.Subject1B.Size = new System.Drawing.Size(121, 21);
            this.Subject1B.TabIndex = 1;
            // 
            // Subject8A
            // 
            this.Subject8A.Location = new System.Drawing.Point(6, 201);
            this.Subject8A.Name = "Subject8A";
            this.Subject8A.Size = new System.Drawing.Size(239, 20);
            this.Subject8A.TabIndex = 14;
            // 
            // Subject7A
            // 
            this.Subject7A.Location = new System.Drawing.Point(6, 175);
            this.Subject7A.Name = "Subject7A";
            this.Subject7A.Size = new System.Drawing.Size(239, 20);
            this.Subject7A.TabIndex = 12;
            // 
            // Subject6A
            // 
            this.Subject6A.Location = new System.Drawing.Point(6, 149);
            this.Subject6A.Name = "Subject6A";
            this.Subject6A.Size = new System.Drawing.Size(239, 20);
            this.Subject6A.TabIndex = 10;
            // 
            // Subject5A
            // 
            this.Subject5A.Location = new System.Drawing.Point(6, 123);
            this.Subject5A.Name = "Subject5A";
            this.Subject5A.Size = new System.Drawing.Size(239, 20);
            this.Subject5A.TabIndex = 8;
            // 
            // Subject4A
            // 
            this.Subject4A.Location = new System.Drawing.Point(6, 97);
            this.Subject4A.Name = "Subject4A";
            this.Subject4A.Size = new System.Drawing.Size(239, 20);
            this.Subject4A.TabIndex = 6;
            // 
            // Subject3A
            // 
            this.Subject3A.Location = new System.Drawing.Point(6, 71);
            this.Subject3A.Name = "Subject3A";
            this.Subject3A.Size = new System.Drawing.Size(239, 20);
            this.Subject3A.TabIndex = 4;
            // 
            // Subject2A
            // 
            this.Subject2A.Location = new System.Drawing.Point(6, 45);
            this.Subject2A.Name = "Subject2A";
            this.Subject2A.Size = new System.Drawing.Size(239, 20);
            this.Subject2A.TabIndex = 2;
            // 
            // Subject1A
            // 
            this.Subject1A.Location = new System.Drawing.Point(6, 19);
            this.Subject1A.Name = "Subject1A";
            this.Subject1A.Size = new System.Drawing.Size(239, 20);
            this.Subject1A.TabIndex = 0;
            // 
            // gbMessage
            // 
            this.gbMessage.Controls.Add(this.Message8B);
            this.gbMessage.Controls.Add(this.Message7B);
            this.gbMessage.Controls.Add(this.Message6B);
            this.gbMessage.Controls.Add(this.Message5B);
            this.gbMessage.Controls.Add(this.Message4B);
            this.gbMessage.Controls.Add(this.Message3B);
            this.gbMessage.Controls.Add(this.Message2B);
            this.gbMessage.Controls.Add(this.Message1B);
            this.gbMessage.Controls.Add(this.Message8A);
            this.gbMessage.Controls.Add(this.Message7A);
            this.gbMessage.Controls.Add(this.Message6A);
            this.gbMessage.Controls.Add(this.Message5A);
            this.gbMessage.Controls.Add(this.Message4A);
            this.gbMessage.Controls.Add(this.Message3A);
            this.gbMessage.Controls.Add(this.Message2A);
            this.gbMessage.Controls.Add(this.Message1A);
            this.gbMessage.Location = new System.Drawing.Point(12, 426);
            this.gbMessage.Name = "gbMessage";
            this.gbMessage.Size = new System.Drawing.Size(383, 250);
            this.gbMessage.TabIndex = 2;
            this.gbMessage.TabStop = false;
            this.gbMessage.Text = "Message";
            // 
            // Message8B
            // 
            this.Message8B.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Message8B.FormattingEnabled = true;
            this.Message8B.Location = new System.Drawing.Point(251, 200);
            this.Message8B.Name = "Message8B";
            this.Message8B.Size = new System.Drawing.Size(121, 21);
            this.Message8B.TabIndex = 15;
            // 
            // Message7B
            // 
            this.Message7B.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Message7B.FormattingEnabled = true;
            this.Message7B.Location = new System.Drawing.Point(251, 175);
            this.Message7B.Name = "Message7B";
            this.Message7B.Size = new System.Drawing.Size(121, 21);
            this.Message7B.TabIndex = 13;
            // 
            // Message6B
            // 
            this.Message6B.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Message6B.FormattingEnabled = true;
            this.Message6B.Location = new System.Drawing.Point(251, 148);
            this.Message6B.Name = "Message6B";
            this.Message6B.Size = new System.Drawing.Size(121, 21);
            this.Message6B.TabIndex = 11;
            // 
            // Message5B
            // 
            this.Message5B.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Message5B.FormattingEnabled = true;
            this.Message5B.Location = new System.Drawing.Point(251, 123);
            this.Message5B.Name = "Message5B";
            this.Message5B.Size = new System.Drawing.Size(121, 21);
            this.Message5B.TabIndex = 9;
            // 
            // Message4B
            // 
            this.Message4B.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Message4B.FormattingEnabled = true;
            this.Message4B.Location = new System.Drawing.Point(251, 96);
            this.Message4B.Name = "Message4B";
            this.Message4B.Size = new System.Drawing.Size(121, 21);
            this.Message4B.TabIndex = 7;
            // 
            // Message3B
            // 
            this.Message3B.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Message3B.FormattingEnabled = true;
            this.Message3B.Location = new System.Drawing.Point(251, 70);
            this.Message3B.Name = "Message3B";
            this.Message3B.Size = new System.Drawing.Size(121, 21);
            this.Message3B.TabIndex = 5;
            // 
            // Message2B
            // 
            this.Message2B.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Message2B.FormattingEnabled = true;
            this.Message2B.Location = new System.Drawing.Point(251, 45);
            this.Message2B.Name = "Message2B";
            this.Message2B.Size = new System.Drawing.Size(121, 21);
            this.Message2B.TabIndex = 3;
            // 
            // Message1B
            // 
            this.Message1B.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Message1B.FormattingEnabled = true;
            this.Message1B.Location = new System.Drawing.Point(251, 19);
            this.Message1B.Name = "Message1B";
            this.Message1B.Size = new System.Drawing.Size(121, 21);
            this.Message1B.TabIndex = 1;
            // 
            // Message8A
            // 
            this.Message8A.Location = new System.Drawing.Point(6, 201);
            this.Message8A.Name = "Message8A";
            this.Message8A.Size = new System.Drawing.Size(239, 20);
            this.Message8A.TabIndex = 14;
            // 
            // Message7A
            // 
            this.Message7A.Location = new System.Drawing.Point(6, 175);
            this.Message7A.Name = "Message7A";
            this.Message7A.Size = new System.Drawing.Size(239, 20);
            this.Message7A.TabIndex = 12;
            // 
            // Message6A
            // 
            this.Message6A.Location = new System.Drawing.Point(6, 149);
            this.Message6A.Name = "Message6A";
            this.Message6A.Size = new System.Drawing.Size(239, 20);
            this.Message6A.TabIndex = 10;
            // 
            // Message5A
            // 
            this.Message5A.Location = new System.Drawing.Point(6, 123);
            this.Message5A.Name = "Message5A";
            this.Message5A.Size = new System.Drawing.Size(239, 20);
            this.Message5A.TabIndex = 8;
            // 
            // Message4A
            // 
            this.Message4A.Location = new System.Drawing.Point(6, 97);
            this.Message4A.Name = "Message4A";
            this.Message4A.Size = new System.Drawing.Size(239, 20);
            this.Message4A.TabIndex = 6;
            // 
            // Message3A
            // 
            this.Message3A.Location = new System.Drawing.Point(6, 71);
            this.Message3A.Name = "Message3A";
            this.Message3A.Size = new System.Drawing.Size(239, 20);
            this.Message3A.TabIndex = 4;
            // 
            // Message2A
            // 
            this.Message2A.Location = new System.Drawing.Point(6, 45);
            this.Message2A.Name = "Message2A";
            this.Message2A.Size = new System.Drawing.Size(239, 20);
            this.Message2A.TabIndex = 2;
            // 
            // Message1A
            // 
            this.Message1A.Location = new System.Drawing.Point(6, 19);
            this.Message1A.Name = "Message1A";
            this.Message1A.Size = new System.Drawing.Size(239, 20);
            this.Message1A.TabIndex = 0;
            // 
            // gbFieldSelection
            // 
            this.gbFieldSelection.Controls.Add(this.ShowHideResults);
            this.gbFieldSelection.Controls.Add(this.RemoveField);
            this.gbFieldSelection.Controls.Add(this.AddField);
            this.gbFieldSelection.Controls.Add(this.lblCondition);
            this.gbFieldSelection.Controls.Add(this.LblFieldsUsed);
            this.gbFieldSelection.Controls.Add(this.lblSelectedStatements);
            this.gbFieldSelection.Controls.Add(this.BoxCondition);
            this.gbFieldSelection.Controls.Add(this.BoxSelectionCriteria);
            this.gbFieldSelection.Controls.Add(this.BoxFieldsUsed);
            this.gbFieldSelection.Controls.Add(this.AvailableSelection);
            this.gbFieldSelection.Location = new System.Drawing.Point(398, 6);
            this.gbFieldSelection.Name = "gbFieldSelection";
            this.gbFieldSelection.Size = new System.Drawing.Size(723, 360);
            this.gbFieldSelection.TabIndex = 3;
            this.gbFieldSelection.TabStop = false;
            this.gbFieldSelection.Text = "Field Selection";
            // 
            // ShowHideResults
            // 
            this.ShowHideResults.Location = new System.Drawing.Point(616, 14);
            this.ShowHideResults.Name = "ShowHideResults";
            this.ShowHideResults.Size = new System.Drawing.Size(75, 23);
            this.ShowHideResults.TabIndex = 6;
            this.ShowHideResults.Text = "Show Results";
            this.ShowHideResults.UseVisualStyleBackColor = true;
            this.ShowHideResults.Click += new System.EventHandler(this.ShowHideResults_Click);
            // 
            // RemoveField
            // 
            this.RemoveField.Location = new System.Drawing.Point(6, 308);
            this.RemoveField.Name = "RemoveField";
            this.RemoveField.Size = new System.Drawing.Size(75, 23);
            this.RemoveField.TabIndex = 1;
            this.RemoveField.Text = "Remove";
            this.RemoveField.UseVisualStyleBackColor = true;
            this.RemoveField.Click += new System.EventHandler(this.RemoveField_Click);
            // 
            // AddField
            // 
            this.AddField.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddField.Location = new System.Drawing.Point(6, 14);
            this.AddField.Name = "AddField";
            this.AddField.Size = new System.Drawing.Size(75, 23);
            this.AddField.TabIndex = 0;
            this.AddField.Text = "Add";
            this.AddField.UseVisualStyleBackColor = true;
            this.AddField.Click += new System.EventHandler(this.AddField_Click);
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.Location = new System.Drawing.Point(166, 164);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(51, 13);
            this.lblCondition.TabIndex = 7;
            this.lblCondition.Text = "Condition";
            // 
            // LblFieldsUsed
            // 
            this.LblFieldsUsed.AutoSize = true;
            this.LblFieldsUsed.Location = new System.Drawing.Point(6, 164);
            this.LblFieldsUsed.Name = "LblFieldsUsed";
            this.LblFieldsUsed.Size = new System.Drawing.Size(62, 13);
            this.LblFieldsUsed.TabIndex = 6;
            this.LblFieldsUsed.Text = "Fields Used";
            // 
            // lblSelectedStatements
            // 
            this.lblSelectedStatements.AutoSize = true;
            this.lblSelectedStatements.Location = new System.Drawing.Point(166, 24);
            this.lblSelectedStatements.Name = "lblSelectedStatements";
            this.lblSelectedStatements.Size = new System.Drawing.Size(105, 13);
            this.lblSelectedStatements.TabIndex = 5;
            this.lblSelectedStatements.Text = "Selected Statements";
            // 
            // BoxCondition
            // 
            this.BoxCondition.Location = new System.Drawing.Point(163, 181);
            this.BoxCondition.Name = "BoxCondition";
            this.BoxCondition.Size = new System.Drawing.Size(528, 121);
            this.BoxCondition.TabIndex = 5;
            this.BoxCondition.Text = "";
            this.BoxCondition.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SQLConditions_KeyUp);
            // 
            // BoxSelectionCriteria
            // 
            this.BoxSelectionCriteria.Location = new System.Drawing.Point(163, 40);
            this.BoxSelectionCriteria.Name = "BoxSelectionCriteria";
            this.BoxSelectionCriteria.Size = new System.Drawing.Size(528, 121);
            this.BoxSelectionCriteria.TabIndex = 3;
            this.BoxSelectionCriteria.Text = "";
            // 
            // ListBoxFieldsUsed
            // 
            this.BoxFieldsUsed.FormattingEnabled = true;
            this.BoxFieldsUsed.Location = new System.Drawing.Point(6, 181);
            this.BoxFieldsUsed.Name = "ListBoxFieldsUsed";
            this.BoxFieldsUsed.Size = new System.Drawing.Size(151, 121);
            this.BoxFieldsUsed.TabIndex = 4;
            // 
            // AvailableSelection
            // 
            this.AvailableSelection.FormattingEnabled = true;
            this.AvailableSelection.Location = new System.Drawing.Point(6, 40);
            this.AvailableSelection.Name = "AvailableSelection";
            this.AvailableSelection.Size = new System.Drawing.Size(151, 121);
            this.AvailableSelection.TabIndex = 2;
            this.AvailableSelection.DoubleClick += new System.EventHandler(this.AvailableSelection_DoubleClick);
            // 
            // gbFieldsToUpdate
            // 
            this.gbFieldsToUpdate.Controls.Add(this.UpdateField5);
            this.gbFieldsToUpdate.Controls.Add(this.UpdateField4);
            this.gbFieldsToUpdate.Controls.Add(this.UpdateField3);
            this.gbFieldsToUpdate.Controls.Add(this.UpdateField1);
            this.gbFieldsToUpdate.Controls.Add(this.UpdateTo5);
            this.gbFieldsToUpdate.Controls.Add(this.UpdateField2);
            this.gbFieldsToUpdate.Controls.Add(this.UpdateTo4);
            this.gbFieldsToUpdate.Controls.Add(this.UpdateTo3);
            this.gbFieldsToUpdate.Controls.Add(this.UpdateTo2);
            this.gbFieldsToUpdate.Controls.Add(this.UpdateTo1);
            this.gbFieldsToUpdate.Location = new System.Drawing.Point(399, 372);
            this.gbFieldsToUpdate.Name = "gbFieldsToUpdate";
            this.gbFieldsToUpdate.Size = new System.Drawing.Size(344, 187);
            this.gbFieldsToUpdate.TabIndex = 4;
            this.gbFieldsToUpdate.TabStop = false;
            this.gbFieldsToUpdate.Text = "Fields to Update";
            // 
            // UpdateField5
            // 
            this.UpdateField5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UpdateField5.FormattingEnabled = true;
            this.UpdateField5.Location = new System.Drawing.Point(6, 122);
            this.UpdateField5.Name = "UpdateField5";
            this.UpdateField5.Size = new System.Drawing.Size(205, 21);
            this.UpdateField5.TabIndex = 8;
            // 
            // UpdateField4
            // 
            this.UpdateField4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UpdateField4.FormattingEnabled = true;
            this.UpdateField4.Location = new System.Drawing.Point(6, 96);
            this.UpdateField4.Name = "UpdateField4";
            this.UpdateField4.Size = new System.Drawing.Size(205, 21);
            this.UpdateField4.TabIndex = 6;
            // 
            // UpdateField3
            // 
            this.UpdateField3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UpdateField3.FormattingEnabled = true;
            this.UpdateField3.Location = new System.Drawing.Point(6, 71);
            this.UpdateField3.Name = "UpdateField3";
            this.UpdateField3.Size = new System.Drawing.Size(205, 21);
            this.UpdateField3.TabIndex = 4;
            // 
            // UpdateField1
            // 
            this.UpdateField1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UpdateField1.FormattingEnabled = true;
            this.UpdateField1.Location = new System.Drawing.Point(6, 17);
            this.UpdateField1.Name = "UpdateField1";
            this.UpdateField1.Size = new System.Drawing.Size(205, 21);
            this.UpdateField1.TabIndex = 0;
            // 
            // UpdateTo5
            // 
            this.UpdateTo5.Location = new System.Drawing.Point(217, 122);
            this.UpdateTo5.Name = "UpdateTo5";
            this.UpdateTo5.Size = new System.Drawing.Size(121, 20);
            this.UpdateTo5.TabIndex = 9;
            // 
            // UpdateField2
            // 
            this.UpdateField2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UpdateField2.FormattingEnabled = true;
            this.UpdateField2.Location = new System.Drawing.Point(6, 42);
            this.UpdateField2.Name = "UpdateField2";
            this.UpdateField2.Size = new System.Drawing.Size(205, 21);
            this.UpdateField2.TabIndex = 2;
            // 
            // UpdateTo4
            // 
            this.UpdateTo4.Location = new System.Drawing.Point(217, 96);
            this.UpdateTo4.Name = "UpdateTo4";
            this.UpdateTo4.Size = new System.Drawing.Size(121, 20);
            this.UpdateTo4.TabIndex = 7;
            // 
            // UpdateTo3
            // 
            this.UpdateTo3.Location = new System.Drawing.Point(217, 71);
            this.UpdateTo3.Name = "UpdateTo3";
            this.UpdateTo3.Size = new System.Drawing.Size(121, 20);
            this.UpdateTo3.TabIndex = 5;
            // 
            // UpdateTo2
            // 
            this.UpdateTo2.Location = new System.Drawing.Point(217, 45);
            this.UpdateTo2.Name = "UpdateTo2";
            this.UpdateTo2.Size = new System.Drawing.Size(121, 20);
            this.UpdateTo2.TabIndex = 3;
            // 
            // UpdateTo1
            // 
            this.UpdateTo1.Location = new System.Drawing.Point(217, 18);
            this.UpdateTo1.Name = "UpdateTo1";
            this.UpdateTo1.Size = new System.Drawing.Size(121, 20);
            this.UpdateTo1.TabIndex = 1;
            // 
            // QueryResult
            // 
            this.QueryResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QueryResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QueryResult.Location = new System.Drawing.Point(6, 6);
            this.QueryResult.Name = "QueryResult";
            this.QueryResult.Size = new System.Drawing.Size(1115, 670);
            this.QueryResult.TabIndex = 10;
            // 
            // gbEmailFooter
            // 
            this.gbEmailFooter.Controls.Add(this.EmailMessageFooter);
            this.gbEmailFooter.Controls.Add(this.AppendEmailFooter);
            this.gbEmailFooter.Location = new System.Drawing.Point(749, 372);
            this.gbEmailFooter.Name = "gbEmailFooter";
            this.gbEmailFooter.Size = new System.Drawing.Size(372, 190);
            this.gbEmailFooter.TabIndex = 5;
            this.gbEmailFooter.TabStop = false;
            this.gbEmailFooter.Text = "Email Footer";
            // 
            // EmailMessageFooter
            // 
            this.EmailMessageFooter.Location = new System.Drawing.Point(6, 39);
            this.EmailMessageFooter.Name = "EmailMessageFooter";
            this.EmailMessageFooter.Size = new System.Drawing.Size(335, 145);
            this.EmailMessageFooter.TabIndex = 1;
            this.EmailMessageFooter.Text = "";
            // 
            // AppendEmailFooter
            // 
            this.AppendEmailFooter.AutoSize = true;
            this.AppendEmailFooter.Location = new System.Drawing.Point(6, 19);
            this.AppendEmailFooter.Name = "AppendEmailFooter";
            this.AppendEmailFooter.Size = new System.Drawing.Size(168, 17);
            this.AppendEmailFooter.TabIndex = 0;
            this.AppendEmailFooter.Text = "Include Email Message Footer";
            this.AppendEmailFooter.UseVisualStyleBackColor = true;
            // 
            // CmdSave
            // 
            this.CmdSave.Location = new System.Drawing.Point(1015, 651);
            this.CmdSave.Name = "CmdSave";
            this.CmdSave.Size = new System.Drawing.Size(50, 25);
            this.CmdSave.TabIndex = 7;
            this.CmdSave.Text = "Save";
            this.CmdSave.UseVisualStyleBackColor = true;
            this.CmdSave.Click += new System.EventHandler(this.CmdSave_Click);
            // 
            // cmdClose
            // 
            this.cmdClose.Location = new System.Drawing.Point(1071, 651);
            this.cmdClose.Name = "cmdClose";
            this.cmdClose.Size = new System.Drawing.Size(50, 25);
            this.cmdClose.TabIndex = 9;
            this.cmdClose.Text = "Close";
            this.cmdClose.UseVisualStyleBackColor = true;
            this.cmdClose.Click += new System.EventHandler(this.CmdClose_Click);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Location = new System.Drawing.Point(12, 16);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1135, 708);
            this.TabControl.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage1.Controls.Add(this.GBSendTo);
            this.tabPage1.Controls.Add(this.gbTableSel);
            this.tabPage1.Controls.Add(this.CmdSave);
            this.tabPage1.Controls.Add(this.gbSubject);
            this.tabPage1.Controls.Add(this.cmdClose);
            this.tabPage1.Controls.Add(this.gbMessage);
            this.tabPage1.Controls.Add(this.gbFieldSelection);
            this.tabPage1.Controls.Add(this.gbEmailFooter);
            this.tabPage1.Controls.Add(this.gbFieldsToUpdate);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1127, 682);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Builder";
            // 
            // GBSendTo
            // 
            this.GBSendTo.Controls.Add(this.BoxSpecificAddress);
            this.GBSendTo.Controls.Add(this.BoxType);
            this.GBSendTo.Controls.Add(this.BoxFieldForEmail);
            this.GBSendTo.Location = new System.Drawing.Point(398, 565);
            this.GBSendTo.Name = "GBSendTo";
            this.GBSendTo.Size = new System.Drawing.Size(338, 110);
            this.GBSendTo.TabIndex = 18;
            this.GBSendTo.TabStop = false;
            this.GBSendTo.Text = "Send To";
            // 
            // BoxSpecificAddress
            // 
            this.BoxSpecificAddress.Location = new System.Drawing.Point(130, 46);
            this.BoxSpecificAddress.Name = "BoxSpecificAddress";
            this.BoxSpecificAddress.Size = new System.Drawing.Size(202, 58);
            this.BoxSpecificAddress.TabIndex = 19;
            this.BoxSpecificAddress.Text = "";
            // 
            // BoxType
            // 
            this.BoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BoxType.Location = new System.Drawing.Point(6, 19);
            this.BoxType.Name = "BoxType";
            this.BoxType.Size = new System.Drawing.Size(326, 21);
            this.BoxType.TabIndex = 18;
            // 
            // BoxFieldForEmail
            // 
            this.BoxFieldForEmail.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BoxFieldForEmail.FormattingEnabled = true;
            this.BoxFieldForEmail.Location = new System.Drawing.Point(6, 46);
            this.BoxFieldForEmail.Name = "BoxFieldForEmail";
            this.BoxFieldForEmail.Size = new System.Drawing.Size(118, 21);
            this.BoxFieldForEmail.TabIndex = 16;
            this.BoxFieldForEmail.Tag = "";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.QueryResult);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1127, 682);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Query Result";
            // 
            // FrmReminderSqlBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 736);
            this.Controls.Add(this.TabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1175, 775);
            this.MinimumSize = new System.Drawing.Size(1175, 775);
            this.Name = "FrmReminderSqlBuilder";
            this.Text = "Builder";
            this.gbTableSel.ResumeLayout(false);
            this.gbSubject.ResumeLayout(false);
            this.gbSubject.PerformLayout();
            this.gbMessage.ResumeLayout(false);
            this.gbMessage.PerformLayout();
            this.gbFieldSelection.ResumeLayout(false);
            this.gbFieldSelection.PerformLayout();
            this.gbFieldsToUpdate.ResumeLayout(false);
            this.gbFieldsToUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QueryResult)).EndInit();
            this.gbEmailFooter.ResumeLayout(false);
            this.gbEmailFooter.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.GBSendTo.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private void InitializeLists()
        {
            SubjectA = new System.Collections.Generic.List<System.Windows.Forms.Control>
            {
                Subject1A,
                Subject2A,
                Subject3A,
                Subject4A,
                Subject5A,
                Subject6A,
                Subject7A,
                Subject8A
            };

            SubjectB = new System.Collections.Generic.List<System.Windows.Forms.Control>
            {
                Subject1B,
                Subject2B,
                Subject3B,
                Subject4B,
                Subject5B,
                Subject6B,
                Subject7B,
                Subject8B
            };

            MessageA = new System.Collections.Generic.List<System.Windows.Forms.Control>
            {
                Message1A,
                Message2A,
                Message3A,
                Message4A,
                Message5A,
                Message6A,
                Message7A,
                Message8A
            };

            MessageB = new System.Collections.Generic.List<System.Windows.Forms.Control>
            {
                Message1B,
                Message2B,
                Message3B,
                Message4B,
                Message5B,
                Message6B,
                Message7B,
                Message8B
            };

            UpdateFields = new System.Collections.Generic.List<System.Windows.Forms.Control>
            {
                UpdateField1,
                UpdateField2,
                UpdateField3,
                UpdateField4,
                UpdateField5
            };

            UpdateFieldsTo = new System.Collections.Generic.List<System.Windows.Forms.Control>
            {
                UpdateTo1,
                UpdateTo2,
                UpdateTo3,
                UpdateTo4,
                UpdateTo5
            };
        }

        private System.Windows.Forms.GroupBox gbTableSel;
        private System.Windows.Forms.Button CmdAddTable;
        private System.Windows.Forms.ComboBox BoxAvailableTables;
        private System.Windows.Forms.Button CmdRemove;
        private System.Windows.Forms.ListBox BoxTablesUsed;
        private System.Windows.Forms.GroupBox gbSubject;
        private System.Windows.Forms.ComboBox Subject8B;
        private System.Windows.Forms.ComboBox Subject7B;
        private System.Windows.Forms.ComboBox Subject6B;
        private System.Windows.Forms.ComboBox Subject5B;
        private System.Windows.Forms.ComboBox Subject4B;
        private System.Windows.Forms.ComboBox Subject3B;
        private System.Windows.Forms.ComboBox Subject2B;
        private System.Windows.Forms.ComboBox Subject1B;
        private System.Windows.Forms.TextBox Subject8A;
        private System.Windows.Forms.TextBox Subject7A;
        private System.Windows.Forms.TextBox Subject6A;
        private System.Windows.Forms.TextBox Subject5A;
        private System.Windows.Forms.TextBox Subject4A;
        private System.Windows.Forms.TextBox Subject3A;
        private System.Windows.Forms.TextBox Subject2A;
        private System.Windows.Forms.TextBox Subject1A;
        private System.Windows.Forms.GroupBox gbMessage;
        private System.Windows.Forms.ComboBox Message8B;
        private System.Windows.Forms.ComboBox Message7B;
        private System.Windows.Forms.ComboBox Message6B;
        private System.Windows.Forms.ComboBox Message5B;
        private System.Windows.Forms.ComboBox Message4B;
        private System.Windows.Forms.ComboBox Message3B;
        private System.Windows.Forms.ComboBox Message2B;
        private System.Windows.Forms.ComboBox Message1B;
        private System.Windows.Forms.TextBox Message8A;
        private System.Windows.Forms.TextBox Message7A;
        private System.Windows.Forms.TextBox Message6A;
        private System.Windows.Forms.TextBox Message5A;
        private System.Windows.Forms.TextBox Message4A;
        private System.Windows.Forms.TextBox Message3A;
        private System.Windows.Forms.TextBox Message2A;
        private System.Windows.Forms.TextBox Message1A;
        private System.Windows.Forms.GroupBox gbFieldSelection;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.Label LblFieldsUsed;
        private System.Windows.Forms.Label lblSelectedStatements;
        private System.Windows.Forms.RichTextBox BoxCondition;
        private System.Windows.Forms.RichTextBox BoxSelectionCriteria;
        private System.Windows.Forms.ListBox BoxFieldsUsed;
        private System.Windows.Forms.ListBox AvailableSelection;
        private System.Windows.Forms.GroupBox gbFieldsToUpdate;
        private System.Windows.Forms.GroupBox gbEmailFooter;
        private System.Windows.Forms.Button CmdSave;
        private System.Windows.Forms.Button cmdClose;
        private System.Windows.Forms.ComboBox UpdateField5;
        private System.Windows.Forms.ComboBox UpdateField4;
        private System.Windows.Forms.ComboBox UpdateField3;
        private System.Windows.Forms.ComboBox UpdateField2;
        private System.Windows.Forms.ComboBox UpdateField1;
        private System.Windows.Forms.TextBox UpdateTo5;
        private System.Windows.Forms.TextBox UpdateTo4;
        private System.Windows.Forms.TextBox UpdateTo3;
        private System.Windows.Forms.TextBox UpdateTo2;
        private System.Windows.Forms.TextBox UpdateTo1;
        private System.Windows.Forms.RichTextBox EmailMessageFooter;
        private System.Windows.Forms.CheckBox AppendEmailFooter;
        private System.Windows.Forms.RichTextBox BoxTableRelations;
        private System.Windows.Forms.Button AddField;
        private System.Windows.Forms.Button RemoveField;
        private System.Windows.Forms.Button ShowHideResults;
        private System.Windows.Forms.DataGridView QueryResult;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;

        //Subject Lists
        private System.Collections.Generic.List<System.Windows.Forms.Control> SubjectA;
        private System.Collections.Generic.List<System.Windows.Forms.Control> SubjectB;
        //Message Lists
        private System.Collections.Generic.List<System.Windows.Forms.Control> MessageA;
        private System.Collections.Generic.List<System.Windows.Forms.Control> MessageB;
        //Fields used Lists
        private System.Collections.Generic.List<System.Windows.Forms.Control> UpdateFields;
        private System.Collections.Generic.List<System.Windows.Forms.Control> UpdateFieldsTo;
        private System.Windows.Forms.ComboBox BoxFieldForEmail;
        private System.Windows.Forms.GroupBox GBSendTo;
        private System.Windows.Forms.RichTextBox BoxSpecificAddress;
        private System.Windows.Forms.ComboBox BoxType;
    }
}