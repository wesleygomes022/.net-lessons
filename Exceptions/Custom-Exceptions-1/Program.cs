using System;
using TestProj.Entities;

namespace TestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Room number: ");
            int rm = int.Parse(Console.ReadLine());
            Console.Write("Check-in date (MM/dd/yyyy): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (MM/dd/yyyy): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            Reservation rv = new Reservation(rm, checkIn, checkOut);

            if(checkIn > checkOut)
            {
                Console.WriteLine("\nCheck-out date must be after check-in date.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine(rv);

                Console.Write("\nEnter data to update the reservation: ");
                Console.Write("Check-in date (MM/dd/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (MM/dd/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                if (checkIn > checkOut)
                {
                    Console.WriteLine("\nCheck-out date must be after check-in date.");
                }
                else 
                {
                    rv.UpdateDates(checkIn, checkOut);
                    Console.WriteLine();
                    Console.WriteLine(rv);
                }
            }
        }
    }
}
