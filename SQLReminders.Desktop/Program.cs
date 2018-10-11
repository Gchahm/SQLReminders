using System;
using System.Windows.Forms;
using SQLReminders.Data;
using SQLReminders.Data.Helpers;
using SQLReminders.Desktop.Forms;
using System.Threading;

namespace SQLReminders.Desktop
{
    static class Program
    {
        public static Form splashForm = null;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //show splash
            Thread splashThread = new Thread(new ThreadStart(
                delegate
                {
                    splashForm = new SplashScreen();
                    Application.Run(splashForm);
                }
                ));

            splashThread.SetApartmentState(ApartmentState.STA);
            splashThread.Start();

            //run form - time taking operation
            App app = new App();
            if (SqlManager.Instance.IsReady() && SqlManager.Instance.IsTablesBuilt())
            {
                Form mainForm = new FrmMain(app);
                mainForm_Load();
                Application.Run(mainForm);
            }
            else
            {
                Form mainForm = new FrmSystemPreferences(app);
                mainForm_Load();
                Application.Run(mainForm);
            }

        }

        static void mainForm_Load()
        {
            //close splash
            if (splashForm == null)
            {
                return;
            }

            splashForm.Invoke(new Action(splashForm.Close));
            splashForm.Dispose();
            splashForm = null;
        }
    }
}
