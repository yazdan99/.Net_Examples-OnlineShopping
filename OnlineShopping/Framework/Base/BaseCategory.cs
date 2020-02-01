using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.Framework.Base
{
    public class BaseCategory : Framework.Interface.ICategory
    {
        #region [- ctor -]
        public BaseCategory(int categoryId, string categoryName, string descriptions)
        {
            CategoryId = categoryId;
            CategoryName = categoryName;
            Descriptions = descriptions;
        }
        #endregion

        #region [- Prop -]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Descriptions { get; set; }
        #endregion

    }
}
