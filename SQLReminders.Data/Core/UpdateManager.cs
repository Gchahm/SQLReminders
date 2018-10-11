using SQLReminders.Data.Helpers;
using SQLReminders.Data.Models;

namespace SQLReminders.Data.Core
{
    public class UpdateManager
    {
        Reminder reminder;

        public UpdateManager()
        {

        }

        public void UpdateFields(Reminder reminder)
        {
            var fieldsToUpdate = reminder.FieldsToUpdate;
            var updateFieldsTo = reminder.UpdateFieldsTo;
            this.reminder = reminder;

            for(int i= 0; i < updateFieldsTo.Count; i++)
            {
                var field = fieldsToUpdate[i];
                var to = updateFieldsTo[i];
                if (field.Contains("."))
                {
                    var query = CreateSqlQuery(field, to);
                    UpdateField(query);
                }
            }
        }

        private void UpdateField(string query)
        {
            try
            {
                SqlManager.Instance.RunCommand(query);
            }
            catch
            {
                AuditLogger.Instance.LogInfo($"Couldn't update fields for reminder {reminder.ReminderID}", "ERROR");
            }
        }

        private string CreateSqlQuery(string field, string to)
        {
            string table = field.Split('.')[0];
            string column = field.Split('.')[1];
            string query = $"UPDATE {table} " +
                           $"SET {column} = '{to}' " +
                           reminder.SqlTables + " " +
                           reminder.SQLConditions;
                                                  
            return query;
        }
    }
}
