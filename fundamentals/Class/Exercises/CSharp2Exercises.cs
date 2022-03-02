using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace csharpFundamentals.Class.Exercises
{
    class CSharp2Exercises
    {

        

        public void Exercise1()
        {
           var names = new List<string>();

            while (true)
            {
                Console.Write("Type a name (or hit ENTER to quit): ");
                var input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input)) break;
                    
                names.Add(input);
            } 


            if (names.Count > 2) Console.WriteLine("{0}, {1} and {2} others like your post", names[0], names[1], names.Count - 2);
            else if (names.Count == 2) Console.WriteLine("{0} and {1} like your post", names[0], names[1]);
                else if(names.Count ==1) Console.WriteLine("{0} likes your post.", names[0]);
                    else Console.WriteLine();
        }

        public void Exercise2()
        {
            Console.Write("Enter your name: ");

            var name = Console.ReadLine();

            Console.WriteLine("{0}",name);

            if (name != null)
            {
                var array = new char[name.Length];

                for (int i = name.Length; i > 0; i--) array[name.Length -i] = name[i-1];

                var reversed = new string(array);

                Console.WriteLine("Reversed name: " + reversed);
            }
        }

        public void Exercise3()
        {
            var numbers = new List<int>();

            while (numbers.Count <5)
            {
                Console.Write("Enter a number: ");
                var num =
                    Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(num))
                {
                    Console.WriteLine("You've previously entered " + num);
                    continue;
                }

                numbers.Add(num);
            }

            numbers.Sort();
            foreach (var number in numbers) Console.WriteLine(number);

        }

        public void Exercise4()
        {
            var numbers = new List<int>();

            while (true)
            {
                Console.Write("Enter a number (or 'Quit' to exit): ");
                var input = Console.ReadLine();

                if (input.ToLower() == "Quit") break;

                numbers.Add(Convert.ToInt32(input));
            }

            var uniqued = new List<int>();

            foreach (var number in numbers)
            {
                if(!uniqued.Contains(number)) uniqued.Add(number);
            }

            Console.WriteLine("Unique numbers:");
            foreach (var unique in uniqued) Console.WriteLine(unique);
        }

        public void Excercise5()
        {
            string[] elements;
            while (true)
            {
                Console.Write("Enter a list of comma-separated numbers: ");
                var input = Console.ReadLine();


                if (!String.IsNullOrWhiteSpace(input))
                {
                    elements = input.Split(',');
                    if (elements.Length >= 5) break;

                }

                Console.WriteLine("Invalid List");
            }

            var numbers = new List<int>();

            foreach (var number in elements) numbers.Add(Convert.ToInt32(number));

            var smallests = new List<int>();
            while (smallests.Count < 3)
            {
                // Assume the first number is the smallest
                var min = numbers[0];
                foreach (var number in numbers)
                {
                    if (number < min)
                        min = number;
                }
                smallests.Add(min);

                numbers.Remove(min);
            }

            Console.WriteLine("The 3 smallest numbers are: ");
            foreach (var number in smallests)
                Console.WriteLine(number);

        }
    }

}
