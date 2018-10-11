using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SQLReminders.Data.Helpers
{
    public sealed class SqlManager
    {
        private static SqlManager instance = new SqlManager();

        private SqlConnection cnn; 
        private string serverName;
        private string database;
        private string username;
        private string password;
        private string status;
        private bool isConfigured;

        public string Status { get => status; set => status = value; }
        public string ServerName { get => serverName; set => serverName = value; }
        public string Database { get => database; set => database = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public bool IsConfigured { get => isConfigured; set => isConfigured = value; }

        public string ConString
        {
            get => "Data Source=" + ServerName + ";Initial Catalog=" + Database + ";User ID=" + Username + ";Password=" + Password;
        }

        private SqlManager()
        {
            cnn = new SqlConnection();
            SetConnection();
            isConfigured = false;
        }

        public static SqlManager Instance
        {
            get
            {
                return instance;
            }
        }

        private void SetConnection()
        {
            ServerName =Properties.Settings.Default.conServer;
            Database = Properties.Settings.Default.conDatabase;
            Username = Properties.Settings.Default.conUsername;
            Password = Properties.Settings.Default.conPassword;
            cnn.ConnectionString = ConString;
        }

        public void TestConnection(string serverName,string database,string username,string password)
        {
            this.ServerName = serverName;
            this.Database = database;
            this.Username = username;
            this.Password = password;
            cnn.ConnectionString = ConString;
            Open();
            Close();
        }
        
        public bool IsReady()
        {
            Open();
            Close();
            return isConfigured;
        }
    
        public SqlConnection GetConnection()
        {
            return cnn;
        }

        public void Open()
        {
            try
            {
                if (cnn != null && cnn.State == ConnectionState.Closed)
                    cnn.Open();
                status =  "connection open";
                isConfigured = true;

            }
            catch (Exception ex)
            {
                status = ex.Message;
                cnn.ConnectionString = ConString;
                isConfigured = false;
            }
        }

        public void Close()
        {
            cnn.Close();
        }

        public void SaveSettings(string server, string database, string username, string password)
        {
            Properties.Settings.Default.conServer = server;
            Properties.Settings.Default.conDatabase = database;
            Properties.Settings.Default.conUsername = username;
            Properties.Settings.Default.conPassword = password;
            Properties.Settings.Default.Save();
        }

        public DataTable GetSchema()
        {
            Open();
            DataTable tables = cnn.GetSchema("Tables");
            Close();
            return tables;
        }

        public List<string> GetAllTables()
        {
            List<string> tables = new List<string>();
            DataTable dt = GetSchema();

            foreach (DataRow row in dt.Rows)
            {
                string tablename = (string)row[2];
                tables.Add(tablename);
            }

            return tables;
        }

        public DataTable GetTableFields(string table)
        {
            string query = "SELECT name FROM sys.columns WHERE object_id = OBJECT_ID('"+table+"')";
            return RunQuery(query);

        }

        public DataTable RunQuery(string query) 
        {
            DataTable dt;
            Open();
            SqlDataAdapter da = new SqlDataAdapter(query, cnn);
            DataSet ds = new DataSet();
            da.Fill(ds, "results");
            dt = ds.Tables["results"];
            Close();
            return dt;
        }

        public void RunCommand(string query)
        {
            SqlCommand command = new SqlCommand();
            command.CommandText = query;
            command.Connection = cnn;
            Open();
            command.ExecuteNonQuery();
            Close();

        }

        public string GetLookupField(string value, string table, string setname)
        {
            string query = "SELECT DESCRIPTION " +
                $"FROM {table} " +
                $"WHERE SETNAME='{setname}' AND CODE='{value}' ";
            DataTable dt =RunQuery(query);
            string result = dt.Rows[0][0].ToString();
            return result;
        }

        public bool IsTablesBuilt()
        {
            var values = Enum.GetValues(typeof(Tables));
            foreach (object value in values)
                if (!CheckIfTableExists(value.ToString()))
                    return false;
            return true;
        }

        public bool CheckIfTableExists(string tableName)
        {
            string query = "SELECT * FROM INFORMATION_SCHEMA.TABLES " +
                $"WHERE TABLE_NAME = '{tableName}'";
            DataTable result = RunQuery(query);
            return result.Rows.Count > 0;
        }


    }


}
