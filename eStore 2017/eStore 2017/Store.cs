using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrollerStore
{
    public static class Store
    {
        /// <summary>
        /// estore creates an account for the customer
        /// </summary>
        /// <param name="emailAddress">email address of the customer</param>
        /// <param name="customerName">first name of the customer</param>
        /// <param name="lastName">Last name of the customer</param>
        /// <param name="contactnumber">phone number of the customer</param>
        /// <returns>returns</returns>
        public  static Customer CreateCustomer(string emailAddress,string customerName,string lastName,string contactNumber)
        {
            var customer = new Customer();
            customer.EmailAddress = emailAddress;
            customer.CustomerName = customerName;
            customer.LastName = lastName;
            customer.ContactNumber = contactNumber;
            return customer;
        }

    }
}
