using System;
using Autofac;
using FOTHEmployeeServiceApi;
using InternFOTH;

namespace Modules
{
    public class InternFOTHServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<InternFOTHService>().As<IFOTHService>();
            base.Load(builder);
        }
    }
}
