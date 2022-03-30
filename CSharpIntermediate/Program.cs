﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Amazon;
using CSharpIntermediate.AssociationBetweenClasses;
using CSharpIntermediate.Classes;
using CSharpIntermediate.Exercises;
using CSharpIntermediate.InheritanceSecondPillarOfOOP;

namespace CSharpIntermediate
{
    internal class Program
    {
        private static void Main()
        {
           UseExerciseStack();
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

        
        /*private static void UseExercisePosts()
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
            

        }*/


        // Association between Classes

        private static void UseInheritance()
        {
            var text = new Text();
            text.Width = 100;
            text.Copy();
        }

        private static void UseComposition()
        {
            var dbMigrator = new DbMigrator(new Logger());
            var logger = new Logger();
            var installer = new Installer(logger);
            dbMigrator.Migrate();
            installer.Install();
        }


        //Inheritance - Second Pillar of OOP
        private static void UseAccessModifiers()
        {
            var customer = new Customer();

            //Internal
            //Amazon.RateCalculator calculate = new RateCalculator();
            

        }

        private static void UseConstructorsInheritance()
        {
            var car = new Card("xyz");
        }

        private static void UseUpcastingDowncasting()
        {
            //Up Casting

            TextShape text = new TextShape();
            Shape shape = text;
            
            text.Width = 200;
            shape.Width = 100;
            
            Console.WriteLine(text.Width);

            //Down Casting
            Shape shape2 = new TextShape();
            TextShape text2 = (TextShape) shape;




        }

        private static void UseBoxingUnboxing()
        {
            var list = new ArrayList();
            list.Add(1);
            list.Add("Josue");
            list.Add(DateTime.Today);

            var anotherList = new List<int>();
            var names = new List<string>();
            names.Add("ha");





        }

        private static void UseExerciseStack()
        {

            try
            {
                var stack = new Exercises.Stack();

                int min = 1;
                int max = 5;

                for (int i = min; i <= max; i++) stack.Push(i);

                //stack.Clear();

                for (int i = min; i <= max; i++) Console.WriteLine(stack.Pop());

                Console.ReadLine();
               

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                
            }
        

        }
    }
}
