using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrollerStore
{

    /// <summary>
    /// customer details
    /// </summary>

    public class Customer
    {
        private static int lastCustomerId = 0;

        #region Properties

        /// <summary>
        /// Customer's identification number
        /// </summary>
        public int CustomerId { get; }
        public string CustomerName { get; set; }

        public string LastName { get; set; }
        /// <summary>
        /// This the customer's email address
        /// </summary>
        public string EmailAddress { get; set; }
        

        #endregion

        #region Constructors

        public Customer()
        {
            CustomerId = ++lastCustomerId;
        }

        #endregion
    }

}
