using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    public static class Library
    {
        static private List<Book> listOfBooks;
        static Library()
        {
            listOfBooks = new List<Book>();
        }

        public static void Add(Book book)
        {
            listOfBooks.Add(book);
        }

        public static void GetAllBooks()
        {
            foreach(var item in listOfBooks)
            {
                item.Print();
            }
        }
        public static void Print(Book Book)
        {
            if (Book is TechnicalBook)
                Console.WriteLine("Technical");
            else if (Book is Fiction)
                Console.WriteLine("Fiction");
        }
    }
}
