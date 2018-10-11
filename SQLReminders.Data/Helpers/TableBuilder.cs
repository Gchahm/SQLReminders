using System.Collections.Generic;
using System.ComponentModel;

namespace SQLReminders.Data.Helpers
{
    public enum Tables
    {
        EREmails,
        ERReminders,
        ERAudit,
        ERLookups
    }

    public class TableBuilder
    {
        private BindingList<string> dataSource;


        public void CreateTables(BindingList<string> list)
    {
            dataSource = list;
            CreateRemindersTable();
            CreateEmailRemindersLookup();
            CreateAuditTrail();
            CreateEmailsToSend();
        }

        private void CreateEmailsToSend()
        {
            string table = Tables.EREmails.ToString();
            string create = $"CREATE TABLE {table}( \n" +
                            "[EmailID] [int] IDENTITY(1,1) NOT NULL, \n" +
                            "[SendTo] [varchar](100) NULL, \n" +
                            "[Subject] [varchar](500) NULL, \n" +
                            "[Message] [varchar](5000) NULL, \n" +
                            "[Sent] [int] NULL DEFAULT 0, \n" +
                            "[SentOn] [datetime] NULL \n" +
                            $"CONSTRAINT PK_{table}_EmailID PRIMARY KEY CLUSTERED (EmailID))";

            dataSource.Add($"Checking if {table} exists");
            CreateTable(SqlManager.Instance.CheckIfTableExists(table), create);
        }

        private void CreateRemindersTable()
        {
            string table = Tables.ERReminders.ToString();
            string command = $"CREATE TABLE {table}( \n" +
                            "[ReminderID] [int] IDENTITY(1,1) NOT NULL, \n" +
                            "[Active] bit NULL DEFAULT 0, \n" +
                            "[ReminderName] [varchar](100) NULL, \n" +
                            "[Description] [varchar](300) NULL, \n" +
                            "[CreatedBy] [varchar](50) NULL, \n" +
                            "[DateCreated] [datetime] NULL, \n" +
                            "[Repeated] bit DEFAULT 0, \n" +
                            "[NextRunDate] [datetime] NULL, \n" +
                            "[RunFrequency] INT NULL, \n" +
                            "[SelectionCriteria] [varchar](500) NULL, \n" +
                            "[TableRelations] [varchar](5000) NULL, \n" +
                            "[SQLConditions] [varchar](5000) NULL, \n" +
                            "[UpdateFields] [varchar](5000) NULL, \n" +
                            "[UpdateFieldsTo] [varchar](5000) NULL, \n" +
                            "[EmailSubjectA] [varchar](4000) NULL, \n" +
                            "[EmailSubjectB] [varchar](4000) NULL, \n" +
                            "[EmailMessageA] [varchar](4000) NULL, \n" +
                            "[EmailMessageB] [varchar](4000) NULL, \n" +
                            "[TablesUsed] [varchar](5000) NULL, \n" +
                            "[FieldsUsed] [varchar](5000) NULL, \n" +
                            "[RemType] INT NULL, \n" +
                            "[FieldForEmail] [varchar](500) NULL, \n" +
                            "[SpecificAddress] [varchar](500) NULL, \n" +
                            "[AppendEmailFooter] bit DEFAULT 0, \n" +
                            "[EmailMessageFooter] [varchar](5000) NULL, \n" +
                            $"CONSTRAINT PK_{table}_ReminderID PRIMARY KEY CLUSTERED (ReminderID))"; ;

            dataSource.Add($"Checking if {table} exists");
            CreateTable(SqlManager.Instance.CheckIfTableExists(table), command);
        }

        private void CreateAuditTrail()
        {
            string table = Tables.ERAudit.ToString();
            string command = $"CREATE TABLE {table}( \n" +
                            "[AuditID] [int] IDENTITY(1,1) NOT NULL, \n" +
                            "[DateCreated] [datetime] NULL, \n" +
                            "[Type] [varchar](50) NULL, \n" +
                            "[Information] [varchar](500) NULL, \n" +
                            $"CONSTRAINT PK_{table}_AuditID PRIMARY KEY CLUSTERED (AuditID))";

            dataSource.Add($"Checking if {table} exists");
            CreateTable(SqlManager.Instance.CheckIfTableExists(table), command);
        }

        private void CreateEmailRemindersLookup()
        {
            string table = Tables.ERLookups.ToString();
            string command = $"CREATE TABLE {table}( \n" +
                            "[LookupID] [int] IDENTITY(1,1) NOT NULL, \n" +
                            "[Tablename] [varchar](100) NULL, \n" +
                            "[SetName] [varchar](200) NULL, \n" +
                            "[LookupName] [varchar](100) NULL \n" +
                            $"CONSTRAINT PK_{table}_LookupID PRIMARY KEY CLUSTERED (LookupID))";

            dataSource.Add($"Checking if {table} exists");
            CreateTable(SqlManager.Instance.CheckIfTableExists(table), command);
        }


        private void CreateTable(bool exists, string query)
        {
            if (!exists)
            {
                SqlManager.Instance.RunCommand(query);
                dataSource.Add("Table Created");
            }
            else
                dataSource.Add("Table Already Exists");
        }
    }
}
