using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.ViewModel
{
    public class ProductViewModel
    {
        #region [- ctor -]
        public ProductViewModel()
        {
            Ref_ProductCrud = new Model.DomainModel.POCO.ProductCrud();
        }
        #endregion

        #region [- Prop -]
        public Model.DomainModel.POCO.ProductCrud Ref_ProductCrud { get; set; }
        #endregion

        #region [-  FillGrid() -]
        public dynamic FillGrid()
        {
            return Ref_ProductCrud.SelectBySp();
        }
        #endregion

        #region [- Select(List<Model.Helper.SPHelper.Product.SpHelper_Product_Select> productList) -]
        public dynamic Select(List<Model.Helper.SPHelper.Product.SpHelper_Product_Select> productList)
        {
            return Ref_ProductCrud.SelectBySp(productList);
        }
        #endregion

        #region [- Save(List<Model.Helper.SPHelper.Product.SpHelper_Product_Insert> productList) -]
        public void Save(List<Model.Helper.SPHelper.Product.SpHelper_Product_Insert> productList)
        {
            Ref_ProductCrud.SaveBySp(productList);
        }
        #endregion

        #region [- Edit(List<Model.Helper.SPHelper.Product.SpHelper_Product_Edit> productList) -]
        public void Edit(List<Model.Helper.SPHelper.Product.SpHelper_Product_Edit> productList)
        {
            Ref_ProductCrud.EditBySp(productList);
        }
        #endregion

        #region [- Delete(List<Model.Helper.SPHelper.Product.SpHelper_Product_Delete> productList) -]
        public void Delete(List<Model.Helper.SPHelper.Product.SpHelper_Product_Delete> productList)
        {
            Ref_ProductCrud.DeleteBySp(productList);
        }
        #endregion
    }
}
