using System;
using System.Collections.Generic;
using RoomApi;
using RoomRepositoryApi;
using RoomServiceApi;

namespace RegularRoom
{
    public class RegularRoomService : IRoomService
    {
        private readonly IRoomRepository _repository;
        private readonly IRoomFactory _factory;

        public RegularRoomService(IRoomFactory factory, IRoomRepository repository)
        {
            _repository = repository;
            _factory = factory;
        }

        public IRoom CreateNewRoom(int roomNumber, double price, int capacity)
        {
            var room = _factory.Create(roomNumber, capacity, price);
            _repository.Add(room);
            return room;
        }

        public List<IRoom> GetRoomsList()
        {
            var list = _repository.Get();
            return list;
        }
    }
}
