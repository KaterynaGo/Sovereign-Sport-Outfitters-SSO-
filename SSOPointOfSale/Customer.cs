namespace SSOPointOfSale
{
    #region Customer Singleton Class
    public sealed class Customer
    {
        #region Singleton Class Setup
        static readonly Customer instance = new Customer();
        static Customer()
        {
        }

        Customer()
        {
            CustomerId = 0;
            CustomerFirstName = "Not";
            CustomerLastName = "Set";
        }
        public static Customer Instance
        {
            get
            {
                return instance;
            }
        }
        #endregion
        #region Customer Class member variables and properties
        // Customer singleton member variables and properties

        private int customerId;
        private string customerFirstName;
        private string customerLastName;
        public int CustomerId { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        #endregion
        #region Customer verification and Customer Name from Id functions
        /**
         * Check Customer Id against database
         */
        public bool verifyCustomerId(string customerid)
        {
            // NOTE: do database check here instead, this line is just for testing, etc.
            return (customerid == "q") ? true : false;
        }
        /**
         * Return Employee firstName and Employee lastName based on Employee Id
         */
        public string getCustomerNameFromId(string customerid)
        {
            // NOTE: do database check here
            //if (customer id exists in database)
            //  return firstName + lastName;
            //else
            //  return string.Empty;


            // NOTE: for now just return Employee Id so the rest of the system works correctly. 
            return "Customer Name Here";
        }
        #endregion
    }
    #endregion
}
