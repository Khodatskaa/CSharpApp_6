using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApp_6
{
    public class LatteFactory : ICoffeeFactory
    {
        public ICoffee CreateCoffee()
        {
            return new Latte();
        }

        public ICoffeeCup CreateCoffeeCup()
        {
            return new LatteCup();
        }
    }

    public class Latte : ICoffee
    {
        public void Brew()
        {
            Console.WriteLine("Brewing Latte");
        }
    }

    public class LatteCup : ICoffeeCup
    {
        public void Pour()
        {
            Console.WriteLine("Pouring Latte into the cup");
        }
    }

}
