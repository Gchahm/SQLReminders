using SQLReminders.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLReminders.Data.Models
{
    public class Ereminders : DataContext
    {
        public Table<Audit> Audits;
        public Table<Reminder> Reminders;
        public Table<Lookup> ReminderLookups;
        private static Ereminders instance = new Ereminders(Helpers.SqlManager.Instance.ConString);

        private Ereminders(string fileOrServerOrConnection) : base(fileOrServerOrConnection)
        {
        }

        public static Ereminders Instance
        {
            get
            {
                return instance;
            }
        }



    }
}
