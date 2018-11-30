using System;
using ReservationApi;
using ReservationRepositoryApi;
using ReservationServiceApi;
using RoomRepositoryApi;
using System.Linq;
using System.Collections.Generic;
using MailApi;

namespace RegularReservation
{
    public class RegularReservationService : IReservationService
    {
        private readonly IRoomRepository _roomRepo;
        private readonly IReservationRepository _reservationRepo;
        private readonly IReservationFactory _factory;
        private readonly IMailSender _mailSender;

        public RegularReservationService(IRoomRepository roomRepo, IReservationRepository reservationRepo, IReservationFactory factory, IMailSender mailSender)
        {
            _roomRepo = roomRepo;
            _reservationRepo = reservationRepo;
            _factory = factory;
            _mailSender = mailSender;
        }

        public IReservation CancelReservation(int roomNumber, string startDate, string endDate)
        {
            var reservation = _reservationRepo.Find(roomNumber, startDate, endDate);
            var removedReservation = _reservationRepo.Remove(reservation);
            _mailSender.SendMail("this@hotelnamespace.com",
                                 removedReservation.Client.Email,
                                 "Your reservation for room " + removedReservation.RoomNumber + " has been canceled");
            return removedReservation;
        }

        public IReservation CreateReservation(int roomNumber, string startDate, string endDate, string firstName, string lastName, string email)
        {
            var room = _roomRepo.Find(roomNumber);
            if (IsRoomAvailable(roomNumber, startDate, endDate))
            {
                var reservation = _factory.Create(roomNumber, room.Price, startDate, endDate, firstName, lastName, email);
                _reservationRepo.Add(reservation);
                return reservation;
            }
            throw new ArgumentException("Room occupied at selected date interval");
        }

        public List<IReservation> GetReservations()
        {
            var reservations = _reservationRepo.Get();
            return reservations;
        }

        public bool IsRoomAvailable(int roomNUmber, string startDate, string endDate)
        {
            var room = _roomRepo.Find(roomNUmber);
            if (room != null) 
            {
                var reservations = _reservationRepo.Get().Where(res =>
                {
                    var start = DateTime.Parse(res.StartDate);
                    var end = DateTime.Parse(res.EndDate);
                    var startDt = DateTime.Parse(startDate);
                    var endDt = DateTime.Parse(endDate);
                    return !(startDt >= start && startDt <= end && endDt >= start && endDt <= end);
                }).ToList();
                return reservations.Count == 0;
            }
            return false;
        }
    }
}
