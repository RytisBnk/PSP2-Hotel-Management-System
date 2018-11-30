using System;
using RoomApi;

namespace NormalRoom
{
    public class RoomFactory : IRoomFactory
    {
        public RoomFactory()
        {
        }

        public IRoom Create(int roomNumber, int capacity, double price)
        {
            return new Room(roomNumber, capacity, price);
        }
    }
}
