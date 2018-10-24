# SQLReminders
.NET App that allows you to create reminders based on SQL queries

## Main  
![main](https://github.com/Gchahm/SQLReminders/blob/master/readme%20images/main.png)  
  The main window will have a data grid view that shows any entry in the trail since the program was opened.  
On the bottom of the window there are labels to show if the system is active and licenced.  
The Next Tick label shows a countdown to when the system will trigger the next tick action.  
You can manually trigger the action by clicking the tick now button.  
  
## SMPT Settings
![smtp](https://github.com/Gchahm/SQLReminders/blob/master/readme%20images/smtp_settings.png)  
  The app is set up to be able to send emails with no encryption as well as explicit and implicit SSL, thanks to [AIM Library](https://sourceforge.net/projects/netimplicitssl/)
  
## SQL Settings
![sql settings](https://github.com/Gchahm/SQLReminders/blob/master/readme%20images/sql_preferences.png)  
  Currently the app is only set to connect to MSSQL..   
After the connection is tested and saved, the button create tables which will then create the necessary tables for it to work.  
  
## Reminder Schedulers
![reminder scheduler](https://github.com/Gchahm/SQLReminders/blob/master/readme%20images/reminder_schedule.png)  
  Through the scheduler you can create, edit delete and copy reminders.  
The tick box active remidners will show active/inactive reminders.
  
## Reminder
![reminder](https://github.com/Gchahm/SQLReminders/blob/master/readme%20images/reminder.png)  
  The Reminder window allows to edit the scheduling settings of the reminder.
- If it's a once off reminder or if it's repeated.
- Next run date and time
- Run Frequency
  
## SQL Builder
![reminder builder](https://github.com/Gchahm/SQLReminders/blob/master/readme%20images/sql_builder.png)  
The SQL builder section is where the SELECT Statement is created.  
The table selection dropbox will have every table in the database.  
You can add tables to the selection by clicking in the add button.  
The relation between tables can be managed by modifying them in the text box below the tables list box.  
After a table is added you can add fields to the selection by selecting the table and double clicking in a field from the field selection list box, or selecting the field and clicking add.  
The field can be removed from te selection using the Fields used list.  
The email the system will use to send the reminders to can come from the select criteria if using the send to as Emails address from query, or can be manually typed using the option specific address.  
  
## Audit Trail
![audit trail](https://github.com/Gchahm/SQLReminders/blob/master/readme%20images/audit_trail.png)  

The app has a single fuction Tick which will do 2 simple task.

```C#
public void Tick()
{
    if(Active && Licenced)
    {
        EmailGenerator.ExtractEmails();
        EmailSender.SendEmails();
    }
}
```

The first goes through the list of due reminders and generate the emails to be picked by the SendEmails function.

```C#
public void ExtractEmails()
{
    foreach (Reminder reminder in ReminderController.DueReminders)
    {
        QueueEmails(reminder);
        UpdateManager.UpdateFields(reminder);
    }
}
```

The SendEmails function pick any email not sent and tries to send them, logging the results in the audit trail.

```C#
public void SendEmails()
{
    foreach (Email email in DueEmails)
        SendEmail(email);
}
```
