using SQLReminders.Data.Controllers;
using System;

using System.Windows.Forms;

namespace SQLReminders.Desktop.Forms
{
    public partial class FrmAuditTrail : Form
    {
        private AuditTrailController TrailController;

        public FrmAuditTrail(AuditTrailController trailController)
        {
            InitializeComponent();
            TrailController = trailController;
        }

        private void AuditTrail_Load(object sender, EventArgs e)
        {
            AuditTrailList.DataSource = TrailController.Audit;
            FormatGrid();
        }

        private void FormatGrid()
        {
            DataGridViewColumn column;
            
            column = AuditTrailList.Columns[0];
            column.Name = "id";

            column = AuditTrailList.Columns[1];
            column.Name = "Type";

            column = AuditTrailList.Columns[2];
            column.Name = "Date Created";

            column = AuditTrailList.Columns[3];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column.MinimumWidth = 100;
            column.Name = "Information";

        }

        private void CmdFilter_Click(object sender, EventArgs e)
        {
            AuditTrailList.DataSource = TrailController.FilterAudit(FromDate.Value, ToDate.Value, txtType.Text);
        }

        private void CmdRefresh_Click(object sender, EventArgs e)
        {
            TrailController.RefreshTrail();
            AuditTrailList.Refresh();
        }
    }
}
