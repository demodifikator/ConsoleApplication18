using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class TechnicalBook : Book
    {
        protected readonly string Theme;
        public TechnicalBook(string Author, string Title, int Pages, string Theme)
            :base(Author, Title, Pages)
        {
            this.Theme = Theme;
        }
        public string FieldOf { get { return Theme; } }
        public override void Print()
        {
            Console.WriteLine($"{Author} {Title} {Pages} {Theme}");
        }
    }
}
