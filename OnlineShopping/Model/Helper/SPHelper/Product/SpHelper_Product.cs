using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.Model.Helper.SPHelper.Product
{
    public class SpHelper_Product
    {
        #region [- Const -]
        public const string USP_Product_Select = "dbo.USP_Product_Select @ProductInfo";
        public const string USP_Product_Insert = "dbo.USP_Product_Insert @ProductInfo";
        public const string USP_Product_Edit = "dbo.USP_Product_Edit @ProductInfo";
        public const string USP_Product_Delete = "dbo.USP_Product_Delete @ProductInfo";
        #endregion

        #region [- SetSelectParameters(List<SpHelper_Product_Select> listProductSelect) -]
        public static object[] SetSelectParameters(List<SpHelper_Product_Select> listProductSelect)
        {
            #region [- SqlParameter -]
            SqlParameter productListParameter = new SqlParameter()
            {
                ParameterName = "@ProductInfo",
                SqlDbType = System.Data.SqlDbType.Structured,
                TypeName = "dbo.UDT_Product_Select",
                Value = listProductSelect.ToDataTable()
            };
            #endregion

            #region [- parameters  -]
            object[] parameters =
               {
                productListParameter
            };
            #endregion

            return parameters;
        }
        #endregion

        #region [- SetInsertParameters(List<SpHelper_Product_Insert> listProductInsert) -]
        public static object[] SetInsertParameters(List<SpHelper_Product_Insert> listProductInsert)
        {
            #region [- SqlParameter -]
            SqlParameter productListParameter = new SqlParameter()
            {
                ParameterName = "@ProductInfo",
                SqlDbType = System.Data.SqlDbType.Structured,
                TypeName = "dbo.UDT_Product_Insert",
                Value = listProductInsert.ToDataTable()
            };
            #endregion

            #region [- parameters  -]
            object[] parameters =
               {
                productListParameter
            };
            #endregion

            return parameters;
        }
        #endregion

        #region [- SetEditParameters(List<SpHelper_Product_Edit> listProductEdit) -]
        public static object[] SetEditParameters(List<SpHelper_Product_Edit> listProductEdit)
        {
            #region [- SqlParameter -]
            SqlParameter productListParameter = new SqlParameter()
            {
                ParameterName = "@ProductInfo",
                SqlDbType = System.Data.SqlDbType.Structured,
                TypeName = "dbo.UDT_Product_Edit",
                Value = listProductEdit.ToDataTable()
            };
            #endregion

            #region [- parameters  -]
            object[] parameters =
               {
                productListParameter
            };
            #endregion

            return parameters;
        }
        #endregion

        #region [- SetDeleteParameters(List<SpHelper_Product_Delete> listProductDelete) -]
        public static object[] SetDeleteParameters(List<SpHelper_Product_Delete> listProductDelete)
        {
            #region [- SqlParameter -]
            SqlParameter productListParameter = new SqlParameter()
            {
                ParameterName = "@ProductInfo",
                SqlDbType = System.Data.SqlDbType.Structured,
                TypeName = "dbo.UDT_Product_Delete",
                Value = listProductDelete.ToDataTable()
            };
            #endregion

            #region [- parameters  -]
            object[] parameters =
               {
                productListParameter
            };
            #endregion

            return parameters;
        }
        #endregion

    }
}
