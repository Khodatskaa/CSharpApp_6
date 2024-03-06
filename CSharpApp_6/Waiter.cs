using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApp_6
{
    public class Waiter
    {
        public void TakeOrder(string dish)
        {
            Console.WriteLine($"Waiter is taking an order for {dish}");
        }

        public void ServeOrder(string dish)
        {
            Console.WriteLine($"Waiter is serving {dish}");
        }
    }
}
