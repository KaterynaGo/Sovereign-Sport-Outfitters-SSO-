#region Imports
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
#endregion
namespace SSOPointOfSale
{
    public partial class frmSelectCustomerForm : Form
    {
        private const string DB_ADDRESS = "ca-cdbr-azure-east-a.cloudapp.net"; // Production DB Address is the same as testing
        private const string DB_NAME = "outfitters_sports_test"; // Production Database Name: 
        private const string DB_USERNAME = "be2159b3dd6898"; // Production DB Username: b26f142c40c5b3
        private const string DB_PASSWORD = "fe8db4d6"; // Production DB Password: 1c94c64f
        // REF (How to connect to MySQL Database?) : http://stackoverflow.com/questions/21618015/how-to-connect-to-mysql-database
        private string DB_CONNSTRING = string.Format("Server={0}; database={1}; UID={2}; password={3}", DB_ADDRESS, DB_NAME, DB_USERNAME, DB_PASSWORD);
        #region Select Customer Form Constructor
        /**
         * Select Customer Form Constructor: Initialize form and check search by customer Id radio button by default
         */
        public frmSelectCustomerForm()
        {
            InitializeComponent();
            BindCustomers();
        }
        #endregion
        #region Cancel and Add customer to order buttons functionality
        private void btnCustomerCancel_Click(object sender, EventArgs e) => this.Hide();
        #endregion
        #region Bind Customers
        private void BindCustomers()
        {
            MySqlConnection conn = new MySqlConnection(DB_CONNSTRING);
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT firstName, lastName, phoneNum, email FROM customer;", conn);

                conn.Open();
                DataTable dataTable = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                adapter.Fill(dataTable);

                customerGridView.DataSource = dataTable;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }            
        }
        #endregion
        #region Customer Submit button functionality
        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(DB_CONNSTRING);
            try
            {
                if (txtCustEmail != null && txtCustEmail.Text != "" && txtCustFirstName != null && txtCustFirstName.Text != "" && txtCustLastName != null && txtCustLastName.Text != "" && txtCustPhone != null && txtCustPhone.Text != "")
                {
                    int status = 1;                    
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO outfitters_sports_test.customer ( firstName, lastName, phoneNum, signUpDate, status, email, password) VALUES ( ?firstName, ?lastName, ?phoneNum, ?signUpDate, ?status, ?email, ?password);", conn);

                    conn.Open();

                    cmd.Parameters.Add("?firstName", MySqlDbType.VarChar).Value = txtCustFirstName.Text;
                    cmd.Parameters.Add("?lastName", MySqlDbType.VarChar).Value = txtCustLastName.Text;
                    cmd.Parameters.Add("?phoneNum", MySqlDbType.VarChar).Value = txtCustPhone.Text;
                    cmd.Parameters.Add("?signUpDate", MySqlDbType.DateTime).Value = DateTime.Today;
                    cmd.Parameters.Add("?status", MySqlDbType.Int32).Value = status;
                    cmd.Parameters.Add("?email", MySqlDbType.VarChar).Value = txtCustEmail.Text;
                    cmd.Parameters.Add("?password", MySqlDbType.VarChar).Value = "password";

                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Customer has been registered.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    txtCustEmail.Clear();
                    txtCustFirstName.Clear();
                    txtCustLastName.Clear();
                    txtCustPhone.Clear();
                    BindCustomers();
                    //this.Hide();
                }
                else
                    MessageBox.Show("Please input all information to register customer");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }
        #endregion


    }
}
