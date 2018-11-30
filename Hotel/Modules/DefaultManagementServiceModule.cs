using System;
using Autofac;
using ManagementEmployeeServiceApi;
using RegularManagementEmployee;

namespace Modules
{
	public class DefaultManagementServiceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<RegularManagementEmployeeService>().As<IManagementService>();
            base.Load(builder);
        }
    }
}
