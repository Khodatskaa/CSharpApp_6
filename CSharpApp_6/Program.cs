namespace CSharpApp_6
{
    internal class Program
    {
        static void Main()
        {
            Restaurant restaurant1 = Restaurant.Instance;
            Restaurant restaurant2 = Restaurant.Instance;

            Console.WriteLine($"Is restaurant1 the same instance as restaurant2? {ReferenceEquals(restaurant1, restaurant2)}");

            restaurant1.ServeFood("Pasta");
            restaurant2.ServeFood("Steak");
        }
    }
}
