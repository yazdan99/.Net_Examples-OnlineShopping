using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.ViewModel
{
    public class CategoryViewModel
    {
        #region [- ctor -]
        public CategoryViewModel()
        {
            Ref_CatgoryCrud = new Model.DomainModel.POCO.CategoryCrud();
        }
        #endregion

        #region [- Prop -]
        public Model.DomainModel.POCO.CategoryCrud Ref_CatgoryCrud { get; set; }
        #endregion

        #region [-  FillGrid() -]
        public dynamic FillGrid()
        {
            return Ref_CatgoryCrud.SelectBySp();
        }
        #endregion

        #region [- Select(List<Model.Helper.SPHelper.Category.SpHelper_Category_Select> categooryList) -]
        public dynamic Select(List<Model.Helper.SPHelper.Category.SpHelper_Category_Select> categooryList)
        {
            return Ref_CatgoryCrud.SelectBySp(categooryList);
        }
        #endregion

        #region [- Save(List<Model.Helper.SPHelper.Category.SpHelper_Category_Insert> categooryList) -]
        public void Save(List<Model.Helper.SPHelper.Category.SpHelper_Category_Insert> categooryList)
        {
            Ref_CatgoryCrud.SaveBySp(categooryList);
        }
        #endregion

        #region [- Edit(List<Model.Helper.SPHelper.Category.SpHelper_Category_Edit> categooryList) -]
        public void Edit(List<Model.Helper.SPHelper.Category.SpHelper_Category_Edit> categooryList)
        {
            Ref_CatgoryCrud.EditBySp(categooryList);
        }
        #endregion

        #region [- Delete(List<Model.Helper.SPHelper.Category.SpHelper_Category_Delete> categooryList) -]
        public void Delete(List<Model.Helper.SPHelper.Category.SpHelper_Category_Delete> categooryList)
        {
            Ref_CatgoryCrud.DeleteBySp(categooryList);
        }
        #endregion

    }
}
