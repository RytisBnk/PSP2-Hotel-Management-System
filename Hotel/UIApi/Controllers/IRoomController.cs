using System;
namespace UIApi.Controllers
{
    public interface IRoomController
    {
        string GetAvailableRooms(string startDate, string endDate);
        string GetAllRooms();
        string RegisterNewRoom(int roomNumber, double price, int capacity);
    }
}
