namespace CSharpApp_6
{
    internal class Program
    {
        static void Main()
        {
            FlowerShop flowerShop = new FlowerShop();

            IFlowerBuilder roseBuilder = new RoseBuilder();
            IFlowerBuilder lilyBuilder = new LilyBuilder();

            Flower rose = flowerShop.CreateFlower(roseBuilder);
            Flower lily = flowerShop.CreateFlower(lilyBuilder);

            rose.Display();
            lily.Display();
        }
    }
}
