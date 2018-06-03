using System;
using Xunit;
using LabT1;

namespace LabT1Test
{
    public class UnitTest1
    {
        [Fact]
        public void ShouldSetBalance()
        {
            Account account1 = new Account(1000);
            Assert.Equal(1000, account1.Balance);
        }


        [Fact]//Deposit
        public void ShouldAddAmountToBalance()
        {
            Account account = new Account(10);
            account.Deposit(2);
            double expected = 12;
            double actual = account.Balance;
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ShoulReturnErrorMessageWhenDepositingUnderOneKr()
        {
            Account account = new Account(10); 
            account.Deposit(0);
            string expected = Console.WriteLine("You can't deposit less than 1kr, try again");
        }


    }
}
