using System.Collections.Generic;


namespace CSharpAdvanced.LINQ
{
    public class BookRepository
    {

        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title = "Ado. net step by step", Price = 4},
                new Book() {Title = "ASP.net MVC", Price = 9.99f},
                new Book() {Title = "ASP.NET Web API", Price = 12},
                new Book() {Title = "C# Advanced Topics", Price = 7},
                new Book() {Title = "C# Advanced Topics", Price = 9},

            };
        }

    }
}