using System;
using Autofac;
using FOTHEmployeeServiceApi;
using RegularFOTH;

namespace Modules
{
    public class RegularFOTHServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<RegularFOTHService>().As<IFOTHService>();
            base.Load(builder);
        }
    }
}
