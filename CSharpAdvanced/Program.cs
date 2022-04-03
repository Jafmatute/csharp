using CSharpAdvanced.Generics;
using System;

namespace CSharpAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            UseGenerics();
        }

        private static void UseGenerics()
        {
            var book = new Book { Isbn = "123", Title = "C# Advanced" };

            //var numbers = new List();
            //numbers.Add(10);

            //var books = new BookList();
            //books.Add(book);

            //var numbers = new GenericList<int>();
            //numbers.Add(10);

            //var books = new GenericList<Book>();
            //books.Add(new Book());

            //var dictionary = new GenericDictionary<string, Book>();
            //dictionary.Add("1234", new Book());

            var number = new Generics.Nullable<int>();
            Console.WriteLine(" Has Value ? " + number.HasValue);
            Console.WriteLine("Value " + number.GetValueOrDefault());
        }
    }
}
