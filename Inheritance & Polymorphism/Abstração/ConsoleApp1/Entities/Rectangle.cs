using System;
using System.Collections.Generic;
using ConsoleApp1.Entities.Enums;

namespace ConsoleApp1.Entities
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height, Color color) : base(color)
        {
            Width = width;
            Height = height;
        }
        public override double Area()
        {
            return Width * Height;
            //throw new NotImplementedException();
        }
    }
}
