using System;
using System.Collections.Generic;
using ReservationApi;

namespace ReservationServiceApi
{
    public interface IReservationService
    {
        Boolean IsRoomAvailable(int roomNUmber, string startDate, string endDate);
        IReservation CreateReservation(int roomNumber,
                                      string startDate,
                                      string endDate,
                                      string firstName,
                                      string lastName,
                                       string email);
        IReservation CancelReservation(int roomNumber, string startDate, string endDate);
        List<IReservation> GetReservations();
    }
}
