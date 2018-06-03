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
            private set { initialBalance += value; }
        }

        public Account(double initialBalance)
        {
            this.initialBalance = initialBalance;
        }

        public void Deposit(double amount)
        {
            try
            {
                Balance = amount;
            }
            catch (OverflowException)
            {
                Console.WriteLine("You got too much money, open a new account!");
            }
            
            if(amount > 1)
            {
                Console.WriteLine("You can't deposit less than 1kr, try again");
            }
            

        }

    }
}
