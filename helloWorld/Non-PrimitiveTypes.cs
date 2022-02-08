using System;

namespace csharpFundamentals
{
    public class Non_PrimitiveTypes
    {

    }

    public class Person
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("My name is:" + FirstName + " " + LastName);
        }
    }
}
