using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLReminders.Data.Controllers
{
    public class CSVController
    {
        private string _WritePath;
        private ReminderController _ReminderController;

        public CSVController(ReminderController reminderController)
        {
            ReminderController = reminderController;
        }

        public string WritePath { get => _WritePath; set => _WritePath = value; }
        public ReminderController ReminderController { get => _ReminderController; private set => _ReminderController = value; }

        public void WriteToCSV(List<int> ids,string path)
        {
            string[] lines = new string[ids.Count];
            for (int i = 0; i <ids.Count; i++)
            {
                lines[i] = ReminderController.GetReminder(ids[i]).ToString();
            }
            File.WriteAllLines(path, lines);
        }

        public void ReadCSV(string path)
        {
            IEnumerable<string> strCSV =
                File.ReadLines(path);
            foreach(string line in strCSV)
            {
                try
                {               
                    ReminderController.NewReminder(line.Split('|'));
                }
                catch
                {
                    throw new Exception("Couldn't import reminder");
                }
            }
        }
    }
}
