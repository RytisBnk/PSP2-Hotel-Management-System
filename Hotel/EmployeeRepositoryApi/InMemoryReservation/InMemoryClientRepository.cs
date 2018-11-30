using System;
using System.Collections.Generic;
using ReservationApi;
using ReservationRepositoryApi;

namespace InMemoryReservation
{
    public class InMemoryClientRepository : IClientRepository
    {
        private readonly List<IClient> _clients;

        public InMemoryClientRepository()
        {
            _clients = new List<IClient>();
        }

        public IClient Add(IClient client)
        {
            if (_clients.Contains(client)) 
            {
                throw new ArgumentException("Client already in repository");
            }
            _clients.Add(client);
            return client;
        }

        public IClient Find(string email)
        {
            var result = _clients.Find(cl => cl.Email == email);
            return result;
        }

        public List<IClient> Get()
        {
            return _clients;
        }

        public IClient Remove(IClient client)
        {
            _clients.Remove(client);
            return client;
        }
    }
}
