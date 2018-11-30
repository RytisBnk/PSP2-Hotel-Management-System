using System;
using Autofac;

namespace Modules
{
    public static class Bootstrapper
    {
        public static IContainer Build()
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule<RoomModule>();







            builder.RegisterModule<EmployeeModule>();
            //builder.RegisterModule<ReservationModule>();
            builder.RegisterModule<DiscountedReservationModule>();


            builder.RegisterModule<RepositoryModule>();

            builder.RegisterModule<RoomServiceModule>();
            builder.RegisterModule<RoomFacadeModule>();

            builder.RegisterModule<ReservationServiceModule>();
            builder.RegisterModule<DefaultReservationFacadeModule>();

            builder.RegisterModule<RegularFOTHServiceModule>();
            builder.RegisterModule<DefaultManagementServiceModule>();
            builder.RegisterModule<DefaultEmployeeFacadeModule>();

            builder.RegisterModule<ConsoleUIModule>();
            builder.RegisterModule<OutlookMailModule>();

            return builder.Build();
        }
    }
}
