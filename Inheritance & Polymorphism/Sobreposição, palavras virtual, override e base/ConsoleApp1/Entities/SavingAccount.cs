﻿using System;

namespace ConsoleApp1.Entities
{
     class SavingAccount : Account
    {
        public double InterestRate { get; protected set; }

        public SavingAccount()
        {

        }

        public SavingAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public sealed override void Withdraw(double amount)
        {
           base.Withdraw(amount);
            Balance -= 2.0;
        }
    }
}
