using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace SQLReminders.Data.Controllers
{
    public class ConfigureController
    {
        public ConfigureController()
        {
        }

        public string Licence
        {
            get => Properties.Settings.Default.Licence;
            set => Properties.Settings.Default.Licence = value;
        }

        public string CompanyName
        {
            get => Properties.Settings.Default.CompanyName;
            set => Properties.Settings.Default.CompanyName = value;
        }

        public bool IsActive
        {
            get => Properties.Settings.Default.Active;
            set
            {
                Properties.Settings.Default.Active = value;
                Save();
            }
        }

        //SMTP Details
        public string SmtpUser { get => Properties.Settings.Default.smtpUser; set => Properties.Settings.Default.smtpUser = value; }
        public string SmtpHost { get => Properties.Settings.Default.smtpServer; set => Properties.Settings.Default.smtpServer = value; }
        public string SmtpPass { get => Properties.Settings.Default.smtpPass; set => Properties.Settings.Default.smtpPass = value; }
        public int SmptPort { get => Properties.Settings.Default.smtpPort; set => Properties.Settings.Default.smtpPort = value; }
        public bool SmptUseAuthentication { get => Properties.Settings.Default.smtpUseAuthentication; set => Properties.Settings.Default.smtpUseAuthentication = value; }
        public bool SmtpUseSecureConnection { get => Properties.Settings.Default.smtpUseSecureConnection; set => Properties.Settings.Default.smtpUseSecureConnection = value; }
        public string SmtpSslMode { get => Properties.Settings.Default.smtpSecureVersion; set => Properties.Settings.Default.smtpSecureVersion = value; }
        

        public string LicenceCheck()
        {
            string companyName = Properties.Settings.Default.CompanyName;
            string licenceRequest = $"{companyName}supersecretlicencekeywowsuchsecret";
            SHA1 hashGen = new SHA1CryptoServiceProvider();
            hashGen.ComputeHash(Encoding.UTF8.GetBytes(licenceRequest));
            StringBuilder sb = new StringBuilder();
            foreach (byte b in hashGen.Hash)
                sb.Append(b.ToString("X2"));
            hashGen.Dispose();
            return sb.ToString();
        }

        public bool CheckLicence(string licence) => licence.Equals(LicenceCheck());



        public bool IsLicenced => CheckLicence(Properties.Settings.Default.Licence);

        public void Save()
        {
            Properties.Settings.Default.Save();
        }

    }
}
