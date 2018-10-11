using SQLReminders.Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;


namespace SQLReminders.Data.Controllers
{
    public class ReminderController
    {
        private Table<Reminder> _Reminders;
        public Table<Reminder> Reminders { get => _Reminders; }

        public ReminderController()
        {
            _Reminders = Models.Ereminders.Instance.GetTable<Reminder>();
        }

        //Properties
        public IQueryable<Reminder> ActiveReminders { get => FilteredReminders(true); }
        public IQueryable<Reminder> InactiveReminders { get => FilteredReminders(false); }
        public List<Reminder> DueReminders { get => _DueReminders(); }
    
        //Handlers for manipulating a reminder
        public Reminder GetReminder(int id)
        {
            return _Reminders.First(i => i.ReminderID == id);
        }

        public Reminder NewReminder()
        {
            Reminder reminder = new Reminder
            {
                DateCreated = DateTime.Today,
                NextRunDate = DateTime.Today.AddDays(1),
                RunFrequency = 1,
                Active = true,
                Repeated = true
            };
            return Save(reminder);
        }

        public void NewReminder(string[] reminderProps)
        {
            //Reminder reminder = new Reminder
            //{
            //    ID = Convert.ToInt32(reminderProps[0]),
            //    ReminderName = reminderProps[1],
            //    NextRunDate = DateTime.Parse(reminderProps[2]),
            //    Active = Convert.ToBoolean(reminderProps[4]),
            //    Description = reminderProps[5],
            //    CreatedBy = reminderProps[6],
            //    DateCreated = DateTime.Parse(reminderProps[7]),
            //    RunOnce = Convert.ToBoolean(reminderProps[8]),
            //    Repeated = Convert.ToBoolean(reminderProps[9]),
            //    RunFrequency = Convert.ToInt32(reminderProps[11]),
            //    SendTo = reminderProps[12],
            //    SpecificAddress = reminderProps[13],
            //    TablesUsed = reminderProps[14],
            //    //FieldsUsed = reminderProps[15],
            //    AppendEmailFooter = Convert.ToBoolean(reminderProps[9]),
            //    EmailMessageFooter = reminderProps[59],
            //    TableRelations = reminderProps[60],
            //    SelectionCriteria = reminderProps[61],
            //    SQLConditions = reminderProps[62],
            //    UseAlternateMgrEmailField = Convert.ToBoolean(reminderProps[63]),
            //    AlternateMgrEmailField = reminderProps[64],
            //    //UpDateFieldsUsed = reminderProps[65]
            //};
            //Save(reminder);
        }

        public Reminder CopyReminder(int id)
        {
            Reminder copiedReminder = Mapper.Map<Reminder, Reminder>(GetReminder(id));
            return Save(copiedReminder);
        }

        public void DeleteReminder(int id)
        {
            _Reminders.DeleteOnSubmit(GetReminder(id));
            Data.Models.Ereminders.Instance.SubmitChanges();

        }

        private Reminder Save(Reminder reminder)
        {
            _Reminders.InsertOnSubmit(reminder);
            Models.Ereminders.Instance.SubmitChanges();
            return reminder;
        }

        private List<Reminder> _DueReminders()
        {
            IQueryable<Reminder> dueReminders =
            from reminder in _Reminders
            where reminder.NextRunDate <= DateTime.Now
            && reminder.Active
            select reminder;

            return dueReminders.ToList();
        }

        private IQueryable<Reminder> FilteredReminders(bool isActive)
        {
            IQueryable<Reminder> custQuery =
            from cust in _Reminders
            where cust.Active == isActive
            select cust;

            return custQuery;
        }        
    }
}
