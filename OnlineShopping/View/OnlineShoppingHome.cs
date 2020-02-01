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
    public partial class OnlineShoppingHome : Form
    {
        #region [- ctor -]
        public OnlineShoppingHome()
        {
            InitializeComponent();
        }
        #endregion

        #region [- categoryToolStripMenuItem_Click -]
        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Category_Crud category_crud_ref = new Category_Crud();
            category_crud_ref.Init_Category_Crud();
            category_crud_ref.ShowDialog();
        }
        #endregion

        #region [- productToolStripMenuItem_Click -]
        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Product_Crud product_crud_ref = new Product_Crud();
            product_crud_ref.ShowDialog();
        }
        #endregion

        #region [- exitToolStripMenuItem_Click -]
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}
