using System;


namespace csharpFundamentals.Class.ControlFlow
{
    class Loops
    {
        public void IterationForLoop()
        {
            for (int i = 0; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(string.Format("count {0}", i));
                }

            }

            //Decrements
            for (int i = 10; i >= 1; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(string.Format("decrement {0}", i));
                }
            }
        }

        public void IterationForEachLoop()
        {
            var name = "John Smith";
            var numbers = new int[] { 1, 2, 3, 4 };

            /* for (int i = 0; i < name.Length; i++)
             {
                 Console.WriteLine(name[i]);
             }*/

            //ForEach
            foreach (var character in name)
            {
                Console.WriteLine(character);
            }
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
        }

        public void IterationWhileLoop()
        {
            var i = 0;

            while (i<=10)
            {
                if(i%2 == 0)
                {
                    Console.WriteLine(i);
                }

                i++;
            }

            while (true)
            {
                Console.Write("Type your Name:");
                var input = Console.ReadLine();

                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@echo:" + input);
                    continue;
                }

                break;
               
            }
        }
    }
}
