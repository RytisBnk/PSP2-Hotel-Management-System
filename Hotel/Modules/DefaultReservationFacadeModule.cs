using System;
using Autofac;
using DefaultReservation;
using ReservationFacadeApi;

namespace Modules
{
    public class DefaultReservationFacadeModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DefaultReservationFacade>().As<IReservationFacade>();
            base.Load(builder);
        }
    }
}
