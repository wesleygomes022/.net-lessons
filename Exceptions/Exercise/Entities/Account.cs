using System;
using TestProj.Entities.Exceptions;

namespace TestProj.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void WithDraw(double amount)
        {
            if(amount > WithdrawLimit)
            {
                throw new DomainException("Withdraw error: The amount exceeds withdraw limit.");
            }
            else if(amount > Balance)
            {
                throw new DomainException("Withdraw error: Not enough balance.");
            }

            Balance -= amount;
        }

        public override string ToString()
        {
            return "Number: " + Number +
                "\nHolder: " + Holder +
                "\nBalance: " + Balance.ToString("F2") +
                "\nWithdraw Limit: " + WithdrawLimit.ToString("F2");
        }
    }
}
