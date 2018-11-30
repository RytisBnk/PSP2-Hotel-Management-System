using System;
using ReservationApi;

namespace NormalReservation
{
    public class Reservation : IReservation
    {
        public int RoomNumber { get ; set ; }
        public string StartDate { get ; set ; }
        public string EndDate { get ; set ; }
        public double Price { get ; set ; }
        public int Id { get ; set ; }
        public IClient Client { get ; set ; }

        public Reservation(int roomNumber, string startDate, string endDate)
        {
            RoomNumber = roomNumber;
            StartDate = startDate;
            EndDate = endDate;
        }
    }
}
