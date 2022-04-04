using CSharpAdvanced.Delegate;
using CSharpAdvanced.LambdaExpressions;
using System;
using Book = CSharpAdvanced.Generics.Book;

namespace CSharpAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            UseLambdaExpressions();
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

        private static void UseDelegation()
        {
            //var processor = new PhotoProcessor();
            //processor.Processor("photo.jpg");

            var processor = new PhotoProcessor();
            var filters = new PhotoFilters();
            Action<Photo> filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;

            //PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
            //filterHandler += filters.ApplyContrast;

            processor.Processor("photo.jpg", filterHandler);
        }

        private static void UseLambdaExpressions()
        {
            var books = new BookRepository().GetBooks();
            var cheapAll = books.FindAll(b => b.Price < 10);

            foreach (var book in cheapAll)
            {
                Console.WriteLine("Title: {0} Price: {1}", book.Title, book.Price);
            }
        }


        static bool IsCheaperThan10Dollars(LambdaExpressions.Book book)
        {
            return book.Price < 10;
        }

    }
}
