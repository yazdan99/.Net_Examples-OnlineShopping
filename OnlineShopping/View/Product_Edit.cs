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
    public partial class Product_Edit : Form
    {
        
        #region [- ctor -]
        public Product_Edit(int productId, int productCode , string productName, int categoryId , 
            int quantity , decimal unitPrice , decimal discount , byte [] picture , string description)
        {
            InitializeComponent();
            Ref_ProductViewModel = new ViewModel.ProductViewModel();
            Ref_Product_Edit = new Model.Helper.SPHelper.Product.SpHelper_Product_Edit();
            Ref_Products_Edit = new List<Model.Helper.SPHelper.Product.SpHelper_Product_Edit>();
            txtProductId.Text = System.Convert.ToString(productId);
            txtProductCode.Text = System.Convert.ToString(productCode);
            txtProductName.Text = productName;
            txtCategoryId.Text = System.Convert.ToString(categoryId);
            txtQuantity.Text = System.Convert.ToString(quantity);
            txtUnitPrice.Text = System.Convert.ToString(unitPrice);
            txtDiscount.Text = System.Convert.ToString(discount);
            if (picture != null)
            {
                MemoryStream Ms = new MemoryStream(picture);
                picboImage.Image = Image.FromStream(Ms);
                Img = picture;
            }
            txtDescriptions.Text = description;
        }
        #endregion

        #region [- Prop -]
        public ViewModel.ProductViewModel Ref_ProductViewModel { get; set; }
        public Model.Helper.SPHelper.Product.SpHelper_Product_Edit Ref_Product_Edit { get; set; }
        public List<Model.Helper.SPHelper.Product.SpHelper_Product_Edit> Ref_Products_Edit { get; set; }
        public byte[] Img { get; set; }
        #endregion

        #region [- ReadImageToByte () -]
        public byte[] ReadImageToByte()
        {
            OpenFileDialog Op = new OpenFileDialog();
            if (Op.ShowDialog() == DialogResult.OK)
            {
                FileStream Fs = new FileStream(Op.FileName, FileMode.Open);
                byte[] b = new byte[Fs.Length];
                Fs.Read(b, 0, b.Length);
                MemoryStream Ms = new MemoryStream(b);
                picboImage.Image = Image.FromStream(Ms);
                return b;
            }
            return null;
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

                Ref_Products_Edit.Clear();
                Ref_Product_Edit.ProductId = System.Convert.ToInt32(txtProductId.Text);
                Ref_Product_Edit.ProductCode = Convert.ToInt32(txtProductCode.Text);
                Ref_Product_Edit.ProductName = txtProductName.Text;
                Ref_Product_Edit.CategoryId = Convert.ToInt32(txtCategoryId.Text);
                Ref_Product_Edit.Quantity = Convert.ToInt32(txtQuantity.Text);
                Ref_Product_Edit.UnitPrice = Convert.ToDecimal(txtUnitPrice.Text);
                Ref_Product_Edit.Discount = Convert.ToDecimal(txtDiscount.Text);
                Ref_Product_Edit.Picture = Img;
                Ref_Product_Edit.Descriptions = txtDescriptions.Text;
                Ref_Products_Edit.Add(Ref_Product_Edit);
                Ref_ProductViewModel.Edit(Ref_Products_Edit);
                MessageBox.Show("Edit is Done");
                OnlineShopping.View.Helper.ViewHelper.CategoryIdLookup = null;
                this.Close();
            }
            #endregion
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

        #region [- btnBrImg_Click -]
        private void btnBrImg_Click(object sender, EventArgs e)
        {
            Img = ReadImageToByte();
        }
        #endregion

        #region [- btnDelmg_Click -]
        private void btnDelImg_Click(object sender, EventArgs e)
        {
            picboImage.Image = null;
            Img = null;
        }
        #endregion

        #region [- Product_Edit_Activated -]
        private void Product_Edit_Activated(object sender, EventArgs e)
        {
           if (OnlineShopping.View.Helper.ViewHelper.CategoryIdLookup != null)
                txtCategoryId.Text = OnlineShopping.View.Helper.ViewHelper.CategoryIdLookup;
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
