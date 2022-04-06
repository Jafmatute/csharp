using System;

namespace CSharpAdvanced.Events
{
    public class MailService
    {
        //public void OnVideoEncoded(object source, EventArgs e)
        //{
        //    Console.WriteLine("Mail service: Sending an email");
        //}

        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("Mail service: Sending an email " + e.Video.Title);
        }
    }
}