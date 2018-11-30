using System;
using ReservationApi;

namespace DiscountedReservation
{
    public class ReservationFactory : IReservationFactory
    {
        private readonly double _coeficient = 0.75;

        public IReservation Create(int roomNumber, 
                                   double roomPrice,
                                   string startDate, 
                                   string endDate,
                                   string cFirstName,
                                   string cLastName, 
                                   string email)
        {
            var start = DateTime.Parse(startDate);
            var end = DateTime.Parse(endDate);
            var length = (end - start).TotalDays;
            var reservation = new Reservation(roomNumber, startDate, endDate)
            {
                Client = new Client(cFirstName, cLastName, email),
                Price = _coeficient * length * roomPrice
            };
            return reservation;
        }
    }
}
