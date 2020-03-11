using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShop.Catalogue
{
    public class Manufacturers
    {
        private readonly string[] _manufacturer = 
        {
            "Intel",
            "AMD",
            "Nvidia",
            "Asus",
            "Sumsung",
            "Aser",
            "LG",
            "Apple",
            "Lenovo"
        };

        public string[] Manufacturer 
        {
        get
            {
                return _manufacturer;
            }                
         }



        public enum Manufact
        {
            Intel,
            AMD,
            Nvidia,
            Asus,
            Sumsung,
            Aser,
            LG,
            Apple,
            Lenovo
        };


    }
}
