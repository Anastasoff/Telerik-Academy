namespace SQLite
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BookLibrary
    {
        private readonly Book[] books =
        {
            new Book()
            {
                Title = "C# 5.0 in a Nutshell: The Definitive Reference",
                Author = "Joseph Albahari",
                PublishDate = new DateTime(2012, 06, 29),
                ISBN = "978-1449320102"
            },
            new Book()
            {
                Title = "C# in Depth, 3rd Edition",
                Author = "Jon Skeet",
                PublishDate = new DateTime(2013, 09, 30),
                ISBN = "978-1617291340"
            },
            new Book()
            {
                Title = "Pro C# 5.0 and the .NET 4.5 Framework",
                Author = "Andrew Troelsen",
                PublishDate = new DateTime(2012, 08, 21),
                ISBN = "978-1430242338"
            }
        };

        public ICollection<Book> Books
        {
            get
            {
                return this.books.ToList();
            }
        }
    }
}