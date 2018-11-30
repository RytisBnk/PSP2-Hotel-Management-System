using System;
using Autofac;
using EmployeeRepositoryApi;
using RoomRepositoryApi;
using ReservationRepositoryApi;
using InMemoryRoom;
using InMemoryEmployee;
using InMemoryReservation;

namespace Modules
{
    public class RepositoryModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<InMemoryEmployeeRepository>().As<IEmployeeRepository>().SingleInstance();
            builder.RegisterType<InMemoryRoomRepository>().As<IRoomRepository>().SingleInstance();
            builder.RegisterType<InMemoryClientRepository>().As<IClientRepository>().SingleInstance();
            builder.RegisterType<InMemoryReservationRepository>().As<IReservationRepository>().SingleInstance();
            base.Load(builder);
        }
    }
}
