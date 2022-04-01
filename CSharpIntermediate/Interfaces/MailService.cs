using System;

namespace CSharpIntermediate.Interfaces
{
    public class MailService
    {
        public void Send(Mail mail)
        {
            Console.WriteLine("Sending email.....");
        }
    }
}