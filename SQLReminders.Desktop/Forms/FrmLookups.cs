using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SQLReminders.Data.Models;
using SQLReminders.Data.Controllers;

namespace SQLReminders.Desktop.Forms
{

    public partial class FrmLookups : AbstractFrame
    {

        private LookupController LookupController;

        public FrmLookups(LookupController lookupController)
        {
            LookupController = lookupController;
            InitializeComponent();
            BuildList();
        }

        private void BuildList()
        {
            GridList.DataSource = LookupController.ReminderLookups;
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            LookupController.DeleteReminder(GetModelID(GridList));
            RefreshList();
        }

        private void CmdAdd_Click(object sender, EventArgs e)
        {
            Lookup reminderLookup = LookupController.NewLookup();
            RefreshList();
            OpenFrame(new FrmLookup(reminderLookup));
        }

        private void CmdEdit_Click(object sender, EventArgs e) => OpenLookupFrame();
        private void DgvLookups_CellDoubleClick(object sender, DataGridViewCellEventArgs e) => OpenLookupFrame();
        private void OpenLookupFrame()
        {
            try
            {
                OpenFrame(new FrmLookup(LookupController.GetLookup(GetModelID(GridList))));
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            RefreshList();

        }

        protected override void RefreshList() => BuildList();
        private void CmdClose_Click(object sender, EventArgs e) => Dispose();
    }
}
