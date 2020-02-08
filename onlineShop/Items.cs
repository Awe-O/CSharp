using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShop
{
    public class Items
    {
        private int _id;
        private string _name;
        private string _description;
        private string _coulor;
        private decimal _price;
        private bool _availability;
        private int _itemsAvailable;

        public Items()
        {
            
        }

        public Items(int id)
        {
            _id = id;
        }

        public Items(int id, string name, decimal price)
            : this(id)
        {            
            _name = name;
            _price = price;
        }

        public Items(int id, string name, decimal price, 
            bool availability, int itemsAvailable)
            : this(id, name, price)
        {
            _availability = availability;
            _itemsAvailable = itemsAvailable;
        }

        public Items(int id, string name, decimal price,
            bool availability, int itemsAvailible, 
            string description, string coulor)
            : this(id, name, price, availability, itemsAvailible)
        {
            _description = description;
            _coulor = coulor;
        }

        public int Id { get { return _id; } }
        public string Name { get { return _name; } }
        public string Description { get { return _description; } }
        public string Colour { get { return _coulor; } }
        public decimal Price { get { return _price; } }
        public bool Availability { get { return _availability; } }
        public int ItemsAbailable { get { return _itemsAvailable; } }
    }
}
