using System;
using System.Text;
using RoomFacadeApi;
using UIApi.Controllers;

namespace ManagementConsole.Controllers
{
    public class RoomController : IRoomController
    {
        private readonly IRoomFacade _facade;

        public RoomController(IRoomFacade facade)
        {
            _facade = facade;
        }

        public string GetAllRooms()
        {
            var rooms = _facade.GetRooms();
            var builder = new StringBuilder();
            foreach (var room in rooms)
            {
                var text = "Number: " + room.Number
                                            + " || Capacity: " + room.Capacity
                                            + " || Price: " + room.Price
                                            + "\n";
                builder.Append(text);
            }
            return builder.ToString();
        }

        public string GetAvailableRooms(string startDate, string endDate)
        {
            var rooms = _facade.GetAvailableRooms(startDate, endDate);
            var builder = new StringBuilder();
            foreach (var room in rooms)
            {
                var text = "Number: " + room.Number
                                            + " || Capacity: " + room.Capacity
                                            + " || Price: " + room.Price
                                            + "\n";
                builder.Append(text);
            }
            return builder.ToString();
        }

        public string RegisterNewRoom(int roomNumber, double price, int capacity)
        {
            var newRoom = _facade.CreateNewRoom(roomNumber, price, capacity);
            var text = "Number: " + newRoom.Number
                                            + " || Capacity: " + newRoom.Capacity
                                            + " || Price: " + newRoom.Price
                                            + "\n";
            return text;
        }
    }
}
