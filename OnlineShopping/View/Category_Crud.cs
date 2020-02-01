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
    public partial class Category_Crud : Form
    {
        #region [- ctor -]
        public Category_Crud()
        {
            InitializeComponent();
            Ref_CategoryViewModel = new ViewModel.CategoryViewModel();
            Ref_Category_Insert = new Model.Helper.SPHelper.Category.SpHelper_Category_Insert();
            Ref_Category_Delete = new Model.Helper.SPHelper.Category.SpHelper_Category_Delete();
            Ref_Category_Select = new Model.Helper.SPHelper.Category.SpHelper_Category_Select();
            Ref_Categories_Insert = new List<Model.Helper.SPHelper.Category.SpHelper_Category_Insert>();
            Ref_Categories_Delete = new List<Model.Helper.SPHelper.Category.SpHelper_Category_Delete>();
            Ref_Categories_Select = new List<Model.Helper.SPHelper.Category.SpHelper_Category_Select>();
        }
        #endregion

        #region [- Prop -]
        public ViewModel.CategoryViewModel Ref_CategoryViewModel { get; set; }
        public Model.Helper.SPHelper.Category.SpHelper_Category_Insert Ref_Category_Insert { get; set; }
        public Model.Helper.SPHelper.Category.SpHelper_Category_Delete Ref_Category_Delete { get; set; }
        public Model.Helper.SPHelper.Category.SpHelper_Category_Select Ref_Category_Select { get; set; }
        public List<Model.Helper.SPHelper.Category.SpHelper_Category_Insert> Ref_Categories_Insert { get; set; }
        public List<Model.Helper.SPHelper.Category.SpHelper_Category_Delete> Ref_Categories_Delete { get; set; }
        public List<Model.Helper.SPHelper.Category.SpHelper_Category_Select> Ref_Categories_Select { get; set; }
        #endregion

        #region [- Init_Category_Crud() -]
        public void Init_Category_Crud()
        {
            btnSelect.Visible = false;    
        }
        #endregion

        #region [- Init_Category_Crud_For_Lookup() -]
        public void Init_Category_Crud_For_Lookup()
        {
            btnSelect.Visible = true;
            btnEdit.Visible = false;
            btnDelete.Visible = false;

        }
        #endregion

        #region [- btnSave_Click -]
        private void btnSave_Click(object sender, EventArgs e)
        {
            #region [- Trim -]
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
                Ref_Categories_Insert.Clear();
                Ref_Category_Insert.CategoryName = txtCategoryName.Text;
                Ref_Category_Insert.Descriptions = txtDescriptions.Text;
                Ref_Categories_Insert.Add(Ref_Category_Insert);
                Ref_CategoryViewModel.Save(Ref_Categories_Insert);
                MessageBox.Show("Save is Done");
                txtCategoryName.Text = "";
                txtDescriptions.Text="";
                txtCategoryName.Focus();
                dgvCategory.DataSource = Ref_CategoryViewModel.FillGrid();
                
            }
        }
        #endregion

        #region [- btnEdit_Click -]
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvCategory.RowCount == 0)
                MessageBox.Show("The Category List is Empty.");
            else
            {
                if (dgvCategory.SelectedRows.Count == 0)
                    MessageBox.Show("Please Selcet a Row.");
                else
                {
                    Category_Edit category_edit_ref = new Category_Edit((int)dgvCategory.CurrentRow.Cells[0].Value,
                        (string)dgvCategory.CurrentRow.Cells[1].Value,
                    (string)dgvCategory.CurrentRow.Cells[2].Value);
                    category_edit_ref.ShowDialog();
                }
            }
        }
        #endregion

        #region [- btnSearch_Click -]
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //dgvCategory.DataSource = Ref_CategoryViewModel.FillGrid();
            #region [- Trim -]
            txtCategoryName.Text = txtCategoryName.Text.Trim();
            txtDescriptions.Text = txtDescriptions.Text.Trim();
            #endregion

            Ref_Categories_Select.Clear();

            Ref_Category_Select.CategoryName = txtCategoryName.Text;
            Ref_Category_Select.Descriptions = txtDescriptions.Text;

            Ref_Categories_Select.Add(Ref_Category_Select);
            dgvCategory.DataSource = Ref_CategoryViewModel.Select(Ref_Categories_Select);
  
            if (dgvCategory.RowCount == 0)
                MessageBox.Show("The Category List is Empty.");
            txtCategoryName.Focus();
        }
        #endregion
               
        #region [- btnDelete_Click -]
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCategory.RowCount == 0)
            {
                MessageBox.Show("The Category List is Empty.");
                txtCategoryName.Focus();
            }
            else
            {
                if (dgvCategory.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please Selcet a Row.");
                    txtCategoryName.Focus();
                }
                else
                {
                    Int32 selectedRowCount = dgvCategory.SelectedRows.Count;
                    if (selectedRowCount > 0)
                    {
                        Ref_Categories_Delete.Clear();
                        for (int i = 0; i < selectedRowCount; i++)
                        {
                            Ref_Category_Delete = new Model.Helper.SPHelper.Category.SpHelper_Category_Delete();
                            Ref_Category_Delete.CategoryId = (int)dgvCategory.SelectedRows[i].Cells[0].Value;
                            Ref_Categories_Delete.Add(Ref_Category_Delete);
                        }
                        int CategoryRowCountBeforDelete = dgvCategory.RowCount;
                        Ref_CategoryViewModel.Delete(Ref_Categories_Delete);
                        dgvCategory.DataSource = Ref_CategoryViewModel.FillGrid();
                        int CategoryRowCountAfterDelete = dgvCategory.RowCount;
                        if (CategoryRowCountBeforDelete == CategoryRowCountAfterDelete)
                        {
                            MessageBox.Show("A Product Already Has Defined With This Category Id.");
                        }
                        else
                        {
                            MessageBox.Show("Delete is Done");
                        }
                      
                        dgvCategory.DataSource = Ref_CategoryViewModel.FillGrid();
                        if (dgvCategory.RowCount == 0)
                            MessageBox.Show("The Category List is Empty.");
                        txtCategoryName.Focus();
                    }
                }
            }
            
        }
        #endregion

        #region [- btnSelect_Click -]
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (dgvCategory.RowCount == 0)
            {
                MessageBox.Show("The Category List is Empty.");
                txtCategoryName.Focus();
            }
            else
            {
                if (dgvCategory.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please Selcet a Row.");
                    txtCategoryName.Focus();
                }
                else
                {
                    OnlineShopping.View.Helper.ViewHelper.CategoryIdLookup = Convert.ToString(dgvCategory.CurrentRow.Cells[0].Value);            
                    this.Close();
                }
            }
            
        }
        #endregion

        #region [- Category_Crud_Activated -]
        private void Category_Crud_Activated(object sender, EventArgs e)
        {
            if (dgvCategory.RowCount != 0)
            {
                dgvCategory.DataSource = Ref_CategoryViewModel.FillGrid();
            }
        }
        #endregion

        #region [- btnExit_Click -]
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

    }
}