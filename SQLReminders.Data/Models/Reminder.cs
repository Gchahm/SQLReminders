using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;

namespace SQLReminders.Data.Models
{
    [Table(Name = "ERReminders")]
    public class Reminder
    {
        char separator = '|';

        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int ReminderID { get; set; }
        [Column] public string ReminderName { get; set; }
        [Column] public DateTime NextRunDate { get; set; }
        [Column] public bool Active;
        //Fields for the main
        [Column] public string Description;
        [Column] public string CreatedBy;
        [Column] public DateTime DateCreated;
        [Column] public bool Repeated;
        [Column] public int RunFrequency;

        //fields for builder
        [Column(Name = "TablesUsed")]
        public string _fldTablesUsed = String.Empty;
        [Column(Name = "FieldsUsed")]
        private string _fldFieldsUsed = String.Empty;
        [Column(Name = "EmailSubjectA")]
        private string _fldEmailSubjectA = String.Empty;
        [Column(Name = "EmailSubjectB")]
        private string _fldEmailSubjectB = String.Empty;
        [Column(Name = "EmailMessageA")]
        private string _fldEmailMessageA = String.Empty;
        [Column(Name = "EmailMessageB")]
        private string _fldEmailMessageB = String.Empty;
        [Column(Name = "FieldsToUpdate")]
        private string _fldFieldsToUpdate = String.Empty;
        [Column(Name = "UpdateFieldsTo")]
        private string _fldUpdateFieldsTo = String.Empty;
        [Column(Name = "TableRelations")]
        public string _fldTableRelations = String.Empty;
        [Column] public string SQLConditions = String.Empty;
        [Column] public int RemType;
        [Column] public string FieldForEmail;
        [Column] public string SpecificAddress;
        [Column] public bool AppendEmailFooter;
        [Column] public string EmailMessageFooter;

        public List<string> EmailSubjectA
        {
            get => EmptyOrList(_fldEmailSubjectA);
            set => _fldEmailSubjectA = String.Join(separator.ToString(), value);
        }

        public List<string> EmailSubjectB
        {
            get => EmptyOrList(_fldEmailSubjectB);
            set => _fldEmailSubjectB = String.Join(separator.ToString(), value);
        }

        public List<string> EmailMessageA
        {
            get => EmptyOrList(_fldEmailMessageA);
            set => _fldEmailMessageA = String.Join(separator.ToString(), value);
        }

        public List<string> EmailMessageB
        {
            get => EmptyOrList(_fldEmailMessageB);
            set => _fldEmailMessageB = String.Join(separator.ToString(), value);
        }

        public List<string> FieldsToUpdate
        {
            get => EmptyOrList(_fldFieldsToUpdate);
            set => _fldFieldsToUpdate = String.Join(separator.ToString(), value);
        }
        
        public List<string> UpdateFieldsTo
        {
            get => EmptyOrList(_fldUpdateFieldsTo);
            set => _fldUpdateFieldsTo = String.Join(separator.ToString(), value);
        }

        private BindingList<SqlField> _FieldsUsed;
        public BindingList<SqlField> FieldsUsed
        {
            get
            {
                if (_FieldsUsed == null)
                    _FieldsUsed = new BindingList<SqlField>(_fldFieldsUsed.Split(separator).Select(x => new SqlField(x)).ToList());
                return _FieldsUsed;
            }
        }

        public IEnumerable<string> FieldsNames
        {
            get
            {
                return FieldsUsed.Select(x => x.FieldName);
            }
        }

        public IEnumerable<string> FieldsFullNames
        {
            get
            {
                return FieldsUsed.Select(x => x.Field);
            }
        }

        private BindingList<string> _TablesUsed;
        public BindingList<string> TablesUsed
        {
            get
            {
                if(_TablesUsed==null)
                    _TablesUsed = new BindingList<string>(EmptyOrList(_fldTablesUsed));
                return _TablesUsed;
            } 
        }

        private List<string> _TableRelations;
        public List<string> TableRelations
        {
            get
            {
                if (_TableRelations == null)
                    _TableRelations = EmptyOrList(_fldTableRelations);
                return _TableRelations;
            }
        }

        public string SlqSelect { get => FieldsUsed.Count > 1 ? "SELECT " + String.Join(", ", FieldsFullNames).Substring(1) : "SELECT "; }

        public string SqlTables { get => TableRelations.Count > 1 ? String.Join(" ", TableRelations) : string.Empty; }

        public string SelectionCriteria
        {
            get
            {
                return $"{SlqSelect} {SqlTables} {SQLConditions}";
            }
        }

        private List<string> EmptyOrList(string value)
        {
            return String.IsNullOrEmpty(value) ? new List<string>() : value.Split(separator).ToList();
        }

        public void UpdateNextRunDate()
        {
            NextRunDate = DateTime.Now.Date.AddDays(RunFrequency) + NextRunDate.TimeOfDay;
            Ereminders.Instance.SubmitChanges();
            Active = Repeated;
        }

        public void Save()
        {
            string sep = separator.ToString();
            _fldFieldsUsed = String.Join(sep, FieldsFullNames);
            _fldTablesUsed = String.Join(sep, TablesUsed);
            _fldTableRelations = String.Join(sep, TableRelations);
        }

        public override string ToString()
        {
            string[] columns = { ReminderID.ToString(),
                                //ReminderName,
                                //NextRunDate.ToString(),
                                //Active.ToString(),
                                //Description,
                                //CreatedBy,
                                //DateCreated.ToString(),
                                //RunOnce.ToString(),
                                //Repeated.ToString(),
                                //RunFrequency.ToString(),
                                //SendTo,
                                //SpecificAddress,
                                //_FieldsUsed,
                                //AppendEmailFooter.ToString(),
                                //EmailMessageFooter,
                                //TableRelations,
                                //SelectionCriteria,
                                //SQLConditions,
                                //UseAlternateMgrEmailField.ToString(),
                                //AlternateMgrEmailField,
                                 };
            return String.Join("|", columns);
        }

        public void AddField(string table, string field)
        {
            SqlField Field = new SqlField(table, field);
            if (!FieldsUsed.Contains(Field))
                FieldsUsed.Add(Field);
        }
        
        public void RemoveField(SqlField field)
        {
             FieldsUsed.Remove(field);
        }

        private string NewRelation(string table)
        {
            if (TableRelations.Count == 0)
                return $"FROM {table}";
            return $"INNER JOIN {table} ON {TablesUsed[0]}.EMPREF={table}.EMPREF";
        }


        public void AddTable(string table)
        {
            if (!TablesUsed.Contains(table))
            {
                TableRelations.Add(NewRelation(table));
                TablesUsed.Add(table);
            }
        }

        public void RemoveTable(int index)
        {
            RemoveFields(TablesUsed[index]);
            TablesUsed.RemoveAt(index);
            TableRelations.RemoveAt(index);

        }

        private void RemoveFields(string table)
        {
            for (int i = FieldsUsed.Count - 1; i >= 0; i--)
            {
                if (FieldsUsed[i].TableName==table)
                    FieldsUsed.RemoveAt(i);
            }
        }
        
    }
}
