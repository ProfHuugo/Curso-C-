using System;
using System.Globalization;
using Course.Entities;
using Course.Entities.Exception;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
          try
          {  
            Console.WriteLine("Enter account data !");
            Console.Write("Number:  ");
            int number = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Holder:  ");
            string holder = Console.ReadLine() ?? " ";
            Console.Write("Initial balance:  ");
            double balance = double.Parse(Console.ReadLine() ?? "0.0", CultureInfo.InvariantCulture);
            Console.Write("Withdraw limit:  ");
            double withDrawLimit = double.Parse(Console.ReadLine() ?? "0.0", CultureInfo.InvariantCulture);

            Account account = new Account(number, holder, balance, withDrawLimit);
            
            Console.WriteLine();
            Console.Write("Enter amount for withdraw:  ");
            double amount = double.Parse(Console.ReadLine() ?? "0.0", CultureInfo.InvariantCulture);

            account.WithDraw(amount);
            Console.WriteLine("New balance:" + account.Balance.ToString("F2", CultureInfo.InvariantCulture));
          }
          catch (DomainException e)
          {
            Console.WriteLine("Withdraw error: " + e.Message);
          }
          catch (Exception e )
          {
            Console.WriteLine("Withdraw error:" + e.Message);
          }

        }
    }
}