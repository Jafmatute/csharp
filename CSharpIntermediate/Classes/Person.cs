using System;
using System.Runtime.CompilerServices;

namespace CSharpIntermediate.Classes
{
    public class Person
    {
        
        public string Name { get; set; }

        public string Username { get; set; }

        private DateTime _birthdate;
        public DateTime BirthDate { get; private set; }


        public Person(DateTime birthdate)
        {
            BirthDate = birthdate;
        }


        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to , Name);
        }

       /* public static Person Parse(string str)
        {
            Person person = new Person
            {
                 
                Name = str
            };

            return person;
        }*/


        public void SetBirthdate(DateTime birthdate)
        {
            this._birthdate = birthdate;
        }

        public  DateTime GetBirthdate()
        {
            return this._birthdate;
        }

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - BirthDate;
                var years = timeSpan.Days / 360;

                return years;
            }
        }
    }
}
