using System;
using System.Collections.Generic;
using System.Text;

namespace LabT1
{
    public class Account
    {
        public double initialBalance;
        public double Balance
        {
            get { return initialBalance; }
            private set { initialBalance = value; }
        }

        public Account(double initialBalance)
        {
            this.initialBalance = initialBalance;
        }

        public void Deposit(double amount)
        {
            if (double.IsNaN(amount))
            {
                throw new Exception("Can't deposit a value that isnt a number");
            }
            else if (double.IsInfinity(amount) || double.IsNegativeInfinity(amount) || double.IsPositiveInfinity(amount))
            {
                throw new Exception("Wow you got alot of money! here's my paypal:");
            }
            else if (amount <= 0)
            {
                throw new Exception("Must deposit a value that is greater than 0");
            }
            else Balance += amount;
            
        }

        public void Withdraw(double amount)
        {
            if(Balance >= amount)
            {
                Balance -= amount;
            }

        }

        public bool Transfer(Account target, double amount)
        {
            Balance -= amount;
            target.Balance += amount;
            return true;
        }


    }
}
