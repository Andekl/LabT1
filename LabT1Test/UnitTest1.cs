using System;
using Xunit;
using LabT1;

namespace LabT1Test
{
    public class UnitTest1
    {
        Account account = new Account(10);
        [Fact]
        public void ShouldSetBalance()
        {
            Account account = new Account(1000);
            Assert.Equal(1000, account.Balance);
        }


        [Fact]//Deposit
        public void ShouldAddAmountToBalance()
        {            
            account.Deposit(2);
            double expected = 12;
            double actual = account.Balance;
            Assert.Equal(expected, actual);
        }

        [Fact]//Deposit
        public void ShouldHandleDepositIfAmountIsNan()
        {
            Assert.Throws<Exception>(() =>
            {
                account.Deposit(double.NaN);
            });
        }

        [Fact]//Deposit
        public void ShouldHandleDepositIfAmountIsPositiveInfinity()
        {
            Assert.Throws<Exception>(() =>
            {
                account.Deposit(double.PositiveInfinity);
            });
        }

        [Fact]//Deposit
        public void ShouldHandleDepositIfAmountIsNegativeInfinity()
        {
            Assert.Throws<Exception>(() =>
            {
                account.Deposit(double.NegativeInfinity);
            });
        }

        [Fact]//Deposit
        public void ShouldHandeDepositIfAmountIsZero()
        {
            Assert.Throws<Exception>(() =>
            {
                account.Deposit(-1);
            });
        }

        [Fact]//Deposit
        public void ShouldHandeDepositIfAmountIsLessThanZero()
        {
            Assert.Throws<Exception>(() =>
            {
                account.Deposit(0);
            });
        }        


        [Fact]//Withdraw
        public void ShouldWithdrawAmountFromBalance()
        {
            account.Withdraw(2);
            double exptected = 8;
            double actual = account.Balance;
            Assert.Equal(exptected, actual);
        }

        [Fact]//Transfer
        public void TransferAmountFromAccountTooAccountB()
        {
            Account account = new Account(100);
            Account accountB = new Account(20);
            account.Transfer(accountB, 50);
            
            double expectedAccountBalanceAfterTransfer = 50;
            double actualAccountBalanceAfterTransfer = account.Balance;
            Assert.Equal(expectedAccountBalanceAfterTransfer, actualAccountBalanceAfterTransfer);

            double exptectedAccountB_Balance = 70;
            double actualAccountB_Balance = accountB.Balance;
            Assert.Equal(exptectedAccountB_Balance, actualAccountB_Balance);
        }
      


    }
}
