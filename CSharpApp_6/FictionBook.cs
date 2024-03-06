using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApp_6
{
    public class FictionBook : IBook
    {
        public void Display()
        {
            Console.WriteLine("Fiction Book is displayed");
        }
    }
}
