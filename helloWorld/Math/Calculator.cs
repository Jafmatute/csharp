using System;

namespace csharpFundamentals.Math
{
   public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public void Render()
        {
            int cal = Add(1, 2);
            Console.WriteLine(cal);
        }
    }
}
