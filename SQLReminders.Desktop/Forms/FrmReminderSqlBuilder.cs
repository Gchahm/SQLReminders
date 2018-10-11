using System;
using System.Windows.Forms;
using SQLReminders.Data.Models;
using SQLReminders.Data.Helpers;
using System.ComponentModel;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.Linq;

namespace SQLReminders.Desktop.Forms
{
    public partial class FrmReminderSqlBuilder : Form
    {
        private Reminder Reminder;

        private List<string> EmailSubjectAs
        {
            get
            {
                List<string> values = new List<string>();
                foreach (Control box in SubjectA)
                    values.Add(box.Text);
                return values;
            }
            set
            {
                for (int i = 0; i < value.Count; i++)
                    SubjectA[i].Text = value[i];
            }
        }
        private List<string> EmailSubjectBs
        {
            get
            {
                List<string> values = new List<string>();
                foreach (Control box in SubjectB)
                    values.Add(box.Text);
                return values;
            }
            set
            {
                for (int i = 0; i < value.Count; i++)
                    SubjectB[i].Text = value[i];
            }
        }
        private List<string> EmailMessageAs
        {
            get
            {
                List<string> values = new List<string>();
                foreach (Control box in MessageA)
                    values.Add(box.Text);
                return values;
            }
            set
            {
                for (int i = 0; i < value.Count; i++)
                    MessageA[i].Text = value[i];
            }
        }
        private List<string> EmailMessageBs
        {
            get
            {
                List<string> values = new List<string>();
                foreach (Control box in MessageB)
                    values.Add(box.Text);
                return values;
            }
            set
            {
                for (int i = 0; i < value.Count; i++)
                    MessageB[i].Text = value[i];
            }
        }
        private List<string> FieldsToUpdateValues
        {
            get
            {
                List<string> values = new List<string>();
                foreach (Control box in UpdateFields)
                    values.Add(box.Text);
                return values;
            }
            set
            {
                for (int i = 0; i < value.Count; i++)
                    UpdateFields[i].Text = value[i];
            }
        }
        private List<string> UpdateFieldsToValues
        {
            get
            {
                List<string> values = new List<string>();
                foreach (Control box in UpdateFieldsTo)
                    values.Add(box.Text);
                return values;
            }
            set
            {
                for (int i = 0; i < value.Count; i++)
                    UpdateFieldsTo[i].Text = value[i];
            }
        }

        private string SelectedTable { get => BoxTablesUsed.SelectedItem.ToString(); }


        public FrmReminderSqlBuilder(Reminder reminder)
        {

            Reminder = reminder;
            InitializeComponent();
            InitializeLists();
            SetUpFields();

        }

        private void SetUpFields()
        {

            BoxAvailableTables.DataSource = SqlManager.Instance.GetAllTables();
            BoxTablesUsed.DataSource = Reminder.TablesUsed;

            GenerateCBsDataSource();

            FieldsToUpdateValues = Reminder.FieldsToUpdate;
            UpdateFieldsToValues = Reminder.UpdateFieldsTo;
            EmailSubjectAs = Reminder.EmailSubjectA;
            EmailSubjectBs = Reminder.EmailSubjectB;
            EmailMessageAs = Reminder.EmailMessageA;
            EmailMessageBs = Reminder.EmailMessageB;

            BoxSelectionCriteria.Text = Reminder.SelectionCriteria;
            BoxCondition.Text = Reminder.SQLConditions;

            BoxType.DataSource = TypeSource();
            BoxType.SelectedIndex = Reminder.RemType;
            BoxFieldForEmail.Text = Reminder.FieldForEmail;
            BoxSpecificAddress.Text = Reminder.SpecificAddress;

            AppendEmailFooter.Checked = Reminder.AppendEmailFooter;
            EmailMessageFooter.Text = Reminder.EmailMessageFooter;

        }

        private void GenerateCBsDataSource()
        {
            BindDataSource(UpdateFields, Reminder.FieldsUsed, "Field");
            BindDataSource(SubjectB, Reminder.FieldsUsed, "FieldName");
            BindDataSource(MessageB, Reminder.FieldsUsed, "FieldName");

            BoxFieldsUsed.BindingContext = new BindingContext();
            BoxFieldsUsed.DataSource = Reminder.FieldsUsed;
            BoxFieldsUsed.DisplayMember = "Field";
            BoxFieldsUsed.ValueMember = "Field";

            BoxFieldForEmail.BindingContext = new BindingContext();
            BoxFieldForEmail.DataSource = Reminder.FieldsUsed;
            BoxFieldForEmail.DisplayMember = "FieldName";
            BoxFieldForEmail.ValueMember = "FieldName";
        }

        private List<string> TypeSource()
        {
            var values = Enum.GetValues(typeof(ReminderType));
            List<string> sendSource = new List<string>();
            foreach (ReminderType remType in values)
                sendSource.Add(remType.GetDescription());
            return sendSource;
        }

        private void UpdateQueryView()
        {
            try
            {
                QueryResult.DataSource = ReminderResults;
                TabControl.SelectedIndex = 1;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public DataTable ReminderResults
        {
            get
            {
                DataTable dt = null;
                try
                {
                    dt = SqlManager.Instance.RunQuery(Reminder.SelectionCriteria);
                }
                catch (SqlException e)
                {
                    SqlManager.Instance.Close();
                    throw new Exception(e.Message);
                }
                catch (Exception e)
                {
                    SqlManager.Instance.Close();
                    throw new Exception(e.Message);
                }
                return dt;
            }
        }

        private void BindDataSource(List<Control> comboBoxes, BindingList<SqlField> dataSource,string display)
        {
            foreach (ComboBox comboBox in comboBoxes)
            {
                comboBox.BindingContext = new BindingContext();
                comboBox.DataSource = dataSource;
                comboBox.DisplayMember = display;
                comboBox.ValueMember = display;
            }
        }

        private void CommitChanges()
        {
            
            Reminder.AppendEmailFooter = AppendEmailFooter.Checked;
            Reminder.EmailMessageFooter = EmailMessageFooter.Text;
            Reminder.EmailSubjectA = EmailSubjectAs;
            Reminder.EmailSubjectB = EmailSubjectBs;
            Reminder.EmailMessageA = EmailMessageAs;
            Reminder.EmailMessageB = EmailMessageBs;
            Reminder.FieldsToUpdate = FieldsToUpdateValues;
            Reminder.UpdateFieldsTo = UpdateFieldsToValues;
            Reminder.Save();
            Reminder.RemType = BoxType.SelectedIndex;
            Reminder.FieldForEmail = BoxFieldForEmail.Text;
            Reminder.SpecificAddress = BoxSpecificAddress.Text;

            Data.Models.Ereminders.Instance.SubmitChanges();
        }

        private void GenerateSQLCriteria()
        {
            Reminder.SQLConditions = BoxCondition.Text;
            BoxSelectionCriteria.Text = Reminder.SelectionCriteria;
        }

        private void AddToFieldsUsed()
        {
            if (AvailableSelection.SelectedItems.Count > 0)
            {
                DataRowView drv = (DataRowView)AvailableSelection.SelectedItem;
                string table = BoxTablesUsed.SelectedValue.ToString();
                string field = drv["name"].ToString();
                Reminder.AddField(table, field);
                GenerateSQLCriteria();
            }
        }

        private void RemoveFromFieldsUsed()
        {
            if (AvailableSelection.SelectedItems.Count > 0)
            {
                var drv = (SqlField)BoxFieldsUsed.SelectedItem;
                Reminder.RemoveField(drv);
                GenerateSQLCriteria();
            }

        }

        //LISTENERS
        private void CmdAddTable_Click(object sender, EventArgs e)
        {
            Reminder.AddTable(BoxAvailableTables.Text);
            GenerateSQLCriteria();
        }
        
        private void CmdRemove_Click(object sender, EventArgs e)
        {
            Reminder.RemoveTable(BoxTablesUsed.SelectedIndex);
            GenerateSQLCriteria();
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            CommitChanges();
        }

        private void CmdSaveAndClose_Click(object sender, EventArgs e)
        {
            CommitChanges();
            this.Dispose();
        }

        private void CmdClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        private void TablesUsed_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                FillAvailableFields(AvailableSelection, BoxTablesUsed.SelectedItem.ToString());
                BoxTableRelations.Text = Reminder.TableRelations[BoxTablesUsed.SelectedIndex];
            }
            catch (NullReferenceException)
            {

            }

        }

        private void FillAvailableFields(ListBox listBox, string tableName)
        {
            listBox.DataSource = SqlManager.Instance.GetTableFields(tableName);
            listBox.DisplayMember = "name";
        }

        private void AvailableSelection_DoubleClick(object sender, EventArgs e)
        {
            AddToFieldsUsed();
        }

        private void AddField_Click(object sender, EventArgs e)
        {
            AddToFieldsUsed();
        }

        private void RemoveField_Click(object sender, EventArgs e)
        {
            RemoveFromFieldsUsed();
        }

        private void SQLConditions_KeyUp(object sender, KeyEventArgs e)
        {
            GenerateSQLCriteria();
        }

        private void TableRelation_KeyUp(object sender, KeyEventArgs e)
        {
            if (BoxTablesUsed.SelectedItems.Count > 0)
            {
                Reminder.TableRelations[BoxTablesUsed.SelectedIndex] = BoxTableRelations.Text;
                GenerateSQLCriteria();
            }

        }

        private void ShowHideResults_Click(object sender, EventArgs e)
        {
            UpdateQueryView();
        }
    }
}
