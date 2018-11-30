using System;
using System.Collections.Generic;
using ReservationApi;

namespace ReservationRepositoryApi
{
    public interface IClientRepository
    {
        IClient Add(IClient client);
        IClient Remove(IClient client);
        List<IClient> Get();
        IClient Find(string email);
    }
}
