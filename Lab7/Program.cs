using System;

namespace ClassExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            Console.WriteLine(book1.GetTitle());//default book

            book1.SetTitle("C# Fundamentals"); 
            Console.WriteLine(book1.GetTitle());

            Book book2 = new Book();
            book2.SetTitle("Advanced C#");
            Console.WriteLine(book2.GetTitle());

            Book book3 = new Book("Advanced C#", "John Doe");
            Console.WriteLine("Title: " + book3.GetTitle());
            Console.WriteLine("Author: " + book3.GetAuthor());

            Book book4 = new Book();
            book4.SetTitle("Mastering C#");
            book4.SetAuthor("Jane Smith");
            Console.WriteLine("Title: " + book4.GetTitle());
            Console.WriteLine("Author: " + book4.GetAuthor());
            

        }
    }
}
