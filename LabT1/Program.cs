using System;

namespace LabT1
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(5000);

            account.Deposit(2);
            Console.WriteLine(account.Balance);

            Console.ReadKey();
        }
    }
}
