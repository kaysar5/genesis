using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrollerStore
{
    public static class Store
    {
        private static StoreModel db = new StoreModel();

        
        /// <summary>
        /// 
        /// ore creates an account for the customer
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
            db.Customers.Add(customer);
            db.SaveChanges();
            return customer;
        }

        public static List<Customer> GetAllCustomers(string emailAddress)
        {
            return db.Customers.Where(a=> a.EmailAddress== emailAddress).ToList();
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
            var product = new Product();
            
            product.ProductName = productName;           
            product.ProductPrice = price;
            db.Products.Add(product);
            db.SaveChanges();
            return product;
        }
        public static List<Product> GetProduct(int productCode)
        {
            return db.Products.Where(a => a.ProductCode == productCode).ToList();
        }
        public static List<Product> GetAllProduct()
        {
            return db.Products.ToList();
        }
        /// <summary>
        /// Order created
        /// </summary>
        /// <param name="orderNumber">order number given</param>
        /// <param name="orderStatus">status of the order</param>
        /// <param name="Quantity">total no of ordered products</param>
        /// <returns>returns</returns>
        public static Order CreateOrder(int orderNumber, string orderStatus, int Quantity)
        {
            var order = new Order();
            order.OrderNumber = orderNumber;
            order.OrderStatus = orderStatus;
            order.Quantity = Quantity;
            db.Orders.Add(order);
            db.SaveChanges();
            return order;
        }
        public static List<Order> GetAllOrders(int orderNumber)
        {
            return db.Orders.Where(a => a.OrderNumber == orderNumber).ToList();
        }
    }          
            
        }
    
    
    

