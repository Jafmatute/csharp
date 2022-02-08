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

            //NoPrimitiveTypes
            var person = new Person();
            person.FirstName = "Josue";
            person.LastName = "Flores";
            person.Introduce();
                
            Calculator calculator = new Calculator();
            int cal = calculator.Add(1, 2);
            Console.WriteLine(cal);

        }


    }
}
