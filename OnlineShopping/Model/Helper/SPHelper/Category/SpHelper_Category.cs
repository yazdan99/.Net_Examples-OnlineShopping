using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.Model.Helper.SPHelper.Category
{
    public static class SpHelper_Category
    {

        #region [- Const -]
        public const string USP_Category_Select = "dbo.USP_Category_Select @CategoryInfo";
        public const string USP_Category_Insert = "dbo.USP_Category_Insert @CategoryInfo";
        public const string USP_Category_Edit = "dbo.USP_Category_Edit @CategoryInfo";
        public const string USP_Category_Delete = "dbo.USP_Category_Delete @CategoryInfo";
        #endregion

        #region [- SetSelectParameters(List<SpHelper_Category_Select> listCategorySelect) -]
        public static object[] SetSelectParameters(List<SpHelper_Category_Select> listCategorySelect)
        {
            #region [- SqlParameter -]
            SqlParameter categoryListParameter = new SqlParameter()
            {
                ParameterName = "@CategoryInfo",
                SqlDbType = System.Data.SqlDbType.Structured,
                TypeName = "dbo.UDT_Category_Select",
                Value = listCategorySelect.ToDataTable()
            };
            #endregion

            #region [- parameters  -]
            object[] parameters =
               {
                categoryListParameter
            };
            #endregion

            return parameters;
        }
        #endregion

        #region [- SetInsertParameters(List<SpHelper_Category_Insert> listCategoryInsert) -]
        public static object[] SetInsertParameters(List<SpHelper_Category_Insert> listCategoryInsert)
        {
            #region [- SqlParameter -]
            SqlParameter categoryListParameter = new SqlParameter()
            {
                ParameterName = "@CategoryInfo",
                SqlDbType = System.Data.SqlDbType.Structured,
                TypeName = "dbo.UDT_Category_Insert",
                Value = listCategoryInsert.ToDataTable()
            };
            #endregion

            #region [- parameters  -]
            object[] parameters =
               {
                categoryListParameter
            };
            #endregion

            return parameters;
        }
        #endregion

        #region [- SetEditParameters(List<SpHelper_Category_Edit> listCategoryEdit) -]
        public static object[] SetEditParameters(List<SpHelper_Category_Edit> listCategoryEdit)
        {
            #region [- SqlParameter -]
            SqlParameter categoryListParameter = new SqlParameter()
            {
                ParameterName = "@CategoryInfo",
                SqlDbType = System.Data.SqlDbType.Structured,
                TypeName = "dbo.UDT_Category_Edit",
                Value = listCategoryEdit.ToDataTable()
            };
            #endregion

            #region [- parameters  -]
            object[] parameters =
               {
                categoryListParameter
            };
            #endregion

            return parameters;
        }
        #endregion

        #region [- SetDeleteParameters(List<SpHelper_Category_Delete> listCategoryDelete) -]
        public static object[] SetDeleteParameters(List<SpHelper_Category_Delete> listCategoryDelete)
        {
            #region [- SqlParameter -]
            SqlParameter categoryListParameter = new SqlParameter()
            {
                ParameterName = "@CategoryInfo",
                SqlDbType = System.Data.SqlDbType.Structured,
                TypeName = "dbo.UDT_Category_Delete",
                Value = listCategoryDelete.ToDataTable(),
            };
            #endregion

            #region [- parameters  -]
            object[] parameters =
               {
                categoryListParameter
            };
            #endregion

            return parameters;
        }
        #endregion

    }

}
