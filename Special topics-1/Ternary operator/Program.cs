using System;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("             ***Welcome to the discount Card program***");
            Console.WriteLine("\nType the products value: ");
            double price= double.Parse(Console.ReadLine());

            double discount = (price < 20) ? price * 0.1 : price * 0.05;
            Console.WriteLine("\nDiscount: " + discount+"$");

        }
    }
}
