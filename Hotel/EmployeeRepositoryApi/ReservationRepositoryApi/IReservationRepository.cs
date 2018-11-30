using System;
using System.Collections.Generic;
using ReservationApi;

namespace ReservationRepositoryApi
{
    public interface IReservationRepository
    {
        IReservation Add(IReservation reservation);
        IReservation Remove(IReservation reservation);
        List<IReservation> Get();
        IReservation Find(int room, string startDate, string endDate);
    }
}
