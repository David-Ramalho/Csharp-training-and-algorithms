using System;
using System.Collections.Generic;
using System.Globalization;

namespace ConsoleApp1.entities
{
	class Account
	{
		public int Number { get; set; }
		public string Holder { get; set; }
		private double Balance { get; set; }
		public double WithDrawLimit { get; set; }

		public Account(int number, string holder, double balance, double withDrawLimit)

		{
			Number = number;
			Holder = holder;
			Balance = balance;
			WithDrawLimit = withDrawLimit;
		}

		public double deposit(double amount)
		{
			return Balance += amount;
		}

		public double withDraw(double amount)
		{
			return Balance -= amount;
		}
	}
}

