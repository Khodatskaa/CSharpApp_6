using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApp_6
{
    public class RoseBuilder : IFlowerBuilder
    {
        private Flower rose = new Flower();

        public void BuildType()
        {
            rose.Type = "Rose";
        }

        public void BuildColor()
        {
            rose.Color = "Red";
        }

        public void BuildPrice()
        {
            rose.Price = 10;
        }

        public Flower GetFlower()
        {
            return rose;
        }
    }
}

