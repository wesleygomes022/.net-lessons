using System;
using TestProj.Entities.Exceptions;
using TestProj.Entities;

namespace TestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial balance: ");
            double balance = double.Parse(Console.ReadLine());
            Console.Write("Withdraw limit: ");
            double wthdrwLmt = double.Parse(Console.ReadLine());

            try
            {
                Account ac = new Account(number, holder, balance, wthdrwLmt);
                Console.Write("\nEnter amount for withdraw: ");
                double withdraw = double.Parse(Console.ReadLine());
                ac.WithDraw(withdraw);
                Console.WriteLine();
                Console.WriteLine(ac);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
