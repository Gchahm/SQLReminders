using System;
using AegisImplicitMail;
using System.ComponentModel;

namespace SQLReminders.Data.Helpers
{
    public sealed class EmailManager
    {
        private static EmailManager instance = new EmailManager();

        private MimeMailer mailer;
        private string status;

        private EmailManager()
        {
            mailer = new MimeMailer();
            //Set a delegate function for call back
            mailer.SendCompleted += CompEvent;
            PrepareSMTP();
        }
        
        public static EmailManager Instance
        {
            get
            {
                return instance;
            }
        }

        public void PrepareSMTP()
        {
             //Create Smtp Client
            mailer.Host = Properties.Settings.Default.smtpServer;
            mailer.Port = Properties.Settings.Default.smtpPort;
            if (Properties.Settings.Default.smtpUseAuthentication)
                SetAuthentication();

            mailer.SslType = GetSslMode();
            mailer.AuthenticationMode = AuthenticationType.Base64;
        }

        public string SendMail(string mail, string subject, string body)
        {
            //Generate Message 
            var mymessage = CreateMessage(mail, subject, body);
            mailer.SendMail(mymessage);           
            return status;
        }

        public void SendMailAsync(string mail, string subject, string body)
        {
            var mymessage = CreateMessage(mail, subject, body);
            mailer.SendMailAsync(mymessage);
        }

        private AbstractMailMessage CreateMessage(string mail, string subject, string body)
        {
            var mymessage = new MimeMailMessage();
            mymessage.From = new MimeMailAddress(Properties.Settings.Default.smtpUser);
            mymessage.To.Add(mail);
            mymessage.Subject = subject;
            mymessage.Body = body;
            return mymessage;
        }

        private void SetAuthentication()
        {
            mailer.User = Properties.Settings.Default.smtpUser;
            mailer.Password = Properties.Settings.Default.smtpPass;
        }

        private SslMode GetSslMode()
        {
            if (!Properties.Settings.Default.smtpUseSecureConnection)
                return SslMode.None;
            switch (Properties.Settings.Default.smtpSecureVersion)
            {
                case "SSL":
                    return SslMode.Ssl;
                case "TLS":
                    return SslMode.Tls;
                default:
                    return SslMode.Auto;
            }
        }

        //Call back function
        private void CompEvent(object sender, AsyncCompletedEventArgs e)
        {
            status = String.Empty;
            if (e.Cancelled)
                status += e.Cancelled;
            else
                status += "Email sent successfully";

            if (e.Error != null)
                status += "Error : " + e.Error.Message;
        }
    }
}
