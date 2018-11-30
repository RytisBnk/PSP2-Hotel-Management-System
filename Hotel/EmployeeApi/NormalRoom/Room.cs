using System;
using RoomApi;

namespace NormalRoom
{
    public class Room : IRoom
    {
        public Room(int number, int capacity, double price)
        {
            Number = number;
            Capacity = capacity;
            Price = price;
        }

        public int Number { get ; set ; }
        public int Capacity { get ; set ; }
        public double Price { get ; set ; }
    }
}
