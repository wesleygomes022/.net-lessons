using System;

namespace TestProj.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct(string name, double price, DateTime manuDate) : 
            base(name, price)
        {
            ManufactureDate = manuDate;
        }

        public override string PriceTag()
        {
            return $"{Name} (used) ${Price.ToString("F2")} (Manufactured date: {ManufactureDate.ToString("dd/MM/yyyy")})";

        }
    }
}
