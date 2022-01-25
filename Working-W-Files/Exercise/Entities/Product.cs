using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProj.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }

        public Product()
        { }

        public Product(string name, double price, double qtd)
        {
            Name = name;
            Price = price;
            Quantity = qtd;
        }

        public double TotalPrice()
        {
            return Price * Quantity;
        }
    }
}
