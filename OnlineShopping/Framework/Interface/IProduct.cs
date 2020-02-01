using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.Framework.Interface
{
    public interface IProduct
    {
        #region [- Prop -]
        int ProductId { get; set; }
        int ProductCode { get; set; }
        string ProductName { get; set; }
        int CategoryId { get; set; }
        int Quantity { get; set; }
        decimal UnitPrice { get; set; }
        decimal Discount { get; set; }
        byte[] Picture { get; set; }
        string Descriptions { get; set; }
        #endregion
    }
}
