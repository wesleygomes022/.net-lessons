using System;
using TestProj.Entities;

namespace TestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount ba = new BusinessAccount(8010, "Bob Brown", 100.00, 500.00);
            Console.WriteLine(ba.Balance);
        }
    }
}
