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

            var product = new Product();
            product.ProductName = "Single Stroller";
            //product.ProductCode = 531;
            //product.ProductPrice = 400;

            //product.IsActive = true;

            Console.WriteLine($"PN:{product.ProductName},PC:{product.ProductCode},PP:{product.ProductPrice},IA:{product.IsActive}");
            var product2 = new Product();

            Console.WriteLine($"PN:{product2.ProductName},PC:{product2.ProductCode},PP:{product2.ProductPrice},IA:{product2.IsActive}");



        }       


    }
   
}
