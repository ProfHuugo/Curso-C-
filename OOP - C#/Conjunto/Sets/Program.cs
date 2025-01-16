using System;
using System.Collections.Generic;
using Course.Entities; // Para usar Course.Entities.Point

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Product> a = new HashSet<Product>();
            a.Add(new Product("Notebook", 1200.0));

            HashSet<Course.Entities.Point> b = new HashSet<Course.Entities.Point>();
            b.Add(new Course.Entities.Point(3, 5));
            b.Add(new Course.Entities.Point(5, 10));

            Product prod = new Product("Notebook", 1200.0);
            Console.WriteLine(a.Contains(prod));

            Course.Entities.Point p = new Course.Entities.Point(5, 10);
            Console.WriteLine(b.Contains(p));

            Console.ReadKey();
        }
    }
}

