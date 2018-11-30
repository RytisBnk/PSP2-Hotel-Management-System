using System;
namespace ReservationApi
{
    public interface IClient
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
    }
}
