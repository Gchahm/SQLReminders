﻿using SQLReminders.Data.Controllers;
using SQLReminders.Data.Core;
using AutoMapper;
using SQLReminders.Data.Models;
using SQLReminders.Data.Helpers;
using System.ComponentModel;

namespace SQLReminders.Data
{
    public class App
    {
        public bool Active { get => Config.IsActive; }
        public bool Licenced { get => Config.IsLicenced; } 

        public ReminderController ReminderController { get; }
        public AuditTrailController AuditTrailController { get; }
        public LookupController LookupController { get; }
        public ConfigureController Config { get; }
        public CSVController CSVController { get; }

        private EmailGenerator EmailGenerator { get; }
        private EmailSender EmailSender { get; }
        
        public App()
        {
            ReminderController = new ReminderController();
            AuditTrailController = new AuditTrailController();
            LookupController = new LookupController();
            CSVController = new CSVController(ReminderController);
            Config = new ConfigureController();

            EmailGenerator = new EmailGenerator(ReminderController);
            EmailSender = new EmailSender();

            
            Mapper.Initialize(cfg => {
                cfg.CreateMap<Reminder, Reminder>();
                cfg.CreateMap<Lookup, Lookup>();
            });
        }
           
        public void Tick()
        {
            if(Active && Licenced)
            {
                EmailGenerator.ExtractEmails();
                EmailSender.SendEmails();
            }
        }

    }
}
