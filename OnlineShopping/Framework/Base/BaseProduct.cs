using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.Framework.Base
{
    public class BaseProduct : Framework.Interface.IProduct
    {
        #region [- ctor -]
        public BaseProduct(int productId, int productCode, string productName, int categoryId,
                           int quantity, decimal unitPrice, decimal discount, byte[] picture,
                           string descriptions)
        {
            ProductId = productId;
            ProductCode = productCode;
            ProductName = productName;
            CategoryId = categoryId;
            Quantity = quantity;
            UnitPrice = unitPrice;
            Discount = discount;
            Picture = picture;
            Descriptions = descriptions;
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
