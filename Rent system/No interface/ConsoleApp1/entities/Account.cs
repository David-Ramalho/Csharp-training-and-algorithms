using System;
using System.Collections.Generic;
using System.Globalization;

namespace ConsoleApp1.entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithDrawLimit { get; set; }


        public double deposit(double amount)
        {
			return Balance += amount;
		}
        }
    }
}
