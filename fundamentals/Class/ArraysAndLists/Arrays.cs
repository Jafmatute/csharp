using System;

namespace csharpFundamentals.Class.ArraysAndLists
{
     class Arrays
    {

        public void Array_()
        {

            var numbers = new[] { 3, 7, 9, 2,14, 6 };

            //Length
            Console.WriteLine("Length " + numbers.Length);

            //IndexOf()
            var index = Array.IndexOf(numbers, 9);

            Console.WriteLine("IndexOf 9 " + index);

            //Clear()
            Array.Clear(numbers, 0, 2);

            Console.WriteLine("Effect of Clear()");
            foreach (var n in numbers) Console.WriteLine(n);
            

            //Copy()
            int[] another = new int[3];
            Array.Copy(numbers,another,3);

            Console.WriteLine("Effect of Copy()");
            foreach (var a in another) Console.WriteLine(a);

            //Sort()
            Array.Sort(numbers);

            Console.WriteLine("Effect of Sort()");
            foreach (var n in numbers) Console.WriteLine(n);

            //Reverse()
            Array.Reverse(numbers);

            Console.WriteLine("Effect of Reverse()");
            foreach (var r in numbers)
            {
                Console.WriteLine(r);
            }

        }

        

    }
}
