using System;

namespace TestProj.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures)
            : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            if(AnualIncome < 20000)
            {
                double tax = AnualIncome * 0.15;
                if(HealthExpenditures > 0)
                {
                    return tax - HealthExpenditures * 0.50;
                }
                else
                {
                    return tax;
                }
            }
            else
            {
                double tax = AnualIncome * 0.25;
                if (HealthExpenditures > 0)
                {
                    return tax - HealthExpenditures * 0.50;
                }
                else
                {
                    return tax;
                }
            }
        }
    }
}
