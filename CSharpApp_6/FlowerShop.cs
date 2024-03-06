using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApp_6
{
    public class FlowerShop
    {
        public Flower CreateFlower(IFlowerBuilder builder)
        {
            builder.BuildType();
            builder.BuildColor();
            builder.BuildPrice();
            return builder.GetFlower();
        }
    }
}
