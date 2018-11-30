using System;
using Autofac;
using RegularReservation;
using ReservationServiceApi;

namespace Modules
{
    public class ReservationServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<RegularReservationService>().As<IReservationService>();
            base.Load(builder);
        }
    }
}
