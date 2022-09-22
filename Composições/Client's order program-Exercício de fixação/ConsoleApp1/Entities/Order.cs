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

        public Order(DateTime moment, OrderStatus status)
        {
            Moment = moment;
            Status = status;
        }

        public void AddItem(OrderItem item)
        {

        }
        public void RemoveItem(OrderItem item)
        {

        }

        public double Total ()
        {

        }
    }
}
