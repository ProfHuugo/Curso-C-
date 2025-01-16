using System;
using System.Globalization;
using System.Collections.Generic;

namespace Course.Entities
{
    class Product : IComparable<Product>
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name + ", " + Price.ToString("F2",CultureInfo.InvariantCulture);
        }

       public int CompareTo(Product? other)
        {
            if (other == null)
            {
                throw new ArgumentNullException(nameof(other), "Argument is null");
            }

            return Price.CompareTo(other.Price);
        }
    }
}