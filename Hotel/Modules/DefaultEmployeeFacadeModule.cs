using System;
using Autofac;
using DefaultEmployee;
using EmployeeFacadeApi;

namespace Modules
{
	public class DefaultEmployeeFacadeModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DefaultEmployeeFacade>().As<IEmployeeFacade>();
            base.Load(builder);
        }
    }
}
