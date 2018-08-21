namespace WindowsFormsApplication1
{
    partial class ProductManagementDepartment
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductManagementDepartment));
            this.tabProducts = new System.Windows.Forms.TabControl();
            this.tabPageAddProductType = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.nUpDownQuantityStocked = new System.Windows.Forms.NumericUpDown();
            this.txtProductTypePrice = new System.Windows.Forms.TextBox();
            this.nUpDownWarranty = new System.Windows.Forms.NumericUpDown();
            this.btnUploadProductImage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rTxtProductDescription = new System.Windows.Forms.RichTextBox();
            this.lblQuantityInStock = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnRegisterProduct = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPMng = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.nUpDownManageQuantity = new System.Windows.Forms.NumericUpDown();
            this.txtManageProductPrice = new System.Windows.Forms.TextBox();
            this.nUpDownManageProductWarranty = new System.Windows.Forms.NumericUpDown();
            this.rTxtManageProductDescript = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtManageProductName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.dgvMngProd = new System.Windows.Forms.DataGridView();
            this.btnDash = new System.Windows.Forms.Button();
            this.tabProducts.SuspendLayout();
            this.tabPageAddProductType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownQuantityStocked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownWarranty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPMng.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownManageQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownManageProductWarranty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMngProd)).BeginInit();
            this.SuspendLayout();
            // 
            // tabProducts
            // 
            this.tabProducts.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabProducts.Controls.Add(this.tabPageAddProductType);
            this.tabProducts.Controls.Add(this.tabPMng);
            this.tabProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabProducts.ImageList = this.imageList1;
            this.tabProducts.Location = new System.Drawing.Point(0, 0);
            this.tabProducts.Name = "tabProducts";
            this.tabProducts.SelectedIndex = 0;
            this.tabProducts.Size = new System.Drawing.Size(986, 529);
            this.tabProducts.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabProducts.TabIndex = 0;
            // 
            // tabPageAddProductType
            // 
            this.tabPageAddProductType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageAddProductType.Controls.Add(this.label2);
            this.tabPageAddProductType.Controls.Add(this.nUpDownQuantityStocked);
            this.tabPageAddProductType.Controls.Add(this.txtProductTypePrice);
            this.tabPageAddProductType.Controls.Add(this.nUpDownWarranty);
            this.tabPageAddProductType.Controls.Add(this.btnUploadProductImage);
            this.tabPageAddProductType.Controls.Add(this.pictureBox1);
            this.tabPageAddProductType.Controls.Add(this.rTxtProductDescription);
            this.tabPageAddProductType.Controls.Add(this.lblQuantityInStock);
            this.tabPageAddProductType.Controls.Add(this.txtProductName);
            this.tabPageAddProductType.Controls.Add(this.btnReset);
            this.tabPageAddProductType.Controls.Add(this.btnRegisterProduct);
            this.tabPageAddProductType.Controls.Add(this.label4);
            this.tabPageAddProductType.Controls.Add(this.label5);
            this.tabPageAddProductType.Controls.Add(this.label7);
            this.tabPageAddProductType.Controls.Add(this.label8);
            this.tabPageAddProductType.ImageIndex = 2;
            this.tabPageAddProductType.Location = new System.Drawing.Point(4, 60);
            this.tabPageAddProductType.Name = "tabPageAddProductType";
            this.tabPageAddProductType.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddProductType.Size = new System.Drawing.Size(978, 465);
            this.tabPageAddProductType.TabIndex = 3;
            this.tabPageAddProductType.Text = "New Product Line";
            this.tabPageAddProductType.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 24);
            this.label2.TabIndex = 64;
            this.label2.Text = "R :";
            // 
            // nUpDownQuantityStocked
            // 
            this.nUpDownQuantityStocked.Location = new System.Drawing.Point(493, 265);
            this.nUpDownQuantityStocked.Name = "nUpDownQuantityStocked";
            this.nUpDownQuantityStocked.Size = new System.Drawing.Size(164, 35);
            this.nUpDownQuantityStocked.TabIndex = 63;
            // 
            // txtProductTypePrice
            // 
            this.txtProductTypePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductTypePrice.Location = new System.Drawing.Point(67, 274);
            this.txtProductTypePrice.Name = "txtProductTypePrice";
            this.txtProductTypePrice.Size = new System.Drawing.Size(265, 29);
            this.txtProductTypePrice.TabIndex = 62;
            // 
            // nUpDownWarranty
            // 
            this.nUpDownWarranty.Location = new System.Drawing.Point(29, 151);
            this.nUpDownWarranty.Name = "nUpDownWarranty";
            this.nUpDownWarranty.Size = new System.Drawing.Size(120, 35);
            this.nUpDownWarranty.TabIndex = 61;
            // 
            // btnUploadProductImage
            // 
            this.btnUploadProductImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUploadProductImage.Location = new System.Drawing.Point(1026, 276);
            this.btnUploadProductImage.Name = "btnUploadProductImage";
            this.btnUploadProductImage.Size = new System.Drawing.Size(199, 28);
            this.btnUploadProductImage.TabIndex = 59;
            this.btnUploadProductImage.Text = "Upload Product Image";
            this.btnUploadProductImage.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1026, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(317, 180);
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // rTxtProductDescription
            // 
            this.rTxtProductDescription.Location = new System.Drawing.Point(493, 61);
            this.rTxtProductDescription.Name = "rTxtProductDescription";
            this.rTxtProductDescription.Size = new System.Drawing.Size(363, 96);
            this.rTxtProductDescription.TabIndex = 57;
            this.rTxtProductDescription.Text = "";
            // 
            // lblQuantityInStock
            // 
            this.lblQuantityInStock.AutoSize = true;
            this.lblQuantityInStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantityInStock.Location = new System.Drawing.Point(489, 221);
            this.lblQuantityInStock.Name = "lblQuantityInStock";
            this.lblQuantityInStock.Size = new System.Drawing.Size(178, 24);
            this.lblQuantityInStock.TabIndex = 56;
            this.lblQuantityInStock.Text = "Quantity In Stock: ";
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(29, 61);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(303, 29);
            this.txtProductName.TabIndex = 55;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReset.BackgroundImage")));
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnReset.ImageIndex = 4;
            this.btnReset.ImageList = this.imageList1;
            this.btnReset.Location = new System.Drawing.Point(253, 359);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(145, 62);
            this.btnReset.TabIndex = 54;
            this.btnReset.Text = "Reset";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "untitled2.png");
            this.imageList1.Images.SetKeyName(1, "menu.png");
            this.imageList1.Images.SetKeyName(2, "th.jpg");
            this.imageList1.Images.SetKeyName(3, "shs.png");
            this.imageList1.Images.SetKeyName(4, "Layer 5.png");
            this.imageList1.Images.SetKeyName(5, "005.png");
            this.imageList1.Images.SetKeyName(6, "Puzzle+Piece+Icon.png");
            this.imageList1.Images.SetKeyName(7, "Stufff.png");
            this.imageList1.Images.SetKeyName(8, "Trash-1.png");
            // 
            // btnRegisterProduct
            // 
            this.btnRegisterProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnRegisterProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegisterProduct.BackgroundImage")));
            this.btnRegisterProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegisterProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegisterProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterProduct.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnRegisterProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegisterProduct.ImageIndex = 2;
            this.btnRegisterProduct.ImageList = this.imageList1;
            this.btnRegisterProduct.Location = new System.Drawing.Point(26, 359);
            this.btnRegisterProduct.Name = "btnRegisterProduct";
            this.btnRegisterProduct.Size = new System.Drawing.Size(167, 62);
            this.btnRegisterProduct.TabIndex = 51;
            this.btnRegisterProduct.Text = "Register";
            this.btnRegisterProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegisterProduct.UseVisualStyleBackColor = false;
            this.btnRegisterProduct.Click += new System.EventHandler(this.btnRegisterProduct_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 24);
            this.label4.TabIndex = 48;
            this.label4.Text = "Product Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(489, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 24);
            this.label5.TabIndex = 35;
            this.label5.Text = "Product Description";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 24);
            this.label7.TabIndex = 30;
            this.label7.Text = "Product Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(258, 24);
            this.label8.TabIndex = 26;
            this.label8.Text = "Warranty Duration in Years";
            // 
            // tabPMng
            // 
            this.tabPMng.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPMng.Controls.Add(this.label1);
            this.tabPMng.Controls.Add(this.nUpDownManageQuantity);
            this.tabPMng.Controls.Add(this.txtManageProductPrice);
            this.tabPMng.Controls.Add(this.nUpDownManageProductWarranty);
            this.tabPMng.Controls.Add(this.rTxtManageProductDescript);
            this.tabPMng.Controls.Add(this.label3);
            this.tabPMng.Controls.Add(this.txtManageProductName);
            this.tabPMng.Controls.Add(this.label6);
            this.tabPMng.Controls.Add(this.label9);
            this.tabPMng.Controls.Add(this.label10);
            this.tabPMng.Controls.Add(this.label11);
            this.tabPMng.Controls.Add(this.btnRemoveProduct);
            this.tabPMng.Controls.Add(this.btnUpdateProduct);
            this.tabPMng.Controls.Add(this.dgvMngProd);
            this.tabPMng.ImageIndex = 6;
            this.tabPMng.Location = new System.Drawing.Point(4, 60);
            this.tabPMng.Name = "tabPMng";
            this.tabPMng.Padding = new System.Windows.Forms.Padding(3);
            this.tabPMng.Size = new System.Drawing.Size(978, 465);
            this.tabPMng.TabIndex = 2;
            this.tabPMng.Text = "Manage Product Lines";
            this.tabPMng.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 24);
            this.label1.TabIndex = 130;
            this.label1.Text = "R :";
            // 
            // nUpDownManageQuantity
            // 
            this.nUpDownManageQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUpDownManageQuantity.Location = new System.Drawing.Point(384, 422);
            this.nUpDownManageQuantity.Name = "nUpDownManageQuantity";
            this.nUpDownManageQuantity.Size = new System.Drawing.Size(120, 26);
            this.nUpDownManageQuantity.TabIndex = 129;
            // 
            // txtManageProductPrice
            // 
            this.txtManageProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManageProductPrice.Location = new System.Drawing.Point(62, 422);
            this.txtManageProductPrice.Name = "txtManageProductPrice";
            this.txtManageProductPrice.Size = new System.Drawing.Size(265, 29);
            this.txtManageProductPrice.TabIndex = 128;
            // 
            // nUpDownManageProductWarranty
            // 
            this.nUpDownManageProductWarranty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUpDownManageProductWarranty.Location = new System.Drawing.Point(24, 349);
            this.nUpDownManageProductWarranty.Name = "nUpDownManageProductWarranty";
            this.nUpDownManageProductWarranty.Size = new System.Drawing.Size(120, 26);
            this.nUpDownManageProductWarranty.TabIndex = 127;
            // 
            // rTxtManageProductDescript
            // 
            this.rTxtManageProductDescript.Location = new System.Drawing.Point(384, 279);
            this.rTxtManageProductDescript.Name = "rTxtManageProductDescript";
            this.rTxtManageProductDescript.Size = new System.Drawing.Size(319, 96);
            this.rTxtManageProductDescript.TabIndex = 126;
            this.rTxtManageProductDescript.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(380, 386);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 24);
            this.label3.TabIndex = 125;
            this.label3.Text = "Quantity In Stock: ";
            // 
            // txtManageProductName
            // 
            this.txtManageProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtManageProductName.Location = new System.Drawing.Point(24, 279);
            this.txtManageProductName.Name = "txtManageProductName";
            this.txtManageProductName.Size = new System.Drawing.Size(303, 29);
            this.txtManageProductName.TabIndex = 124;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 24);
            this.label6.TabIndex = 123;
            this.label6.Text = "Product Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(380, 252);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(193, 24);
            this.label9.TabIndex = 122;
            this.label9.Text = "Product Description";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 24);
            this.label10.TabIndex = 121;
            this.label10.Text = "Product Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 322);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(258, 24);
            this.label11.TabIndex = 120;
            this.label11.Text = "Warranty Duration in Years";
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.AutoEllipsis = true;
            this.btnRemoveProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemoveProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveProduct.BackgroundImage")));
            this.btnRemoveProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoveProduct.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnRemoveProduct.FlatAppearance.BorderSize = 0;
            this.btnRemoveProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveProduct.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnRemoveProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveProduct.ImageIndex = 8;
            this.btnRemoveProduct.ImageList = this.imageList1;
            this.btnRemoveProduct.Location = new System.Drawing.Point(753, 334);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnRemoveProduct.Size = new System.Drawing.Size(156, 55);
            this.btnRemoveProduct.TabIndex = 119;
            this.btnRemoveProduct.Text = "Remove";
            this.btnRemoveProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoveProduct.UseCompatibleTextRendering = true;
            this.btnRemoveProduct.UseVisualStyleBackColor = false;
            this.btnRemoveProduct.Click += new System.EventHandler(this.btnRemoveProduct_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.AutoEllipsis = true;
            this.btnUpdateProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUpdateProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateProduct.BackgroundImage")));
            this.btnUpdateProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpdateProduct.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnUpdateProduct.FlatAppearance.BorderSize = 0;
            this.btnUpdateProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProduct.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnUpdateProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateProduct.ImageIndex = 0;
            this.btnUpdateProduct.ImageList = this.imageList1;
            this.btnUpdateProduct.Location = new System.Drawing.Point(753, 272);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnUpdateProduct.Size = new System.Drawing.Size(156, 55);
            this.btnUpdateProduct.TabIndex = 118;
            this.btnUpdateProduct.Text = "Update";
            this.btnUpdateProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateProduct.UseCompatibleTextRendering = true;
            this.btnUpdateProduct.UseVisualStyleBackColor = false;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // dgvMngProd
            // 
            this.dgvMngProd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMngProd.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMngProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMngProd.Location = new System.Drawing.Point(8, 6);
            this.dgvMngProd.Name = "dgvMngProd";
            this.dgvMngProd.Size = new System.Drawing.Size(962, 231);
            this.dgvMngProd.TabIndex = 76;
            // 
            // btnDash
            // 
            this.btnDash.BackColor = System.Drawing.Color.Transparent;
            this.btnDash.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDash.BackgroundImage")));
            this.btnDash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDash.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDash.ForeColor = System.Drawing.Color.FloralWhite;
            this.btnDash.Location = new System.Drawing.Point(870, 0);
            this.btnDash.Name = "btnDash";
            this.btnDash.Size = new System.Drawing.Size(145, 57);
            this.btnDash.TabIndex = 1;
            this.btnDash.UseVisualStyleBackColor = false;
            this.btnDash.Click += new System.EventHandler(this.btnDash_Click);
            // 
            // ProductManagementDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 529);
            this.ControlBox = false;
            this.Controls.Add(this.btnDash);
            this.Controls.Add(this.tabProducts);
            this.Name = "ProductManagementDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Procurement_Department";
            this.Load += new System.EventHandler(this.ProductManagementDepartment_Load);
            this.tabProducts.ResumeLayout(false);
            this.tabPageAddProductType.ResumeLayout(false);
            this.tabPageAddProductType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownQuantityStocked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownWarranty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPMng.ResumeLayout(false);
            this.tabPMng.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownManageQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUpDownManageProductWarranty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMngProd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabProducts;
        private System.Windows.Forms.TabPage tabPMng;
        private System.Windows.Forms.Button btnDash;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView dgvMngProd;
        private System.Windows.Forms.Button btnRemoveProduct;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.TabPage tabPageAddProductType;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRegisterProduct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblQuantityInStock;
        private System.Windows.Forms.RichTextBox rTxtProductDescription;
        private System.Windows.Forms.Button btnUploadProductImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nUpDownQuantityStocked;
        private System.Windows.Forms.TextBox txtProductTypePrice;
        private System.Windows.Forms.NumericUpDown nUpDownWarranty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nUpDownManageQuantity;
        private System.Windows.Forms.TextBox txtManageProductPrice;
        private System.Windows.Forms.NumericUpDown nUpDownManageProductWarranty;
        private System.Windows.Forms.RichTextBox rTxtManageProductDescript;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtManageProductName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}