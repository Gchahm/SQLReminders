using System;
using System.Windows.Forms;
using SQLReminders.Data;

namespace SQLReminders.Desktop.Forms
{
    public partial class FrmMain : AbstractFrame
    {

        private DateTime _DateOpened;
        App _App;
        private int _counter;

        public FrmMain(App app)
        {
            _App = app;
            InitializeComponent();
            _DateOpened = DateTime.Now;
            InitSystem();
        }

        private bool SetMenus(bool enabled)
        {
            CmdOpenAuditTrail.Enabled = enabled;
            CmdOpenLookup.Enabled = enabled;
            CmdOpenSchedule.Enabled = enabled;
            Audit.Visible = enabled;
            return enabled;
        }

        private void InitSystem()
        {
            _counter = TimerControl.Interval/1000;
            Text = $"{Text}: {_App.Config.CompanyName}";
            BuildAudit();
            FormatGrid();
            lblStatus.Text = (_App.Active) ? "Status: Active" : "Status: Inactive";
            lblLicence.Text = (_App.Licenced) ? "Licence: OK" : "Licence: Unlicenced";

        }

        private void BuildAudit() => Audit.DataSource = _App.AuditTrailController.GetAuditFrom(_DateOpened);

        private void FormatGrid()
        {

            DataGridViewColumn column;

            column = Audit.Columns[0];
            column.Visible = false;

            column = Audit.Columns[1];
            column.Width = 150;
            column.HeaderText = "Type";

            column = Audit.Columns[2];
            column.HeaderText = "Date";

            column = Audit.Columns[3];
            column.HeaderText = "Information";
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            for (int i = 4; i < Audit.ColumnCount; i++)
            {
                column = Audit.Columns[i];
                column.Visible = false;
            }

            DateTime currentDate = DateTime.Today.Date;

        }

        private void CmdOpenAuditTrail_Click(object sender, EventArgs e)
        {
            OpenFrame(new FrmAuditTrail(_App.AuditTrailController));
        }

        private void CmdOpenReminder_Click(object sender, EventArgs e)
        {
            OpenFrame(new FrmRemindersSchedule(_App.ReminderController));
        }

        private void CmdOpenSystemPreferences_Click(object sender, EventArgs e)
        {
            OpenFrame(new FrmSystemPreferences(_App));
        }

        private void CmdOpenLookups_Click(object sender, EventArgs e)
        {
            OpenFrame(new FrmLookups(_App.LookupController));
        }

        private void TimerControl_Tick(object sender, EventArgs e)
        {
            Tick();
        }

        private void Tick()
        {
            _App.Tick();
            lblStatus.Text = (_App.Active) ? "Status: Active" : "Status: Inactive";
            lblLicence.Text = (_App.Licenced) ? "Licence: OK" : "Licence: Unlicenced";
            BuildAudit();
        }

        private void LabelTimer_Tick(object sender, EventArgs e)
        {
            TimeNow.Text = DateTime.Now.ToString("HH:mm:ss");
            NextTick.Text = $"Next tick: {Counter}";
        }

        private int Counter
        {
            get => (_counter < 1) ? _counter = TimerControl.Interval / 1000 : _counter-- ;
        }

        private void ImportExportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFrame(new FrmInExport(_App.CSVController));
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            TopMost = true;//show form in top
            Application.DoEvents();//execute all events in message queue
            TopMost = false;//make default window behavior
            Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFrame(new FrmHelp());
        }

        private void CmdTickNow_Click(object sender, EventArgs e)
        {
            Tick();
        }
    }
}
