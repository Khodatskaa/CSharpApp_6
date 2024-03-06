using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApp_6
{
    public interface IInstrument : ICloneable
    {
        void Play();
    }

    public class Guitar : IInstrument
    {
        public required string Type { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public void Play()
        {
            Console.WriteLine($"Playing {Type} guitar");
        }
    }

    public class Piano : IInstrument
    {
        public required string Type { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public void Play()
        {
            Console.WriteLine($"Playing {Type} piano");
        }
    }

    public class Drum : IInstrument
    {
        public required string Type { get; set; }

        public object Clone()
        {
            return MemberwiseClone();
        }

        public void Play()
        {
            Console.WriteLine($"Playing {Type} drum");
        }
    }
}
