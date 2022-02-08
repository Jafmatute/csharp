using System;

namespace csharpFundamentals
{
    public class Non_PrimitiveTypes
    {
        public void DemoArrays()
        {
            //Arrays
            var numbers = new int[3];
            numbers[0] = 1;
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            //Boolean
            var flags = new bool[3];
            flags[0] = true;
            Console.WriteLine(flags[0]);
            Console.WriteLine(flags[1]);
            Console.WriteLine(flags[2]);

            //Strings
            var names = new string[3] { "Jack", "Many", "Torry" };
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
        }

        public void DemoStrings()
        {
            var firstName = "Josue";
            String lastName = "Flores";
            string myName = "Josue Flores";

            var fullName = firstName+ " " + lastName;

            var myFullName = string.Format("my name is: {0} {1}", firstName, lastName);

            var names = new string[3] { "John", "Jack", "Mary" };
            var fomattedNames = string.Join(",", names);

            var text = "Hi John\nLook into the following paths\nc:\\folder1\\folder2\nc:\\folder3\\folder4";
            var text2 = @"Hi John
Look into the following paths
c:\folder1\folder2
c:\folder3\folder4";
            Console.WriteLine(text2);


        }
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
