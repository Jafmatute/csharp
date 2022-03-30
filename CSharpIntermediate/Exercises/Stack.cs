using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpIntermediate.Exercises
{
    public class Stack
    {
        private readonly List<object> _lists = new List<object>();


        public void Push(object obj)
        {
            if (obj == null) throw new InvalidOperationException("Invalidated argument ");

            _lists.Add(obj);

        }


        public object Pop()
        {
            if(_lists.Count<=0) throw  new InvalidOperationException("Empty list ");

            int index = _lists.Count - 1;

            var value = _lists[index];

            _lists.RemoveAt(index);

            return value;

        }

        public void Clear()
        {
            _lists.Clear();
        }


    }
}
