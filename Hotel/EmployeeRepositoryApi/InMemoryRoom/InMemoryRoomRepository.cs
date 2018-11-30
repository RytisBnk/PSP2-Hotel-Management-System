using System;
using System.Collections.Generic;
using RoomApi;
using RoomRepositoryApi;
namespace InMemoryRoom
{
    public class InMemoryRoomRepository : IRoomRepository
    {
        private readonly List<IRoom> _rooms;

        public InMemoryRoomRepository()
        {
            _rooms = new List<IRoom>();
        }

        public IRoom Add(IRoom room)
        {
            if (_rooms.Contains(room))
            {
                throw new ArgumentException("Room already in repository");
            }
            _rooms.Add(room);
            return room;
        }

        public IRoom Find(int roomNumber)
        {
            var result = _rooms.Find(room => room.Number == roomNumber);
            return result;
        }

        public List<IRoom> Get()
        {
            return _rooms;
        }

        public IRoom Remove(IRoom room)
        {
            _rooms.Remove(room);
            return room;
        }
    }
}
