using System.Globalization;

namespace Course.Entities
{
    class Employee
    {
        public string Name { get; set; } = string.Empty;
        public int Hours { get; set; }
        public double ValuePerHour  { get; set; }


        public Employee()
        {

        }


        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual double Payment()
        {
            return ValuePerHour * Hours;
        }
            

        public override string ToString()
        {
            return Name
                + " - $"
                + Payment().ToString("F2",CultureInfo.InvariantCulture);
        }
    }
}