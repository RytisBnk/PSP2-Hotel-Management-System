using System;
using Autofac;
using DefaultRoom;
using RoomFacadeApi;

namespace Modules
{
    public class RoomFacadeModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<RegularRoomFacade>().As<IRoomFacade>();
            base.Load(builder);
        }
    }
}
