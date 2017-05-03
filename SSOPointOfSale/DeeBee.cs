#region Imports
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
#endregion
namespace SSOPointOfSale
{
    #region Database Class Important Notes
    /**
     * DEEBEE CLASS NOTES
     */
    // This is the connect class between the rest of the project and the MySQL database hosted on Azure.
    // Anything database should run through here.
    //
    // If we go "connected architecture" it may make more sense to move this class to a singleton
    // although I almost always prefer the "non-connected architecture" see how you feel:
    //
    // REF (How to connect to MySQL Database?) : http://stackoverflow.com/questions/21618015/how-to-connect-to-mysql-database
    // REF (Connect C# to MySQL) : https://www.codeproject.com/articles/43438/connect-c-to-mysql
    // REF (How to populate gridview with mysql?) : http://stackoverflow.com/questions/16115985/how-to-populate-gridview-with-mysql
    // REF (Fill Datagridview with MySQL data) : http://stackoverflow.com/questions/12904854/fill-datagridview-with-mysql-data
    #endregion
    #region Database Interface Class
    public class DeeBee
    {
        #region DeeBee Class Constructor
        /**
         * DeeBee Class Constructor
         */
        public DeeBee()
        {
            // 
        }
        #endregion
        #region DeeBee member variables and properties
        private const string DB_ADDRESS = "ca-cdbr-azure-east-a.cloudapp.net"; // Production DB Address is the same as testing
        private const string DB_NAME = "outfitters_sports_test"; // Production Database Name: 
        private const string DB_USERNAME = "be2159b3dd6898"; // Production DB Username: b26f142c40c5b3
        private const string DB_PASSWORD = "fe8db4d6"; // Production DB Password: 1c94c64f
        // REF (How to connect to MySQL Database?) : http://stackoverflow.com/questions/21618015/how-to-connect-to-mysql-database
        private string DB_CONNSTRING = string.Format("Server={0}; database={1}; UID={2}; password={3}", DB_ADDRESS, DB_NAME, DB_USERNAME, DB_PASSWORD);
        public string DbConnString { get; } // Needed only if we use gridviews.
        #endregion

        private string databaseName = string.Empty;
        public string DatabaseName
        {
            get { return databaseName; }
            set { databaseName = value; }
        }

        public string Password { get; set; }
        private MySqlConnection connection = null;
        public MySqlConnection Connection
        {
            get { return connection; }
        }

        private static DeeBee _instance = null;
        public static DeeBee Instance()
        {
            if (_instance == null)
                _instance = new DeeBee();
            return _instance;
        }

        public bool IsConnect()
        {
            bool result = true;
            if (Connection == null)
            {
                try
                {
                    if (String.IsNullOrEmpty(databaseName))
                        result = false;
                    //string connstring = string.Format("Server=localhost; database={0}; UID=UserName; password=your password", databaseName);
                    connection = new MySqlConnection(DB_CONNSTRING);
                    connection.Open();
                    result = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Close();
                }
            }
            return result;
        }

        public void Close()
        {
            connection.Close();
        }
    }

}
    #endregion

