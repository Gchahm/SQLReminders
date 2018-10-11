using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLReminders.Data.Helpers;

namespace SQLReminders.Data.Models
{
    [Table(Name = "EREmails")]
    public class Email
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int EmailID { get; set; }
        [Column] public string SendTo { get; set; }
        [Column] public string Subject { get; set; }
        [Column] public string Message { get; set; }
        [Column] public int Sent { get; set; }
        [Column] public DateTime? SentOn { get; set; }



    }
}
