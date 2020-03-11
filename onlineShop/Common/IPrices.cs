using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShop.Common
{
    public interface IPrices<TItem>
    {
        decimal OriginalPriceUSD { get; set; }

        int VAT { get; set; }

        decimal SellPriceUSD { get; set; }

        int Discount { get; set; }
    }
}
