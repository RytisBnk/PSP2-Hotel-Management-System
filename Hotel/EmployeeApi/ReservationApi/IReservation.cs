using System;
namespace ReservationApi
{
    public interface IReservation
    {
        int RoomNumber { get; set; }
        string StartDate { get; set; }
        string EndDate { get; set; }
        double Price { get; set; }
        IClient Client { get; set; }
    }
}
