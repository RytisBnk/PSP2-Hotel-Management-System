using System;
namespace ReservationApi
{
    public interface IReservationFactory
    {
        IReservation Create(int roomNumber, 
                            double roomPrice, 
                            string startDate, 
                            string endDate, 
                            string cFirstName, 
                            string cLastName, 
                            string email);
    }
}
