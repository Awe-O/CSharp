using onlineShop.Catalogue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShop.Helpers
{
    public class Generators
    {
        private readonly string _latinSymbols = "ABCDEFGHIJKLMPNOPQRSTUVWXYZ";
        private readonly string _numbers = "0123456789";

        private string createPrefix()
        {
            string prefix = "";
            Random rnd = new Random();
            for (int i = 0; i < 3; i++)
            {
                prefix += _latinSymbols[rnd.Next(0, 25)];
            }
            return prefix;
        }

        private string createPostfix()
        {
            string postfix = "";
            Random rnd = new Random();
            for (int i = 0; i < 4; i++)
            {
                postfix += _numbers[rnd.Next(0, 9)];
                if (i > 1)
                {
                    postfix += _latinSymbols[rnd.Next(0, 25)];
                    postfix += _latinSymbols[rnd.Next(0, 25)];
                }
            }
            return postfix;
        }        

        public string ModelCodeCreator()
        {
            string prefix = createPrefix();
            string postfix = createPostfix();
            return string.Format("{0}-{1}", prefix, postfix);
        }

        public int createId()
        {
            Random rnd = new Random();
            int Id = rnd.Next(0, 999999999);
            return Id;
        }

        public decimal createPrice()
        {
            Random rnd = new Random();
            decimal price = rnd.Next(100, 5000);
            return price;
        }

        public string getManufacturer()
        {
            Random rnd = new Random();
            Manufacturers manufact = new Manufacturers();
            return manufact.Manufacturer[rnd.Next(0, 8)];
        }


    }
}
