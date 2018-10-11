using SQLReminders.Data.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLReminders.Desktop.Forms
{
    public partial class FrmInExport : AbstractFrame
    {
        private CSVController _CSVController;
        public CSVController CSVController { get => _CSVController; set => _CSVController = value; }

        public FrmInExport(CSVController cSVController)
        {
            CSVController = cSVController;
            InitializeComponent();
            DgvReminders.DataSource = CSVController.ReminderController.Reminders;
            FormatGrid();
        }

        private void FormatGrid()
        {
            DataGridViewColumn column;

            column = DgvReminders.Columns[0];
            column.Width = 60;
            column.Name = "ID";

            column = DgvReminders.Columns[1];
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            column.Name = "Reminder Name";

            for (int i = 2; i < DgvReminders.ColumnCount; i++)
            {
                column = DgvReminders.Columns[i];
                column.Visible = false;
            }

            DataGridViewCheckBoxColumn dgvCmb = new DataGridViewCheckBoxColumn
            {
                ValueType = typeof(bool),
                Name = "export",
                HeaderText = "Export"
            };
            dgvCmb.DefaultCellStyle.NullValue = false;
            DgvReminders.Columns.Add(dgvCmb);
        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void CmdSetExportPath_Click(object sender, EventArgs e)
        {
            try
            {
                CSVController.WriteToCSV(GetIDs(), FilePath());
                MessageBox.Show("Reminders exported successfully");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            }

        private string FilePath()
        {
            if (FileDialog.ShowDialog() == DialogResult.OK)
                return FileDialog.FileName;
            return string.Empty;
        }

        private List<int> GetIDs()
        {
            List<int> reminderIDs = new List<int>();
            foreach(DataGridViewRow row in DgvReminders.Rows)
            {
                if ((bool) row.Cells[0].FormattedValue)
                    reminderIDs.Add((int)row.Cells[1].Value);
            }
            return reminderIDs;
        }

        private void CmdImport_Click(object sender, EventArgs e)
        {
            try
            {
                CSVController.ReadCSV(FilePath());
                MessageBox.Show("Reminders imported Successfully");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
