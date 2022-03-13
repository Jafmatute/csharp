using System;
using System.Collections.Generic;
using System.Text;

namespace csharpFundamentals.Class.Text
{
    class Strings
    {

        public void Strings_()
        {
            var fullName = "Josue Flores ";

            //Trim(), ToUpper(), ToLower
            Console.WriteLine( "Trim: {0}", fullName.Trim());
            Console.WriteLine( "ToUpper: {0}", fullName.ToUpper());
            Console.WriteLine( "ToLower: {0}", fullName.ToLower());

            //Search, Substract
            var index = fullName.IndexOf(' ');
            string firstName = fullName.Substring(0,index);
            string lastName = fullName.Substring(index + 1);
            Console.WriteLine("first name: {0}, last Name: {1}",firstName, lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("first name: {0}, last Name: {1}",names[0], names[1]);

            //Replace
            var name = fullName.Replace("Josue", "Ariel");
            Console.WriteLine(name);

            //Methods, convert
            if (String.IsNullOrEmpty(" ".Trim())) Console.WriteLine("Invalid");
            if (String.IsNullOrWhiteSpace(" ")) Console.WriteLine("Invalid");

            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("C0"));




        }
    }
}
