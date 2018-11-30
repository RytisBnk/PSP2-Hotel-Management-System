using System;
using System.Collections.Generic;
using ReservationApi;
using ReservationFacadeApi;
using ReservationServiceApi;
using System.Linq;

namespace DefaultReservation
{
    public class DefaultReservationFacade : IReservationFacade
    {
        private readonly IReservationService _service;

        public DefaultReservationFacade(IReservationService service)
        {
            _service = service;
        }

        public IReservation CancelReservation(int roomNumber, string startDate, string endDate)
        {
            var reservation = _service.CancelReservation(roomNumber, startDate, endDate);
            return reservation;
        }

        public IReservation CreateReservation(int roomNumber, string startDate, string endDate, string firstName, string lastName, string email)
        {
            var reservation = _service.CreateReservation(roomNumber, startDate, endDate, firstName, lastName, email);
            return reservation;
        }

        public List<IReservation> GetReservations(string startDate, string endDate)
        {
            var allReservations = _service.GetReservations();
            var filteredReservations = new List<IReservation>();
            foreach (var res in allReservations)
            {
                var start = DateTime.Parse(startDate);
                var end = DateTime.Parse(endDate);
                var cStart = DateTime.Parse(res.StartDate);
                if (cStart >= start && cStart <= end)
                {
                    filteredReservations.Add(res);
                }
            }
            return filteredReservations;
        }

        public List<IReservation> GetRoomReservations(int roomNumber)
        {
            var result = _service.GetReservations().Where(res => res.RoomNumber == roomNumber).ToList();
            return result;
        }
    }
}
