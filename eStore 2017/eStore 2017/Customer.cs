using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eStore_2017
{
    #region Properties
    /// <summary>
    /// customer details
    /// </summary>
    class Customer
    {
        /// <summary>
        /// Customer's identification number
        /// </summary>
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        /// <summary>
        /// This the customer's email address
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// This the customer's phone number
        /// </summary>
        public int ContactNumber { get; set; }
        
       
# endregion



    }
}
