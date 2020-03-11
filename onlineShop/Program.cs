using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using onlineShop.Helpers;
using onlineShop.Items;

namespace onlineShop
{
    class Program
    {
        static void Main(string[] args)
        {

            Generators generator = new Generators();
            List<Item<Laptop>> laptops = new List<Item<Laptop>>();
            for (int i = 0; i < 10; i++)
            {

                laptops.Add(new Item<Laptop>() { OriginalPriceUSD = generator.createPrice() });
            }

        }
    }
}
