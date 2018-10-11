using SQLReminders.Data.Helpers;
using SQLReminders.Data.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Data.Linq;

namespace SQLReminders.Data.Core
{
    public class EmailGenerator
    {

        Reminder reminder;
        private Table<Email> _Emails;
        UpdateManager UpdateManager;

        public EmailGenerator(UpdateManager updateManager)
        {
            _Emails = Models.Ereminders.Instance.GetTable<Email>();
            UpdateManager = updateManager;
        }

        public void ExtractEmails(List<Reminder> dueReminders)
        {
            foreach (Reminder reminder in dueReminders)
            {
                QueueEmails(reminder);
                UpdateManager.UpdateFields(reminder);
            }
        }

        private void QueueEmails(Reminder reminder)
        {
            try
            {
                this.reminder = reminder;
                reminder.UpdateNextRunDate();
                DataTable reminderResults = DataTable();
                foreach (DataRow row in reminderResults.Rows)
                    BuildEmail(row);
                AuditLogger.Instance.LogInfo($"Reminder {reminder.ReminderID}: triggered with {reminderResults.Rows.Count} emails to send","REMINDER");
            }
            catch (SqlException e)
            {
                AuditLogger.Instance.LogInfo($"Reminder {reminder.ReminderID}: {e.Message}", "SQL ERROR");
            }
            catch(Exception e)
            {
                AuditLogger.Instance.LogInfo($"Reminder {reminder.ReminderID}: {e.Message}", "ERROR");
            }
        }

        private DataTable DataTable()
        {
            DataTable dt = null;
            try
            {
                dt = SqlManager.Instance.RunQuery(reminder.SelectionCriteria);
            }
            catch (SqlException e)
            {
                SqlManager.Instance.Close();
                throw new Exception(e.Message);
            }
            catch (Exception e)
            {
                SqlManager.Instance.Close();
                throw new Exception(e.Message);
            }
            return dt;
        }

        private void BuildEmail(DataRow row)
        {
            Email email = new Email
            {
                Message = EmailMessage(row),
                Subject = EmailSubject(row),
                SendTo = SendToAddress(row),
                Sent = 0
            };
            _Emails.InsertOnSubmit(email);
            Models.Ereminders.Instance.SubmitChanges();
        }

        private string SendToAddress(DataRow row)
        {
            switch (reminder.RemType)
            {
                case 0:
                    return reminder.SpecificAddress;
                case 1:
                    return row[reminder.FieldForEmail].ToString();
                default:
                    return reminder.SpecificAddress;
            }
        }

        private string EmailSubject(DataRow row)
        {
            string message = MessageParser(row, reminder.EmailSubjectA, reminder.EmailSubjectB);
            if (reminder.AppendEmailFooter)
                message += reminder.EmailMessageFooter;
            return message;
        }

        private string EmailMessage(DataRow row)
        {
            return MessageParser(row, reminder.EmailMessageA, reminder.EmailMessageB);
        }

        private string MessageParser(DataRow row, List<string> As, IEnumerable<string> Bs)
        {
            var bsResult = Bs.Select(x => String.IsNullOrEmpty(x) ? x : row[x].ToString()).ToList();
            string result = String.Empty;
            for (int i = 0; i < As.Count; i++)
                result += $"{As[i]} {bsResult[i]} ";
            return result;
        }
    }
}
