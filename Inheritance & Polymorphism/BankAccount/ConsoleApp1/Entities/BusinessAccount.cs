using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Entities
{
     class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount(int number, string holder, double balance, double loanLimit)
        {
            LoanLimit = loanLimit;
        }
    }

 }
