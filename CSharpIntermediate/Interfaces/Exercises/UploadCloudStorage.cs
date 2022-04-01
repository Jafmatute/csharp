using System;

namespace CSharpIntermediate.Interfaces.Exercises
{
    public class UploadCloudStorage : ITask
    {
        public void Execute(ActivityWork activityWork)
        {
            Console.WriteLine("Upload video");
        }
    }
}