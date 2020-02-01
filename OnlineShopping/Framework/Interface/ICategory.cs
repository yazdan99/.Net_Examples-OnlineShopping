using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.Framework.Interface
{
    public interface ICategory
    {
        #region [- Prop -]
        int CategoryId { get; set; }
        string CategoryName { get; set; }
        string Descriptions { get; set; }
        #endregion
    }
}
