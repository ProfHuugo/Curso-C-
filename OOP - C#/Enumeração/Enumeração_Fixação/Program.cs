﻿using System;
using Course.Entities;
using Course.Entities.Enums;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Client data:");
            Console.Write("Name: ");
            string clientName = Console.ReadLine() ?? "";

            Console.Write("Email: ");
            string email = Console.ReadLine() ?? "";

            Console.Write("Birth Date (DD/MM/YYYY): ");
            DateTime birhtDate = DateTime.Parse(Console.ReadLine() ?? " ");

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine() ?? "");
            

            Client client = new Client(clientName, email, birhtDate);
            Order order = new Order(DateTime.Now, status, client);

            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine() ?? "");
            
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data: ");
                Console.Write("Product name: ");
                string productName = Console.ReadLine() ?? " ";
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine() ?? " ", CultureInfo.InvariantCulture);

                Product product = new Product(productName, price);


                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine() ?? " ");

                OrderItem orderItem = new OrderItem(quantity, price, product);
                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);


        }
    }
}
