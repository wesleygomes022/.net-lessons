﻿using System;

namespace TestProj.Entities
{
    class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }
        public double TotalPayment 
        {
            get { return BasicPayment + Tax; }
        }

        public override string ToString()
        {
            return $"Basic Payment: {BasicPayment};\n" +
                $"Tax: {Tax};\n" +
                $"Total Payment: {TotalPayment.ToString("F2")}";
        }
    }
}
