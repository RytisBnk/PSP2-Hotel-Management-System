using System;
using Autofac;
using NormalRoom;
using RoomApi;

namespace Modules
{
    public class RoomModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<RoomFactory>().As<IRoomFactory>();
            base.Load(builder);
        }
    }
}
