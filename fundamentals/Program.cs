﻿using csharpFundamentals.Math;
using csharpFundamentals.Class.ControlFlow;
using csharpFundamentals.Class.ArraysAndLists;
using csharpFundamentals.Class.Exercises;
using System;
using System.Collections.Generic;

namespace csharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DemoArraysAndList();
            
        }

        static void DemoPrimitiveTypes()
        {
            //Primitive Types
            PrimitivesTypes primitives = new PrimitivesTypes();
            primitives.Operators();
        }
        static void DemoNon_PrimitiveTypes()
        {

            var nonPrimitivies = new Non_PrimitiveTypes();


            //NoPrimitiveTypes
            nonPrimitivies.DemoClass();

            Calculator calculator = new Calculator();
            calculator.Render();

            //Array

            //nonPrimitivies.DemoArrays();
            nonPrimitivies.DemoStrings();

            //Enums
            nonPrimitivies.DemoShippingMethod();

            //References Type Value Structs
            nonPrimitivies.DemoReferencesTypeValue();

            var number = 1;
            nonPrimitivies.Increment(number);
            Console.WriteLine(number);

            var person = new Person() { Age = 20 };
            nonPrimitivies.MakeOld(person);
            Console.WriteLine(person.Age);

        }

        static void DemoControlFlow()
        {
            ControlFlow controlFlow = new ControlFlow();
            //controlFlow.Sentences();

            //Loops, for, foreach, while
            Loops loops = new Loops();
            //loops.IterationWhileLoop();

            //random values
            RandomClass random = new RandomClass();
            random.RandomValues();

        }

        static void DemoArraysAndList()
        {
            Arrays array = new Arrays();

            Lists lists = new Lists();

            //array.Array_();
            lists.List();
        }

        static void Exercises()
        {
            CSharp1Exercises exercises = new CSharp1Exercises();
            exercises.Exercise4();
        }

    }
}
