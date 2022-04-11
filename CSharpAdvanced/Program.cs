using CSharpAdvanced.Delegate;
using CSharpAdvanced.Events;
using CSharpAdvanced.ExtensionMethods;
using CSharpAdvanced.LambdaExpressions;
using System;
using System.Linq;
using Book = CSharpAdvanced.Generics.Book;

namespace CSharpAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            UseDynamic();
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

        static void UseEventsDelegations()
        {
            var video = new Video() { Title = "video 1" };
            var videoEncoder = new VideoEncoder(); //publisher
            var mailService = new MailService(); //subscribe
            var messageService = new MessageService(); //subscribe

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;
            videoEncoder.Encode(video);
        }

        static void UseExtensionMethods()
        {
            string post = "this is supposed to be a very long blog post blah blah blah blah.....";
            var shortenedPost = post.Shorten(5);

            Console.WriteLine(shortenedPost);
        }

        static void UseLinq()
        {
            var books = new LINQ.BookRepository().GetBooks();

            //var cheapBooks = new List<LINQ.Book>();
            //foreach (var book in books)
            //    if (book.Price < 10)
            //        cheapBooks.Add(book);


            //LINQ  Query Operators
            var cheapBooks1 =
                from b in books
                where b.Price < 10
                orderby b.Title
                select b.Title;

            foreach (var book in cheapBooks1) Console.WriteLine(book);

            Console.WriteLine("----------------------------------------------------------");

            //LINQ Extension method
            var cheapBooks = books
                                                    .Where(b => b.Price < 10)
                                                    .OrderBy(b => b.Title);

            foreach (var cheapBook in cheapBooks) Console.WriteLine(cheapBook.Title + ' ' + cheapBook.Price);

            //Find condition exists
            Console.WriteLine("-------------------------Single-------------------------");
            var single = books.Single(b => b.Title == "ASP.net MVC");
            Console.WriteLine(single.Title);

            Console.WriteLine("-------------------------SingleOrDefault------------------");
            //If not, I'm sure there is a condition to use => return null o true
            var singleOrDefault = books.SingleOrDefault(b => b.Title == "ASP.NET MVC");
            Console.WriteLine(singleOrDefault == null);

            //Find First
            Console.WriteLine("-------------------------First-------------------------");
            var first = books.First(b => b.Title == "C# Advanced Topics");
            Console.WriteLine(first.Title + ' ' + first.Price);


            Console.WriteLine("-----------------------Last---------------------------");
            var last = books.Last(b => b.Title == "C# Advanced Topics");
            Console.WriteLine(last.Title + ' ' + last.Price);

            //Paginate
            Console.WriteLine("------------------------Skip and Take--------------------------");
            var paginate = books.Skip(2).Take(3);
            foreach (var book in paginate) Console.WriteLine(book.Title);

            Console.WriteLine("------------------------- Count-------------------------");
            var count = books.Count();
            Console.WriteLine(count);

            Console.WriteLine("-----------------------Max, min,sum-----------------------");
            var max = books.Max(b => b.Price);
            var min = books.Min(b => b.Price);
            var total = books.Sum(b => b.Price);
            Console.WriteLine("{0}, {1}", max, min);
            Console.WriteLine("sum: {0}", total);
        }

        static void UseNullableTypes()
        {
            var types = new NullableTypes.NullableTypes();
            types.Main();

        }

        static void UseDynamic()
        {
            var dinamic = new Dynamic.Dynamic();
            dinamic.Main();
        }

    }
}
