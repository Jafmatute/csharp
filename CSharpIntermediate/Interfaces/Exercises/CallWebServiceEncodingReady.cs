using System;

namespace CSharpIntermediate.Interfaces.Exercises
{
    public class CallWebServiceEncodingReady : ITask
    {
        public void Execute(ActivityWork activityWork)
        {
            Console.WriteLine("Encoding ready");
        }
    }
}