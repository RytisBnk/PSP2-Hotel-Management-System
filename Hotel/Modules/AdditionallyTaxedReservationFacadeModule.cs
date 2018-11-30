using System;
using AdditionallyTaxedReservation;
using Autofac;
using ReservationFacadeApi;

namespace Modules
{
    public class AdditionallyTaxedReservationFacadeModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AdditionallyTaxedReservationFacade>().As<IReservationFacade>();
            base.Load(builder);
        }
    }
}
