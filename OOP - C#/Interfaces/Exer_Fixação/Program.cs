using System;
using System.Globalization;
using Course.Entities;
using Course.Services;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number:  ");
            int number = int.Parse(Console.ReadLine() ?? "0");
            Console.Write("Date (dd/MM/yyyy):  ");
            DateTime date = DateTime.ParseExact(Console.ReadLine() ?? " ","dd/MM/yyyy",CultureInfo.InvariantCulture);
            Console.Write("Contract value:  ");
            double value = double.Parse(Console.ReadLine() ?? "0.00",CultureInfo.InvariantCulture);
            Console.Write("Enter number of installments:  ");
            int months = int.Parse(Console.ReadLine() ?? "0");

            Contract myContract = new Contract(number, date, value);

            ContractService contractService = new ContractService(new PaypalService());
            contractService.ProcessContract(myContract, months);

            Console.WriteLine("Installments:  ");
            foreach (Installment installment in myContract.Installments)
            {
                Console.WriteLine(installment);
            }

        }
    }
}