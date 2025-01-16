using System;
using Course.Entites.Enums;

namespace Course.Entites
{
    abstract class Shape
    {
        public Color Color { get; set; }



        public Shape(Color color)
        {  
            Color = color;
        }

        public abstract double Area();
        
    }
}