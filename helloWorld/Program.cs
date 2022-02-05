using System;

namespace helloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Variables();
        }

        static void Variables()
        {
            byte number = 1;
            int count = 10;
            float totalPrice = 20.95f;
            char character = 'A';
            string firstName = "Josue";
            bool isWorking = true;

            const float Pi = 3.14f;

            Console.WriteLine(number);
            Console.WriteLine( "{0}, {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0},{1}", float.MinValue, float.MaxValue);



        }
    }
}
