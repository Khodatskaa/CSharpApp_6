namespace CSharpApp_6
{
    internal class Program
    {
        static void Main()
        {
            ICoffeeFactory espressoFactory = new EspressoFactory();
            ICoffee espresso = espressoFactory.CreateCoffee();
            ICoffeeCup espressoCup = espressoFactory.CreateCoffeeCup();

            espresso.Brew();
            espressoCup.Pour();

            Console.WriteLine();

            ICoffeeFactory latteFactory = new LatteFactory();
            ICoffee latte = latteFactory.CreateCoffee();
            ICoffeeCup latteCup = latteFactory.CreateCoffeeCup();

            latte.Brew();
            latteCup.Pour();
        }
    }
}
