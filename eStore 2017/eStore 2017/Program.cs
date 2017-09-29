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

           var customer= Store.CreateCustomer("test@test.com", "Mike", "Jo", "2314445678");

            Console.WriteLine($"CI:{customer.CustomerId}, CN:{customer.CustomerName}, CL:{customer.LastName},CN:{customer.ContactNumber},EA:{customer.EmailAddress}");

            var customer2 = new Customer();
            Console.WriteLine($"CI:{customer2.CustomerId}, CN:{customer2.CustomerName}, CL:{customer2.LastName},CN:{customer2.ContactNumber},EA:{customer2.EmailAddress}");

            var product = new Product(200)
            {
                ProductName = "Single Stroller"
            };

           
            
           
            


            var order = new Order();
            order.OrderedProduct = product;
            order.OrderStatus = "Pending";
            order.Quantity = 4;

            var cart = new Cart();
            cart.RemoveItems = 4;
            cart.AddItems = 2;
            cart.TotalItems = 3;





            Console.WriteLine($"PN:{product.ProductName},PC:{product.ProductCode},PP:{product.ProductPrice},IA:{product.IsActive}");
            var product2 = new Product(200);

            Console.WriteLine($"CI:{customer.CustomerId}, CN:{customer.CustomerName}, CL:{customer.LastName},CN:{customer.ContactNumber},EA:{customer.EmailAddress}");
            Console.WriteLine($"CI:{customer2.CustomerId}, CN:{customer2.CustomerName}, CL:{customer2.LastName},CN:{customer2.ContactNumber},EA:{customer2.EmailAddress}");
            Console.WriteLine($"PN:{product.ProductName},PC:{product.ProductCode},PP:{product.ProductPrice}");
            var product2 = new Product(100);


            Console.WriteLine($"PN:{product2.ProductName},PC:{product2.ProductCode},PP:{product2.ProductPrice}");

            Console.WriteLine($"OP:{order.OrderedProduct.ProductName},OS:{order.OrderStatus},,OQ: {order.Quantity}OT:{order.OrderTotal()}");





        }       


    }
   
}
