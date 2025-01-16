using System;

namespace Course.Entities
{
    class Department
    {
        public string Name { get; set; } = string.Empty;

        public Department() 
        {

        }  

        public Department(string name)
        {
            Name = name;
        }
    }
}