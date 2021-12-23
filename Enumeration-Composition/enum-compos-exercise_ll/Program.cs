using System;
using TestProj.Entities;
using TestProj.Entities.Enum;

namespace TestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Client data:");
            Client c = new Client();
            Order order = new Order();

            Console.Write("Name: ");
            c.Name = Console.ReadLine();
            Console.Write("Email: ");
            c.Email = Console.ReadLine();
            Console.Write("Birth Date (MM/DD/YYYY): ");
            c.BirthDate = DateTime.Parse(Console.ReadLine());
            order.Client = c;
            
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            order.Status = Enum.Parse<OrderStatus>(Console.ReadLine());
            

            Console.Write("How many items to this order? ");            
            int numItems = int.Parse(Console.ReadLine());

            for(int i = 1; i <= numItems; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Product p = new Product();
                OrderItem oi = new OrderItem();
                Console.Write("Product name: ");
                p.Name = Console.ReadLine();
                Console.Write("Product price: ");
                p.Price = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                oi.Quantity = int.Parse(Console.ReadLine());
                oi.Price = p.Price;
                oi.Product = p;
                order.Items.Add(oi);
            }

            Console.WriteLine("\nORDER SUMMARY:");
            Console.WriteLine(order);
        }      
    }
}
