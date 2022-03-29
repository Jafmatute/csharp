﻿using System;
using CSharpIntermediate.Classes;
using CSharpIntermediate.Exercises;

namespace CSharpIntermediate
{
    internal class Program
    {
        private static void Main()
        {
            UseExercisePosts();
        }

     

        private static void UsePoint()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(null);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

                point.Move(100, 200);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
            }
            catch (Exception)
            {
                Console.WriteLine("an unexpected error ocurred");
                
            }
        }


        private static void TryParse()
        {
            // method 1

            try
            {
                var num = int.Parse("abc");

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                
            }
            //method 2
            int number;
            var result = int.TryParse("abc", out number);
            if(result) Console.WriteLine(number);
            else Console.WriteLine("Conversion failed");
        }


        private static void UseFields()
        {
            var customer = new Customer2(1);
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());
            customer.Promote();
            Console.WriteLine(customer.Orders.Count);
        }

        private static void UsePerson()
        {
            var person = new Person(new DateTime(1992, 9, 6));

            Console.WriteLine(person.Age);
        }

        private static void UseCookie()
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Josue";
            Console.WriteLine(cookie["name"]);
        }

        private static void UseExerciseStopWatch()
        {
            
            var stopwatch = new Stopwatch();
            Console.WriteLine("Stopwatch");
            stopwatch.Start();
            

            while (true)
            {
                var input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                {
                    stopwatch.Stop();
                    var durationStopwatch = stopwatch.GetIntervaSpan();
                    Console.WriteLine("Duration: {0}", durationStopwatch.ToString("mm\\:ss\\.ff"));

                    Console.WriteLine("Press Enter to run the stopwatch one more line");
                    
                }
            }

        }

        private static void UseExercisePosts()
        {

            while (true)
            {
                var post = new Post();

                Console.WriteLine("Title");
                string title = Console.ReadLine().Trim();
                Console.WriteLine("Description");
                string description = Console.ReadLine().Trim();
            

                post.Create(title, description);
            }
            

        }
    }
}