/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAccessTester
{
    class DBConnection
    {
    }
}
*/
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Data
{
    public class DBConnection
    {
        private DBConnection()
        {
        }

        //private string databaseName = string.Empty;
        private string dbAddress = "ca-cdbr-azure-east-a.cloudapp.net";
        private string dbUserId = "be2159b3dd6898";
        private string dbPassword = "fe8db4d6";
        private string dbName = "outfitters_sports_test";
        public string DbAddress
        {
            get { return dbAddress; }
            set { dbAddress = value; }
        }

        public string DbPassword { get; set; }
        private MySqlConnection connection = null;
        public MySqlConnection Connection
        {
            get { return connection; }
        }

        private static DBConnection _instance = null;
        public static DBConnection Instance()
        {
            if (_instance == null)
                _instance = new DBConnection();
            return _instance;
        }
        // string cs = @"server=ca-cdbr-azure-east-a.cloudapp.net;userid=be2159b3dd6898;password=fe8db4d6;database=outfitters_sports_test";
        public bool IsConnect()
        {
            bool result = true;
            if (Connection == null)
            {
                if (string.IsNullOrEmpty(dbAddress) || string.IsNullOrEmpty(dbName) || string.IsNullOrEmpty(dbUserId) || string.IsNullOrEmpty(dbPassword))
                    result = false;
                else
                {
                    string connstring = string.Format("Server={0}; database={1}; UID={2}; password={3}; ", dbAddress, dbName, dbUserId, dbPassword);
                    connection = new MySqlConnection(connstring);
                    connection.Open();
                    result = true;
                }
            }
            return result;
        }

        public void Close() => connection.Close();
    }
}