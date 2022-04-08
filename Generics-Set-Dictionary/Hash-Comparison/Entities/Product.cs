using System;

namespace TestProj
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public override string ToString()
        {
            return $"Name: {Name}, Price: {Price}";
        }

        /*public override int GetHashCode()
        {
            return Name.GetHashCode() + Price.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            Product temp = obj as Product;
            return Name.Equals(temp.Name) && Price.Equals(temp.Price);
        }*/
    }
}
