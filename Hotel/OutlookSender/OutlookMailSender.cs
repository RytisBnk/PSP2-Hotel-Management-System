using System;
using MailApi;

namespace OutlookSender
{
    public class OutlookMailSender : IMailSender
    {
        public void SendMail(string sender, string receiver, string message)
        {
            Console.WriteLine("Mail succesfully sent via outlook");
            Console.WriteLine("Sender: " + sender + " receiver: " + receiver + " message: " + message);
        }
    }
}
