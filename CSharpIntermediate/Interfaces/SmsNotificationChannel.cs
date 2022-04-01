using System;

namespace CSharpIntermediate.Interfaces
{
    public class SmsNotificationChannel : INotificationChannel
    {
        public void Send(Message message)
        {
            Console.WriteLine("Sending SMS..");
        }
    }
}