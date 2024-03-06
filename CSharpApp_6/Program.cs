namespace CSharpApp_6
{
    internal class Program
    {
        static void Main()
        {
            MusicShop musicShop = new MusicShop();

            musicShop.AddInstrument("acousticGuitar", new Guitar { Type = "Acoustic" });
            musicShop.AddInstrument("electricGuitar", new Guitar { Type = "Electric" });
            musicShop.AddInstrument("grandPiano", new Piano { Type = "Grand" });
            musicShop.AddInstrument("drumSet", new Drum { Type = "Drum Set" });

            musicShop.DisplayCatalog();

            IInstrument acousticGuitar = musicShop.CreateInstrument("acousticGuitar");
            IInstrument electricGuitar = musicShop.CreateInstrument("electricGuitar");
            IInstrument grandPiano = musicShop.CreateInstrument("grandPiano");
            IInstrument drumSet = musicShop.CreateInstrument("drumSet");

            Console.WriteLine("\nPlaying Instruments:");
            acousticGuitar?.Play();
            electricGuitar?.Play();
            grandPiano?.Play();
            drumSet?.Play();
        }
    }
}
