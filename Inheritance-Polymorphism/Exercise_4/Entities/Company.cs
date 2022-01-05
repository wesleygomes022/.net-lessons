using System;

namespace TestProj.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company(string name, double anualIncome, int numEmployee)
            : base(name, anualIncome)
        {
            NumberOfEmployees = numEmployee;
        }

        public override double Tax()
        {
            if(NumberOfEmployees > 10)
            {
                return AnualIncome * 0.14;
            }
            else
            {
                return AnualIncome * 0.16;
            }
        }
    }
}
