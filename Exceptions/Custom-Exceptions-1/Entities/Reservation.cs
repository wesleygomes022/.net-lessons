using System;

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
