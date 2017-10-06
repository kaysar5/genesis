using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrollerStore
{
    public static class Store
    {
        private static List<Customer> customers = new List<Customer>();
        /// <summary>
        /// estore creates an account for the customer
        /// </summary>
        /// <param name="emailAddress">email address of the customer</param>
        /// <param name="customerName">first name of the customer</param>
        /// <param name="lastName">Last name of the customer</param>      
        /// <returns>returns</returns>
        public  static Customer CreateCustomer(string emailAddress,string customerName,string lastName)
        {
            var customer = new Customer();
            customer.EmailAddress = emailAddress;
            customer.CustomerName = customerName;
            customer.LastName = lastName;
            customers.Add(customer);
            return customer;
        }

        public static List<Customer> GetAllCustomers()
        {
            return customers;
        }
        private static List<Product> products = new List<Product>();
        /// <summary>
        /// Factory for Products
        /// </summary>
        /// <param name="productName">name of the product</param>
        /// <param name="productCode">lists Product code for each product</param>
        /// <param name="productPrice">price of the product</param>
        /// <returns>returns the new product</returns>
        public static Product CreateProduct(string productName,  decimal price)
        {
            var product = new Product(price);
            
            product.ProductName = productName;          

            products.Add(product);
            return product;
        }
        public static List<Product> GetAllProducts()
        {
            return products;
        }

        }
           
            
        }
    
    
    

