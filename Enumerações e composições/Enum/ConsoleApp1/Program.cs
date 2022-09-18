using System;

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
                i=int.Parse(Console.ReadLine());

                if(i == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Resgister");
                    Console.ReadKey();
                }

                else if(i == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Adding contracts");
                    Console.ReadKey();
                }
                else if (i == 3)
                {
                    Console.Clear();
                    Console.WriteLine("Calculating income");
                    Console.ReadKey();
                }
                else if (i ==0)
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
