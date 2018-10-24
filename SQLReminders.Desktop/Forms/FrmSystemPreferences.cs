using SQLReminders.Data;
using SQLReminders.Data.Controllers;
using SQLReminders.Data.Helpers;
using System;
using System.Windows.Forms;

namespace SQLReminders.Desktop.Forms
{
    public partial class FrmSystemPreferences : AbstractFrame
    {
        App App;
        ConfigureController Configure;

        public FrmSystemPreferences(App app)
        {
            App = app;
            Configure = app.Config;
            InitializeComponent();
            LoadGeneralSettings();
            LoadSMTPSettings();
            LoadSQLSettings();
        }
        /**
        General Tab
        **/
        private void LoadGeneralSettings()
        {
            TxtCompanyName.Text = Configure.CompanyName;

            BoxActive.Checked = Configure.IsActive;
            BoxLicence.Text = Configure.Licence;
        }


        private void CmdSave_Click(object sender, EventArgs e)
        {
            Configure.CompanyName = TxtCompanyName.Text;
            Configure.Save();
        }

        private void BoxActive_CheckedChanged(object sender, EventArgs e)
        {

            if (BoxActive.Checked)
            {
                if (!Configure.IsLicenced)
                {
                    BoxActive.Checked = false;
                    MessageBox.Show("Incorrect Licence");
                }
                else if (!SqlManager.Instance.IsReady())
                {
                    BoxActive.Checked = false;
                    MessageBox.Show(SqlManager.Instance.Status);
                }
                else if (!SqlManager.Instance.IsTablesBuilt())
                {
                    BoxActive.Checked = false;
                    MessageBox.Show("It seems not all tables are set up go in SQL tab and build the tables.");
                }
                else
                    Configure.IsActive = BoxActive.Checked;
            }
            else
                Configure.IsActive = BoxActive.Checked;


        }
        //
        //SMTP Tab
        //
        private void LoadSMTPSettings()
        {
            BoxAuthenticaton.Checked = true;
            BoxSecureConnection.Checked = true;
            TxtSmtpPort.Value =Configure.SmptPort;
            TxtSmtpServer.Text = Configure.SmtpHost;
            TxtSmtpUser.Text = Configure.SmtpUser;
            TxtSmtpPass.Text = Configure.SmtpPass;
            BoxAuthenticaton.Checked = Configure.SmptUseAuthentication;
            BoxSecureConnection.Checked = Configure.SmtpUseSecureConnection;
            if (BoxSecureConnection.Checked)
                SetConnectionType();
        }


        private void SetConnectionType()
        {
            switch (Configure.SmtpSslMode)
            {
                case "SSL":
                    BoxSSL.Checked = true;
                    break;
                case "TLS":
                    BoxTls.Checked = true;
                    break;
                default:
                    BoxAuto.Checked = true;
                    break;
            }
        }

        private void CmdTestEmail_Click(object sender, EventArgs e)
        {
            var status = EmailManager.Instance.SendMail(txtAddress.Text, txtSubject.Text, txtBody.Text);
            MessageBox.Show(status);
        }

        private void CmdSaveSMTP_Click(object sender, EventArgs e)
        {
            int port = Convert.ToInt32(TxtSmtpPort.Value);
            Configure.SmtpHost = TxtSmtpServer.Text;
            Configure.SmptPort = Convert.ToInt32(TxtSmtpPort.Value);
            Configure.SmtpUser = TxtSmtpUser.Text;
            Configure.SmtpPass = TxtSmtpPass.Text;
            Configure.SmtpUseSecureConnection = BoxSecureConnection.Checked;
            Configure.SmptUseAuthentication = BoxAuthenticaton.Checked;
            Configure.SmtpSslMode =  GetSslMode();
            Configure.Save();
            EmailManager.Instance.PrepareSMTP();
        }

        private string GetSslMode()
        {
            if (BoxSSL.Checked)
                return "SSL";
            if (BoxTls.Checked)
                return "TLS";
            if (BoxAuto.Checked)
                return "AUTO";
            return "NONE";
        }

        //
        //SQL Tab
        //
        private void LoadSQLSettings()
        {
            TextSqlServer.Text = SqlManager.Instance.ServerName;
            TxtDatabase.Text = SqlManager.Instance.Database;
            TxtUsername.Text = SqlManager.Instance.Username;
            TxtPassword.Text = SqlManager.Instance.Password;
        }

        private void CmdSaveSQL_Click(object sender, EventArgs e)
        {
            SqlManager.Instance.SaveSettings(TextSqlServer.Text, TxtDatabase.Text, TxtUsername.Text, TxtPassword.Text);
        }


        private void CmdTest_Click(object sender, EventArgs e)
        {
            SqlManager.Instance.TestConnection(TextSqlServer.Text, TxtDatabase.Text, TxtUsername.Text, TxtPassword.Text);
            lblStatus.Text = SqlManager.Instance.Status;
        }

        private void CmdApply_Click(object sender, EventArgs e)
        {
            if (Configure.CheckLicence(BoxLicence.Text))
                Configure.Licence = BoxLicence.Text;
            else
                MessageBox.Show("Incorrect Licence Value");
        }

        private void CmdCreateTables_Click(object sender, EventArgs e)
        {
            OpenFrame(new FrmCreateTables(Configure.TableBuilder));
        }

        private void SystemPreferences_Load(object sender, EventArgs e)
        {
            TopMost = true;//show form in top
            Application.DoEvents();//execute all events in message queue
            TopMost = false;//make default window behavior
            Show();
        }

        private void BoxAuthenticaton_CheckedChanged(object sender, EventArgs e)
        {
            TxtSmtpUser.Enabled = TxtSmtpPass.Enabled = BoxAuthenticaton.Checked;
        }

        private void BoxSecureConnection_CheckedChanged(object sender, EventArgs e)
        {
            BoxSSL.Enabled = BoxTls.Enabled = BoxAuto.Enabled = BoxSecureConnection.Checked;

        }
    }
}
