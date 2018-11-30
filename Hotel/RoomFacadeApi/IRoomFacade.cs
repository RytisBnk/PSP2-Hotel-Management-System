using System;
using System.Collections.Generic;
using RoomApi;

namespace RoomFacadeApi
{
    public interface IRoomFacade
    {
        List<IRoom> GetAvailableRooms(string startDate, string endDate);
        List<IRoom> GetRooms();
        IRoom CreateNewRoom(int number, double price, int capacity);
    }
}
