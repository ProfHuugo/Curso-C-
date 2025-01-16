using System;
using System.Globalization;
using System.Collections.Generic;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<People> list = new List<People>();
            
            Console.Write("Enter the number of tax payers:  ");
            int n = int.Parse(Console.ReadLine() ?? "0");

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)?  ");
                char ch = char.Parse(Console.ReadLine() ?? "ch");
                Console.Write("Name:  ");
                string name = Console.ReadLine() ?? " ";
                Console.Write("Anual income:  ");
                double annualIncome = double.Parse(Console.ReadLine() ?? "0.0", CultureInfo.InvariantCulture);

                if (ch == 'i')
                {
                    Console.Write("Health expenditures:  ");
                    double healthExpenditures = double.Parse(Console.ReadLine() ?? "0.0", CultureInfo.InvariantCulture);

                    list.Add(new Individual(name, annualIncome, healthExpenditures));
                }
                else
                {
                    Console.Write("Number of employees:  ");
                    int numberOfEmloyees = int.Parse(Console.ReadLine() ?? "0");

                    list.Add(new Company(name, annualIncome, numberOfEmloyees));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            
            foreach (People tax in list)
            {
                Console.WriteLine(tax.Name + ":  $ " + tax.PayTax().ToString("F2", CultureInfo.InvariantCulture));
            }

            double sum = 0.0;

            foreach (People tax in list)
            {
                sum += tax.PayTax(); 
            }

            Console.WriteLine();    
            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}