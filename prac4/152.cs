using System;
using System.Collections.Generic;

class Book
{
    public int Id;
    public string Title;
    public bool IsIssued;
}

class Program
{
    static List<Book> books = new List<Book>();

    static void Main()
    {
        books.Add(new Book { Id = 1, Title = "C# Basics", IsIssued = false });

        foreach (var book in books)
        {
            Console.WriteLine($"{book.Id} - {book.Title} - Issued: {book.IsIssued}");
        }
    }
}