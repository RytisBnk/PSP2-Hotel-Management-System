using System;
using System.Collections.Generic;
using RoomApi;
namespace RoomRepositoryApi
{
    public interface IRoomRepository
    {
        IRoom Add(IRoom room);
        IRoom Remove(IRoom room);
        List<IRoom> Get();
        IRoom Find(int roomNumber);
    }
}
