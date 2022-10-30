using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Entities
{
    internal class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price,DateTime manufactureDate)
        : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override double PriceTag()
        {
            return base.PriceTag();
        }
    }

}
