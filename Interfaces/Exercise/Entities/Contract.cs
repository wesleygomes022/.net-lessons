using System;
using System.Collections.Generic;

namespace TestProj.Entities
{
    class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public LinkedList<Installment> Installments { get; set; } 

        public Contract(int number, DateTime date, double totalValue, int nIntmts)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            Installments = new LinkedList<Installment>();
        }

        public void Print()
        {
            foreach(Installment el in Installments)
            {
                Console.WriteLine(el);
            }
        }
    }
}
