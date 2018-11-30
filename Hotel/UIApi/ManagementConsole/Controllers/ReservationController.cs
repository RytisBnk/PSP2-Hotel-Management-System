using System;
using System.Text;
using ReservationApi;
using ReservationFacadeApi;
using UIApi.Controllers;

namespace ManagementConsole.Controllers
{
    public class ReservationController : IReservationController
    {
        private readonly IReservationFacade _facade;

        public ReservationController(IReservationFacade facade)
        {
            _facade = facade;
        }

        public string CancelReservation(int roomNumber, string startDate, string endDate)
        {
            var result = _facade.CancelReservation(roomNumber, startDate, endDate);
            var text = FormatReservation(result);
            return text;
        }

        public string CreateReservation(int roomNUmber, string startDate, string endDate, string firstName, string lastName, string email)
        {
            var result = _facade.CreateReservation(roomNUmber, startDate, endDate, firstName, lastName, email);
            var text = FormatReservation(result);
            return text;
        }

        public string GetReservations(string startDate, string endDate)
        {
            var result = _facade.GetReservations(startDate, endDate);
            var builder = new StringBuilder();
            foreach(var res in result) 
            {
                var text = FormatReservation(res);
                builder.Append(text);
            }
            return builder.ToString();
        }

        public string GetRoomReservations(int roomNumber)
        {
            var result = _facade.GetRoomReservations(roomNumber);
            var builder = new StringBuilder();
            foreach (var res in result)
            {
                var text = FormatReservation(res);
                builder.Append(text);
            }
            return builder.ToString();
        }

        private string FormatReservation(IReservation reservation) 
        {
            var text = "Room: " + reservation.RoomNumber + " || "
                                             + "Start: " + reservation.StartDate + " || "
                                             + "End :" + reservation.EndDate + " || "
                                             + "ClientName: " + reservation.Client.FirstName + " " + reservation.Client.LastName + " || "
                                             + "Price: " + reservation.Price + "\n";
            return text;
        }
    }
}
