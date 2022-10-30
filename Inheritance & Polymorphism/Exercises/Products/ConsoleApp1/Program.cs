using System;
using System.Globalization;
using System.Collections.Generic;
using ConsoleApp1.Entities;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            Console.WriteLine("Enter the number of products:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data: ");
                Console.WriteLine("Common, used or imported (c/u/i)?");
                char ch = char.Parse(Console.ReadLine());
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);

                if (ch == 'i')
                {
                    Console.WriteLine("Customs fee: ");
                    double fee = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
                    list.Add(new ImportedProduct(name, price, fee));
                }
                else if (ch == 'u')
                {
                    Console.WriteLine("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(name, price, date));
                }
                else
                {
                    list.Add(new Product(name, price));
                }
            }
            Console.WriteLine("Products: ");
            foreach(Product product in list)
            {
                Console.WriteLine(product.Name +"$"+product.Price);
            }
            
        }
    }
}
