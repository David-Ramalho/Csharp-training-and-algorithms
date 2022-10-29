using System;
using System.Collections.Generic;
using ConsoleApp1.Entities;
using System.Globalization;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.WriteLine("Enter the number of employee: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i} data: ");
                Console.Write("Outsourced (y/n)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.WriteLine("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
                if (ch == 'y')
                {
                    Console.WriteLine("Additional charge: ");                  
                    double additionalCharge= double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);

                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }

                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }

            }

            Console.WriteLine("\nPayments: ");
            foreach (Employee emp in list)
            {
                Console.WriteLine(emp.Name+ "-$"+ emp.Payment().ToString("f2", CultureInfo.InstalledUICulture));
            }
        }
    }
}

