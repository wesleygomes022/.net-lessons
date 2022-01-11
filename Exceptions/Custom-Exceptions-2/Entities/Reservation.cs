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

        public string UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            if (checkIn > checkOut)
            {
                return "Check-out date must be after check-in date.";
            }
            else if (checkIn < DateTime.Now)
            {
                return "Reservation dates for update must be future dates.";
            }
            else
            {
                Checkin = checkIn;
                CheckOut = checkOut;

                return null;
            }                        
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
