using System;
using System.Collections.Generic;
using ReservationApi;
using ReservationRepositoryApi;

namespace InMemoryReservation
{
    public class InMemoryReservationRepository : IReservationRepository
    {
        private readonly List<IReservation> _reservations;

        public InMemoryReservationRepository()
        {
            _reservations = new List<IReservation>();
        }

        public IReservation Add(IReservation reservation)
        {
            if (_reservations.Contains(reservation))
            {
                throw new ArgumentException("Reservation is already in repository");
            }
            _reservations.Add(reservation);
            return reservation;
        }

        public IReservation Find(int room, string startDate, string endDate)
        {
            var result = _reservations.Find(res => res.RoomNumber == room && res.StartDate == startDate && res.EndDate == endDate);
            return result;
        }

        public List<IReservation> Get()
        {
            return _reservations;
        }

        public IReservation Remove(IReservation reservation)
        {
            _reservations.Remove(reservation);
            return reservation;
        }
    }
}
