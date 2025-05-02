using System;

namespace ClassExample
{
   public class Book
    {
        private string title;


        public Book()  // Default Constructor
        {
            title = "Unknown Title";
        }

        public string GetTitle()
        {
            return title;
        }

        public void SetTitle(string newTitle)
        {
            this.title = newTitle;
        }
    }
    
}