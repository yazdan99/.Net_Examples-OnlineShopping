using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShopping.Model.Helper
{
    public static class ModelHelper
    {
        #region [- Prop -]
        public static string DatabaseException { get; set; }
        #endregion

        #region [- ToDataTable<T>(List<T> list_T) -]
        public static DataTable ToDataTable<T>(this List<T> list_T) where T : class
        {

            list_T = list_T == null ? ((List<T>)Activator.CreateInstance(typeof(List<>).MakeGenericType(typeof(T)))) : list_T;
            List<PropertyInfo> properties = ((T)Activator.CreateInstance(typeof(T))).GetType().GetProperties().Where(p => p.GetMethod.IsVirtual == false).ToList();
            DataTable dataTable = new DataTable();
            foreach (var item in properties)
            {
                PropertyInfo property = item;
                dataTable.Columns.Add(property.Name, Nullable.GetUnderlyingType(property.PropertyType) ?? property.PropertyType);
            }
            object[] values = new object[properties.Count];
            foreach (T item in list_T)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = properties[i].GetValue(item);
                }
                dataTable.Rows.Add(values);
            }

            return dataTable;

        }
        #endregion

        #region [- DatabaseExceptionHandeler() -]
        public static string DatabaseExceptionHandeler()
        {
            if (DatabaseException != null)
            {
                string DatabaseExceptionMessage;
                DatabaseExceptionMessage= "Database Exception: " + '\n' + '\n' + DatabaseException;
                DatabaseException = null;
                return DatabaseExceptionMessage;
            }
            return null;
        }
        #endregion

        #region [- DatabaseExceptionHandeler(string databaseException) -]
        public static void DatabaseExceptionHandeler(string databaseException)
        {
            DatabaseException = databaseException;
        }
        #endregion

    }
}
