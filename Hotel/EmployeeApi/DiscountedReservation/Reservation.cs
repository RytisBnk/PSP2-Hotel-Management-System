using System;
using ReservationApi;

namespace DiscountedReservation
{
    public class Reservation : IReservation
    {
        public Reservation(int roomNumber, string startDate, string endDate)
        {
            RoomNumber = roomNumber;
            StartDate = startDate;
            EndDate = endDate;
        }

        public int RoomNumber { get ; set ; }
        public string StartDate { get ; set ; }
        public string EndDate { get ; set ; }
        public double Price { get ; set ; }
        public IClient Client { get ; set ; }
    }
}
