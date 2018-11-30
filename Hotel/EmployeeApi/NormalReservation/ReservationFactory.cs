using System;
using ReservationApi;

namespace NormalReservation
{
    public class ReservationFactory : IReservationFactory
    {
        public IReservation Create(int roomNumber, 
                                   double roomPrice, 
                                   string startDate,
                                   string endDate, 
                                   string cFirstName, 
                                   string cLastName, 
                                   string email)
        {
            var start = DateTime.ParseExact(startDate, "yyyy-MM-dd", null);
            var end = DateTime.ParseExact(endDate, "yyyy-MM-dd", null);
            var lenght = (end - start).TotalDays;
            var reservation = new Reservation(roomNumber, startDate, endDate)
            {
                Client = new Client(cFirstName, cLastName, email),
                Price = lenght * roomPrice
            };
            return reservation;
        }
    }
}
