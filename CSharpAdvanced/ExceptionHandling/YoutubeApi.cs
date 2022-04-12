using System;
using System.Collections.Generic;

namespace CSharpAdvanced.ExceptionHandling
{
    public class YoutubeApi
    {
        public List<ExceptionHandling.Video> GetVideos(string user)
        {
            try
            {
                // Access youtube web service
                // Read the data
                // Create a list of videos objects

                throw new Exception("Oops some low level youtube error");
            }
            catch (Exception e)
            {
                //log
                throw new YoutubeException("could not fetch the videos from youtube", e);
            }

            return new List<Video>();
        }
    }
}