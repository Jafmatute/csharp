using System;

namespace CSharpAdvanced.Events
{
    public class MessageService
    {
        //public void OnVideoEncoded(object source, EventArgs e)
        //{
        //    Console.WriteLine("Message service: Sending a text sms.....");
        //}
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("Message service: Sending a text sms..... " + e.Video.Title);
        }


    }
}