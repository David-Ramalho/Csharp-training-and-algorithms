using System;
using ConsoleApp1.Entities;
using ConsoleApp1.Entities.Enums;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };


            Console.WriteLine(order);
            string txt = OrderStatus.PendingPayment.ToString();
            OrderStatus os = Enum.Parse<OrderStatus>("Shipped");
            Console.WriteLine(os);
        }
    }
}


