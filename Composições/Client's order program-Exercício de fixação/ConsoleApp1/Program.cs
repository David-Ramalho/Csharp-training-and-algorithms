using System;
using ConsoleApp1.Entities.Enums;
using ConsoleApp1.Entities;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client's Data: ");
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Email: ");
            string email = Console.ReadLine();
            //Console.WriteLine("Birth date(DD/MM/YYYY");
            DateTime birhtDate = DateTime.Now;//DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data");
            Console.WriteLine("Status");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Client client = new Client(name, email, birhtDate);
            Order order = new Order(DateTime.Now, status, client);

            Console.WriteLine("How many items to this order?");
            int n = int.Parse(Console.ReadLine());
            int i = 0;
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("Enter " + n + "° Item Data: ");
                Console.WriteLine("Product name: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Product price: ");
                double preco = double.Parse(Console.ReadLine());

                Product produto = new Product(nome, preco);

                Console.WriteLine("Quantity: ");
                int quant = int.Parse(Console.ReadLine());

                OrderItem item = new OrderItem(quant, preco, produto);

                order.AddItem(item);
            }
            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);




        }
    }
}
