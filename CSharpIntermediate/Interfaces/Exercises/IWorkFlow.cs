using System.Collections.Generic;

namespace CSharpIntermediate.Interfaces.Exercises
{
    public interface IWorkFlow
    {
        void Add(ITask task);

        void Remove(ITask task);

        IEnumerable<ITask> GetTasks();

    }
}