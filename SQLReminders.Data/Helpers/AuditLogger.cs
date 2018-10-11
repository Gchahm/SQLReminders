using SQLReminders.Data.Models;
using SQLReminders.Data.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLReminders.Data.Helpers
{
    public class AuditLogger
    {
        private static AuditLogger instance = new AuditLogger();


        private AuditLogger()
        {

        }

        public static AuditLogger Instance
        {
            get
            {
                return instance;
            }
        }

        public void LogInfo(string info, string type)
        {

            Audit audit = new Audit
            {
                Type = type,
                DateCreated = DateTime.Now,
                Information = info
            };
            Models.Ereminders.Instance.Audits.InsertOnSubmit(audit);
            Models.Ereminders.Instance.SubmitChanges();
        }

    }
}
