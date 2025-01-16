using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities
{
    class Employee
    {

        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public double Salary { get; set; }


        public Employee(string name, string email, double salary)
        {
            Name = name;
            Email = email;
            Salary = salary;
        }


    }
}
