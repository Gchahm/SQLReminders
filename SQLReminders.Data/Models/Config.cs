using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLReminders.Data.Models
{
    [Table(Name = "ERConfig")]
    class Config
    {
        [Column] public string Section { get; set; }
        [Column] public string Porperty { get; set; }
        [Column] public string Value { get; set; }
    }
}
