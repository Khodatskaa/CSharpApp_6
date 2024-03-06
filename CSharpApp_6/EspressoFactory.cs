using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApp_6
{
    public class EspressoFactory : ICoffeeFactory
    {
        public ICoffee CreateCoffee()
        {
            return new Espresso();
        }

        public ICoffeeCup CreateCoffeeCup()
        {
            return new EspressoCup();
        }
    }

    public class Espresso : ICoffee
    {
        public void Brew()
        {
            Console.WriteLine("Brewing Espresso");
        }
    }

    public class EspressoCup : ICoffeeCup
    {
        public void Pour()
        {
            Console.WriteLine("Pouring Espresso into the cup");
        }
    }

}
