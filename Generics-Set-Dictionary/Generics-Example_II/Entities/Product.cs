using System;
using System.Collections.Generic;

namespace TestProj.Entities
{
    class Product : IComparable
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public int CompareTo(Object? obj)
        {
            Product temp = obj as Product;
            return Price.CompareTo(temp.Price);
        }

        public override string ToString()
        {
            return Name + ", " + Price;
        }
    }
}
