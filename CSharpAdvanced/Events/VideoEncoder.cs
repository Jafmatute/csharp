using System;
using System.Threading;

namespace CSharpAdvanced.Events
{
    public class VideoEncoder
    {


        // 1- Define a delegate
        // 2- Define an event based on that delegate 
        // 3- Ride the event


        //1
        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs e);  //EventArgs

        //EventHandler
        //EventHandler<TEventArgs>

        //2
        //public event VideoEncodedEventHandler VideoEncoded;
        public event EventHandler<VideoEventArgs> VideoEncoded;

        //nothing information
        //public event EventHandler VideoEncoding;


        public void Encode(Video video)
        {
            Console.WriteLine("encoding video");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            //VideoEncoded?.Invoke(this, EventArgs.Empty);
            VideoEncoded?.Invoke(this, new VideoEventArgs() { Video = video });
        }
    }
}