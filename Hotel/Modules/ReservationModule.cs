using System;
using Autofac;
using NormalReservation;
using ReservationApi;

namespace Modules
{
    public class ReservationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ReservationFactory>().As<IReservationFactory>();
            base.Load(builder);
        }
    }
}
