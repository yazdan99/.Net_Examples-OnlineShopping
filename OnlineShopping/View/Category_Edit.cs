using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineShopping.View
{
    public partial class Category_Edit : Form
    {
        #region [- ctor -]
        public Category_Edit(int categoryId, string categoryName, string description)
        {
            InitializeComponent();
            Ref_CategoryViewModel = new ViewModel.CategoryViewModel();
            Ref_Category_Edit = new Model.Helper.SPHelper.Category.SpHelper_Category_Edit();
            Ref_Categories_Edit = new List<Model.Helper.SPHelper.Category.SpHelper_Category_Edit>();
            txtCategoryId.Text = System.Convert.ToString(categoryId);
            txtCategoryName.Text = categoryName;
            txtDescriptions.Text = description;
        }
        #endregion

        #region [- Prop -]
        public ViewModel.CategoryViewModel Ref_CategoryViewModel { get; set; }
        public Model.Helper.SPHelper.Category.SpHelper_Category_Edit Ref_Category_Edit { get; set; }
        public List<Model.Helper.SPHelper.Category.SpHelper_Category_Edit> Ref_Categories_Edit { get; set; }
        #endregion

        #region [- Init_Database_Exception() -]
        public int Init_Database_Exception()
        {
            string DatabaseExceptionMessage = Model.Helper.ModelHelper.DatabaseExceptionHandeler();
            if (DatabaseExceptionMessage != null)
            {
                MessageBox.Show(DatabaseExceptionMessage);
                return 0;
            }
            return 1;
        }
        #endregion

        #region [- Init_Database_SP_Message() -]
        public int Init_Database_SP_Message()
        {
            string DatabaseSPMessage = Model.Helper.ModelHelper.DatabaseSpMessage();
            if (DatabaseSPMessage != null)
            {
                MessageBox.Show(DatabaseSPMessage);
                return 0;
            }
            return 1;
        }
        #endregion

        #region [- btnSave_Click -]
        private void btnSave_Click(object sender, EventArgs e)
        {
            #region [- Trim -]
            txtCategoryId.Text = txtCategoryId.Text.Trim();
            txtCategoryName.Text = txtCategoryName.Text.Trim();
            txtDescriptions.Text = txtDescriptions.Text.Trim();
            #endregion

            if (txtCategoryName.Text == "")
            {
                MessageBox.Show("Category Name Can Not Be Empty");
                txtCategoryName.Focus();
            }
            else
            {
                Ref_Categories_Edit.Clear();
                Ref_Category_Edit.CategoryId = System.Convert.ToInt32(txtCategoryId.Text);
                Ref_Category_Edit.CategoryName = txtCategoryName.Text;
                Ref_Category_Edit.Descriptions = txtDescriptions.Text;
                Ref_Categories_Edit.Add(Ref_Category_Edit);
                Ref_CategoryViewModel.Edit(Ref_Categories_Edit);
                if(Init_Database_Exception() != 0)
                {
                    Init_Database_SP_Message();
                    this.Close();
                }  
            }
        }
        #endregion

        #region [- btnExit_Click -]
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

    }
}
