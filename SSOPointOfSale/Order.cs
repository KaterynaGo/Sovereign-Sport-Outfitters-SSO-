#region Imports
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion
namespace SSOPointOfSale
{
    public sealed class Order
    {
        // NOTE: This class is the ORDER itself. It can have zero to many OrderItem
        #region Singleton Class Setup
        // Order Singleton, used so whole program can reference the single Order object
        static readonly Order instance = new Order();
        static Order()
        {
        }
        Order()
        {
        }
        public static Order Instance
        {
            get
            {
                return instance;
            }
        }
        #endregion
        #region Order Class member variables
        // Private singleton member variables
        private int orderId;
        public int OrderId
        {
            get { return orderId; }
            set
            {
                if (value > 0)
                    orderId = value;
            }
        }
        #endregion
        #region Order functions
        /**
         * Ideas : Change Order Information from one customer to another after completing it
         * Send order to database
         * Void order
         * Clear order
         * ...
         */
        #endregion
    }
}
