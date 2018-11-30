using System;
using System.Collections.Generic;
using ReservationApi;

namespace ReservationFacadeApi
{
    public interface IReservationFacade
    {
        List<IReservation> GetReservations(string startDate, string endDate);
        List<IReservation> GetRoomReservations(int roomNumber);
        IReservation CreateReservation(int roomNumber,
                                      string startDate,
                                      string endDate,
                                      string firstName,
                                      string lastName,
                                       string email);
        IReservation CancelReservation(int roomNumber, string startDate, string endDate);
    }
}
