using System;
namespace MailApi
{
    public interface IMailSender
    {
        void SendMail(string sender, string receiver, string message);
    }
}
