using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApp_6
{
    public class MusicShop
    {
        private Dictionary<string, IInstrument> instrumentCatalog = new Dictionary<string, IInstrument>();

        public void AddInstrument(string key, IInstrument prototype)
        {
            instrumentCatalog[key] = prototype;
        }

        public IInstrument? CreateInstrument(string key)
        {
            if (instrumentCatalog.ContainsKey(key))
            {
                return instrumentCatalog[key].Clone() as IInstrument;
            }

            Console.WriteLine($"Instrument with key '{key}' not found in the catalog.");
            return null;
        }

        public void DisplayCatalog()
        {
            Console.WriteLine("Music Shop Catalog:");
            foreach (var instrument in instrumentCatalog)
            {
                Console.WriteLine($"- {instrument.Key}: {instrument.Value.GetType().Name}");
            }
        }
    }
}
