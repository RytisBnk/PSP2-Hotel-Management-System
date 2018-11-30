using System;
using ReservationApi;

namespace NormalReservation
{
    public class Client : IClient
    {
        public string FirstName { get ; set ; }
        public string LastName { get ; set ; }
        public string Email { get ; set ; }
        public int Id { get ; set ; }

        public Client(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }
    }
}
