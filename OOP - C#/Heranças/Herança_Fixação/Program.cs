using System;
using System.Globalization;
using Course.Entities;

namespace Course
{
    class Programs
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine() ?? "0");

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char type = char.Parse(Console.ReadLine() ?? "t");
                Console.Write("Name: ");
                    string name = Console.ReadLine() ?? " ";
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine() ?? "0.0",CultureInfo.InvariantCulture);

                if (type == 'i')
                {
                    
                    Console.Write("Customs free: ");
                    double customsFree = double.Parse(Console.ReadLine() ?? "0.0",CultureInfo.InvariantCulture);

                    products.Add(new ImportedProduct(name, price, customsFree));

                }
                else if (type == 'c')
                {

                    products.Add(new Product(name, price));

                }
                else
                {

                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine() ?? "dd/MM/yyyy");

                    products.Add(new UsedProduct(name, price, manufactureDate));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS: ");
            foreach (Product prod in products)
            {
                Console.WriteLine(prod.PriceTag());
            }


        }
    }
}