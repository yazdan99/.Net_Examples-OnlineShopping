using System;
using System.Collections.Generic;
//using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.Model.DomainModel.POCO
{
    public class CategoryCrud
    {
        #region [- ctor -]
        public CategoryCrud()
        {

        }
        #endregion

        #region [- List<Helper.SPHelper.Category.SpHelper_Category_Select> SelectBySp() -]
        public List<Helper.SPHelper.Category.SpHelper_Category_Select> SelectBySp()
        {
            using (var context = new DTO.EF.OnlineShoppingEntities())
            {
                List<Helper.SPHelper.Category.SpHelper_Category_Select> list_Category = new List<Helper.SPHelper.Category.SpHelper_Category_Select>();
                try
                {
                    list_Category = context.Database.SqlQuery<Helper.SPHelper.Category.SpHelper_Category_Select>
                        (Model.Helper.SPHelper.Category.SpHelper_Category.Usp_Category_List).ToList();
                }
                catch (Exception ex)
                {

                    //throw;
                    Model.Helper.ModelHelper.DatabaseExceptionHandeler(ex.Message);
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }
                return list_Category;
            }
        }




        #endregion

        #region [- SelectBySp(List<Model.Helper.SPHelper.Category.SpHelper_Category_Select> listCategorySelect) -]
        public List<Helper.SPHelper.Category.SpHelper_Category_Select> SelectBySp(List<Model.Helper.SPHelper.Category.SpHelper_Category_Select> listCategorySelect)
        {
            using (var context = new DTO.EF.OnlineShoppingEntities())
            {
                List<Helper.SPHelper.Category.SpHelper_Category_Select> list_Category = new List<Helper.SPHelper.Category.SpHelper_Category_Select>();
                try
                {
                    list_Category = context.Database.SqlQuery<Helper.SPHelper.Category.SpHelper_Category_Select>
                    (Model.Helper.SPHelper.Category.SpHelper_Category.USP_Category_Select,
                     Model.Helper.SPHelper.Category.SpHelper_Category.SetSelectParameters(listCategorySelect)).ToList();

                }
                catch (Exception ex)
                {

                    //throw;
                    Model.Helper.ModelHelper.DatabaseExceptionHandeler(ex.Message);

                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }
                
                return list_Category;
            }
        }
        #endregion

        #region [- SaveBySp(List<Model.Helper.SPHelper.Category.SpHelper_Category_Insert> listCategoryInsert) -]
        public void SaveBySp(List<Model.Helper.SPHelper.Category.SpHelper_Category_Insert> listCategoryInsert)
        {
            using (var context = new DTO.EF.OnlineShoppingEntities())
            {
                try
                {
                    context.Database.ExecuteSqlCommand(
                        Model.Helper.SPHelper.Category.SpHelper_Category.USP_Category_Insert,
                  Model.Helper.SPHelper.Category.SpHelper_Category.SetInsertParameters(listCategoryInsert));
                }
                catch (Exception ex)
                {

                    //throw;
                    Model.Helper.ModelHelper.DatabaseExceptionHandeler(ex.Message);
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }
            }
        }
        #endregion

        #region [- EditBySp(List<Model.Helper.SPHelper.Category.SpHelper_Category_Edit> listCategoryEdit) -]
        public void EditBySp(List<Model.Helper.SPHelper.Category.SpHelper_Category_Edit> listCategoryEdit)
        {
            using (var context = new DTO.EF.OnlineShoppingEntities())
            {
                try
                {
                    context.Database.ExecuteSqlCommand(
                        Model.Helper.SPHelper.Category.SpHelper_Category.USP_Category_Edit,
                  Model.Helper.SPHelper.Category.SpHelper_Category.SetEditParameters(listCategoryEdit));
                }
                catch (Exception ex)
                {

                    //throw;
                    Model.Helper.ModelHelper.DatabaseExceptionHandeler(ex.Message);
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }
            }
        }
        #endregion

        #region [- DeleteBySp(List<Model.Helper.SPHelper.Category.SpHelper_Category_Delete> listCategoryDelete) -]
        public void DeleteBySp(List<Model.Helper.SPHelper.Category.SpHelper_Category_Delete> listCategoryDelete)
        {
            using (var context = new DTO.EF.OnlineShoppingEntities())
            {
                try
                {
                  context.Database.ExecuteSqlCommand(
                        Model.Helper.SPHelper.Category.SpHelper_Category.USP_Category_Delete,
                  Model.Helper.SPHelper.Category.SpHelper_Category.SetDeleteParameters(listCategoryDelete));                    
                }
                catch (Exception ex)
                {

                    //throw;
                    Model.Helper.ModelHelper.DatabaseExceptionHandeler(ex.Message);
                    //string sss = DbCommand.Parameters["@OutputResult"].Value.ToString();
                    //System.Diagnostics.Debug.Print("  Message: {0}", ex.Message);                 
                    //string retunvalue = Parameters["@OutputResult"].Value.ToString();
                    
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }
                }
            }
        }
        #endregion

    }

}
