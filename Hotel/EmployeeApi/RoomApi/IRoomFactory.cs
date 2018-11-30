using System;
namespace RoomApi
{
    public interface IRoomFactory
    {
        IRoom Create(int roomNumber, int capacity, double price);
    }
}
