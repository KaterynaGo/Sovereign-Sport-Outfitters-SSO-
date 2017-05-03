#region Imports
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
#endregion
namespace SSOPointOfSale
{
    #region Main Register Form Class
    public partial class frmPointOfSaleForm : Form
    {
        #region Class Constructor : Register Setup
        /**
         * Form class constructor: Initialize form, start a new receipt, and lock the register
         * so an employee must login
         */
        public frmPointOfSaleForm()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            VoidTransaction.OnVoidTransaction += VoidTransaction_OnVoidTransaction; // Void transaction delegate
            CleanupTransaction.OnDoCleanupTransaction += CleanupTransaction_OnDoCleanupTransactionTransaction; // Cleanup transaction delegate
            AddChangeCustomer.OnAddChangeCustomer += AddChangeCustomer_OnAddChangeCustomer; // Add or Change customer delegate
            populateReceiptHeader();
            registerLock();
        }
        #endregion
        #region Register Locking, Unlocking and Close.
        /**
         * Lock register so employee has to sign-in
         */

        private void registerLock()
        {
            rtxtReceipt.Visible = false;
            btnOrderCustomer.Visible = false;
            btnEmployee.Visible = false;
            btnOrderAddItem.Visible = false;
            btnExit.Visible = true; // If employee cannot login, they can still close the register
            btnOrderRemoveItem.Visible = false;
            btnOrderVoid.Visible = false;
            btnOrderTotal.Visible = false;
            btnOrderPayment.Visible = false;
            btnEmployee.Visible = false;
            txtEmployeeId.Visible = true;
            txtEmployeePassword.Visible = true;
            btnRegisterUnlock.Visible = true;
            empIdLabel.Visible = true;
            passwordLabel.Visible = true;
            productGridView.Visible = false;
            customerGridView.Visible = false;
            lblCustomer.Visible = false;
            lblProduct.Visible = false;
            txtSearchCustomer.Visible = false;
            txtSearchItem.Visible = false;
            btnSearchCustomer.Visible = false;
            btnSearchItem.Visible = false;
            btnViewAllCustomers.Visible = false;
            btnViewAllItem.Visible = false;
        }

        /**
         * When the register is unlocked, an employee is logged in.
         */
        private void registerUnLock()
        {
            // NOTE: this IF statement should be replaced to check if the username/password is
            // correct in the database
            if (Employee.Instance.verifyIdandPassword(txtEmployeeId.Text, txtEmployeePassword.Text))
            {
                rtxtReceipt.Visible = true;
                btnOrderCustomer.Visible = true;
                btnEmployee.Visible = true;
                btnOrderAddItem.Visible = true;
                btnOrderRemoveItem.Visible = true;
                btnOrderVoid.Visible = true;
                btnOrderTotal.Visible = true;
                btnOrderPayment.Visible = true; // This will be done once an Order Item is added
                btnExit.Visible = true;
                txtEmployeeId.Visible = false;
                txtEmployeePassword.Visible = false;
                btnEmployee.Visible = true;
                btnEmployee.Text = "Lock (" + Employee.Instance.getEmployeeNameFromId(txtEmployeeId.Text) + ")";
                btnRegisterUnlock.Visible = false;
                empIdLabel.Visible = false;
                passwordLabel.Visible = false;
                //txtEmployeeId.Text = string.Empty; // This doesn't cancel the transaction, so can leave "logged in"
                txtEmployeePassword.Text = string.Empty;
                setCustomerButtonText();
                productGridView.Visible = true;
                customerGridView.Visible = true;
                lblCustomer.Visible = true;
                lblProduct.Visible = true;
                txtSearchCustomer.Visible = true;
                txtSearchItem.Visible = true;
                btnSearchCustomer.Visible = true;
                btnSearchItem.Visible = true;
                btnViewAllCustomers.Visible = true;
                btnViewAllItem.Visible = true;
            }
            else
                MessageBox.Show("Incorrect employee ID or password");
        }
        private void btnEmployee_Click(object sender, EventArgs e) => registerLock();
        private void btnRegisterUnlock_Click(object sender, EventArgs e) => registerUnLock();
        /**
         * Close the register with a confirmation prompt
         */
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult closeRegisterDialog = MessageBox.Show("Are you sure you want to close the register?", "Close register", MessageBoxButtons.YesNo);
            if (closeRegisterDialog == DialogResult.Yes)
                Application.Exit();
        }
        #endregion
        #region Customer button selection and text functionality
        /**
         * Show the Customer Selection Form
         */
        private void btnOrderCustomer_Click(object sender, EventArgs e)
        {
            frmSelectCustomerForm selectcustomerform = new frmSelectCustomerForm();
            selectcustomerform.Show();
        }
        /**
         * Sets the customer name to the Button text.
         * 
         * NOTE: This SHOULD be called from a delegate, triggered by the Add Customer
         * in Select Customer Form, I just haven't set that up yet.
         */
        public void setCustomerButtonText() => btnOrderCustomer.Text = (Customer.Instance.CustomerId != 0)
            ? "Customer: " + Customer.Instance.CustomerFirstName + " " + Customer.Instance.CustomerLastName
            : btnOrderCustomer.Text = "(No customer)";
        #endregion
        #region Print receipt
        /**
         * Print the receipt header information
         */
        private void populateReceiptHeader()
        {
            rtxtReceipt.Clear();
            //rtxtReceipt.ForeColor = Color.Chocolate;
            rtxtReceipt.SelectionAlignment = HorizontalAlignment.Center;
            //rtxtReceipt.SelectionFont = new Font("Calibri", 11);
            rtxtReceipt.SelectedText = "\nSovereign Sport Outfitters\nScarborough Branch #0001\n941 Progress Avenue, Scarborough, Ontario\nPhone: 416-SSO-5000\n--------------------------\n";
        }
        #endregion
        #region Order total and payment button functionality
        /**
         * Gather all order items, add them to the order, then enable the payment button
         */
        private void btnOrderTotal_Click(object sender, EventArgs e)
        {
            // if: check if there are items to total up!
            // YES THERE ARE ITEMS TO TOTAL.
            // Loop through OrderItem array and get subtotal and apply tax to total
            //foreach blah blah ordersubtotal += item[i]
            //
            // total = ordersubtotal * TAXCONST;
            // rtxtReceipt.Text += string.Format("Subtotal: {0:C}\nTotal: {1:C}", ordersubtotal, ordertotal);
            // BUTTONS, disable: Total, Add, Remove, Customer, Employee    enable: Payment
            //btnOrderTotal.Enabled = false;
            //btnOrderAddItem.Enabled = false;
            //btnOrderRemoveItem.Enabled = false;
            //btnOrderCustomer.Enabled = false;
            //btnEmployee.Enabled = false;
            btnOrderPayment.Enabled = true;
            // else: do nothing
        }
        /**
         * Order is prepared, subtotal and total have been calculated, show payment form
         */
        private void btnOrderPayment_Click(object sender, EventArgs e)
        {
            SelectPaymentForm paymentselectionform = new SelectPaymentForm();
            paymentselectionform.Show();
        }
        #endregion
        #region Delegated Functions: Void Transaction, Add/Change Customer
        /**
         * Cleanup the transaction after it has had payment successfully processed. Different from VoidTransaction which is cancelling an unpaid order
         */
        public void CleanupTransaction_OnDoCleanupTransactionTransaction()
        {
            // TODO: Should set current customer to 0 and reset the customer button, reprint receipt, maybe set the transaction as COMPLETED in the database?
            rtxtReceipt.Text += "Cleanup this transaction delegate fired!"; // Delegate test!
        }
        /**
         * Void the current transaction
         */
        public void VoidTransaction_OnVoidTransaction(string voidMsg)
        {
            // TODO: Should set current customer to 0 and reset the customer button, reprint receipt, maybe set the transaction as VOIDED in the database?
            // FOR TESTINGS!
            DialogResult voidTransactionDialog = MessageBox.Show("Are you want to void the current transaction?", "Void transaction", MessageBoxButtons.YesNo);
            if (voidTransactionDialog == DialogResult.Yes)
            {
                // Print receipt Header
                populateReceiptHeader();
                rtxtReceipt.Text += voidMsg; // Delegate test!
                // Set to default non-customer
                Customer.Instance.CustomerId = 0;
                Customer.Instance.CustomerFirstName = "Please select";
                Customer.Instance.CustomerLastName = "a customer";
            }
            else
                MessageBox.Show("Void Transaction aborted. Transaction NOT VOID.", "Transaction NOT Void", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        /**
         * Void Order Button Click Event
         */
        private void btnOrderVoid_Click(object sender, EventArgs e) => VoidTransaction_OnVoidTransaction("Void Order Button Pressed and Void Confirmed!");
        public void AddChangeCustomer_OnAddChangeCustomer(int customerId, string customerFirstName, string customerLastName)
        {
            // Change information in Customer Singleton Object
            Customer.Instance.CustomerId = customerId; // set customer to customer id or something
            Customer.Instance.CustomerFirstName = customerFirstName; // set customer to customer id or something
            Customer.Instance.CustomerLastName = customerLastName; // set customer to customer id or something
            // Change button 
            btnOrderCustomer.Text = "Customer: " + customerFirstName + " " + customerLastName;
            // Add customer information to receipt
            rtxtReceipt.Text += "Customer ID: " + customerId + "\n" + "Customer: " + customerFirstName + " " + customerLastName;
        }
        #endregion

        // http://stackoverflow.com/questions/652978/parameterized-query-for-mysql-with-c-sharp
        // https://msdn.microsoft.com/en-us/library/sebfsz50(v=vs.110).aspx
        // https://www.youtube.com/watch?v=b3Q7UjK5_t0

        private const string DB_ADDRESS = "ca-cdbr-azure-east-a.cloudapp.net"; // Production DB Address is the same as testing
        private const string DB_NAME = "outfitters_sports_test"; // Production Database Name: 
        private const string DB_USERNAME = "be2159b3dd6898"; // Production DB Username: b26f142c40c5b3
        private const string DB_PASSWORD = "fe8db4d6"; // Production DB Password: 1c94c64f
        // REF (How to connect to MySQL Database?) : http://stackoverflow.com/questions/21618015/how-to-connect-to-mysql-database
        private string DB_CONNSTRING = string.Format("Server={0}; database={1}; UID={2}; password={3}", DB_ADDRESS, DB_NAME, DB_USERNAME, DB_PASSWORD);
        private void frmPointOfSaleForm_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(DB_CONNSTRING);
            try
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM productitem;", conn);

                conn.Open();
                DataTable dataTable = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);


                MySqlCommand cmd2 = new MySqlCommand("SELECT * FROM customer", conn);
                DataTable dataTable2 = new DataTable();
                MySqlDataAdapter adapter2 = new MySqlDataAdapter(cmd2);

                adapter.Fill(dataTable);
                adapter2.Fill(dataTable2);

                productGridView.DataSource = dataTable;
                customerGridView.DataSource = dataTable2;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
            }
        }

        private void btnSearchItem_Click(object sender, EventArgs e)
        {

            try
            {
                MySqlConnection conn = new MySqlConnection(DB_CONNSTRING);
                conn.Open();

                string productName = txtSearchItem.Text;
                MySqlCommand searchItemCmd = new MySqlCommand("SELECT * FROM productitem where productName= @productName;", conn);
                searchItemCmd.Parameters.AddWithValue("productName", productName);

                DataTable dataSearchedItem = new DataTable();
                MySqlDataAdapter adpaterSearchedItem = new MySqlDataAdapter(searchItemCmd);
                adpaterSearchedItem.Fill(dataSearchedItem);

                productGridView.DataSource = dataSearchedItem;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };
        }

        private void btnViewAllItem_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(DB_CONNSTRING);
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM productitem;", conn);

                conn.Open();
                DataTable dataTable = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                adapter.Fill(dataTable);

                productGridView.DataSource = dataTable;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(DB_CONNSTRING);
                conn.Open();

                string lastName = txtSearchCustomer.Text;
                MySqlCommand searchCustomerCmd = new MySqlCommand("SELECT * FROM customer where lastName= @lastName;", conn);
                searchCustomerCmd.Parameters.AddWithValue("lastName", lastName);

                DataTable dataSearchedCustomer = new DataTable();
                MySqlDataAdapter adpaterCustomer = new MySqlDataAdapter(searchCustomerCmd);
                adpaterCustomer.Fill(dataSearchedCustomer);

                customerGridView.DataSource = dataSearchedCustomer;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnViewAllCustomers_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conn = new MySqlConnection(DB_CONNSTRING);

                conn.Open();

                MySqlCommand cmd2 = new MySqlCommand("SELECT * FROM customer", conn);
                DataTable dataTable2 = new DataTable();
                MySqlDataAdapter adapter2 = new MySqlDataAdapter(cmd2);


                adapter2.Fill(dataTable2);

                customerGridView.DataSource = dataTable2;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnOrderAddItem_Click(object sender, EventArgs e)
        {
            AddNewItemForm newOrderform = new AddNewItemForm();
            newOrderform.Show();
        }
    }
    #endregion
    #region Void Transaction Delegate Class
    /**
     * Using special threadsafe delegates because problems. ADD ClearTransaction function!!! Like voiding but without a void message
     * REF: http://stackoverflow.com/questions/2950326/calling-a-function-in-the-form-class-from-another-class-c-sharp-net
     */
    public delegate void VoidTransactionDelegate(string voidMsg);
    public static class VoidTransaction
    {
        public static Form frmPOS;
        public static event VoidTransactionDelegate OnVoidTransaction;
        public static void ShowVoidMessage(string voidMsg) => ThreadSafeVoidFunction(voidMsg);
        private static void ThreadSafeVoidFunction(string voidMsg)
        {
            if (frmPOS != null && frmPOS.InvokeRequired)  // we are in a different thread to the main window
                frmPOS.Invoke(new VoidTransactionDelegate(ThreadSafeVoidFunction), new object[] { voidMsg });  // call self from main thread
            else
                OnVoidTransaction(voidMsg);
        }
    }
    #endregion
    #region Clear Transaction Delegate Class
    /**
     * Clear up the transaction
     */
    public delegate void CleanupTransactionDelegate();
    public static class CleanupTransaction
    {
        public static Form frmPOS;
        public static event CleanupTransactionDelegate OnDoCleanupTransaction;
        public static void DoCleanupTransaction() => ThreadSafeCleanupTransactionFunction();
        private static void ThreadSafeCleanupTransactionFunction()
        {
            if (frmPOS != null && frmPOS.InvokeRequired)  // we are in a different thread to the main window
                frmPOS.Invoke(new CleanupTransactionDelegate(ThreadSafeCleanupTransactionFunction), new object[] { });  // call self from main thread
            else
                OnDoCleanupTransaction();
        }
    }
    #endregion
    #region Add or Change Customer Delegate Class
    public delegate void AddChangeCustomerDelegate(int customerId, string customerFirstName, string customerLastName);
    public static class AddChangeCustomer
    {
        public static Form frmPOS;
        public static event AddChangeCustomerDelegate OnAddChangeCustomer;
        public static void AddChangeCustomerEverywhere(int customerId, string customerFirstName, string customerLastName) => ThreadSafeAddChangeCustomerFunction(customerId, customerFirstName, customerLastName);
        private static void ThreadSafeAddChangeCustomerFunction(int customerId, string customerFirstName, string customerLastName)
        {
            if (frmPOS != null && frmPOS.InvokeRequired)  // we are in a different thread to the main window
                frmPOS.Invoke(new AddChangeCustomerDelegate(ThreadSafeAddChangeCustomerFunction), new object[] { customerId, customerFirstName, customerLastName });  // call self from main thread
            else
                OnAddChangeCustomer(customerId, customerFirstName, customerLastName);
        }
    }
    #endregion
}
