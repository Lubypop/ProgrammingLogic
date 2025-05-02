using System;

namespace ClassExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            Console.WriteLine(book1.GetTitle());

            book1.SetTitle("C# Fundamentals");
            Console.WriteLine(book1.GetTitle());

            Book book2 = new Book();
            Console.WriteLine(book2.GetTitle());

            book2.SetTitle("Advanced C#");
            Console.WriteLine(book2.GetTitle());
        }
    }
}
