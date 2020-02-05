using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OnlineShopping.View
{
    public partial class Product_Crud : Form
    {
        #region [- ctor -]
        public Product_Crud()
        {
            InitializeComponent();
            Ref_ProductViewModel = new ViewModel.ProductViewModel();
            Ref_Product_Insert = new Model.Helper.SPHelper.Product.SpHelper_Product_Insert();
            Ref_Product_Delete = new Model.Helper.SPHelper.Product.SpHelper_Product_Delete();
            Ref_Product_Select = new Model.Helper.SPHelper.Product.SpHelper_Product_Select();
            Ref_Products_Insert = new List<Model.Helper.SPHelper.Product.SpHelper_Product_Insert>();
            Ref_Products_Delete = new List<Model.Helper.SPHelper.Product.SpHelper_Product_Delete>();
            Ref_Products_Select = new List<Model.Helper.SPHelper.Product.SpHelper_Product_Select>();
        }
        #endregion

        #region [- Prop -]
        public ViewModel.ProductViewModel Ref_ProductViewModel { get; set; }
        public Model.Helper.SPHelper.Product.SpHelper_Product_Insert Ref_Product_Insert { get; set; }
        public Model.Helper.SPHelper.Product.SpHelper_Product_Delete Ref_Product_Delete { get; set; }
        public Model.Helper.SPHelper.Product.SpHelper_Product_Select Ref_Product_Select { get; set; }
        public List<Model.Helper.SPHelper.Product.SpHelper_Product_Insert> Ref_Products_Insert { get; set; }
        public List<Model.Helper.SPHelper.Product.SpHelper_Product_Delete> Ref_Products_Delete { get; set; }
        public List<Model.Helper.SPHelper.Product.SpHelper_Product_Select> Ref_Products_Select { get; set; }
        public byte[] Img { get; set; }
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

        #region [- ReadImageToByte () -]
        public byte[] ReadImageToByte ()
        {
            OpenFileDialog Op = new OpenFileDialog();
            if (Op.ShowDialog()==DialogResult.OK)
            {
                FileStream Fs = new FileStream(Op.FileName,FileMode.Open);
                byte[] b = new byte[Fs.Length];
                Fs.Read(b, 0, b.Length);
                MemoryStream Ms = new MemoryStream(b);
                picboImage.Image = Image.FromStream(Ms);
                return b;
            }
            return null;
        }
        #endregion

        #region [- btnSearch_Click -]
        private void btnSearch_Click(object sender, EventArgs e)
        {
            #region [- Trim -]
            txtProductCode.Text = txtProductCode.Text.Trim();
            txtProductName.Text = txtProductName.Text.Trim();
            txtCategoryId.Text = txtCategoryId.Text.Trim();
            txtQuantity.Text = txtQuantity.Text.Trim();
            txtUnitPrice.Text = txtUnitPrice.Text.Trim();
            txtDiscount.Text = txtDiscount.Text.Trim();
            txtDescriptions.Text = txtDescriptions.Text.Trim();
            #endregion

            Ref_Products_Select.Clear();

            if (txtProductCode.Text != "")
                Ref_Product_Select.ProductCode = Convert.ToInt32(txtProductCode.Text);
            else
                Ref_Product_Select.ProductCode = 0;
            Ref_Product_Select.ProductName = txtProductName.Text;
            Ref_Product_Select.Descriptions = txtDescriptions.Text;

            Ref_Products_Select.Add(Ref_Product_Select);
            dgvProduct.DataSource = Ref_ProductViewModel.Select(Ref_Products_Select);
            if (Init_Database_Exception() != 0)
            {
                if (dgvProduct.RowCount == 0)
                    MessageBox.Show("The Product List is Empty.");
                txtProductCode.Focus();
            }
            txtProductCode.Focus();
        }
        #endregion

        #region [- btnSave_Click -]
        private void btnSave_Click(object sender, EventArgs e)
        {
            #region [- Trim -]
            txtProductCode.Text = txtProductCode.Text.Trim();
            txtProductName.Text = txtProductName.Text.Trim();
            txtCategoryId.Text = txtCategoryId.Text.Trim();
            txtQuantity.Text = txtQuantity.Text.Trim();
            txtUnitPrice.Text = txtUnitPrice.Text.Trim();
            txtDiscount.Text = txtDiscount.Text.Trim();
            txtDescriptions.Text = txtDescriptions.Text.Trim();
            #endregion

            #region [- Control Mandatory Fields -]
            if (txtProductCode.Text == "" || txtProductName.Text == "" || txtCategoryId.Text == "")
            {
                if (txtProductCode.Text == "")
                {
                    MessageBox.Show("Product Code Can Not Be Empty");
                    txtProductCode.Focus();
                }
                else if (txtProductName.Text == "")
                {
                    MessageBox.Show("Product Name Can Not Be Empty");
                    txtProductName.Focus();
                }
                else if (txtCategoryId.Text == "")
                {
                    MessageBox.Show("Category Id Can Not Be Empty");
                    btnCategory.Focus();
                }
            }
            else
            {
                #region [- Convert Null To Zero For Price Fields -]
                if (txtQuantity.Text == "")
                    txtQuantity.Text = Convert.ToString(0);
                if (txtUnitPrice.Text == "")
                    txtUnitPrice.Text = Convert.ToString(0);
                if (txtDiscount.Text == "")
                    txtDiscount.Text = Convert.ToString(0);
                #endregion

                Ref_Products_Insert.Clear();
                Ref_Product_Insert.ProductCode = Convert.ToInt32(txtProductCode.Text);
                Ref_Product_Insert.ProductName = txtProductName.Text;
                Ref_Product_Insert.CategoryId = Convert.ToInt32(txtCategoryId.Text);
                Ref_Product_Insert.Quantity = Convert.ToInt32(txtQuantity.Text);
                Ref_Product_Insert.UnitPrice = Convert.ToInt32(txtUnitPrice.Text);
                Ref_Product_Insert.Discount = Convert.ToInt32(txtDiscount.Text);
                Ref_Product_Insert.Picture = Img; 
                Ref_Product_Insert.Descriptions = txtDescriptions.Text;
                Ref_Products_Insert.Add(Ref_Product_Insert);
                Ref_ProductViewModel.Save(Ref_Products_Insert);
                if (Init_Database_Exception() != 0)
                {
                    MessageBox.Show("Save is Done");

                    #region [- Clear Product Form -]
                    txtProductCode.Text = "";
                    txtProductName.Text = "";
                    txtCategoryId.Text = "";
                    txtQuantity.Text = "";
                    txtUnitPrice.Text = "";
                    txtDiscount.Text = "";
                    txtDescriptions.Text = "";
                    picboImage.Image = null;
                    Img = null;
                    txtProductCode.Focus();
                    #endregion

                    OnlineShopping.View.Helper.ViewHelper.CategoryIdLookup = null;
                    dgvProduct.DataSource = Ref_ProductViewModel.FillGrid();
                    Init_Database_Exception();
                }
            }
            #endregion

        }
        #endregion

        #region [- btnBrImg_Click -]
        private void btnBrImg_Click(object sender, EventArgs e)
        {
            Img = ReadImageToByte();
        }
        #endregion

        #region [- btnDelete_Click -]
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProduct.RowCount == 0)
            {
                MessageBox.Show("The Product List is Empty.");
                txtProductCode.Focus();
            }
            else
            {
                if (dgvProduct.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please Selcet a Row.");
                    txtProductCode.Focus();
                }
                else
                {
                    Int32 selectedRowCount = dgvProduct.SelectedRows.Count;
                    if (selectedRowCount > 0)
                    {
                        Ref_Products_Delete.Clear();
                        for (int i = 0; i < selectedRowCount; i++)
                        {
                            Ref_Product_Delete = new Model.Helper.SPHelper.Product.SpHelper_Product_Delete();
                            Ref_Product_Delete.ProductId = (int)dgvProduct.SelectedRows[i].Cells[0].Value;
                            Ref_Products_Delete.Add(Ref_Product_Delete);
                        }
                        Ref_ProductViewModel.Delete(Ref_Products_Delete);
                        if (Init_Database_Exception() != 0)
                        {
                            MessageBox.Show("Delete is Done");
                            dgvProduct.DataSource = Ref_ProductViewModel.FillGrid();
                            Init_Database_Exception();
                            if (dgvProduct.RowCount == 0)
                                MessageBox.Show("The Product List is Empty.");
                            txtProductCode.Focus();
                        }
                    }
                }
            }
        }
        #endregion

        #region [- btnEdit_Click -]
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvProduct.RowCount == 0)
                MessageBox.Show("The Product List is Empty.");
            else
            {
                if (dgvProduct.SelectedRows.Count == 0)
                    MessageBox.Show("Please Selcet a Row.");
                else
                {
                    Product_Edit product_edit_ref = new Product_Edit((int)dgvProduct.CurrentRow.Cells[0].Value,
                                                                    (int)dgvProduct.CurrentRow.Cells[1].Value,
                                                                    (string)dgvProduct.CurrentRow.Cells[2].Value,
                                                                    (int)dgvProduct.CurrentRow.Cells[3].Value,
                                                                    (int)dgvProduct.CurrentRow.Cells[4].Value,
                                                                    (decimal)dgvProduct.CurrentRow.Cells[5].Value,
                                                                    (decimal)dgvProduct.CurrentRow.Cells[6].Value,
                                                                    (byte[])dgvProduct.CurrentRow.Cells[7].Value,
                                                                    (string)dgvProduct.CurrentRow.Cells[8].Value);
                    product_edit_ref.ShowDialog();
                }
            }
        }
        #endregion

        #region [- btnCategory_Click -]
        private void btnCategory_Click(object sender, EventArgs e)
        {
            Category_Crud category_crud_ref = new Category_Crud();
            category_crud_ref.Init_Category_Crud_For_Lookup();
            category_crud_ref.ShowDialog();
        }
        #endregion

        #region [- Product_Crud_Activated -]
        private void Product_Crud_Activated(object sender, EventArgs e)
        {
            if (OnlineShopping.View.Helper.ViewHelper.CategoryIdLookup != null)
            {
                txtCategoryId.Text = OnlineShopping.View.Helper.ViewHelper.CategoryIdLookup;
            }
            if (dgvProduct.RowCount != 0)
            {
                dgvProduct.DataSource = Ref_ProductViewModel.FillGrid();
            }
        }
        #endregion

        #region [- txtProductCode_KeyPress -]
        private void txtProductCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }          
        }
        #endregion

        #region [- txtQuantity_KeyPress -]
        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region [- txtUnitPrice_KeyPress -]
        private void txtUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region [- txtDiscount_KeyPress -]
        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
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
