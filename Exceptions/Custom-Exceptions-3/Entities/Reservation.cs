using System;
using TestProj.Entities.Exceptions;

namespace TestProj.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {

        }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkIn > checkOut)
                throw new DomainException("\nError in reservation: Check-out date must be after check-in date.");
            
            RoomNumber = roomNumber;
            Checkin = checkIn;
            CheckOut = checkOut;
        }

        public int Duration(DateTime checkIn, DateTime checkOut)
        {
            TimeSpan dur = checkOut.Subtract(checkIn);
            return (int)dur.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            if (checkIn > checkOut)
            {
                throw new DomainException("Error in reservation: Check-out date must be after check-in date.");
            }
            else if (checkIn < DateTime.Now)
            {
                throw new DomainException("Error in reservation: Reservation dates for update must be future dates.");
            }

            Checkin = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            return "Room Number: " + RoomNumber +
                ";\nCheck-in Date: " + Checkin.ToString("dd/MM/yyyy") +
                ";\nCheck-out Date: " + CheckOut.ToString("dd/MM/yyyy") +
                ";\nReservation: " + Duration(Checkin, CheckOut) + " nights;";
        }
    }
}
