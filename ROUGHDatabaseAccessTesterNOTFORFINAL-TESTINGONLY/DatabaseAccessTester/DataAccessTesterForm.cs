using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace DatabaseAccessTester
{
    public partial class frmDataAccessTesterForm : Form
    {


        // REF: http://stackoverflow.com/questions/21618015/how-to-connect-to-mysql-database




        // REF: https://www.codeproject.com/articles/43438/connect-c-to-mysql




        // WORKS
        string serverName = "server=ca-cdbr-azure-east-a.cloudapp.net";
        string serverUserId = "be2159b3dd6898";
        string serverPassword = "fe8db4d6";
        string serverDB = "outfitters_sports_test";
        string cs = @"server=ca-cdbr-azure-east-a.cloudapp.net;userid=be2159b3dd6898;password=fe8db4d6;database=outfitters_sports_test";
        public frmDataAccessTesterForm()
        {
            InitializeComponent();
        }
        #region DB Connection Test
        public void DBConnectTest()
        {
            MySqlConnection conn = null;
            try
            {
                conn = new MySqlConnection(cs);
                conn.Open();
                rtxtResultant.Text = "MySQL version : " + conn.ServerVersion;
            }
            catch (MySqlException ex)
            {
                rtxtResultant.Text = "Error: " + ex.ToString();
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
        }
        private void btnTestConnection_Click(object sender, EventArgs e) => DBConnectTest();
        #endregion
        
    }
}
