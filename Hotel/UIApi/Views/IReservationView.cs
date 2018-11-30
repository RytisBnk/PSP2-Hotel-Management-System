using System;
namespace UIApi.Views
{
    public interface IReservationView
    {
        void ShowMenu();
        void DisplayReservations();
        void DisplayRoomReservations();
        void CreateReservation();
        void CancelReservation();
    }
}
