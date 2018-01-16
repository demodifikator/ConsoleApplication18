using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class Fiction : TechnicalBook
    {
        public Fiction(string Author, string Title, int Pages, string Theme)
            : base(Author, Title, Pages, Theme)
        {
        }
        //public string MyProperty { get { return Theme; }  }

        public override void Print()
        { 
        }
    }
}
