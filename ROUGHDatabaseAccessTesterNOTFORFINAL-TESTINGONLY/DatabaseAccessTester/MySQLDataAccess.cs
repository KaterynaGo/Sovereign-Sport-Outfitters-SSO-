using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace DatabaseAccessTester
{
    class MySQLDataAccess
    {
        /*
        static void DBConnect()
        {
            string cs = @"server=ca-cdbr-azure-east-a.cloudapp.net;userid=be2159b3dd6898;
            password=fe8db4d6;database=mydb";

            MySqlConnection conn = null;

            try
            {
                conn = new MySqlConnection(cs);
                conn.Open();
                Console.WriteLine("MySQL version : {0}", conn.ServerVersion);
                frmDataAccessTesterForm.rtxtResultant.Text = "My"
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.ToString());

            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
        */
    }
}
