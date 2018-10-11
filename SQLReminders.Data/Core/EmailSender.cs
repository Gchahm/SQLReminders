using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using SQLReminders.Data.Helpers;
using SQLReminders.Data.Models;

namespace SQLReminders.Data.Core
{
    public class EmailSender
    {
        private Table<Email> _Emails;

        public EmailSender()
        {
            _Emails = Models.Ereminders.Instance.GetTable<Email>();
        }

        public void SendEmails()
        {
            foreach (Email email in DueEmails)
                SendEmail(email);
        }


        //Properties
        private Table<Email> Emails { get => _Emails; }
        private List<Email> DueEmails {
            get
            {
                IQueryable<Email> dueEmailsToSend =
                from item in _Emails
                where item.Sent == 0
                select item;
                return dueEmailsToSend.ToList();
            }
        }
        
        private void SendEmail(Email email)
        {
            try
            {
                EmailManager.Instance.SendMailAsync(email.SendTo, email.Subject, email.Message);
                email.Sent = 1;
                AuditLogger.Instance.LogInfo($"Sending email ID: {email.EmailID}.", "EMAIL");
            }
            catch (Exception e)
            {
                email.Sent = 400;
                AuditLogger.Instance.LogInfo($"Couldn't send email ID: {email.EmailID}. Error message: {e.Message}", "ERROR");
            }
            finally
            {
                email.SentOn = DateTime.Today.Date;
                Models.Ereminders.Instance.SubmitChanges();
            }
        }
    }
}
