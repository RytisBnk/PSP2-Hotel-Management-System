using System;
using Autofac;
using RegularRoom;
using RoomServiceApi;

namespace Modules
{
    public class RoomServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<RegularRoomService>().As<IRoomService>();
            base.Load(builder);
        }
    }
}
