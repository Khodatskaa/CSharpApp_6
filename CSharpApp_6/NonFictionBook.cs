using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApp_6
{
    public class NonFictionBook : IBook
    {
        public void Display()
        {
            Console.WriteLine("Non-Fiction Book is displayed");
        }
    }
}
