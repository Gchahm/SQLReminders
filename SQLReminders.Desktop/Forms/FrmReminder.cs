using System;
using System.Windows.Forms;
using SQLReminders.Data.Models;
using System.Collections.Generic;
using SQLReminders.Data.Helpers;

namespace SQLReminders.Desktop.Forms
{
    public partial class FrmReminder : Form
    {

        FrmReminderSqlBuilder sqlBuilder;
        Reminder reminder;

        public FrmReminder(Reminder reminder)
        {
            this.reminder = reminder;
            
            InitializeComponent();
            SetUpFields();
        }

        private void xbRunOnce_CheckedChanged(object sender, EventArgs e)
        {
            Repeated.Checked = !RunOnce.Checked;
        }

        private void XbRepeated_CheckedChanged(object sender, EventArgs e)
        {
            RunOnce.Checked = !Repeated.Checked;
        }

        private void CmdSQLBuilder_Click(object sender, EventArgs e)
        {
            
            if (sqlBuilder == null || sqlBuilder.IsDisposed)
            {
                sqlBuilder = new FrmReminderSqlBuilder(reminder);
                sqlBuilder.Show();
            }
            sqlBuilder.Show();
            sqlBuilder.BringToFront();
        }

        private void SetUpFields()
        {
            //update the fields with the values from the reminder
            ReminderName.Text = reminder.ReminderName;
            Description.Text = reminder.Description;
            CreatedBy.Text = reminder.CreatedBy;
            DateCreated.Value = reminder.DateCreated;
            RunOnce.Checked = !reminder.Repeated;
            Repeated.Checked = reminder.Repeated;
            ActiveReminder.Checked = reminder.Active;
            RunFrequency.Value = Convert.ToInt32(reminder.RunFrequency);
            NextRunDate.Value = reminder.NextRunDate;
            RepeatedRunTime.Value = reminder.NextRunDate;
        }



        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            CommitChanges();
        }

        private void CommitChanges()
        {
            //updates all fields in the reminder object
            reminder.ReminderName = ReminderName.Text;
            reminder.Description = Description.Text;
            reminder.CreatedBy = CreatedBy.Text;
            reminder.Repeated = Repeated.Checked;
            reminder.Active = ActiveReminder.Checked;
            reminder.RunFrequency = Convert.ToInt32(RunFrequency.Value);
            reminder.NextRunDate = NextRunDate.Value.Date + RepeatedRunTime.Value.TimeOfDay;
            
            Data.Models.Ereminders.Instance.SubmitChanges();

        }

    }
}
