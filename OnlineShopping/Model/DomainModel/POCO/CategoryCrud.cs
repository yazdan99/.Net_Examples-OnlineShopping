using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        #region [- prop -]
        public string SpMessage { get; set; }
        public SqlParameter[] Parameters { get; set; }

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
                    Parameters = Model.Helper.SPHelper.Category.SpHelper_Category.SetSelectParameters(listCategorySelect);
                    list_Category = context.Database.SqlQuery<Helper.SPHelper.Category.SpHelper_Category_Select>
                    (Model.Helper.SPHelper.Category.SpHelper_Category.USP_Category_Select,
                     Parameters).ToList();
                    SpMessage = Parameters[1].Value.ToString();
                    Model.Helper.ModelHelper.DatabaseSpMessage(SpMessage);

                }
                catch (Exception ex)
                {

                    //throw;
                    Model.Helper.ModelHelper.DatabaseExceptionHandeler(ex.Message);
                    SpMessage = Parameters[1].Value.ToString();
                    Model.Helper.ModelHelper.DatabaseSpMessage(SpMessage); ;

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
                    Parameters = Model.Helper.SPHelper.Category.SpHelper_Category.SetInsertParameters(listCategoryInsert);
                    context.Database.ExecuteSqlCommand(Model.Helper.SPHelper.Category.SpHelper_Category.USP_Category_Insert,
                    Parameters);
                    SpMessage = Parameters[1].Value.ToString();
                    Model.Helper.ModelHelper.DatabaseSpMessage(SpMessage);
                }
                catch (Exception ex)
                {

                    //throw;
                    Model.Helper.ModelHelper.DatabaseExceptionHandeler(ex.Message);
                    SpMessage = Parameters[1].Value.ToString();
                    Model.Helper.ModelHelper.DatabaseSpMessage(SpMessage); ;
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
                    Parameters = Model.Helper.SPHelper.Category.SpHelper_Category.SetEditParameters(listCategoryEdit);
                    context.Database.ExecuteSqlCommand(Model.Helper.SPHelper.Category.SpHelper_Category.USP_Category_Edit,
                    Parameters);
                    SpMessage = Parameters[1].Value.ToString();
                    Model.Helper.ModelHelper.DatabaseSpMessage(SpMessage);
                }
                catch (Exception ex)
                {

                    //throw;
                    Model.Helper.ModelHelper.DatabaseExceptionHandeler(ex.Message);
                    SpMessage = Parameters[1].Value.ToString();
                    Model.Helper.ModelHelper.DatabaseSpMessage(SpMessage); ;
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
                    Parameters = Model.Helper.SPHelper.Category.SpHelper_Category.SetDeleteParameters(listCategoryDelete);
                    context.Database.ExecuteSqlCommand(Model.Helper.SPHelper.Category.SpHelper_Category.USP_Category_Delete,
                    Parameters);
                    SpMessage = Parameters[1].Value.ToString();
                    Model.Helper.ModelHelper.DatabaseSpMessage(SpMessage);
                }
                catch (Exception ex)
                {
                    //throw;
                    Model.Helper.ModelHelper.DatabaseExceptionHandeler(ex.Message);
                    SpMessage = Parameters[1].Value.ToString();
                    Model.Helper.ModelHelper.DatabaseSpMessage(SpMessage);
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
