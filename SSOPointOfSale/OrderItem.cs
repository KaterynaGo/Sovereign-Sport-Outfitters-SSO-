#region Imports
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion
namespace SSOPointOfSale
{
    #region OrderItem Class which creates a new OrderItem object for each item ordered.
    class OrderItem
    {
        #region OrderItem Class Constructor : ...
        public OrderItem(int orderId)
        {
            this.orderId = orderId;
        }
        #endregion
        #region OrderItem member variables and properties
        private int orderId;
        private int itemId;
        // LOTS TO ADD FROM DATABASE
        #endregion
        #region Retrieve Item Data from Database
        /**
         * Get Item information from database
         */
        public void populateOrderItemFromDatabase(int itemId)
        {
            // Get item information from Database and populate it into a datastructure or a bunch of member variables. 
        }
        #endregion
    }
    #endregion
}
