using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.Model.DomainModel.POCO
{
    public class ProductCrud
    {
        #region [- ctor -]
        public ProductCrud()
        {

        }
        #endregion

        #region [- List<Helper.SPHelper.Product.SpHelper_Product_Select> SelectBySp() -]
        public List<Helper.SPHelper.Product.SpHelper_Product_Select> SelectBySp()
        {
            using (var context = new DTO.EF.OnlineShoppingEntities())
            {
                List<Helper.SPHelper.Product.SpHelper_Product_Select> list_Product = new List<Helper.SPHelper.Product.SpHelper_Product_Select>();
                try
                {
                    list_Product = context.Database.SqlQuery<Helper.SPHelper.Product.SpHelper_Product_Select>
                        (Model.Helper.SPHelper.Product.SpHelper_Product.Usp_Product_List).ToList();
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
                return list_Product;
            }
        }




        #endregion

        #region [- SelectBySp(List<Model.Helper.SPHelper.Product.SpHelper_Product_Select> listProductSelect) -]
        public List<Helper.SPHelper.Product.SpHelper_Product_Select> SelectBySp(List<Model.Helper.SPHelper.Product.SpHelper_Product_Select> listProductSelect)
        {
            using (var context = new DTO.EF.OnlineShoppingEntities())
            {
                List<Helper.SPHelper.Product.SpHelper_Product_Select> list_Product = new List<Helper.SPHelper.Product.SpHelper_Product_Select>();
                try
                {
                    list_Product = context.Database.SqlQuery<Helper.SPHelper.Product.SpHelper_Product_Select>
                    (Model.Helper.SPHelper.Product.SpHelper_Product.USP_Product_Select,
                     Model.Helper.SPHelper.Product.SpHelper_Product.SetSelectParameters(listProductSelect)).ToList();

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
                return list_Product;
            }
        }
        #endregion

        #region [- SaveBySp(List<Model.Helper.SPHelper.Product.SpHelper_Product_Insert> listProductInsert) -]
        public void SaveBySp(List<Model.Helper.SPHelper.Product.SpHelper_Product_Insert> listProductInsert)
        {
            using (var context = new DTO.EF.OnlineShoppingEntities())
            {
                try
                {
                    context.Database.ExecuteSqlCommand(
                        Model.Helper.SPHelper.Product.SpHelper_Product.USP_Product_Insert,
                  Model.Helper.SPHelper.Product.SpHelper_Product.SetInsertParameters(listProductInsert));
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

        #region [- EditBySp(List<Model.Helper.SPHelper.Product.SpHelper_Product_Edit> listProductEdit) -]
        public void EditBySp(List<Model.Helper.SPHelper.Product.SpHelper_Product_Edit> listProductEdit)
        {
            using (var context = new DTO.EF.OnlineShoppingEntities())
            {
                try
                {
                    context.Database.ExecuteSqlCommand(
                        Model.Helper.SPHelper.Product.SpHelper_Product.USP_Product_Edit,
                  Model.Helper.SPHelper.Product.SpHelper_Product.SetEditParameters(listProductEdit));
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

        #region [- DeleteBySp(List<Model.Helper.SPHelper.Product.SpHelper_Product_Delete> listProductDelete) -]
        public void DeleteBySp(List<Model.Helper.SPHelper.Product.SpHelper_Product_Delete> listProductDelete)
        {
            using (var context = new DTO.EF.OnlineShoppingEntities())
            {
                try
                {
                    context.Database.ExecuteSqlCommand(
                        Model.Helper.SPHelper.Product.SpHelper_Product.USP_Product_Delete,
                  Model.Helper.SPHelper.Product.SpHelper_Product.SetDeleteParameters(listProductDelete));
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
    }
}
