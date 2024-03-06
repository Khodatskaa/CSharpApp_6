using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApp_6
{
    public interface IFlowerBuilder
    {
        void BuildType();
        void BuildColor();
        void BuildPrice();
        Flower GetFlower();
    }
}
