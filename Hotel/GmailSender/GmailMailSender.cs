using System;
using MailApi;

namespace GmailSender
{
    public class GmailMailSender : IMailSender
    {
        public void SendMail(string sender, string receiver, string message)
        {
            Console.WriteLine("Mail succesfully sent via gmail");
            Console.WriteLine("Sender: " + sender + " receiver: " + receiver + " message: " + message);
        }
    }
}
