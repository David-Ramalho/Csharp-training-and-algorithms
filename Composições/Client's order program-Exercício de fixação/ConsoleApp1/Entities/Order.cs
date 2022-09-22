using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1.Entities.Enums;

namespace ConsoleApp1.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Produtos { get; set; } = new List<OrderItem>();

        public Order(DateTime moment, OrderStatus status, Client Client)
        {
            Moment = moment;
            Status = status;
        }

        public void AddItem(OrderItem produto)
        {
            Produtos.Add(produto);
        }
        public void RemoveItem(OrderItem produto)
        {
            Produtos.Remove(produto);
        }

        public double Total ()
        {
            double sum = 0.0;
            foreach(OrderItem produto in Produtos)
            {
                sum += produto.SubTotal();
            }
            return sum;
        }
    }
}
