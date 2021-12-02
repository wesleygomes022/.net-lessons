using System;
using System.Globalization;
using TestProj.Entities;
using TestProj.Entities.Enums;

namespace TestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Order o1 = new Order {
                ID = 1221,
                Moment = DateTime.Now,
                Status = OrderStatus.Processing
            };

            //Console.WriteLine(o1);

            //converting string to enumerations and vice versa
            OrderStatus temp = Enum.Parse<OrderStatus>("Shipped");
            string temp2 = temp.ToString();
            Console.WriteLine(temp);
            Console.WriteLine(temp2);

        }
    }
}
