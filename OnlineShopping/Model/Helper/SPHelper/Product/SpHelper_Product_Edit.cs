using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.Model.Helper.SPHelper.Product
{
    public class SpHelper_Product_Edit
    {
        #region [- ctor -]
        public SpHelper_Product_Edit()
        {

        }
        #endregion

        #region [- Prop -]
        public int ProductId { get; set; }
        public int ProductCode { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public byte[] Picture { get; set; }
        public string Descriptions { get; set; }
        #endregion
    }
}
