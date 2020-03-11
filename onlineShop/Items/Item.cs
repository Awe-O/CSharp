using onlineShop.Catalogue;
using onlineShop.Common;
using onlineShop.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShop.Items
{
    public class Item<TItem> : Generators, IItems<TItem>, IPrices<TItem>
        where TItem: class
    {
        private int _id;
        private string _itemName;
        private string _modelCode;
        private string _displayName;
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = createId();
            }
        }
        public string ItemName
        {
            get
            {
                return _itemName;
            }
            set
            {
                _itemName = string.Format("{0} {1}", nameof(TItem), getManufacturer());
            }
        }
        public string ModelCode
        {
            get
            {
                return _modelCode;
            }
            set
            {
                _modelCode = ModelCodeCreator();
            }
        }
        public string DisplayName { get; set; }
        public decimal OriginalPriceUSD { get; set; }
        public int VAT { get; set; }
        public decimal SellPriceUSD { get; set; }
        public int Discount { get; set; }

        public Item()
        {
            _id = createId();
            _itemName = string.Format("{0} {1}", nameof(Laptop), getManufacturer());
            _modelCode = ModelCodeCreator();
            _displayName = string.Format("{0} {1}", _itemName, _modelCode);
        }

        public Item(int id)
        {
            this.Id = id;
        }

        public Item(int id, string itemName) 
            : this (id)
        {
            this.ItemName = itemName;
        }

        public Item(int id, string itemName, string modelCode)
            : this (id, itemName)
        {
            this.ModelCode = modelCode;
        }

        public Item(int id, string itemName, string modelCode, string displayName)
            : this(id, itemName, modelCode)
        {
            this.DisplayName = displayName;
        }


    }
}
