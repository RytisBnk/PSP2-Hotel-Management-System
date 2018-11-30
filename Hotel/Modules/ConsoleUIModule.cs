using System;
using Autofac;
using ManagementConsole.Controllers;
using ManagementConsole.Views;
using UIApi.Controllers;
using UIApi.Views;

namespace Modules
{
    public class ConsoleUIModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<RoomController>().As<IRoomController>();
            builder.RegisterType<RoomView>().As<IRoomView>();
            builder.RegisterType<ReservationController>().As<IReservationController>();
            builder.RegisterType<ReservationView>().As<IReservationView>();
            builder.RegisterType<EmployeeController>().As<IEmployeeController>();
            builder.RegisterType<EmployeeView>().As<IEmployeeView>();
            base.Load(builder);
        }
    }
}
