using System.Collections.Generic;

namespace CSharpIntermediate.Interfaces.Exercises
{
    public class WorkflowEngine
    {
        private readonly IList<ITask> _tasks;

        public WorkflowEngine()
        {
            _tasks = new List<ITask>();
        }

        public void Run(IWorkFlow workFlow)
        {
            foreach (var activity in workFlow.GetTasks())
            {
                activity.Execute(new ActivityWork());
            }


        }

    }
}
