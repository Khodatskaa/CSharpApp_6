using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApp_6
{
    public class LilyBuilder : IFlowerBuilder
    {
        private Flower lily = new Flower();

        public void BuildType()
        {
            lily.Type = "Lily";
        }

        public void BuildColor()
        {
            lily.Color = "White";
        }

        public void BuildPrice()
        {
            lily.Price = 15;
        }

        public Flower GetFlower()
        {
            return lily;
        }
    }
}
