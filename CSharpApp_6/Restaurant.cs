using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpApp_6
{
    public sealed class Restaurant
    {
        private static Restaurant? instance;
        private static readonly object lockObject = new object();

        private Chef chef;
        private Waiter waiter;

        private Restaurant()
        {
            chef = new Chef();
            waiter = new Waiter();
        }

        public static Restaurant Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null)
                        {
                            instance = new Restaurant();
                        }
                    }
                }

                return instance;
            }
        }

        public void ServeFood(string dish)
        {
            waiter.TakeOrder(dish);
            chef.Cook(dish);
            waiter.ServeOrder(dish);
        }
    }
}
