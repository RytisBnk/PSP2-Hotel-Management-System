using System;
namespace RoomApi
{
    public interface IRoom
    {
        int Number { get; set; }
        int Capacity { get; set; }
        double Price { get; set; }
    }
}
