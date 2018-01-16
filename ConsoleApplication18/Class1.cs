using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    public abstract class Book
    {
        protected readonly string Author, Title;
        protected readonly int Pages;

        public Book()
        {

        }
        public Book(string Author, string Title)
        {
            this.Author = Author;
            this.Title = Title;
        }

        public Book(string Author, string Title, int Pages)
        {
            this.Author = Author;
            this.Title = Title;
            this.Pages = Pages;
        }

        public string AuthorProperty
            { get { return Author; } }

        public string TitleProperty
            { get { return Title; } }

        public int PagesProperty
            { get { return Pages; } }

        public abstract void Print();
    }
}
