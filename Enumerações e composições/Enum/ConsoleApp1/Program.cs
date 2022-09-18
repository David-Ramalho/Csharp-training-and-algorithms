using System;
using ConsoleApp1.Entities;
using ConsoleApp1.Entities.Enums;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = -1;
            Console.Clear();
            while (i != 0)
            {
                Console.Clear();
                Console.WriteLine("                   ***Welcome to the Workers controller***");
                Console.WriteLine("\nChoose the best option:");
                Console.WriteLine("1-Register employee\n2-Add contracts\n3-Calculate employee's Income\n0-Exit");
                i = int.Parse(Console.ReadLine());

                if (i == 1)
                {
                    Console.Clear();

                    Console.WriteLine("Enter department's name: ");
                    string dptName = Console.ReadLine();
                    Console.WriteLine("Enter Worker Data Below:");
                    Console.WriteLine("Name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Level(Junior/MidLevel/Senior): ");
                    WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
                    Console.WriteLine("Base Salary: ");
                    double baseSalary = double.Parse(Console.ReadLine());

                }

                else if (i == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Adding contracts");

                }
                else if (i == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Calculating income");

                }
                else if (i == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Exiting");
                }
                else Console.WriteLine("Invalid option!\n try again");
                Console.ReadKey();
            }
        }
    }
}
