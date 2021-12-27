using System;
using TestProj.Entities;

namespace TestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new BusinessAccount(1229, "Wesley", 3000.00, 5000.00);
            Account acc2 = new SavingsAccount(1320, "Luis", 3000.00, 10000.00);
            acc1.Withdraw(1000);
            acc2.Withdraw(1000);
            Console.WriteLine(acc1.Balance);            
            Console.WriteLine(acc2.Balance);
        }
    }
}
