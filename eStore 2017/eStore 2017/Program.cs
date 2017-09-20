using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrollerStore
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate an object
            var customer = new Customer();
            //customer.CustomerId = 1205;
            customer.CustomerName = "Molly";
            customer.LastName = "Simon";
            customer.ContactNumber = "2467651234";
            customer.EmailAddress = "test@test.com";

            Console.WriteLine($"CI:{customer.CustomerId}, CN:{customer.CustomerName}, CL:{customer.LastName},CN:{customer.ContactNumber},EA:{customer.EmailAddress}");

            var customer2 = new Customer();
            Console.WriteLine($"CI:{customer2.CustomerId}, CN:{customer2.CustomerName}, CL:{customer2.LastName},CN:{customer2.ContactNumber},EA:{customer2.EmailAddress}");



        }
    }
}
