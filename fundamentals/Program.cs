using csharpFundamentals.Math;
using System;

namespace csharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
           
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


    }
}
