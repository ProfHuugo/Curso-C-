using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Course.Entities;

namespace Course
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path:  ");
            string path = Console.ReadLine() ?? string.Empty;

            Console.Write("Enter salary:  ");
            double salaryUser = double.Parse(Console.ReadLine() ?? "0.00", CultureInfo.InvariantCulture);

            List<Employee> list = new List<Employee>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] dateOfEmployee = (sr.ReadLine() ?? string.Empty).Split(',');
                    string name = dateOfEmployee[0];
                    string email = dateOfEmployee[1];
                    double salary = double.Parse(dateOfEmployee[2], CultureInfo.InvariantCulture);

                    list.Add(new Employee(name, email, salary));
                }
            }

            Console.WriteLine($"Email of people whose salary is more than {salaryUser.ToString("F2", CultureInfo.InvariantCulture)}: ");

            var order = list.Where(p => p.Salary > salaryUser).OrderBy(p => p.Email).Select(p => p.Email);
            foreach (string emails in order)
            {
                Console.WriteLine(emails);
            }

            Console.Write("Sum of salary of people whose name starts with 'M':  ");
            var sum = list.Where(p => p.Name[0] == 'M').Select(p => p.Salary).Sum();
            Console.WriteLine(sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}