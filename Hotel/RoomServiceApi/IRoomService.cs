using System;
using System.Collections.Generic;
using RoomApi;

namespace RoomServiceApi
{
    public interface IRoomService
    {
        IRoom CreateNewRoom(int roomNumber, double price, int capacity);
        List<IRoom> GetRoomsList();
    }
}
