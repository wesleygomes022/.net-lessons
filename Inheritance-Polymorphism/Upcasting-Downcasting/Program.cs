﻿using System;
using TestProj.Entities;

namespace TestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.00);

            //UPCASTING
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Bob", 0.0, 200.00);
            Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01);

            //DOWNCASTING
            //BusinessAccount acc4 = (BusinessAccount) acc2; -> other form of casting declaration
            BusinessAccount acc4 = acc2 as BusinessAccount;
            //Console.Write(acc4.LoanLimit);

            if(acc3 is BusinessAccount)
            {
                BusinessAccount acc5 = acc3 as BusinessAccount;
                acc5.Loan(350.00);
                Console.WriteLine("Loan!");
            }

            if(acc3 is SavingsAccount)
            {
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");
            }
        }
    }
}
