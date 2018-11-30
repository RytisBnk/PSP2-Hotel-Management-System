using System;
namespace UIApi.Controllers
{
    public interface IReservationController
    {
        string GetReservations(string startDate, string endDate);
        string GetRoomReservations(int roomNumber);
        string CreateReservation(int roomNUmber, string startDate, string endDate, string firstName, string lastName, string email);
        string CancelReservation(int roomNumber, string startDate, string endDate);
    }
}
