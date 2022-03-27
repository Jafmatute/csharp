using System;

namespace CSharpIntermediate.Classes
{
    public class Person
    {
        public string Name;
        private DateTime _birthdate;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to , Name);
        }

        public static Person Parse(string str)
        {
            Person person = new Person
            {
                Name = str
            };

            return person;
        }

        public void SetBirthdate(DateTime birthdate)
        {
            this._birthdate = birthdate;
        }

        public  DateTime GetBirthdate()
        {
            return this._birthdate;
        }
    }
}
