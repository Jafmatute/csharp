using System;

namespace CSharpAdvanced.Dynamic
{
    public class Dynamic
    {

        public void Main()
        {
            dynamic name = "Josue";
            name = 20;

            Console.WriteLine(name);

            dynamic a = 10;
            dynamic b = 5;
            var c = a + b;
            Console.WriteLine(c);

            //conversion, not casting
            int i = 2;
            dynamic d = i;

        }

    }
}
