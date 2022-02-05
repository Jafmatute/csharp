using System;

namespace helloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TypeConversion();
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

        static void TypeConversion()
        {
            byte b = 1;
            int i = b;
            Console.WriteLine( i );

            //reverse
            int a = 1;
            byte ba = (byte) a;

            string number = "1234";
            int iNumber = Convert.ToInt32(number);
            Console.WriteLine( iNumber );

            try
            {
                var n = "1234";
                byte bt = Convert.ToByte(n);
                Console.WriteLine(bt);

            }
            catch (Exception)
            {

                Console.WriteLine("The number could not be convert to a byte");
            }


            //Boolean
            var str = "true";
            bool bs = Convert.ToBoolean(str);
            Console.WriteLine(bs);


        }
    }
}
