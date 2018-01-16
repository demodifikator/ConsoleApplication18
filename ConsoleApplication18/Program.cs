using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class Program
    {
        static void Main(string[] args)
        {
            Book b = new TechnicalBook ("fgsfd", "dfadfd", 412, "afdafd");
            b.Print();
            Book b1 = new Fiction("asfd", "fddf", 444, "fdasf");
            Library.Print(b);
        }
    }
}
