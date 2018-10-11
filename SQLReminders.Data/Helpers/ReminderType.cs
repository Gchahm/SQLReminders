using System.ComponentModel;

namespace SQLReminders.Data.Helpers
{
 
    public enum ReminderType
    {

        [Description("Specific Address")]
        SpecificAddress = 0,
        [Description("Email Address from query")]
        FromSQL = 1,
    }


}
