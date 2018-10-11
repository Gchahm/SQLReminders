using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Ereminders.Data.Singletons;
using NHibernate;
using NHibernate.Criterion;

namespace Ereminders.Data.Models
{
    public class Reminders : IModel
    {


        public virtual string ID { get; set; }
        public virtual string ReminderName { get; set; }
        public virtual DateTime NextRunDate { get; set; }
        public virtual string RepeatedRunTime { get; set; }
        public virtual string ActiveReminder { get; set; }
        //Fields for the main
        public virtual string Description { get; set; }
        public virtual string CreatedBy { get; set; }
        public virtual DateTime DateCreated { get; set; }
        public virtual string RunOnce { get; set; }
        public virtual string Repeated { get; set; }
        public virtual DateTime FirstRunDate { get; set; }
        public virtual string RunEveryXDays { get; set; }
        public virtual string SendTo { get; set; }
        public virtual string SpecificAddress { get; set; }

        //fields for builder

        public virtual string TablesUsed { get; set; }
        public virtual string FieldsUsed { get; set; }
        public virtual string Subject1A { get; set; }
        public virtual string Subject1B { get; set; }
        public virtual string Subject2A { get; set; }
        public virtual string Subject2B { get; set; }
        public virtual string Subject3A { get; set; }
        public virtual string Subject3B { get; set; }
        public virtual string Subject4A { get; set; }
        public virtual string Subject4B { get; set; }
        public virtual string Subject5A { get; set; }
        public virtual string Subject5B { get; set; }
        public virtual string Subject6A { get; set; }
        public virtual string Subject6B { get; set; }
        public virtual string Subject7A { get; set; }
        public virtual string Subject7B { get; set; }
        public virtual string Subject8A { get; set; }
        public virtual string Subject8B { get; set; }
        public virtual string Message1A { get; set; }
        public virtual string Message1B { get; set; }
        public virtual string Message2A { get; set; }
        public virtual string Message2B { get; set; }
        public virtual string Message3A { get; set; }
        public virtual string Message3B { get; set; }
        public virtual string Message4A { get; set; }
        public virtual string Message4B { get; set; }
        public virtual string Message5A { get; set; }
        public virtual string Message5B { get; set; }
        public virtual string Message6A { get; set; }
        public virtual string Message6B { get; set; }
        public virtual string Message7A { get; set; }
        public virtual string Message7B { get; set; }
        public virtual string Message8A { get; set; }
        public virtual string Message8B { get; set; }
        public virtual string UpDateField1 { get; set; }
        public virtual string UpDateTo1 { get; set; }
        public virtual string UpDateField2 { get; set; }
        public virtual string UpDateTo2 { get; set; }
        public virtual string UpDateField3 { get; set; }
        public virtual string UpDateTo3 { get; set; }
        public virtual string UpDateField4 { get; set; }
        public virtual string UpDateTo4 { get; set; }
        public virtual string UpDateField5 { get; set; }
        public virtual string UpDateTo5 { get; set; }
        public virtual string AppendEmailFooter { get; set; }
        public virtual string EmailMessageFooter { get; set; }
        public virtual string SelectionCriteria { get; set; }
        public virtual string SQLSelectionCriteria2 { get; set; }
        public virtual string SQLConditions { get; set; }
        public virtual string UseAlternateMgrEmailField { get; set; }
        public virtual string AlternateMgrEmailField { get; set; }
        public virtual string UpDateFieldsUsed { get; set; }

        private DataTable dt;
        private List<string> subjectAs;
        private List<string> subjectBs;
        private List<string> messageAs;
        private List<string> messageBs;



        public void SetActiveReminder(bool value)
        {
            ActiveReminder = SaveBool(value);
        }

        public bool GetActiveReminder()
        {
            return GetBool(ActiveReminder);
        }

        public bool GetBool(string boolValue)
        {
            try
            {
                if (boolValue.ToUpper().Equals("TRUE"))
                    return true;
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }

        public string SaveBool(bool boolValue)
        {
            if (boolValue)
                return "TRUE";
            else
                return "FALSE";
        }

        public void SetRunOnce(bool value)
        {
            RunOnce = SaveBool(value);
        }

        public bool GetRunOnce()
        {
            return GetBool(RunOnce);
        }

        public void SetRepeated(bool value)
        {
            Repeated = SaveBool(value);
        }

        public bool GetRepeated()
        {
            return GetBool(Repeated);
        }

        public void SetAppendEmailFooter(bool value)
        {
            AppendEmailFooter = SaveBool(value);
        }
        public bool GetAppendEmailFooter()
        {
            return GetBool(AppendEmailFooter);
        }

        public void SetUseAlternateMgrEmailField(bool value)
        {
            UseAlternateMgrEmailField = SaveBool(value);
        }

        public bool GetUseAlternateMgrEmailField()
        {
            return GetBool(UseAlternateMgrEmailField);
        }

        public DataTable GetSQLInfo()
        {
            DataTable dt = null;
            try
            {
                dt = SqlManager.Instance.RunQuery(SQLSelectionCriteria2);
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


        public int HasEmailsToSend()
        {
            return GetSQLInfo().Rows.Count;
        }

        public void UpdateNextRunDate()
        {
            int days = Convert.ToInt32(RunEveryXDays);
            NextRunDate = DateTime.Now.Date.AddDays(days);
            HibernateConnection.Instance.SaveOrUpdate(this);
        }

        public Queue<Email> GetEmailsToSendList()
        {
            Queue<Email> EmailsToSend = new Queue<Email>();
            BuildLists();
            dt = GetSQLInfo();
            if (dt == null)
                return EmailsToSend;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Employee emp = GetEmployee(i);
                if (emp.IsValid())
                {
                    Email email;
                    if (SendTo.Equals("Selected Employees Only - SQL Filter"))
                        email = new Email(ID, emp.GetEmpref(), emp.GetEmpEmail(), GetSubject(i), GetMessage(i));
                    else if (SendTo.Equals("Specific Email Address - SQL Filter"))
                        email = new Email(ID, emp.GetEmpref(), SpecificAddress, GetSubject(i), GetMessage(i));
                    else
                        email = new Email(ID, emp.GetEmpref(), emp.GetSupEmail(), GetSubject(i), GetMessage(i));

                    if (GetAppendEmailFooter())
                        email.AddFooter(EmailMessageFooter);
                    if (GetUseAlternateMgrEmailField())
                        email.ToAddress = emp.GetEmail("tmsemp", AlternateMgrEmailField);

                    UpdateFields(emp.GetEmpref());
                    EmailsToSend.Enqueue(email);
                }
            }
            return EmailsToSend;
        }

        public List<string> SendToSource()
        {
            List<string> list = new List<string>();
            list.Add("Selected Employees Managers Only  - SQL Filter");
            list.Add("Selected Employees Only - SQL Filter");
            list.Add("Specific Email Address - SQL Filter");
            return list;
        }

        public void UpdateFields(string empref)
        {
                UpdateField(empref, UpDateField1, UpDateTo1);
                UpdateField(empref, UpDateField2, UpDateTo2);
                UpdateField(empref, UpDateField3, UpDateTo3);
                UpdateField(empref, UpDateField4, UpDateTo4);
                UpdateField(empref, UpDateField5, UpDateTo5);
        }

        private void UpdateField(string empref, string tableAndField, string value)
        {
            if(tableAndField != null && tableAndField != "" && value != null && value != "")
            {
                try
                {
                    string[] split = tableAndField.Split('.');
                    string table = split[0];
                    string field = split[1];
                    SqlManager.Instance.UpdateField(empref, table, field, value);
                }
                catch
                {
                    AuditLogger.Instance.LogInfo($"Couldn't update {tableAndField} for {empref}", "ERROR");
                }

            }
        }

        private string GetEmailSubject()
        {
            BuildLists();
            dt = GetSQLInfo();
            if (dt != null)
                return GetMessage(0);
            return $"Reminder {ID} null Dt";
        }

        private Employee GetEmployee(int i)
        {
            Employee employee;
            if (GetBool(UseAlternateMgrEmailField))
                employee = new Employee(dt.Rows[i]["EMPREF"].ToString(), AlternateMgrEmailField);
            else
                employee = new Employee(dt.Rows[i]["EMPREF"].ToString());
            return employee;
        }

        private string GetSubject(int row)
        {
            string emailSubject = "";
            for (int i = 0; i < 8; i++)
            {
                string subjectBValue = "";
                if (subjectBs[i] != "")
                    subjectBValue = GetFieldValue(row, i, subjectBs[i]);
                emailSubject = $"{emailSubject} {subjectAs[i]} {subjectBValue}";
            }

            return emailSubject;
        }

        private string GetMessage(int row)
        {
            string emailMessage = "";
            for (int i = 0; i < 8; i++)
            {
                string messageBVlaue = "";
                if (messageBs[i] != "")
                    messageBVlaue = GetFieldValue(row, i, messageBs[i]);
                emailMessage = $"{emailMessage} {messageAs[i]} {messageBVlaue}";
            }
            return emailMessage;
        }

        private string GetFieldValue(int row,int pos, string field)
        {
            string value;
            try
            {
                string[] splitField = field.Split('.');
                if (splitField.Length > 1)
                {
                    value = dt.Rows[row][splitField[1]].ToString();
                    return GetLookupValue(value, splitField[1]);
                }
                value = dt.Rows[row][field].ToString();
                return value;
            }
            catch
            {
                AuditLogger.Instance.LogInfo($"Reminder {ID}: Value in message/subject {pos + 1} is invalid", "Builder Error");
                value = "";
                return value;
            }
        }

        private string GetLookupValue(string value,string field)
        {
            ICriteria criteria = HibernateConnection.Instance.GetSession().CreateCriteria<ReminderLookup>();
            criteria.Add(Restrictions.Eq("Lookup", field));
            ReminderLookup lookup = HibernateConnection.Instance.GetAllEntities<ReminderLookup>(criteria)[0];

            string result = SqlManager.Instance.GetLookupField(value,lookup.Tablename,lookup.SetName);

            return result;
        }

        private void BuildLists()
        {
            BuildSubjectAs();
            BuildSubjectBs();
            BuildMessageAs();
            BuildMessageBs();
        }
        private void BuildSubjectAs()
        {
            subjectAs = new List<string>();
            subjectAs.Add(Subject1A);
            subjectAs.Add(Subject2A);
            subjectAs.Add(Subject3A);
            subjectAs.Add(Subject4A);
            subjectAs.Add(Subject5A);
            subjectAs.Add(Subject6A);
            subjectAs.Add(Subject7A);
            subjectAs.Add(Subject8A);
        }
        private void BuildSubjectBs()
        {
            subjectBs = new List<string>();
            subjectBs.Add(Subject1B);
            subjectBs.Add(Subject2B);
            subjectBs.Add(Subject3B);
            subjectBs.Add(Subject4B);
            subjectBs.Add(Subject5B);
            subjectBs.Add(Subject6B);
            subjectBs.Add(Subject7B);
            subjectBs.Add(Subject8B);
        }
        private void BuildMessageAs()
        {
            messageAs = new List<string>();
            messageAs.Add(Message1A);
            messageAs.Add(Message2A);
            messageAs.Add(Message3A);
            messageAs.Add(Message4A);
            messageAs.Add(Message5A);
            messageAs.Add(Message6A);
            messageAs.Add(Message7A);
            messageAs.Add(Message8A);
        }
        private void BuildMessageBs()
        {
            messageBs = new List<string>();
            messageBs.Add(Message1B);
            messageBs.Add(Message2B);
            messageBs.Add(Message3B);
            messageBs.Add(Message4B);
            messageBs.Add(Message5B);
            messageBs.Add(Message6B);
            messageBs.Add(Message7B);
            messageBs.Add(Message8B);

        }

    }
}
