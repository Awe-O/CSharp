using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onlineShop.Common
{
    public interface IItems<TItem>
    {
        int Id { get; }
        string ItemName { get; set; }
        string DisplayName { get; }
        string ModelCode { get; set; }
    }
}
