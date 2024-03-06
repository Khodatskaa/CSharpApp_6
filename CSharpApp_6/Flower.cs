using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApp_6
{
    public class Flower
    {
        public string? Type { get; set; }
        public string? Color { get; set; }
        public int Price { get; set; }

        public void Display()
        {
            Console.WriteLine($"Flower: {Type}, Color: {Color}, Price: {Price}");
        }
    }
}
