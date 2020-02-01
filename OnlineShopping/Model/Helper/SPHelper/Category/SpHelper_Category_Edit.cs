using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.Model.Helper.SPHelper.Category
{
    public class SpHelper_Category_Edit
    {
        #region [- ctor -]
        public SpHelper_Category_Edit()
        {

        }
        #endregion

        #region [- Prop -]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Descriptions { get; set; }
        #endregion
    }
}
