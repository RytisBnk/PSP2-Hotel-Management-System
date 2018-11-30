using System;
using Autofac;
using EmployeeApi;
using FOTHEmployee;
using ManagementEmployee;

namespace Modules
{
    public class EmployeeModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<FOTHEmployee.EmployeeFactory>().As<IEmployeeFactory>().Keyed<IEmployeeFactory>("foth");
            builder.RegisterType<ManagementEmployee.EmployeeFactory>().As<IEmployeeFactory>().Keyed<IEmployeeFactory>("management");
            base.Load(builder);
        }
    }
}
