using System;
using Autofac;
using MailApi;
using OutlookSender;

namespace Modules
{
    public class OutlookMailModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<OutlookMailSender>().As<IMailSender>();
            base.Load(builder);
        }
    }
}
