using System;
using Autofac;
using ReservationApi;

namespace Modules
{
	public class DiscountedReservationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DiscountedReservation.ReservationFactory>().As<IReservationFactory>();
            base.Load(builder);
        }
    }
}
