using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApp_6
{
    public interface ICoffeeFactory
    {
        ICoffee CreateCoffee();
        ICoffeeCup CreateCoffeeCup();
    }

    public interface ICoffee
    {
        void Brew();
    }

    public interface ICoffeeCup
    {
        void Pour();
    }
}
