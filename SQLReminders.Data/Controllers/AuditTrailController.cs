using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLReminders.Data.Models;

namespace SQLReminders.Data.Controllers
{
    public class AuditTrailController
    {
        private Table<Audit> _Audit;


        public AuditTrailController()
        {
            _Audit = Models.Ereminders.Instance.GetTable<Audit>();
        }

        public Table<Audit> Audit { get => _Audit; }

        public IQueryable<Audit> GetAuditFrom(DateTime fromDate)
        {
            IQueryable<Audit> filteredAudit =
            from audit in _Audit
            where audit.DateCreated >= fromDate
            select audit;

            return filteredAudit;
        }

        public IQueryable<Audit> FilterAudit(DateTime fromDate, DateTime toDate, string type)
        {
            IQueryable<Audit> custQuery =
            from audit in _Audit
            where audit.DateCreated >= fromDate
            && audit.DateCreated <= toDate
            && audit.Type.Contains(type)
            select audit;
            return custQuery;
        }

        public void RefreshTrail()
        {
            Data.Models.Ereminders.Instance.Refresh(RefreshMode.OverwriteCurrentValues, _Audit);
        }

    }
}
