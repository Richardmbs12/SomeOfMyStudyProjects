using WFPresentationLayer;

namespace WindowsFormsApplication1
{
    partial class SalesManagementDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesManagementDepartment));
            this.tabControlSales = new System.Windows.Forms.TabControl();
            this.tabPageMakeSale = new System.Windows.Forms.TabPage();
            this.dgvEnquiries = new System.Windows.Forms.DataGridView();
            this.lblYearsOfWarranty = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbCustomerIDSearch = new System.Windows.Forms.ComboBox();
            this.lblOrderSubTotal = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.txtProductType = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.numProdQty = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbxCart = new System.Windows.Forms.ListBox();
            this.btnFindCustomer = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAnswerCall = new System.Windows.Forms.Button();
            this.btnHoldCall = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.cmbSalSearchIn = new System.Windows.Forms.ComboBox();
            this.txtCName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtSalSearch = new System.Windows.Forms.TextBox();
            this.btnSalSearch = new System.Windows.Forms.Button();
            this.btnEndCall = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.lbxProducts = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tabPageCheckOut = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblAmountReduced = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAmountDue = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblCheckoutTotal = new System.Windows.Forms.Label();
            this.rtxtEnquiryNote = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rTechnicalTaskDesc = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnConfirmOrder = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lbxChekoutProducts = new System.Windows.Forms.ListBox();
            this.btnDash = new System.Windows.Forms.Button();
            this.tabControlSales.SuspendLayout();
            this.tabPageMakeSale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnquiries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProdQty)).BeginInit();
            this.tabPageCheckOut.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlSales
            // 
            this.tabControlSales.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControlSales.Controls.Add(this.tabPageMakeSale);
            this.tabControlSales.Controls.Add(this.tabPageCheckOut);
            this.tabControlSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.tabControlSales.ImageList = this.imageList1;
            this.tabControlSales.Location = new System.Drawing.Point(0, 0);
            this.tabControlSales.Name = "tabControlSales";
            this.tabControlSales.SelectedIndex = 0;
            this.tabControlSales.Size = new System.Drawing.Size(1531, 770);
            this.tabControlSales.TabIndex = 0;
            // 
            // tabPageMakeSale
            // 
            this.tabPageMakeSale.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageMakeSale.Controls.Add(this.dgvEnquiries);
            this.tabPageMakeSale.Controls.Add(this.lblYearsOfWarranty);
            this.tabPageMakeSale.Controls.Add(this.label12);
            this.tabPageMakeSale.Controls.Add(this.cmbCustomerIDSearch);
            this.tabPageMakeSale.Controls.Add(this.lblOrderSubTotal);
            this.tabPageMakeSale.Controls.Add(this.label14);
            this.tabPageMakeSale.Controls.Add(this.label5);
            this.tabPageMakeSale.Controls.Add(this.label3);
            this.tabPageMakeSale.Controls.Add(this.lblProductPrice);
            this.tabPageMakeSale.Controls.Add(this.txtProductType);
            this.tabPageMakeSale.Controls.Add(this.label4);
            this.tabPageMakeSale.Controls.Add(this.label22);
            this.tabPageMakeSale.Controls.Add(this.txtProdName);
            this.tabPageMakeSale.Controls.Add(this.numProdQty);
            this.tabPageMakeSale.Controls.Add(this.label1);
            this.tabPageMakeSale.Controls.Add(this.label11);
            this.tabPageMakeSale.Controls.Add(this.lbxCart);
            this.tabPageMakeSale.Controls.Add(this.btnFindCustomer);
            this.tabPageMakeSale.Controls.Add(this.label2);
            this.tabPageMakeSale.Controls.Add(this.btnCancel);
            this.tabPageMakeSale.Controls.Add(this.btnAnswerCall);
            this.tabPageMakeSale.Controls.Add(this.btnHoldCall);
            this.tabPageMakeSale.Controls.Add(this.btnCheckout);
            this.tabPageMakeSale.Controls.Add(this.lblUnitPrice);
            this.tabPageMakeSale.Controls.Add(this.label18);
            this.tabPageMakeSale.Controls.Add(this.cmbSalSearchIn);
            this.tabPageMakeSale.Controls.Add(this.txtCName);
            this.tabPageMakeSale.Controls.Add(this.txtPhone);
            this.tabPageMakeSale.Controls.Add(this.txtEmail);
            this.tabPageMakeSale.Controls.Add(this.txtSalSearch);
            this.tabPageMakeSale.Controls.Add(this.btnSalSearch);
            this.tabPageMakeSale.Controls.Add(this.btnEndCall);
            this.tabPageMakeSale.Controls.Add(this.btnAddProduct);
            this.tabPageMakeSale.Controls.Add(this.lbxProducts);
            this.tabPageMakeSale.Controls.Add(this.label10);
            this.tabPageMakeSale.Controls.Add(this.label8);
            this.tabPageMakeSale.Controls.Add(this.label15);
            this.tabPageMakeSale.ImageIndex = 9;
            this.tabPageMakeSale.Location = new System.Drawing.Point(4, 60);
            this.tabPageMakeSale.Name = "tabPageMakeSale";
            this.tabPageMakeSale.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMakeSale.Size = new System.Drawing.Size(1523, 706);
            this.tabPageMakeSale.TabIndex = 0;
            this.tabPageMakeSale.Text = "Sales";
            this.tabPageMakeSale.UseVisualStyleBackColor = true;
            // 
            // dgvEnquiries
            // 
            this.dgvEnquiries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEnquiries.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEnquiries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnquiries.Location = new System.Drawing.Point(12, 100);
            this.dgvEnquiries.Name = "dgvEnquiries";
            this.dgvEnquiries.Size = new System.Drawing.Size(550, 239);
            this.dgvEnquiries.TabIndex = 171;
            // 
            // lblYearsOfWarranty
            // 
            this.lblYearsOfWarranty.AutoSize = true;
            this.lblYearsOfWarranty.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYearsOfWarranty.Location = new System.Drawing.Point(1429, 259);
            this.lblYearsOfWarranty.Name = "lblYearsOfWarranty";
            this.lblYearsOfWarranty.Size = new System.Drawing.Size(0, 24);
            this.lblYearsOfWarranty.TabIndex = 170;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1249, 259);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(180, 24);
            this.label12.TabIndex = 169;
            this.label12.Text = "Years of Warranty:";
            // 
            // cmbCustomerIDSearch
            // 
            this.cmbCustomerIDSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCustomerIDSearch.FormattingEnabled = true;
            this.cmbCustomerIDSearch.Location = new System.Drawing.Point(13, 46);
            this.cmbCustomerIDSearch.Name = "cmbCustomerIDSearch";
            this.cmbCustomerIDSearch.Size = new System.Drawing.Size(313, 32);
            this.cmbCustomerIDSearch.TabIndex = 168;
            // 
            // lblOrderSubTotal
            // 
            this.lblOrderSubTotal.AutoSize = true;
            this.lblOrderSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderSubTotal.Location = new System.Drawing.Point(1387, 192);
            this.lblOrderSubTotal.Name = "lblOrderSubTotal";
            this.lblOrderSubTotal.Size = new System.Drawing.Size(49, 24);
            this.lblOrderSubTotal.TabIndex = 167;
            this.lblOrderSubTotal.Text = "0.00";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1249, 192);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(131, 24);
            this.label14.TabIndex = 166;
            this.label14.Text = "Sub Total : R";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(209, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 24);
            this.label5.TabIndex = 165;
            this.label5.Text = "Products  Available";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(970, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 24);
            this.label3.TabIndex = 164;
            this.label3.Text = "Products In Cart:";
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductPrice.Location = new System.Drawing.Point(1387, 127);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(49, 24);
            this.lblProductPrice.TabIndex = 163;
            this.lblProductPrice.Text = "0.00";
            // 
            // txtProductType
            // 
            this.txtProductType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductType.Location = new System.Drawing.Point(929, 238);
            this.txtProductType.Name = "txtProductType";
            this.txtProductType.Size = new System.Drawing.Size(267, 29);
            this.txtProductType.TabIndex = 161;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(929, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 24);
            this.label4.TabIndex = 162;
            this.label4.Text = "Product Type";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(1249, 127);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(132, 24);
            this.label22.TabIndex = 160;
            this.label22.Text = "Unit Price : R";
            // 
            // txtProdName
            // 
            this.txtProdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdName.Location = new System.Drawing.Point(929, 163);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(267, 29);
            this.txtProdName.TabIndex = 155;
            // 
            // numProdQty
            // 
            this.numProdQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numProdQty.Location = new System.Drawing.Point(773, 469);
            this.numProdQty.Name = "numProdQty";
            this.numProdQty.Size = new System.Drawing.Size(167, 30);
            this.numProdQty.TabIndex = 157;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(929, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 24);
            this.label1.TabIndex = 158;
            this.label1.Text = "Product Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(769, 427);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 24);
            this.label11.TabIndex = 156;
            this.label11.Text = "Quantity";
            // 
            // lbxCart
            // 
            this.lbxCart.FormattingEnabled = true;
            this.lbxCart.ItemHeight = 31;
            this.lbxCart.Location = new System.Drawing.Point(974, 383);
            this.lbxCart.Name = "lbxCart";
            this.lbxCart.Size = new System.Drawing.Size(528, 252);
            this.lbxCart.TabIndex = 152;
            this.lbxCart.SelectedIndexChanged += new System.EventHandler(this.lbxCart_SelectedIndexChanged);
            // 
            // btnFindCustomer
            // 
            this.btnFindCustomer.AutoEllipsis = true;
            this.btnFindCustomer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFindCustomer.BackColor = System.Drawing.Color.Transparent;
            this.btnFindCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFindCustomer.BackgroundImage")));
            this.btnFindCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFindCustomer.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnFindCustomer.FlatAppearance.BorderSize = 0;
            this.btnFindCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindCustomer.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnFindCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindCustomer.ImageIndex = 16;
            this.btnFindCustomer.ImageList = this.imageList1;
            this.btnFindCustomer.Location = new System.Drawing.Point(354, 32);
            this.btnFindCustomer.Name = "btnFindCustomer";
            this.btnFindCustomer.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btnFindCustomer.Size = new System.Drawing.Size(209, 61);
            this.btnFindCustomer.TabIndex = 151;
            this.btnFindCustomer.Text = "Find Customer";
            this.btnFindCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFindCustomer.UseCompatibleTextRendering = true;
            this.btnFindCustomer.UseVisualStyleBackColor = false;
            this.btnFindCustomer.Click += new System.EventHandler(this.btnFindCustomer_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "support.png");
            this.imageList1.Images.SetKeyName(1, "Answering.png");
            this.imageList1.Images.SetKeyName(2, "Divert.png");
            this.imageList1.Images.SetKeyName(3, "Hold.png");
            this.imageList1.Images.SetKeyName(4, "EndCall.png");
            this.imageList1.Images.SetKeyName(5, "Remove_from_Basket-512.png");
            this.imageList1.Images.SetKeyName(6, "Dispatch.png");
            this.imageList1.Images.SetKeyName(7, "Tree2.png");
            this.imageList1.Images.SetKeyName(8, "Layer 5.png");
            this.imageList1.Images.SetKeyName(9, "chart.png");
            this.imageList1.Images.SetKeyName(10, "Sell.png");
            this.imageList1.Images.SetKeyName(11, "Order.png");
            this.imageList1.Images.SetKeyName(12, "Stock.png");
            this.imageList1.Images.SetKeyName(13, "Remove_from_Basket-512.png");
            this.imageList1.Images.SetKeyName(14, "Stufff.png");
            this.imageList1.Images.SetKeyName(15, "Places.png");
            this.imageList1.Images.SetKeyName(16, "imagesVPAQIKL6.png");
            this.imageList1.Images.SetKeyName(17, "Checkouts.png");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 24);
            this.label2.TabIndex = 150;
            this.label2.Text = "Customer ID";
            // 
            // btnCancel
            // 
            this.btnCancel.AutoEllipsis = true;
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.ImageIndex = 8;
            this.btnCancel.ImageList = this.imageList1;
            this.btnCancel.Location = new System.Drawing.Point(1128, 642);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btnCancel.Size = new System.Drawing.Size(182, 61);
            this.btnCancel.TabIndex = 147;
            this.btnCancel.Text = "Cancel Item";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseCompatibleTextRendering = true;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAnswerCall
            // 
            this.btnAnswerCall.AutoEllipsis = true;
            this.btnAnswerCall.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAnswerCall.BackColor = System.Drawing.Color.Transparent;
            this.btnAnswerCall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAnswerCall.BackgroundImage")));
            this.btnAnswerCall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnswerCall.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAnswerCall.FlatAppearance.BorderSize = 0;
            this.btnAnswerCall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnswerCall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswerCall.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnAnswerCall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnswerCall.ImageIndex = 1;
            this.btnAnswerCall.ImageList = this.imageList1;
            this.btnAnswerCall.Location = new System.Drawing.Point(17, 390);
            this.btnAnswerCall.Name = "btnAnswerCall";
            this.btnAnswerCall.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btnAnswerCall.Size = new System.Drawing.Size(167, 61);
            this.btnAnswerCall.TabIndex = 117;
            this.btnAnswerCall.Text = "Answer";
            this.btnAnswerCall.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnswerCall.UseCompatibleTextRendering = true;
            this.btnAnswerCall.UseVisualStyleBackColor = false;
            this.btnAnswerCall.Click += new System.EventHandler(this.btnAnswerCall_Click);
            // 
            // btnHoldCall
            // 
            this.btnHoldCall.AutoEllipsis = true;
            this.btnHoldCall.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHoldCall.BackColor = System.Drawing.Color.Transparent;
            this.btnHoldCall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHoldCall.BackgroundImage")));
            this.btnHoldCall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHoldCall.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnHoldCall.Enabled = false;
            this.btnHoldCall.FlatAppearance.BorderSize = 0;
            this.btnHoldCall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoldCall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoldCall.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnHoldCall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoldCall.ImageIndex = 3;
            this.btnHoldCall.ImageList = this.imageList1;
            this.btnHoldCall.Location = new System.Drawing.Point(17, 469);
            this.btnHoldCall.Name = "btnHoldCall";
            this.btnHoldCall.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnHoldCall.Size = new System.Drawing.Size(167, 61);
            this.btnHoldCall.TabIndex = 118;
            this.btnHoldCall.Text = "Hold Call";
            this.btnHoldCall.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHoldCall.UseCompatibleTextRendering = true;
            this.btnHoldCall.UseVisualStyleBackColor = false;
            this.btnHoldCall.Click += new System.EventHandler(this.btnHoldCall_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.AutoEllipsis = true;
            this.btnCheckout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCheckout.BackColor = System.Drawing.Color.Transparent;
            this.btnCheckout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCheckout.BackgroundImage")));
            this.btnCheckout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCheckout.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCheckout.FlatAppearance.BorderSize = 0;
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnCheckout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheckout.ImageIndex = 17;
            this.btnCheckout.ImageList = this.imageList1;
            this.btnCheckout.Location = new System.Drawing.Point(1335, 642);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btnCheckout.Size = new System.Drawing.Size(167, 61);
            this.btnCheckout.TabIndex = 136;
            this.btnCheckout.Text = "Check Out";
            this.btnCheckout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCheckout.UseCompatibleTextRendering = true;
            this.btnCheckout.UseVisualStyleBackColor = false;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitPrice.Location = new System.Drawing.Point(13, 14);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(0, 24);
            this.lblUnitPrice.TabIndex = 133;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(687, 26);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(99, 24);
            this.label18.TabIndex = 128;
            this.label18.Text = "Search In";
            // 
            // cmbSalSearchIn
            // 
            this.cmbSalSearchIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSalSearchIn.ForeColor = System.Drawing.Color.Black;
            this.cmbSalSearchIn.FormattingEnabled = true;
            this.cmbSalSearchIn.Items.AddRange(new object[] {
            "Products",
            "Customers",
            "Orders",
            "Calls",
            "Inventory"});
            this.cmbSalSearchIn.Location = new System.Drawing.Point(792, 22);
            this.cmbSalSearchIn.Name = "cmbSalSearchIn";
            this.cmbSalSearchIn.Size = new System.Drawing.Size(267, 32);
            this.cmbSalSearchIn.TabIndex = 126;
            this.cmbSalSearchIn.Text = "--Select Search Filter--";
            // 
            // txtCName
            // 
            this.txtCName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCName.Location = new System.Drawing.Point(604, 137);
            this.txtCName.Name = "txtCName";
            this.txtCName.Size = new System.Drawing.Size(263, 29);
            this.txtCName.TabIndex = 88;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(604, 214);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(263, 29);
            this.txtPhone.TabIndex = 90;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(604, 291);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(263, 29);
            this.txtEmail.TabIndex = 92;
            // 
            // txtSalSearch
            // 
            this.txtSalSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalSearch.Location = new System.Drawing.Point(1065, 22);
            this.txtSalSearch.Name = "txtSalSearch";
            this.txtSalSearch.Size = new System.Drawing.Size(263, 30);
            this.txtSalSearch.TabIndex = 125;
            // 
            // btnSalSearch
            // 
            this.btnSalSearch.AutoEllipsis = true;
            this.btnSalSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSalSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalSearch.BackgroundImage")));
            this.btnSalSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalSearch.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSalSearch.FlatAppearance.BorderSize = 0;
            this.btnSalSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalSearch.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnSalSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalSearch.ImageIndex = 16;
            this.btnSalSearch.ImageList = this.imageList1;
            this.btnSalSearch.Location = new System.Drawing.Point(1335, 4);
            this.btnSalSearch.Name = "btnSalSearch";
            this.btnSalSearch.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btnSalSearch.Size = new System.Drawing.Size(167, 61);
            this.btnSalSearch.TabIndex = 124;
            this.btnSalSearch.Text = "Search";
            this.btnSalSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalSearch.UseCompatibleTextRendering = true;
            this.btnSalSearch.UseVisualStyleBackColor = false;
            // 
            // btnEndCall
            // 
            this.btnEndCall.AutoEllipsis = true;
            this.btnEndCall.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEndCall.BackColor = System.Drawing.Color.Transparent;
            this.btnEndCall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEndCall.BackgroundImage")));
            this.btnEndCall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEndCall.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEndCall.Enabled = false;
            this.btnEndCall.FlatAppearance.BorderSize = 0;
            this.btnEndCall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEndCall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEndCall.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnEndCall.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEndCall.ImageIndex = 4;
            this.btnEndCall.ImageList = this.imageList1;
            this.btnEndCall.Location = new System.Drawing.Point(17, 548);
            this.btnEndCall.Name = "btnEndCall";
            this.btnEndCall.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnEndCall.Size = new System.Drawing.Size(167, 61);
            this.btnEndCall.TabIndex = 119;
            this.btnEndCall.Text = "End Call";
            this.btnEndCall.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEndCall.UseCompatibleTextRendering = true;
            this.btnEndCall.UseVisualStyleBackColor = false;
            this.btnEndCall.Click += new System.EventHandler(this.btnEndCall_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.AutoEllipsis = true;
            this.btnAddProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnAddProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddProduct.BackgroundImage")));
            this.btnAddProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddProduct.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnAddProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProduct.ImageIndex = 10;
            this.btnAddProduct.ImageList = this.imageList1;
            this.btnAddProduct.Location = new System.Drawing.Point(773, 524);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(167, 61);
            this.btnAddProduct.TabIndex = 114;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddProduct.UseCompatibleTextRendering = true;
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // lbxProducts
            // 
            this.lbxProducts.FormattingEnabled = true;
            this.lbxProducts.ItemHeight = 31;
            this.lbxProducts.Location = new System.Drawing.Point(213, 383);
            this.lbxProducts.Name = "lbxProducts";
            this.lbxProducts.Size = new System.Drawing.Size(528, 252);
            this.lbxProducts.TabIndex = 112;
            this.lbxProducts.SelectedIndexChanged += new System.EventHandler(this.lbxProducts_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(604, 255);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 24);
            this.label10.TabIndex = 93;
            this.label10.Text = "Email Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(604, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 24);
            this.label8.TabIndex = 91;
            this.label8.Text = "Phone Number";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(604, 101);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(160, 24);
            this.label15.TabIndex = 89;
            this.label15.Text = "Customer Name";
            // 
            // tabPageCheckOut
            // 
            this.tabPageCheckOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageCheckOut.Controls.Add(this.groupBox1);
            this.tabPageCheckOut.Controls.Add(this.rtxtEnquiryNote);
            this.tabPageCheckOut.Controls.Add(this.label9);
            this.tabPageCheckOut.Controls.Add(this.rTechnicalTaskDesc);
            this.tabPageCheckOut.Controls.Add(this.label13);
            this.tabPageCheckOut.Controls.Add(this.btnBack);
            this.tabPageCheckOut.Controls.Add(this.btnConfirmOrder);
            this.tabPageCheckOut.Controls.Add(this.label6);
            this.tabPageCheckOut.Controls.Add(this.lbxChekoutProducts);
            this.tabPageCheckOut.ImageIndex = 13;
            this.tabPageCheckOut.Location = new System.Drawing.Point(4, 60);
            this.tabPageCheckOut.Name = "tabPageCheckOut";
            this.tabPageCheckOut.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCheckOut.Size = new System.Drawing.Size(1523, 706);
            this.tabPageCheckOut.TabIndex = 1;
            this.tabPageCheckOut.Text = "Check Out";
            this.tabPageCheckOut.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDiscount);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.lblAmountReduced);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblAmountDue);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.lblCheckoutTotal);
            this.groupBox1.Location = new System.Drawing.Point(366, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(833, 214);
            this.groupBox1.TabIndex = 215;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Billing";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(423, 126);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(22, 24);
            this.lblDiscount.TabIndex = 162;
            this.lblDiscount.Text = "..";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(18, 126);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(214, 24);
            this.label19.TabIndex = 161;
            this.label19.Text = "Contract Discount % : ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(18, 83);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(323, 24);
            this.label16.TabIndex = 159;
            this.label16.Text = "Amount Reduced By Contract : R ";
            // 
            // lblAmountReduced
            // 
            this.lblAmountReduced.AutoSize = true;
            this.lblAmountReduced.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountReduced.Location = new System.Drawing.Point(423, 83);
            this.lblAmountReduced.Name = "lblAmountReduced";
            this.lblAmountReduced.Size = new System.Drawing.Size(22, 24);
            this.lblAmountReduced.TabIndex = 160;
            this.lblAmountReduced.Text = "..";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 24);
            this.label7.TabIndex = 157;
            this.label7.Text = "Amount Due : R ";
            // 
            // lblAmountDue
            // 
            this.lblAmountDue.AutoSize = true;
            this.lblAmountDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountDue.Location = new System.Drawing.Point(423, 172);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(22, 24);
            this.lblAmountDue.TabIndex = 158;
            this.lblAmountDue.Text = "..";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(18, 45);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(137, 24);
            this.label20.TabIndex = 137;
            this.label20.Text = "Sub Total : R ";
            // 
            // lblCheckoutTotal
            // 
            this.lblCheckoutTotal.AutoSize = true;
            this.lblCheckoutTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckoutTotal.Location = new System.Drawing.Point(423, 45);
            this.lblCheckoutTotal.Name = "lblCheckoutTotal";
            this.lblCheckoutTotal.Size = new System.Drawing.Size(49, 24);
            this.lblCheckoutTotal.TabIndex = 156;
            this.lblCheckoutTotal.Text = "0.00";
            // 
            // rtxtEnquiryNote
            // 
            this.rtxtEnquiryNote.Location = new System.Drawing.Point(366, 331);
            this.rtxtEnquiryNote.Name = "rtxtEnquiryNote";
            this.rtxtEnquiryNote.Size = new System.Drawing.Size(403, 129);
            this.rtxtEnquiryNote.TabIndex = 214;
            this.rtxtEnquiryNote.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(362, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 24);
            this.label9.TabIndex = 213;
            this.label9.Text = "Order Note";
            // 
            // rTechnicalTaskDesc
            // 
            this.rTechnicalTaskDesc.Location = new System.Drawing.Point(820, 331);
            this.rTechnicalTaskDesc.Name = "rTechnicalTaskDesc";
            this.rTechnicalTaskDesc.Size = new System.Drawing.Size(379, 129);
            this.rTechnicalTaskDesc.TabIndex = 212;
            this.rTechnicalTaskDesc.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(816, 294);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(205, 24);
            this.label13.TabIndex = 211;
            this.label13.Text = "Technical Task Desc";
            // 
            // btnBack
            // 
            this.btnBack.AutoEllipsis = true;
            this.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.ImageIndex = 17;
            this.btnBack.ImageList = this.imageList1;
            this.btnBack.Location = new System.Drawing.Point(820, 553);
            this.btnBack.Name = "btnBack";
            this.btnBack.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btnBack.Size = new System.Drawing.Size(214, 61);
            this.btnBack.TabIndex = 157;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.UseCompatibleTextRendering = true;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnConfirmOrder
            // 
            this.btnConfirmOrder.AutoEllipsis = true;
            this.btnConfirmOrder.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConfirmOrder.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmOrder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfirmOrder.BackgroundImage")));
            this.btnConfirmOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirmOrder.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConfirmOrder.FlatAppearance.BorderSize = 0;
            this.btnConfirmOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmOrder.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnConfirmOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmOrder.ImageIndex = 14;
            this.btnConfirmOrder.ImageList = this.imageList1;
            this.btnConfirmOrder.Location = new System.Drawing.Point(555, 553);
            this.btnConfirmOrder.Name = "btnConfirmOrder";
            this.btnConfirmOrder.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btnConfirmOrder.Size = new System.Drawing.Size(214, 61);
            this.btnConfirmOrder.TabIndex = 155;
            this.btnConfirmOrder.Text = "Confirm Order";
            this.btnConfirmOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmOrder.UseCompatibleTextRendering = true;
            this.btnConfirmOrder.UseVisualStyleBackColor = false;
            this.btnConfirmOrder.Click += new System.EventHandler(this.btnConfirmOrder_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 24);
            this.label6.TabIndex = 154;
            this.label6.Text = "Products In Cart:";
            // 
            // lbxChekoutProducts
            // 
            this.lbxChekoutProducts.FormattingEnabled = true;
            this.lbxChekoutProducts.ItemHeight = 31;
            this.lbxChekoutProducts.Location = new System.Drawing.Point(17, 55);
            this.lbxChekoutProducts.Name = "lbxChekoutProducts";
            this.lbxChekoutProducts.Size = new System.Drawing.Size(305, 593);
            this.lbxChekoutProducts.TabIndex = 153;
            // 
            // btnDash
            // 
            this.btnDash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDash.AutoEllipsis = true;
            this.btnDash.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDash.BackColor = System.Drawing.Color.Transparent;
            this.btnDash.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDash.BackgroundImage")));
            this.btnDash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDash.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDash.FlatAppearance.BorderSize = 0;
            this.btnDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDash.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnDash.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDash.ImageList = this.imageList1;
            this.btnDash.Location = new System.Drawing.Point(1410, 1);
            this.btnDash.Name = "btnDash";
            this.btnDash.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnDash.Size = new System.Drawing.Size(137, 55);
            this.btnDash.TabIndex = 137;
            this.btnDash.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDash.UseCompatibleTextRendering = true;
            this.btnDash.UseVisualStyleBackColor = false;
            this.btnDash.Click += new System.EventHandler(this.btnDash_Click);
            // 
            // SalesManagementDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1531, 770);
            this.ControlBox = false;
            this.Controls.Add(this.btnDash);
            this.Controls.Add(this.tabControlSales);
            this.Name = "SalesManagementDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesDepartment";
            this.Load += new System.EventHandler(this.SalesManagementDepartment_Load);
            this.tabControlSales.ResumeLayout(false);
            this.tabPageMakeSale.ResumeLayout(false);
            this.tabPageMakeSale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnquiries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProdQty)).EndInit();
            this.tabPageCheckOut.ResumeLayout(false);
            this.tabPageCheckOut.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSales;
        private System.Windows.Forms.TabPage tabPageMakeSale;
        private System.Windows.Forms.TabPage tabPageCheckOut;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtCName;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ListBox lbxProducts;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnEndCall;
        private System.Windows.Forms.Button btnHoldCall;
        private System.Windows.Forms.Button btnAnswerCall;
        private System.Windows.Forms.ComboBox cmbSalSearchIn;
        private System.Windows.Forms.TextBox txtSalSearch;
        private System.Windows.Forms.Button btnSalSearch;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnDash;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnFindCustomer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.TextBox txtProductType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.NumericUpDown numProdQty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListBox lbxCart;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbxChekoutProducts;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblCheckoutTotal;
        private System.Windows.Forms.Button btnConfirmOrder;
        private System.Windows.Forms.Label lblOrderSubTotal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbCustomerIDSearch;
        private System.Windows.Forms.Label lblYearsOfWarranty;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvEnquiries;
        private System.Windows.Forms.RichTextBox rTechnicalTaskDesc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox rtxtEnquiryNote;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblAmountReduced;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAmountDue;
    }
}