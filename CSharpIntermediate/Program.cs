using System;
using System.Globalization;
using CSharpIntermediate.Classes;

namespace CSharpIntermediate
{

    
    class Program
    {
        static void Main()
        {
            TryParse();
         
        }

        static void UsePoint()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(null);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

                point.Move(100, 200);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
            }
            catch (Exception e)
            {
                Console.WriteLine("an unexpected error ocurred", e);
                
            }
        }

        static void UseParams()
        {
            var calculator = new Calculator();

            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 4 }));
        }

        static void TryParse()
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
    }
}
