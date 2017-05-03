using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace SSOPointOfSale
{
    public partial class AddNewItemForm : Form
    {
        private const string DB_ADDRESS = "ca-cdbr-azure-east-a.cloudapp.net"; // Production DB Address is the same as testing
        private const string DB_NAME = "outfitters_sports_test"; // Production Database Name: 
        private const string DB_USERNAME = "be2159b3dd6898"; // Production DB Username: b26f142c40c5b3
        private const string DB_PASSWORD = "fe8db4d6"; // Production DB Password: 1c94c64f
        // REF (How to connect to MySQL Database?) : http://stackoverflow.com/questions/21618015/how-to-connect-to-mysql-database
        private string DB_CONNSTRING = string.Format("Server={0}; database={1}; UID={2}; password={3}", DB_ADDRESS, DB_NAME, DB_USERNAME, DB_PASSWORD);

        public AddNewItemForm()
        {
            InitializeComponent();
            BindOrder();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void BindOrder()
        {
            MySqlConnection conn = new MySqlConnection(DB_CONNSTRING);
            try
            {

                MySqlCommand cmd = new MySqlCommand("SELECT productName FROM ProductItem;", conn);

                conn.Open();
                DataSet dataTable = new DataSet();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                adapter.Fill(dataTable);

                adapter.Fill(dataTable);
                listItems.DataSource = dataTable.Tables[0];
                listItems.DisplayMember = "productName";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }
        private void btnNewCustomer_Click(object sender, EventArgs e)
        {

        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            int shipment = 0;
            double itemPrice = 0;
            double total = 0;
            string productName = listItems.Text;
            MySqlConnection conn = new MySqlConnection(DB_CONNSTRING);
            try
            {
               
                conn.Open();
                MySqlDataReader reader = null;
                string selectCmd = "SELECT price FROM ProductItem where productName = @productName;";
                MySqlCommand cmd = new MySqlCommand(selectCmd,conn);
                
                cmd.Parameters.Add("?productName", MySqlDbType.VarChar).Value = productName;
                
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    decimal price = (decimal)reader["price"];
                    MessageBox.Show($"{price}");
                    itemPrice = Convert.ToDouble(price);
                }
                conn.Close();
                
            }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conn.Close();
                }
            if (radioButton1.Checked == true)
            {
                shipment = 1;
                total = itemPrice + 50;
                txtTotal.Text = total.ToString();
            }
            else if (radioButton2.Checked == true)
            {
                shipment = 2;
                total = itemPrice + 25;
                txtTotal.Text = total.ToString();
            }
            else if (radioButton3.Checked == true)
            {
                shipment = 3;
                total = itemPrice + 15;
                txtTotal.Text = total.ToString();
            }
            else
            {
                MessageBox.Show("Please select the way of shipment");
                return;
            }
           
            

            try
            {
                if (listItems != null && total != 0)
                {
                    
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO outfitters_sports_test.saleorder ( saleDateTime, employeeID, SHPrice, tax, totalAmt, shipMethod) VALUES ( ?saleDateTime, ?employeeID, ?SHPrice, ?tax, ?totalAmt, ?shipMethod);", conn);

                    conn.Open();

                    double shipmentPrice = total - itemPrice;

                    cmd.Parameters.Add("?employeeID", MySqlDbType.Decimal).Value = 1;
                    cmd.Parameters.Add("?saleDateTime", MySqlDbType.DateTime).Value = DateTime.Today;
                    cmd.Parameters.Add("?SHPrice", MySqlDbType.Decimal).Value = shipmentPrice ;
                    cmd.Parameters.Add("?tax", MySqlDbType.Decimal).Value = total * 0.13;
                    cmd.Parameters.Add("?totalAmt", MySqlDbType.Decimal).Value = total*1.13;
                    cmd.Parameters.Add("?shipMethod", MySqlDbType.Int32).Value = shipment ;

                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Order has been Added.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    txtTotal.Clear();
                    
                }
                else
                    MessageBox.Show("Please input all information to register an order");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void btnOrderCancel_Click(object sender, EventArgs e) => this.Hide();


    }
}
