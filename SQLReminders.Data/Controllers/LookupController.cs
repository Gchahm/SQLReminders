using SQLReminders.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLReminders.Data.Controllers
{
    public class LookupController
    {
        private Table<Lookup> _ReminderLookups;
        public IQueryable<Lookup> ReminderLookups { get => LookupQuery(); }

        public LookupController()
        {
            _ReminderLookups = Models.Ereminders.Instance.GetTable<Lookup>();
        }

        //Handlers for manipulating a reminder
        public Lookup NewLookup()
        {
            return Save(new Lookup());
        }
        public Lookup GetLookup(int id) => _ReminderLookups.First(i => i.LookupID == id);

        public void DeleteReminder(int id)
        {
            _ReminderLookups.DeleteOnSubmit(GetLookup(id));
            Models.Ereminders.Instance.SubmitChanges();
        }

        private Lookup Save(Lookup lookup)
        {
            _ReminderLookups.InsertOnSubmit(lookup);
            Models.Ereminders.Instance.SubmitChanges();
            return lookup;
        }

        private IQueryable<Lookup> LookupQuery()
        {
            IQueryable<Lookup> lookupQuery =
            from lookup in _ReminderLookups
            select lookup;

            return lookupQuery;
        }
    }
}
