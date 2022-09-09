using System;
using System.Globalization;

namespace Date_time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime d1=DateTime.Now;
            DateTime d2 = new DateTime(2018,11,25,20,45,3);
            DateTime d3 = DateTime.Today;
            DateTime d4 = DateTime.UtcNow;

            DateTime d5 = DateTime.Parse("2000-08-15");
            DateTime d6 = DateTime.ParseExact("15-08-2000 13:05:58", "dd-MM-yyyy HH:mm:ss",CultureInfo.InvariantCulture);



            Console.WriteLine("Atual: "+ d1);
            //Console.WriteLine("Atual: " + d1.Ticks);
            Console.WriteLine("d2: " + d2);
            Console.WriteLine("d3: " + d3);
            Console.WriteLine("utcnow: " + d4);
            Console.WriteLine("d5: " + d5);
            Console.WriteLine("d6: " + d6);
            Console.WriteLine("\n");
            

            TimeSpan t1 = new TimeSpan(10, 15, 20);
            Console.WriteLine(t1);
            Console.WriteLine(t1.Ticks);

            TimeSpan t2 = new TimeSpan();
            TimeSpan t3 = new TimeSpan(90000000l);
            TimeSpan t4 = new TimeSpan(5,2,11,21);


            Console.WriteLine(t3);
            Console.WriteLine(t4);

            TimeSpan t5 = TimeSpan.FromDays(2.9);

            Console.WriteLine(t5);

        }
    }
}
