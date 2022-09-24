using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp1.Entities.Enums;
using System.Globalization;

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
            this.Client = Client;
        }

        public void AddItem(OrderItem produto)
        {
            Produtos.Add(produto);
        }
        public void RemoveItem(OrderItem produto)
        {
            Produtos.Remove(produto);
        }

        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItem produto in Produtos)
            {
                sum += produto.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToString("dd/mm/yyyy hh:mm:ss"));
            sb.AppendLine("Order Status: " + Status);
            sb.AppendLine("Client :" + Client);
            sb.AppendLine("Order items: ");
            foreach (OrderItem product in Produtos)
            {
                sb.Append(product.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }

    }
}
