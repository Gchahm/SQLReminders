using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using SQLReminders.Data.Models;
using Xunit;

namespace SQLReminders.Data.Test.Models
{
    public class ReminderTest
    {
        Reminder reminder;
        List<string> emptyList;
        List<string> propListFormat;
        BindingList<string> propBidingListFormat;
        BindingList<string> fieldsUsed;
        string propStringFormat;


        public ReminderTest()
        {
            reminder = new Reminder();
            propListFormat = new List<string>
            {
                "item1",
                "item2",
                "item3",
                "item4",
                "item5",
                "item6",
                "item7",
                "item8"
            };
            propBidingListFormat = new BindingList<string>(propListFormat);
            propStringFormat = "item1|item2|item3|item4|item5|item6|item7|item8";
            emptyList = new List<string>();
            fieldsUsed = new BindingList<string>();
        }

        [Fact]
        public void TestSubjectAProperty()
        {
            //asserts default is empty string and empty list
            Assert.Equal(emptyList,reminder.EmailSubjectA);
            //assert that the list can be stored and returned properly
            reminder.EmailSubjectA = propListFormat;
            Assert.Equal(propListFormat, reminder.EmailSubjectA);
        }

        [Fact]
        public void TestSubjectBProperty()
        {
            Assert.Equal(emptyList, reminder.EmailSubjectB);
            reminder.EmailSubjectB = propListFormat;
            Assert.Equal(propListFormat, reminder.EmailSubjectB);
        }

        [Fact]
        public void TesMessageAProperty()
        {
            Assert.Equal(emptyList, reminder.EmailMessageA);
            reminder.EmailMessageA = propListFormat;
            Assert.Equal(propListFormat, reminder.EmailMessageA);
        }

        [Fact]
        public void TestMessageBProperty()
        {
            Assert.Equal(emptyList, reminder.EmailMessageB);
            reminder.EmailMessageB = propListFormat;
            Assert.Equal(propListFormat, reminder.EmailMessageB);
        }

        [Fact]
        public void TestUpdateFieldsProperty()
        {
            Assert.Equal(emptyList, reminder.FieldsToUpdate);
            reminder.FieldsToUpdate = propListFormat;
            Assert.Equal(propListFormat, reminder.FieldsToUpdate);
        }

        [Fact]
        public void TestUpdateFieldsToProperty()
        {
            Assert.Equal(emptyList, reminder.UpdateFieldsTo);
            reminder.UpdateFieldsTo = propListFormat;
            Assert.Equal(propListFormat, reminder.UpdateFieldsTo);
        }

        [Fact]
        public void TestTableRelationsToProperty()
        {
            Assert.Equal(emptyList, reminder.TableRelations);
            Assert.Equal(string.Empty, reminder._fldTableRelations);
            Assert.Equal(propListFormat, reminder.TableRelations);
            Assert.Equal(propStringFormat, reminder._fldTableRelations);
        }

        [Fact]
        public void TestTablesUsedToProperty()
        {
            Assert.Equal(new BindingList<string>(), reminder.TablesUsed);
            Assert.Equal(string.Empty, reminder._fldTablesUsed);
            Assert.Equal(propBidingListFormat, reminder.TablesUsed);
            Assert.Equal(propStringFormat, reminder._fldTablesUsed);
        }

        [Fact]
        public void TestFieldsUsedToProperty()
        {
            //From empty to adding 2 new fields
            //Assert.Equal(new BindingList<string>(), reminder.FieldsUsed);
            //Assert.Equal(string.Empty, reminder._FieldsUsed);
            reminder.AddField("tableName", "fieldName");
            fieldsUsed.Add("fieldName");
            reminder.AddField("tableName2", "fieldName2");
            fieldsUsed.Add("fieldName2");
        }

    }
}
