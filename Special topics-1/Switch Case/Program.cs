using System;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                 ***Welcome to the week's day verifier***");
            Console.WriteLine("\nType the week's day: ");
            var x = int.Parse(Console.ReadLine());
            var day = "";

            switch (x)
            {
                case 1:
                    day = "sunday";
                    break;
                case 2:
                    day = "Monday";
                    break;
                case 3:
                    day = "Tuesday";
                    break;
                case 4:
                    day = "Wednesday";
                    break;
                case 5:
                    day = "Thursday";
                    break;
                case 6:
                    day = "Friday";
                    break;
                case 7:
                    day = "Saturday";
                    break;
                default:
                    day = "Inválid value";
                    break;

            }
            Console.Clear();
            Console.WriteLine("Day: " + day);

        }
    }
}