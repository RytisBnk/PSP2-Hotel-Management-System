using System;
using Autofac;
using GmailSender;
using MailApi;

namespace Modules
{
	public class GmailMailModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<GmailMailSender>().As<IMailSender>();
            base.Load(builder);
        }
    }
}
