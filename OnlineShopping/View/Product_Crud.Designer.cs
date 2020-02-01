namespace OnlineShopping.View
{
    partial class Product_Crud
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCategoryId = new System.Windows.Forms.TextBox();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtDescriptions = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnBrImg = new System.Windows.Forms.Button();
            this.picboImage = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboImage)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProduct
            // 
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(11, 271);
            this.dgvProduct.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowTemplate.Height = 24;
            this.dgvProduct.Size = new System.Drawing.Size(553, 260);
            this.dgvProduct.TabIndex = 21;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(12, 18);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 24);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 209);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 110);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 24);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(12, 144);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 10;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(236, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Image :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.btnExit);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Location = new System.Drawing.Point(471, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(93, 248);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 177);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "UnitPrice :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Quantity :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Category Id :";
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.Enabled = false;
            this.txtCategoryId.Location = new System.Drawing.Point(97, 82);
            this.txtCategoryId.Margin = new System.Windows.Forms.Padding(2);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.Size = new System.Drawing.Size(56, 20);
            this.txtCategoryId.TabIndex = 2;
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(97, 24);
            this.txtProductCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(99, 20);
            this.txtProductCode.TabIndex = 0;
            this.txtProductCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtProductCode_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Product Name :";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(97, 53);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(2);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(99, 20);
            this.txtProductName.TabIndex = 1;
            // 
            // txtDescriptions
            // 
            this.txtDescriptions.Location = new System.Drawing.Point(97, 212);
            this.txtDescriptions.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescriptions.Name = "txtDescriptions";
            this.txtDescriptions.Size = new System.Drawing.Size(337, 20);
            this.txtDescriptions.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Descriptions :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1.Controls.Add(this.btnCategory);
            this.groupBox1.Controls.Add(this.btnBrImg);
            this.groupBox1.Controls.Add(this.picboImage);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDiscount);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtUnitPrice);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCategoryId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtProductCode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtProductName);
            this.groupBox1.Controls.Add(this.txtDescriptions);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(11, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 248);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // btnCategory
            // 
            this.btnCategory.Location = new System.Drawing.Point(157, 82);
            this.btnCategory.Margin = new System.Windows.Forms.Padding(2);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(39, 21);
            this.btnCategory.TabIndex = 2;
            this.btnCategory.Text = "...";
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnBrImg
            // 
            this.btnBrImg.Location = new System.Drawing.Point(295, 24);
            this.btnBrImg.Name = "btnBrImg";
            this.btnBrImg.Size = new System.Drawing.Size(96, 23);
            this.btnBrImg.TabIndex = 7;
            this.btnBrImg.Text = "Brows Image";
            this.btnBrImg.UseVisualStyleBackColor = true;
            this.btnBrImg.Click += new System.EventHandler(this.btnBrImg_Click);
            // 
            // picboImage
            // 
            this.picboImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picboImage.Location = new System.Drawing.Point(239, 58);
            this.picboImage.Name = "picboImage";
            this.picboImage.Size = new System.Drawing.Size(156, 138);
            this.picboImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboImage.TabIndex = 22;
            this.picboImage.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Discount :";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(97, 176);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(99, 20);
            this.txtDiscount.TabIndex = 5;
            this.txtDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtDiscount_KeyPress);

            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(97, 147);
            this.txtUnitPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(99, 20);
            this.txtUnitPrice.TabIndex = 4;
            this.txtUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtUnitPrice_KeyPress);

            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(97, 113);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(99, 20);
            this.txtQuantity.TabIndex = 3;
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(txtQuantity_KeyPress);

            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Product Code :";
            // 
            // Product_Crud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 541);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Product_Crud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Product_Crud";
            this.Activated += new System.EventHandler(this.Product_Crud_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtCategoryId;
        public System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtProductName;
        public System.Windows.Forms.TextBox txtDescriptions;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtDiscount;
        public System.Windows.Forms.TextBox txtUnitPrice;
        public System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picboImage;
        private System.Windows.Forms.Button btnBrImg;
        private System.Windows.Forms.Button btnCategory;
    }
}