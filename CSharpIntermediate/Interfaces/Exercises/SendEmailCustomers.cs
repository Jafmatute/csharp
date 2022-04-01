using System;

namespace CSharpIntermediate.Interfaces.Exercises
{
    public class SendEmailCustomers : ITask
    {
        public void Execute(ActivityWork activityWork)
        {
            Console.WriteLine("started processing.");
        }
    }
}