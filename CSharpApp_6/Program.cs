namespace CSharpApp_6
{
    internal class Program
    {
        static void Main()
        {
            ILibrary fictionLibrary = new FictionLibrary();
            IBook fictionBook = fictionLibrary.CreateBook();
            fictionBook.Display();

            ILibrary nonFictionLibrary = new NonFictionLibrary();
            IBook nonFictionBook = nonFictionLibrary.CreateBook();
            nonFictionBook.Display();
        }
    }
}
