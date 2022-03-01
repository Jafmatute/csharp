using System;
using System.Collections.Generic;


namespace csharpFundamentals.Class.ArraysAndLists
{
    class Lists
    {

        public void List()
        {
            var numbers = new List<int>() {1,2,3,4};
            numbers.Add(1);
            numbers.AddRange(new int[3]{5,6,7});

            foreach (var n in numbers) Console.WriteLine(n);

            Console.WriteLine();
            Console.WriteLine("Index Of 1: " + numbers.IndexOf(1));
            Console.WriteLine("Last Index Of 1: " + numbers.LastIndexOf(1));
            Console.WriteLine("Count: " + numbers.Count);

           // numbers.Remove(1);
            //foreach (var n in numbers) Console.WriteLine(n);

            for (var i = 0; i < numbers.Count; i++)
            {
                if(numbers[i]==1) numbers.Remove(numbers[i]);
            }
            foreach (var n in numbers) Console.WriteLine(n);

            numbers.Clear();
        }
    }
}
