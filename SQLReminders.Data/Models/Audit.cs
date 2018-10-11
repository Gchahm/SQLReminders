using System;
using System.Data.Linq.Mapping;

namespace SQLReminders.Data.Models
{
    [Table(Name = "ERAudit")]
    public class Audit
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int AuditID { get; set; }
        [Column] public DateTime DateCreated { get; set; }
        [Column] public string Type { get; set; }
        [Column] public string Information { get; set; }
    }
}
