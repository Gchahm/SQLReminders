using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLReminders.Data.Models
{
    public class SqlField
    {
        public string TableName { get; set; }
        public string FieldName { get; set; }
        public string Field { get; set; }

        public SqlField(string field)
        {
            Field = field;
            TableName = FieldPart(0);
            FieldName = FieldPart(1);
        }

        public SqlField(string table, string field)
        {
            TableName = table;
            FieldName = field;
            Field = $"{table}.{field}";
        }

        private string FieldPart(int i)
        {
            if (Field.Contains('.'))
                return Field.Split('.')[i];
            return String.Empty;
        }

    }
}
