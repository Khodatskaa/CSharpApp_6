using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApp_6
{
    public class FictionLibrary : ILibrary
    {
        public IBook CreateBook()
        {
            return new FictionBook();
        }
    }
}
