using csharpFundamentals.Math;
using System;

namespace csharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //PrimitivesTypes primitives = new PrimitivesTypes();
            //primitives.Operators();

            var nonPrimitivies = new Non_PrimitiveTypes();


            //NoPrimitiveTypes
            nonPrimitivies.DemoClass();

            //Calculator calculator = new Calculator();
            //calculator.Render();

            //Array

            //nonPrimitivies.DemoArrays();
            nonPrimitivies.DemoStrings();

            //Enums
            nonPrimitivies.DemoShippingMethod();


        }


    }
}
