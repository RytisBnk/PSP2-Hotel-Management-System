using System;
using System.Collections.Generic;
using ReservationServiceApi;
using RoomApi;
using RoomFacadeApi;
using RoomServiceApi;

namespace DefaultRoom
{
    public class RegularRoomFacade : IRoomFacade
    {
        private readonly IRoomService _roomService;
        private readonly IReservationService _resService;

        public RegularRoomFacade(IRoomService service, IReservationService resService)
        {
            _roomService = service;
            _resService = resService;
        }

        public IRoom CreateNewRoom(int number, double price, int capacity)
        {
            var room = _roomService.CreateNewRoom(number, price, capacity);
            return room;
        }

        public List<IRoom> GetAvailableRooms(string startDate, string endDate)
        {
            var allRooms = _roomService.GetRoomsList();
            var newList = new List<IRoom>();
            foreach (var room in allRooms)
            {
                if (_resService.IsRoomAvailable(room.Number, startDate, endDate))
                {
                    newList.Add(room);
                }
            }
            return newList;
        }

        public List<IRoom> GetRooms()
        {
            var result = _roomService.GetRoomsList();
            return result;
        }
    }
}
