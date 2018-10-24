using System.ComponentModel;
using System.Windows.Forms;
using SQLReminders.Data;
using SQLReminders.Data.Helpers;

namespace SQLReminders.Desktop.Forms
{
    public partial class FrmCreateTables : Form
    {
        private BindingList<string> dataSource;
        public FrmCreateTables(TableBuilder builder)
        {

            InitializeComponent();
            dataSource = new BindingList<string>();
            ListBox.DataSource = dataSource;
            builder.CreateTables(dataSource);
        }
    }
}
