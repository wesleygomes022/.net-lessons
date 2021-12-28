using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProj.Entities
{
    //cannot derive class from other sealed class
    class SavingsAccountPlus : SavingsAccount
    {
        //cannot override method because it's sealed
        public override void Withdraw(double amount)
        {
            Console.WriteLine("test");
        }
    }
}
