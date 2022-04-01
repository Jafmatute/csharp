using System;

namespace CSharpIntermediate.Interfaces.Exercises
{
    public class ChangeStatusVideo : ITask
    {
        public void Execute(ActivityWork activityWork)
        {
            Console.WriteLine("Status changed record video");
        }
    }
}