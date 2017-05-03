#region Imports
using System;
using System.Windows.Forms;
#endregion
namespace SSOPointOfSale
{
    public partial class SelectPaymentForm : Form
    {
        #region Select Payment Form Class Constructor
        /**
         * Initialize form, hide order complete button, and fill the payment combo box with the payment types
         */
        public SelectPaymentForm()
        {
            InitializeComponent();
            btnOrderComplete.Visible = false;
            populatePaymentTypes();
        }
        #endregion
        #region Add payment types to combobox
        /**
         * Get payment types from database and populate the combobox
         */
        private void populatePaymentTypes()
        {
            // NOTE: Get payment types from Database then populate the payment types combobox!
            // For now, just make up something for testing here:
            cbxPaymentType.Items.AddRange(new string[] { "", "Visa", "MasterCard", "PayPal", "BitCoin", "DogeCoin", "Memes" });
        }
        #endregion
        #region Process payment
        /**
         * Payment is always accepted for this project because we do not have a payment processor back-end.
         */
        private int processPayment()
        {
            // Payment Processor Interface would go here,
            // since we don't have one, this will have to always succede.
            // For testing purposes, positive succedes, negative numbers fail.
            return 777;
        }
        private void btnConfirmPayment_Click(object sender, EventArgs e)
        {
            int transactioncode = processPayment();
            if (transactioncode >= 0)
            {
                lblPaymentResult.Text = "Payment Accepted!\nTransaction Number: " + transactioncode;
                // Order and Payment complete, clean up
                cbxPaymentType.Enabled = false;
                btnConfirmPayment.Enabled = false;
                btnBackToOrder.Enabled = false;
                // Button to clear up the order
                btnOrderComplete.Visible = true;
            }
            else
                lblPaymentResult.Text = "Payment Not Accepted!\nError Code: (" + System.Math.Abs(transactioncode) + ")\nPlease select another\npayment method";
        }
        #endregion
        #region Complete order and go back to order form button functionality
        /**
         * Just go back to the order form
         */
        private void btnBackToOrder_Click(object sender, EventArgs e) => this.Close();
        /**
         * Call delegate in PointOfSaleForm to clean up order form for next customer
         * Close this payment window
         */
        private void btnOrderComplete_Click(object sender, EventArgs e)
        {
            // VoidTransaction.ShowVoidMessage("Void transaction"); // Call a delegate to clear up the order form for the next customer
            CleanupTransaction.DoCleanupTransaction(); // Call a delegate to clear up the order form for the next customer
            this.Close(); // Close this window
        }
        #endregion
    }
}
