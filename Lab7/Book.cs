using System;
using System.Net;

namespace ClassExample
{
   public class Book
    {
        private string title;
        private string author;


        public Book()  // Default Constructor
        {
            title = "Unknown Title";
            author = "Unknown Author";
        }

        public Book(string title, string author) // Constructor with parameters
        {
            this.title = title;
            this.author = author;
        }

        public string GetTitle()
        {
            return title;
        }

        public void SetTitle(string newTitle)
        {
            this.title = newTitle;
        }
        
        public string GetAuthor()
        {
            return author;
        }
        
        public void SetAuthor(string newAuthor)
        {
            this.author = newAuthor;
        }

    }
    
}