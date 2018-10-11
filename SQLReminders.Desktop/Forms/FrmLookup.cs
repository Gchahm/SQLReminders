using SQLReminders.Data.Models;
using System;
using System.Windows.Forms;

namespace SQLReminders.Desktop.Forms
{
    public partial class FrmLookup : Form
    {
        private Lookup ReminderLookup;

        public FrmLookup(Lookup lookup)
        {
            ReminderLookup = lookup;
            InitializeComponent();
            LoadReminder();
        }

        private void LoadReminder()
        {
            Tablename.Text = ReminderLookup.Tablename;
            SetName.Text = ReminderLookup.SetName;
            Lookup.Text = ReminderLookup.LookupName;
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            ReminderLookup.Tablename = Tablename.Text;
            ReminderLookup.SetName = SetName.Text;
            ReminderLookup.LookupName = Lookup.Text;
            Data.Models.Ereminders.Instance.SubmitChanges();
        }

        private void CmdClose_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void SetName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
