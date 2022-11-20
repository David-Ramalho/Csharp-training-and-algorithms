using System;
using System.Collections.Generic;
using ConsoleApp1.Entities.Enums;

namespace ConsoleApp1.Entities
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;

        }
    }
}

