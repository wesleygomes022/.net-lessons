using System;
using TestProj.Entities;
using TestProj.Entities.Exceptions;

namespace TestProj
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room number: ");
                int rm = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (MM/dd/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (MM/dd/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation rv = new Reservation(rm, checkIn, checkOut);

                Console.WriteLine();
                Console.WriteLine(rv);

                Console.WriteLine("\nEnter data to update the reservation: ");
                Console.Write("Check-in date (MM/dd/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (MM/dd/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                rv.UpdateDates(checkIn, checkOut);
                Console.WriteLine();
                Console.WriteLine(rv);
            }
            catch(DomainException e)
            {
                Console.WriteLine(e.Message);
            }            
            catch(Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}
