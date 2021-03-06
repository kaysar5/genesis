﻿using System;
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
            //Initialize customers
            Store.CreateCustomer("someone@somewhere.com", "Some", "One");
            Store.CreateProduct("Single Stroller", (decimal)250);
            Store.CreateProduct("Double Stroller", (decimal)350);
            Store.CreateProduct("Triple Stroller", (decimal)400);
            Store.CreateProduct("Jogger Stroller", (decimal)200);



            Console.WriteLine("*********************");
            Console.WriteLine("Welcome to Stroller Store");
            Console.WriteLine("*************************");
            while (true)
            {


                Console.WriteLine("Please choose an option");
                Console.WriteLine("0.Exit");
                Console.WriteLine("1.Create a customer account");
                Console.WriteLine("2.Show products");
                Console.WriteLine("3.Create Order");
                Console.WriteLine("4.Check the order status");
                Console.WriteLine("5.Make a payment");


                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "0":
                        return;

                    case "1":
                        Console.Write("Customer Name:");
                        var customerName = Console.ReadLine();
                        Console.Write("Last Name:");
                        var lastName = Console.ReadLine();
                        Console.Write("Email Address:");
                        var emailAddress = Console.ReadLine();
                        var customer = Store.CreateCustomer(customerName, lastName, emailAddress);
                        Console.WriteLine($"CustomerID:{customer.CustomerId}");
                        break;

                    case "2":
                        Product chosenProduct = ShowProduct();
                        break;

                    case "3":
                        Console.WriteLine($"CustomerID:");
                        var customerId = Console.ReadLine();
                        int custId;

                        try
                        {
                            custId = Int32.Parse(customerId);
                        }
                        catch (System.FormatException e)
                        {
                            Console.WriteLine("Error in input; failed due to error in formatting:{0} ", e.Message);
                            break;
                        }

                        Console.WriteLine("Product Code");
                        var productCode = Console.ReadLine();
                        int pdCode;
                        try
                        {
                            pdCode = Int32.Parse(productCode);
                        }
                        catch(System.FormatException e)
                        {
                            Console.WriteLine("Error in input; failed due to error in formatting:{0}",e.Message);
                            break;
                        }

                        Console.WriteLine("Quantity");
                        var quantity = Console.ReadLine();
                        
                        
                            var order= Store.CreateOrder(Int32.Parse(customerId), Int32.Parse(productCode), TypeOfStatus.Complete, Int32.Parse(quantity));
                        
                        
                        Console.WriteLine();                      


                        break;                
                                            
                    case "4":
                        Console.WriteLine("Orderstatus");
                        var orderStatus = Enum.GetNames(typeof(TypeOfStatus));
                        for (int i = 0; i < orderStatus.Length; i++)
                        {
                            Console.WriteLine($"{i}.{orderStatus[i]}");
                        }
                        var orderType = (TypeOfStatus)Enum.Parse(typeof(TypeOfStatus), Console.ReadLine());
                        break;
                    case "5":
                        Console.WriteLine("Payment Type:");
                        var paymentTypes = Enum.GetNames(typeof(TypeOfPayment));
                        for (int i = 0; i < paymentTypes.Length; i++)
                        {
                            Console.WriteLine($"{i}.{paymentTypes[i]}");
                        }
                        var accountType = (TypeOfPayment)Enum.Parse(typeof(TypeOfPayment), Console.ReadLine());
                        break;

                    default:
                        break;
                }
            }

        }

        private static Product ShowProduct()
        {
            Console.WriteLine("Here are the choices: ");
            var productList = Store.GetAllProduct();
            int i = 0;
            foreach (Product p in productList)
            {
                Console.WriteLine(i++);
                p.print();
            }
            Console.Write("Your Choice: ");
            int answer = Int32.Parse(Console.ReadLine());
            
            return productList[answer-1];


        }
    }
   
}
