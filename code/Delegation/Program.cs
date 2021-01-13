using System;
using System.Collections.Generic;

namespace Delegation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>()
            {
                new Book{Title="Smith Travels", Price=15M, YearPublished= 2005 },
                new Book{Title="James Travels", Price=3M, YearPublished= 1992 },
                new Book{Title="Gullivers Travels", Price=10M, YearPublished= 1726 },
                new Book{Title="James Adventure", Price=20M, YearPublished= 1999 },
                new Book{Title="Nice Things Oh", Price=5M, YearPublished= 2017 }
            };
            Console.WriteLine("Cheap Books\nTitle\t\tPrice\tYear Published");
            //var cheapBooks = FindCheapBooks(books);
            //var cheapBooks = FindBooks(books, CheapBook);
            var cheapBooks = FindBooks(books, b => b.Price < 10M);
            foreach (var book in cheapBooks)
            {
                Console.WriteLine(book.ToString());
            }

            Console.WriteLine("Recent Books\nTitle\t\tPrice\tYear Published");
            //var recentBooks = FindRecentBooks(books);
            //var recentBooks = FindBooks(books, RecentBook);
            var recentBooks = FindBooks(books, b => b.YearPublished > 1990);
            foreach (var book in recentBooks)
            {
                Console.WriteLine(book.ToString());
            }

            Console.WriteLine("Starts with J");
            //var booksStartingWithJ = FindBooks(books, StartsWith);
            var booksStartingWithJ = FindBooks(books, b => b.Title.StartsWith('J'));
            foreach (var book in booksStartingWithJ)
            {
                Console.WriteLine(book.ToString());
            }
        }
        static List<Book> FindBooks(List<Book> books, Func<Book, bool> func)
        {
            List<Book> booksFound = new List<Book>();
            foreach (var book in books)
            {
                if (func(book))
                    booksFound.Add(book);
            }
            return booksFound;
        }

        //books less than or equal to £10
        //        static bool CheapBook(Book book)
        //        {
        //            return book.Price < 10M;
        //        }
        //        static bool RecentBook(Book book)
        //        {
        //            return book.YearPublished > 1990
        //;
        //        }
        //        static bool StartsWith(Book book)
        //        {
        //            return book.Title.StartsWith("J");
        //        }
        //static List<Book> FindCheapBooks(List<Book> books)
        //{
        //    List<Book> booksFound = new List<Book>();
        //    foreach (var book in books)
        //    {
        //        if (book.Price <= 10)
        //            booksFound.Add(book);
        //    }
        //    return booksFound;
        //}
        //books published 1990 or later
        //static List<Book> FindRecentBooks(List<Book> books)
        //{
        //    List<Book> booksFound = new List<Book>();
        //    foreach (var book in books)
        //    {
        //        if (book.YearPublished >= 1990)
        //            booksFound.Add(book);
        //    }
        //    return booksFound;
        //}
    }
}
