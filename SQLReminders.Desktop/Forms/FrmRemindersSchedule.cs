using System;
using System.Windows.Forms;
using SQLReminders.Data.Controllers;
using SQLReminders.Data.Models;

namespace SQLReminders.Desktop.Forms
{
    public partial class FrmRemindersSchedule : AbstractFrame
    {
        ReminderController ReminderController;

        public FrmRemindersSchedule(ReminderController reminderController)
        {
            ReminderController = reminderController;
            InitializeComponent();
        }

        private void FrmRemindersSchedule_Load(object sender, EventArgs e)
        {
            BuildList();
            FormatGrid();
        }

        private void FormatGrid()
        {
            DataGridViewColumn column;

            column = DgvReminderList.Columns[0];
            column.Width = 60;
            column.HeaderText = "ID";

            column = DgvReminderList.Columns[1];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column.HeaderText = "Reminder Name";

            column = DgvReminderList.Columns[2];
            column.HeaderText = "Next Run Date";
            column.Width = 120;

            for (int i = 3; i < DgvReminderList.ColumnCount; i++)
                DgvReminderList.Columns[i].Visible = false;
        }

        private void BuildList()
        {
            if (xbShowActive.Checked)
                DgvReminderList.DataSource = ReminderController.ActiveReminders;
            else
                DgvReminderList.DataSource = ReminderController.InactiveReminders;
        }

        private void XbShowActive_CheckedChanged(object sender, EventArgs e)
        {
            if (xbShowActive.Checked)
                xbShowActive.Text = "Active Reminders";
            else
                xbShowActive.Text = "Inactive Reminders";
            BuildList();
        }

        private Reminder GetSelectedReminder()
        {
            return ReminderController.GetReminder(GetModelID(DgvReminderList));
        }

        //Command Add
        private void CmdAdd_Click(object sender, EventArgs e)
        {
            Reminder reminder = ReminderController.NewReminder();
            RefreshList();
            OpenFrame(new FrmReminder(reminder));
        }

        //Command Edit
        private void CmdEdit_Click(object sender, EventArgs e)
        {
            OpenReminder();
        }

        private void DgvReminderList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenReminder();
        }

        private void OpenReminder()
        {
            try
            {
                Reminder reminder = GetSelectedReminder();
                OpenFrame(new FrmReminder(reminder));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        //Command Copy
        private void CmdCopy_Click(object sender, EventArgs e)
        {
            ReminderController.CopyReminder(GetModelID(DgvReminderList));
            RefreshList();
        }

        //Command Delete
        private void CmdDelete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this reminder?",
                                     "Delete Reminder",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                ReminderController.DeleteReminder(GetModelID(DgvReminderList));
                BuildList();
            }

        }

        //Command Refresh
        private void CmdRefresh_Click(object sender, EventArgs e)
        {
            BuildList();
        }

        //Command Close
        private void CmdClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
