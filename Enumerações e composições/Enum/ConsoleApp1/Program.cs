using System;
using ConsoleApp1.Entities;
using ConsoleApp1.Entities.Enums;
using System.Globalization;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = -1;
            Console.Clear();
            Department dept = new Department();
            Worker worker = new Worker();
            HourContract contract = new HourContract();

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

                    dept = new Department(dptName);
                    worker = new Worker(name, level, baseSalary, dept);
                }

                else if (i == 2)
                {
                    Console.Clear();
                    Console.WriteLine("How many constracts will be add?");
                    int n = int.Parse(Console.ReadLine());

                    for (int j = 0; j < n; j++)
                    {
                        int c = j + 1;
                        Console.WriteLine("Enter " + c + " contract data:");
                        Console.WriteLine("Date(DD/MM/YYYY): ");
                        DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        Console.WriteLine("Value per hour: ");
                        double valuePerhour = double.Parse(Console.ReadLine());
                        Console.WriteLine("Duration(hours): ");
                        int hours = int.Parse(Console.ReadLine());

                        contract = new HourContract(date, valuePerhour, hours);                         
                        worker.AddContract(contract);
                    }

                }
                else if (i == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Enter month and year to calculate income(MM/YYYY):");
                    string MandY = Console.ReadLine();
                    int month = int.Parse(MandY.Substring(0, 2));
                    int year = int.Parse(MandY.Substring(3));
                    
                    Console.WriteLine("Work info: " + worker);
                    Console.WriteLine("Income for " + MandY + ": " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));

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
