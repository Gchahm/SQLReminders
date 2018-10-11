using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLReminders.Data.Models
{
    [Table(Name = "ERLookups")]
    public class Lookup
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public virtual int LookupID { get; set; }
        [Column] public virtual string Tablename { get; set; }
        [Column] public virtual string SetName { get; set; }
        [Column] public virtual string LookupName { get; set; }
    }
}
