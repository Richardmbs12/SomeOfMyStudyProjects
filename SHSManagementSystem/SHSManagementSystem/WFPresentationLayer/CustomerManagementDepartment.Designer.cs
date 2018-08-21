namespace WindowsFormsApplication1
{
    partial class CustomerManagementDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerManagementDepartment));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabAddCust = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtCustFullName = new System.Windows.Forms.TextBox();
            this.txtRSAID = new System.Windows.Forms.TextBox();
            this.txtCustGender = new System.Windows.Forms.TextBox();
            this.txtCustSurname = new System.Windows.Forms.TextBox();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.txtCustTitle = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.dtCustDOB = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.txtCustMobile = new System.Windows.Forms.TextBox();
            this.txtCustEmail = new System.Windows.Forms.TextBox();
            this.txtCustWorkTel = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.txtBank = new System.Windows.Forms.TextBox();
            this.txtBranch = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtContractEndDate = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbContractType = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCustCountry = new System.Windows.Forms.TextBox();
            this.txtCustCity = new System.Windows.Forms.TextBox();
            this.txtCustPostalCode = new System.Windows.Forms.TextBox();
            this.txtCustSuburb = new System.Windows.Forms.TextBox();
            this.txtCustAddressLine1 = new System.Windows.Forms.TextBox();
            this.txtCustAddressLine2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCReg = new System.Windows.Forms.Button();
            this.btnCReset = new System.Windows.Forms.Button();
            this.tabMngC = new System.Windows.Forms.TabPage();
            this.btnViewCustomerAdditionalInfo = new System.Windows.Forms.Button();
            this.btnSearchCust = new System.Windows.Forms.Button();
            this.dgvMngCust = new System.Windows.Forms.DataGridView();
            this.txtUpFullName = new System.Windows.Forms.TextBox();
            this.txtUpGender = new System.Windows.Forms.TextBox();
            this.txtUpWorkTel = new System.Windows.Forms.TextBox();
            this.txtUpCountry = new System.Windows.Forms.TextBox();
            this.txtUpCity = new System.Windows.Forms.TextBox();
            this.txtUpPostalCode = new System.Windows.Forms.TextBox();
            this.txtUpSuburb = new System.Windows.Forms.TextBox();
            this.txtUpAddressLine1 = new System.Windows.Forms.TextBox();
            this.txtUpEmail = new System.Windows.Forms.TextBox();
            this.txtUpMobile = new System.Windows.Forms.TextBox();
            this.txtUpTitle = new System.Windows.Forms.TextBox();
            this.txtUpName = new System.Windows.Forms.TextBox();
            this.txtUpSurname = new System.Windows.Forms.TextBox();
            this.txtUpAddressLine2 = new System.Windows.Forms.TextBox();
            this.txtSearchCust = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblCID = new System.Windows.Forms.Label();
            this.btnCustRemove = new System.Windows.Forms.Button();
            this.btnSaveCust = new System.Windows.Forms.Button();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.CustControl = new System.Windows.Forms.TabControl();
            this.tabManageContracts = new System.Windows.Forms.TabPage();
            this.cmbServiceLevel = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.dgvContracts = new System.Windows.Forms.DataGridView();
            this.chkTechnicalSupportIncluded = new System.Windows.Forms.CheckBox();
            this.numIncludedCredit = new System.Windows.Forms.NumericUpDown();
            this.txtContractName = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.btnAddNewContract = new System.Windows.Forms.Button();
            this.tabCustomerEnquiry = new System.Windows.Forms.TabPage();
            this.btnDivertCallToTechnicalSupport = new System.Windows.Forms.Button();
            this.rtxtEnquiryNote = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtCName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.cmbCustomerIDSearch = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.btnFindCustomer = new System.Windows.Forms.Button();
            this.btnDivertCallToSales = new System.Windows.Forms.Button();
            this.btnCreateCustomerEnquiry = new System.Windows.Forms.Button();
            this.btnAnswerCall = new System.Windows.Forms.Button();
            this.btnHoldCall = new System.Windows.Forms.Button();
            this.btnEndCall = new System.Windows.Forms.Button();
            this.btnDash = new System.Windows.Forms.Button();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabAddCust.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabMngC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMngCust)).BeginInit();
            this.CustControl.SuspendLayout();
            this.tabManageContracts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIncludedCredit)).BeginInit();
            this.tabCustomerEnquiry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "3db286cc805e66e763fba9b5370856e9.png");
            this.imageList1.Images.SetKeyName(1, "driver-512.png");
            this.imageList1.Images.SetKeyName(2, "Icon-User-Research-300x300.png");
            this.imageList1.Images.SetKeyName(3, "7-512.png");
            this.imageList1.Images.SetKeyName(4, "imagesVPAQIKL6.png");
            this.imageList1.Images.SetKeyName(5, "Mobile_Menu_icon.png");
            this.imageList1.Images.SetKeyName(6, "menu.png");
            this.imageList1.Images.SetKeyName(7, "Button1.png");
            this.imageList1.Images.SetKeyName(8, "checked-user-xxl.png");
            this.imageList1.Images.SetKeyName(9, "checked-users-xxl.png");
            this.imageList1.Images.SetKeyName(10, "remove-user-xxl.png");
            this.imageList1.Images.SetKeyName(11, "Layer 5.png");
            this.imageList1.Images.SetKeyName(12, "Layer 6.png");
            this.imageList1.Images.SetKeyName(13, "cal-bw-01.png");
            this.imageList1.Images.SetKeyName(14, "RegComp.png");
            this.imageList1.Images.SetKeyName(15, "contract-512.png");
            this.imageList1.Images.SetKeyName(16, "COmp.png");
            this.imageList1.Images.SetKeyName(17, "contr.png");
            this.imageList1.Images.SetKeyName(18, "Discard.png");
            this.imageList1.Images.SetKeyName(19, "AddAcc.png");
            this.imageList1.Images.SetKeyName(20, "TechSup.png");
            this.imageList1.Images.SetKeyName(21, "Stufff.png");
            this.imageList1.Images.SetKeyName(22, "Trash-1.png");
            this.imageList1.Images.SetKeyName(23, "Divert.png");
            this.imageList1.Images.SetKeyName(24, "EndCall.png");
            // 
            // tabAddCust
            // 
            this.tabAddCust.Controls.Add(this.groupBox5);
            this.tabAddCust.Controls.Add(this.groupBox4);
            this.tabAddCust.Controls.Add(this.groupBox3);
            this.tabAddCust.Controls.Add(this.groupBox2);
            this.tabAddCust.Controls.Add(this.groupBox1);
            this.tabAddCust.Controls.Add(this.btnCReg);
            this.tabAddCust.Controls.Add(this.btnCReset);
            this.tabAddCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.tabAddCust.ImageKey = "7-512.png";
            this.tabAddCust.Location = new System.Drawing.Point(4, 68);
            this.tabAddCust.Name = "tabAddCust";
            this.tabAddCust.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddCust.Size = new System.Drawing.Size(1306, 661);
            this.tabAddCust.TabIndex = 1;
            this.tabAddCust.Text = "New Customer";
            this.tabAddCust.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtCustFullName);
            this.groupBox5.Controls.Add(this.txtRSAID);
            this.groupBox5.Controls.Add(this.txtCustGender);
            this.groupBox5.Controls.Add(this.txtCustSurname);
            this.groupBox5.Controls.Add(this.txtCustName);
            this.groupBox5.Controls.Add(this.txtCustTitle);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label34);
            this.groupBox5.Controls.Add(this.label33);
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Controls.Add(this.label25);
            this.groupBox5.Controls.Add(this.label24);
            this.groupBox5.Controls.Add(this.dtCustDOB);
            this.groupBox5.Location = new System.Drawing.Point(19, 18);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(288, 641);
            this.groupBox5.TabIndex = 163;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Personal Details";
            // 
            // txtCustFullName
            // 
            this.txtCustFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustFullName.Location = new System.Drawing.Point(17, 425);
            this.txtCustFullName.Name = "txtCustFullName";
            this.txtCustFullName.Size = new System.Drawing.Size(257, 29);
            this.txtCustFullName.TabIndex = 161;
            // 
            // txtRSAID
            // 
            this.txtRSAID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRSAID.Location = new System.Drawing.Point(17, 69);
            this.txtRSAID.Name = "txtRSAID";
            this.txtRSAID.Size = new System.Drawing.Size(257, 29);
            this.txtRSAID.TabIndex = 159;
            // 
            // txtCustGender
            // 
            this.txtCustGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustGender.Location = new System.Drawing.Point(17, 514);
            this.txtCustGender.Name = "txtCustGender";
            this.txtCustGender.Size = new System.Drawing.Size(257, 29);
            this.txtCustGender.TabIndex = 158;
            // 
            // txtCustSurname
            // 
            this.txtCustSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustSurname.Location = new System.Drawing.Point(17, 336);
            this.txtCustSurname.Name = "txtCustSurname";
            this.txtCustSurname.Size = new System.Drawing.Size(257, 29);
            this.txtCustSurname.TabIndex = 151;
            // 
            // txtCustName
            // 
            this.txtCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustName.Location = new System.Drawing.Point(17, 247);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(257, 29);
            this.txtCustName.TabIndex = 150;
            // 
            // txtCustTitle
            // 
            this.txtCustTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustTitle.Location = new System.Drawing.Point(17, 158);
            this.txtCustTitle.Name = "txtCustTitle";
            this.txtCustTitle.Size = new System.Drawing.Size(257, 29);
            this.txtCustTitle.TabIndex = 149;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(17, 383);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 24);
            this.label13.TabIndex = 162;
            this.label13.Text = "Full Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(17, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(157, 24);
            this.label12.TabIndex = 160;
            this.label12.Text = "RSA ID Number";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.Transparent;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(17, 116);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(50, 24);
            this.label34.TabIndex = 157;
            this.label34.Text = "Title";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(17, 205);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(104, 24);
            this.label33.TabIndex = 156;
            this.label33.Text = "Fist Name";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(17, 294);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(108, 24);
            this.label26.TabIndex = 155;
            this.label26.Text = "Last Name";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(17, 472);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(80, 24);
            this.label25.TabIndex = 154;
            this.label25.Text = "Gender";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(17, 561);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(129, 24);
            this.label24.TabIndex = 153;
            this.label24.Text = "Date  of Birth";
            // 
            // dtCustDOB
            // 
            this.dtCustDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dtCustDOB.Location = new System.Drawing.Point(17, 603);
            this.dtCustDOB.Name = "dtCustDOB";
            this.dtCustDOB.Size = new System.Drawing.Size(257, 29);
            this.dtCustDOB.TabIndex = 152;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label31);
            this.groupBox4.Controls.Add(this.label30);
            this.groupBox4.Controls.Add(this.label32);
            this.groupBox4.Controls.Add(this.txtCustMobile);
            this.groupBox4.Controls.Add(this.txtCustEmail);
            this.groupBox4.Controls.Add(this.txtCustWorkTel);
            this.groupBox4.Location = new System.Drawing.Point(653, 18);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(317, 314);
            this.groupBox4.TabIndex = 162;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Contact Information";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(16, 223);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(145, 24);
            this.label31.TabIndex = 43;
            this.label31.Text = "Email Address";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(16, 130);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(94, 24);
            this.label30.TabIndex = 42;
            this.label30.Text = "Work Tel";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Transparent;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(16, 37);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(154, 24);
            this.label32.TabIndex = 44;
            this.label32.Text = "Mobile Number";
            // 
            // txtCustMobile
            // 
            this.txtCustMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustMobile.Location = new System.Drawing.Point(16, 81);
            this.txtCustMobile.Name = "txtCustMobile";
            this.txtCustMobile.Size = new System.Drawing.Size(289, 29);
            this.txtCustMobile.TabIndex = 7;
            // 
            // txtCustEmail
            // 
            this.txtCustEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustEmail.Location = new System.Drawing.Point(16, 267);
            this.txtCustEmail.Name = "txtCustEmail";
            this.txtCustEmail.Size = new System.Drawing.Size(289, 29);
            this.txtCustEmail.TabIndex = 8;
            // 
            // txtCustWorkTel
            // 
            this.txtCustWorkTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustWorkTel.Location = new System.Drawing.Point(16, 174);
            this.txtCustWorkTel.Name = "txtCustWorkTel";
            this.txtCustWorkTel.Size = new System.Drawing.Size(289, 29);
            this.txtCustWorkTel.TabIndex = 143;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtAccountNumber);
            this.groupBox3.Controls.Add(this.txtBank);
            this.groupBox3.Controls.Add(this.txtBranch);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Location = new System.Drawing.Point(993, 290);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(309, 296);
            this.groupBox3.TabIndex = 161;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bank Information";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(18, 256);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(279, 29);
            this.txtAccountNumber.TabIndex = 164;
            // 
            // txtBank
            // 
            this.txtBank.Location = new System.Drawing.Point(18, 78);
            this.txtBank.Name = "txtBank";
            this.txtBank.Size = new System.Drawing.Size(279, 29);
            this.txtBank.TabIndex = 163;
            // 
            // txtBranch
            // 
            this.txtBranch.Location = new System.Drawing.Point(18, 167);
            this.txtBranch.Name = "txtBranch";
            this.txtBranch.Size = new System.Drawing.Size(279, 29);
            this.txtBranch.TabIndex = 162;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(18, 214);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(174, 24);
            this.label23.TabIndex = 161;
            this.label23.Text = "Account Number ";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(18, 36);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(62, 24);
            this.label21.TabIndex = 160;
            this.label21.Text = "Bank ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(18, 125);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 24);
            this.label15.TabIndex = 159;
            this.label15.Text = "Branch ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtContractEndDate);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.cmbContractType);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(993, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 225);
            this.groupBox2.TabIndex = 160;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contract";
            // 
            // dtContractEndDate
            // 
            this.dtContractEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dtContractEndDate.Location = new System.Drawing.Point(15, 172);
            this.dtContractEndDate.Name = "dtContractEndDate";
            this.dtContractEndDate.Size = new System.Drawing.Size(257, 29);
            this.dtContractEndDate.TabIndex = 159;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 131);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 24);
            this.label14.TabIndex = 158;
            this.label14.Text = "End Date";
            // 
            // cmbContractType
            // 
            this.cmbContractType.FormattingEnabled = true;
            this.cmbContractType.Location = new System.Drawing.Point(15, 80);
            this.cmbContractType.Name = "cmbContractType";
            this.cmbContractType.Size = new System.Drawing.Size(279, 32);
            this.cmbContractType.TabIndex = 157;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 24);
            this.label11.TabIndex = 156;
            this.label11.Text = "Contract Type";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCustCountry);
            this.groupBox1.Controls.Add(this.txtCustCity);
            this.groupBox1.Controls.Add(this.txtCustPostalCode);
            this.groupBox1.Controls.Add(this.txtCustSuburb);
            this.groupBox1.Controls.Add(this.txtCustAddressLine1);
            this.groupBox1.Controls.Add(this.txtCustAddressLine2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(324, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 568);
            this.groupBox1.TabIndex = 159;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Location";
            // 
            // txtCustCountry
            // 
            this.txtCustCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustCountry.Location = new System.Drawing.Point(15, 529);
            this.txtCustCountry.Name = "txtCustCountry";
            this.txtCustCountry.Size = new System.Drawing.Size(284, 29);
            this.txtCustCountry.TabIndex = 154;
            // 
            // txtCustCity
            // 
            this.txtCustCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustCity.Location = new System.Drawing.Point(15, 440);
            this.txtCustCity.Name = "txtCustCity";
            this.txtCustCity.Size = new System.Drawing.Size(284, 29);
            this.txtCustCity.TabIndex = 153;
            // 
            // txtCustPostalCode
            // 
            this.txtCustPostalCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustPostalCode.Location = new System.Drawing.Point(15, 351);
            this.txtCustPostalCode.Name = "txtCustPostalCode";
            this.txtCustPostalCode.Size = new System.Drawing.Size(284, 29);
            this.txtCustPostalCode.TabIndex = 151;
            // 
            // txtCustSuburb
            // 
            this.txtCustSuburb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustSuburb.Location = new System.Drawing.Point(15, 262);
            this.txtCustSuburb.Name = "txtCustSuburb";
            this.txtCustSuburb.Size = new System.Drawing.Size(284, 29);
            this.txtCustSuburb.TabIndex = 149;
            // 
            // txtCustAddressLine1
            // 
            this.txtCustAddressLine1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustAddressLine1.Location = new System.Drawing.Point(15, 84);
            this.txtCustAddressLine1.Name = "txtCustAddressLine1";
            this.txtCustAddressLine1.Size = new System.Drawing.Size(284, 29);
            this.txtCustAddressLine1.TabIndex = 147;
            // 
            // txtCustAddressLine2
            // 
            this.txtCustAddressLine2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustAddressLine2.Location = new System.Drawing.Point(15, 173);
            this.txtCustAddressLine2.Name = "txtCustAddressLine2";
            this.txtCustAddressLine2.Size = new System.Drawing.Size(284, 29);
            this.txtCustAddressLine2.TabIndex = 143;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 24);
            this.label4.TabIndex = 152;
            this.label4.Text = "Postal Code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 24);
            this.label5.TabIndex = 150;
            this.label5.Text = "Suburb";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 24);
            this.label6.TabIndex = 148;
            this.label6.Text = "AddressLine 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 487);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 24);
            this.label7.TabIndex = 146;
            this.label7.Text = "Country";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 24);
            this.label8.TabIndex = 145;
            this.label8.Text = "AddressLine 2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 398);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 24);
            this.label9.TabIndex = 144;
            this.label9.Text = "City";
            // 
            // btnCReg
            // 
            this.btnCReg.AutoEllipsis = true;
            this.btnCReg.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCReg.BackColor = System.Drawing.Color.Transparent;
            this.btnCReg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCReg.BackgroundImage")));
            this.btnCReg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCReg.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCReg.FlatAppearance.BorderSize = 0;
            this.btnCReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCReg.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnCReg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCReg.ImageIndex = 9;
            this.btnCReg.ImageList = this.imageList1;
            this.btnCReg.Location = new System.Drawing.Point(729, 483);
            this.btnCReg.Name = "btnCReg";
            this.btnCReg.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnCReg.Size = new System.Drawing.Size(156, 55);
            this.btnCReg.TabIndex = 49;
            this.btnCReg.Text = "Register";
            this.btnCReg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCReg.UseCompatibleTextRendering = true;
            this.btnCReg.UseVisualStyleBackColor = false;
            this.btnCReg.Click += new System.EventHandler(this.btnCReg_Click);
            // 
            // btnCReset
            // 
            this.btnCReset.AutoEllipsis = true;
            this.btnCReset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCReset.BackColor = System.Drawing.Color.Transparent;
            this.btnCReset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCReset.BackgroundImage")));
            this.btnCReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCReset.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCReset.FlatAppearance.BorderSize = 0;
            this.btnCReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCReset.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnCReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCReset.ImageIndex = 11;
            this.btnCReset.ImageList = this.imageList1;
            this.btnCReset.Location = new System.Drawing.Point(729, 402);
            this.btnCReset.Name = "btnCReset";
            this.btnCReset.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnCReset.Size = new System.Drawing.Size(156, 55);
            this.btnCReset.TabIndex = 48;
            this.btnCReset.Text = "Reset";
            this.btnCReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCReset.UseCompatibleTextRendering = true;
            this.btnCReset.UseVisualStyleBackColor = false;
            this.btnCReset.Click += new System.EventHandler(this.btnCReset_Click);
            // 
            // tabMngC
            // 
            this.tabMngC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabMngC.Controls.Add(this.btnViewCustomerAdditionalInfo);
            this.tabMngC.Controls.Add(this.btnSearchCust);
            this.tabMngC.Controls.Add(this.dgvMngCust);
            this.tabMngC.Controls.Add(this.txtUpFullName);
            this.tabMngC.Controls.Add(this.txtUpGender);
            this.tabMngC.Controls.Add(this.txtUpWorkTel);
            this.tabMngC.Controls.Add(this.txtUpCountry);
            this.tabMngC.Controls.Add(this.txtUpCity);
            this.tabMngC.Controls.Add(this.txtUpPostalCode);
            this.tabMngC.Controls.Add(this.txtUpSuburb);
            this.tabMngC.Controls.Add(this.txtUpAddressLine1);
            this.tabMngC.Controls.Add(this.txtUpEmail);
            this.tabMngC.Controls.Add(this.txtUpMobile);
            this.tabMngC.Controls.Add(this.txtUpTitle);
            this.tabMngC.Controls.Add(this.txtUpName);
            this.tabMngC.Controls.Add(this.txtUpSurname);
            this.tabMngC.Controls.Add(this.txtUpAddressLine2);
            this.tabMngC.Controls.Add(this.txtSearchCust);
            this.tabMngC.Controls.Add(this.label17);
            this.tabMngC.Controls.Add(this.label16);
            this.tabMngC.Controls.Add(this.label3);
            this.tabMngC.Controls.Add(this.label2);
            this.tabMngC.Controls.Add(this.label1);
            this.tabMngC.Controls.Add(this.label48);
            this.tabMngC.Controls.Add(this.lblStatus);
            this.tabMngC.Controls.Add(this.lblGender);
            this.tabMngC.Controls.Add(this.lblCID);
            this.tabMngC.Controls.Add(this.btnCustRemove);
            this.tabMngC.Controls.Add(this.btnSaveCust);
            this.tabMngC.Controls.Add(this.label43);
            this.tabMngC.Controls.Add(this.label44);
            this.tabMngC.Controls.Add(this.label45);
            this.tabMngC.Controls.Add(this.label47);
            this.tabMngC.Controls.Add(this.label49);
            this.tabMngC.Controls.Add(this.label51);
            this.tabMngC.Controls.Add(this.label52);
            this.tabMngC.Controls.Add(this.label53);
            this.tabMngC.ImageIndex = 1;
            this.tabMngC.Location = new System.Drawing.Point(4, 68);
            this.tabMngC.Name = "tabMngC";
            this.tabMngC.Padding = new System.Windows.Forms.Padding(3);
            this.tabMngC.Size = new System.Drawing.Size(1306, 661);
            this.tabMngC.TabIndex = 3;
            this.tabMngC.Text = "Customers";
            this.tabMngC.UseVisualStyleBackColor = true;
            // 
            // btnViewCustomerAdditionalInfo
            // 
            this.btnViewCustomerAdditionalInfo.AutoEllipsis = true;
            this.btnViewCustomerAdditionalInfo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnViewCustomerAdditionalInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnViewCustomerAdditionalInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnViewCustomerAdditionalInfo.BackgroundImage")));
            this.btnViewCustomerAdditionalInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnViewCustomerAdditionalInfo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnViewCustomerAdditionalInfo.FlatAppearance.BorderSize = 0;
            this.btnViewCustomerAdditionalInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewCustomerAdditionalInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewCustomerAdditionalInfo.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnViewCustomerAdditionalInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewCustomerAdditionalInfo.ImageIndex = 19;
            this.btnViewCustomerAdditionalInfo.ImageList = this.imageList1;
            this.btnViewCustomerAdditionalInfo.Location = new System.Drawing.Point(948, 311);
            this.btnViewCustomerAdditionalInfo.Name = "btnViewCustomerAdditionalInfo";
            this.btnViewCustomerAdditionalInfo.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnViewCustomerAdditionalInfo.Size = new System.Drawing.Size(329, 55);
            this.btnViewCustomerAdditionalInfo.TabIndex = 187;
            this.btnViewCustomerAdditionalInfo.Text = "View Additional Customer Info";
            this.btnViewCustomerAdditionalInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewCustomerAdditionalInfo.UseCompatibleTextRendering = true;
            this.btnViewCustomerAdditionalInfo.UseVisualStyleBackColor = false;
            this.btnViewCustomerAdditionalInfo.Click += new System.EventHandler(this.btnViewCustomerAdditionalInfo_Click);
            // 
            // btnSearchCust
            // 
            this.btnSearchCust.AutoEllipsis = true;
            this.btnSearchCust.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSearchCust.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchCust.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchCust.BackgroundImage")));
            this.btnSearchCust.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchCust.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSearchCust.FlatAppearance.BorderSize = 0;
            this.btnSearchCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCust.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnSearchCust.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchCust.ImageIndex = 4;
            this.btnSearchCust.ImageList = this.imageList1;
            this.btnSearchCust.Location = new System.Drawing.Point(1121, 0);
            this.btnSearchCust.Name = "btnSearchCust";
            this.btnSearchCust.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnSearchCust.Size = new System.Drawing.Size(156, 55);
            this.btnSearchCust.TabIndex = 116;
            this.btnSearchCust.Text = "Search";
            this.btnSearchCust.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearchCust.UseCompatibleTextRendering = true;
            this.btnSearchCust.UseVisualStyleBackColor = false;
            // 
            // dgvMngCust
            // 
            this.dgvMngCust.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMngCust.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvMngCust.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvMngCust.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMngCust.Location = new System.Drawing.Point(12, 49);
            this.dgvMngCust.Name = "dgvMngCust";
            this.dgvMngCust.Size = new System.Drawing.Size(1265, 226);
            this.dgvMngCust.TabIndex = 151;
            // 
            // txtUpFullName
            // 
            this.txtUpFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpFullName.Location = new System.Drawing.Point(12, 327);
            this.txtUpFullName.Name = "txtUpFullName";
            this.txtUpFullName.Size = new System.Drawing.Size(284, 29);
            this.txtUpFullName.TabIndex = 149;
            // 
            // txtUpGender
            // 
            this.txtUpGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpGender.Location = new System.Drawing.Point(12, 604);
            this.txtUpGender.Name = "txtUpGender";
            this.txtUpGender.Size = new System.Drawing.Size(284, 29);
            this.txtUpGender.TabIndex = 146;
            // 
            // txtUpWorkTel
            // 
            this.txtUpWorkTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpWorkTel.Location = new System.Drawing.Point(326, 522);
            this.txtUpWorkTel.Name = "txtUpWorkTel";
            this.txtUpWorkTel.Size = new System.Drawing.Size(284, 29);
            this.txtUpWorkTel.TabIndex = 131;
            // 
            // txtUpCountry
            // 
            this.txtUpCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpCountry.Location = new System.Drawing.Point(993, 604);
            this.txtUpCountry.Name = "txtUpCountry";
            this.txtUpCountry.Size = new System.Drawing.Size(284, 29);
            this.txtUpCountry.TabIndex = 130;
            // 
            // txtUpCity
            // 
            this.txtUpCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpCity.Location = new System.Drawing.Point(993, 522);
            this.txtUpCity.Name = "txtUpCity";
            this.txtUpCity.Size = new System.Drawing.Size(284, 29);
            this.txtUpCity.TabIndex = 129;
            // 
            // txtUpPostalCode
            // 
            this.txtUpPostalCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpPostalCode.Location = new System.Drawing.Point(993, 445);
            this.txtUpPostalCode.Name = "txtUpPostalCode";
            this.txtUpPostalCode.Size = new System.Drawing.Size(284, 29);
            this.txtUpPostalCode.TabIndex = 126;
            // 
            // txtUpSuburb
            // 
            this.txtUpSuburb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpSuburb.Location = new System.Drawing.Point(637, 604);
            this.txtUpSuburb.Name = "txtUpSuburb";
            this.txtUpSuburb.Size = new System.Drawing.Size(330, 29);
            this.txtUpSuburb.TabIndex = 124;
            // 
            // txtUpAddressLine1
            // 
            this.txtUpAddressLine1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpAddressLine1.Location = new System.Drawing.Point(637, 445);
            this.txtUpAddressLine1.Name = "txtUpAddressLine1";
            this.txtUpAddressLine1.Size = new System.Drawing.Size(330, 29);
            this.txtUpAddressLine1.TabIndex = 122;
            // 
            // txtUpEmail
            // 
            this.txtUpEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpEmail.Location = new System.Drawing.Point(326, 604);
            this.txtUpEmail.Name = "txtUpEmail";
            this.txtUpEmail.Size = new System.Drawing.Size(284, 29);
            this.txtUpEmail.TabIndex = 120;
            // 
            // txtUpMobile
            // 
            this.txtUpMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpMobile.Location = new System.Drawing.Point(326, 447);
            this.txtUpMobile.Name = "txtUpMobile";
            this.txtUpMobile.Size = new System.Drawing.Size(284, 29);
            this.txtUpMobile.TabIndex = 5;
            // 
            // txtUpTitle
            // 
            this.txtUpTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpTitle.Location = new System.Drawing.Point(12, 394);
            this.txtUpTitle.Name = "txtUpTitle";
            this.txtUpTitle.Size = new System.Drawing.Size(284, 29);
            this.txtUpTitle.TabIndex = 1;
            // 
            // txtUpName
            // 
            this.txtUpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpName.Location = new System.Drawing.Point(12, 461);
            this.txtUpName.Name = "txtUpName";
            this.txtUpName.Size = new System.Drawing.Size(284, 29);
            this.txtUpName.TabIndex = 2;
            // 
            // txtUpSurname
            // 
            this.txtUpSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpSurname.Location = new System.Drawing.Point(12, 528);
            this.txtUpSurname.Name = "txtUpSurname";
            this.txtUpSurname.Size = new System.Drawing.Size(284, 29);
            this.txtUpSurname.TabIndex = 3;
            // 
            // txtUpAddressLine2
            // 
            this.txtUpAddressLine2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpAddressLine2.Location = new System.Drawing.Point(637, 522);
            this.txtUpAddressLine2.Name = "txtUpAddressLine2";
            this.txtUpAddressLine2.Size = new System.Drawing.Size(330, 29);
            this.txtUpAddressLine2.TabIndex = 11;
            // 
            // txtSearchCust
            // 
            this.txtSearchCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCust.Location = new System.Drawing.Point(813, 12);
            this.txtSearchCust.Name = "txtSearchCust";
            this.txtSearchCust.Size = new System.Drawing.Size(286, 29);
            this.txtSearchCust.TabIndex = 85;
            this.txtSearchCust.Text = "...";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(12, 296);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(106, 24);
            this.label17.TabIndex = 150;
            this.label17.Text = "Full Name";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(12, 573);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 24);
            this.label16.TabIndex = 145;
            this.label16.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(989, 411);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 24);
            this.label3.TabIndex = 127;
            this.label3.Text = "Postal Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(637, 568);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 24);
            this.label2.TabIndex = 125;
            this.label2.Text = "Suburb";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(637, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 24);
            this.label1.TabIndex = 123;
            this.label1.Text = "AddressLine 1";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.BackColor = System.Drawing.Color.Transparent;
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.Location = new System.Drawing.Point(326, 568);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(145, 24);
            this.label48.TabIndex = 121;
            this.label48.Text = "Email Address";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(21, 325);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 24);
            this.lblStatus.TabIndex = 119;
            this.lblStatus.Visible = false;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(21, 17);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(0, 24);
            this.lblGender.TabIndex = 118;
            this.lblGender.Visible = false;
            // 
            // lblCID
            // 
            this.lblCID.AutoSize = true;
            this.lblCID.BackColor = System.Drawing.Color.Transparent;
            this.lblCID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCID.Location = new System.Drawing.Point(8, 3);
            this.lblCID.Name = "lblCID";
            this.lblCID.Size = new System.Drawing.Size(0, 24);
            this.lblCID.TabIndex = 117;
            this.lblCID.Visible = false;
            // 
            // btnCustRemove
            // 
            this.btnCustRemove.AutoEllipsis = true;
            this.btnCustRemove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCustRemove.BackColor = System.Drawing.Color.Transparent;
            this.btnCustRemove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCustRemove.BackgroundImage")));
            this.btnCustRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCustRemove.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCustRemove.FlatAppearance.BorderSize = 0;
            this.btnCustRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustRemove.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnCustRemove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustRemove.ImageIndex = 10;
            this.btnCustRemove.ImageList = this.imageList1;
            this.btnCustRemove.Location = new System.Drawing.Point(637, 314);
            this.btnCustRemove.Name = "btnCustRemove";
            this.btnCustRemove.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnCustRemove.Size = new System.Drawing.Size(156, 55);
            this.btnCustRemove.TabIndex = 114;
            this.btnCustRemove.Text = "Remove";
            this.btnCustRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCustRemove.UseCompatibleTextRendering = true;
            this.btnCustRemove.UseVisualStyleBackColor = false;
            this.btnCustRemove.Click += new System.EventHandler(this.btnCustRemove_Click);
            // 
            // btnSaveCust
            // 
            this.btnSaveCust.AutoEllipsis = true;
            this.btnSaveCust.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveCust.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveCust.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveCust.BackgroundImage")));
            this.btnSaveCust.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveCust.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSaveCust.FlatAppearance.BorderSize = 0;
            this.btnSaveCust.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCust.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnSaveCust.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveCust.ImageIndex = 9;
            this.btnSaveCust.ImageList = this.imageList1;
            this.btnSaveCust.Location = new System.Drawing.Point(450, 314);
            this.btnSaveCust.Name = "btnSaveCust";
            this.btnSaveCust.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnSaveCust.Size = new System.Drawing.Size(156, 55);
            this.btnSaveCust.TabIndex = 113;
            this.btnSaveCust.Text = "Save";
            this.btnSaveCust.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveCust.UseCompatibleTextRendering = true;
            this.btnSaveCust.UseVisualStyleBackColor = false;
            this.btnSaveCust.Click += new System.EventHandler(this.btnSaveCust_Click);
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.BackColor = System.Drawing.Color.Transparent;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(993, 568);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(82, 24);
            this.label43.TabIndex = 110;
            this.label43.Text = "Country";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.BackColor = System.Drawing.Color.Transparent;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(637, 488);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(144, 24);
            this.label44.TabIndex = 109;
            this.label44.Text = "AddressLine 2";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.BackColor = System.Drawing.Color.Transparent;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(993, 488);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(44, 24);
            this.label45.TabIndex = 108;
            this.label45.Text = "City";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.BackColor = System.Drawing.Color.Transparent;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.Location = new System.Drawing.Point(326, 488);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(94, 24);
            this.label47.TabIndex = 106;
            this.label47.Text = "Work Tel";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.BackColor = System.Drawing.Color.Transparent;
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.Location = new System.Drawing.Point(326, 411);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(154, 24);
            this.label49.TabIndex = 104;
            this.label49.Text = "Mobile Number";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.BackColor = System.Drawing.Color.Transparent;
            this.label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.Location = new System.Drawing.Point(12, 497);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(108, 24);
            this.label51.TabIndex = 102;
            this.label51.Text = "Last Name";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.BackColor = System.Drawing.Color.Transparent;
            this.label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.Location = new System.Drawing.Point(12, 430);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(111, 24);
            this.label52.TabIndex = 101;
            this.label52.Text = "First Name";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.BackColor = System.Drawing.Color.Transparent;
            this.label53.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.Location = new System.Drawing.Point(12, 363);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(50, 24);
            this.label53.TabIndex = 100;
            this.label53.Text = "Title";
            // 
            // CustControl
            // 
            this.CustControl.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
            this.CustControl.AllowDrop = true;
            this.CustControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.CustControl.Controls.Add(this.tabMngC);
            this.CustControl.Controls.Add(this.tabAddCust);
            this.CustControl.Controls.Add(this.tabManageContracts);
            this.CustControl.Controls.Add(this.tabCustomerEnquiry);
            this.CustControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.CustControl.HotTrack = true;
            this.CustControl.ImageList = this.imageList1;
            this.CustControl.ItemSize = new System.Drawing.Size(126, 64);
            this.CustControl.Location = new System.Drawing.Point(0, 0);
            this.CustControl.Name = "CustControl";
            this.CustControl.Padding = new System.Drawing.Point(8, 4);
            this.CustControl.SelectedIndex = 0;
            this.CustControl.ShowToolTips = true;
            this.CustControl.Size = new System.Drawing.Size(1314, 733);
            this.CustControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.CustControl.TabIndex = 50;
            // 
            // tabManageContracts
            // 
            this.tabManageContracts.Controls.Add(this.cmbServiceLevel);
            this.tabManageContracts.Controls.Add(this.label29);
            this.tabManageContracts.Controls.Add(this.dgvContracts);
            this.tabManageContracts.Controls.Add(this.chkTechnicalSupportIncluded);
            this.tabManageContracts.Controls.Add(this.numIncludedCredit);
            this.tabManageContracts.Controls.Add(this.txtContractName);
            this.tabManageContracts.Controls.Add(this.label28);
            this.tabManageContracts.Controls.Add(this.label27);
            this.tabManageContracts.Controls.Add(this.btnAddNewContract);
            this.tabManageContracts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.tabManageContracts.ImageIndex = 15;
            this.tabManageContracts.Location = new System.Drawing.Point(4, 68);
            this.tabManageContracts.Name = "tabManageContracts";
            this.tabManageContracts.Padding = new System.Windows.Forms.Padding(3);
            this.tabManageContracts.Size = new System.Drawing.Size(1306, 661);
            this.tabManageContracts.TabIndex = 5;
            this.tabManageContracts.Text = "Manage Contracts";
            this.tabManageContracts.UseVisualStyleBackColor = true;
            // 
            // cmbServiceLevel
            // 
            this.cmbServiceLevel.FormattingEnabled = true;
            this.cmbServiceLevel.Items.AddRange(new object[] {
            "Entry",
            "Deluxe",
            "Premium",
            "Ultimate"});
            this.cmbServiceLevel.Location = new System.Drawing.Point(52, 217);
            this.cmbServiceLevel.Name = "cmbServiceLevel";
            this.cmbServiceLevel.Size = new System.Drawing.Size(279, 32);
            this.cmbServiceLevel.TabIndex = 167;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(52, 174);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(136, 24);
            this.label29.TabIndex = 166;
            this.label29.Text = "Service Level";
            // 
            // dgvContracts
            // 
            this.dgvContracts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContracts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvContracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContracts.Location = new System.Drawing.Point(553, 61);
            this.dgvContracts.Name = "dgvContracts";
            this.dgvContracts.Size = new System.Drawing.Size(654, 248);
            this.dgvContracts.TabIndex = 165;
            // 
            // chkTechnicalSupportIncluded
            // 
            this.chkTechnicalSupportIncluded.AutoSize = true;
            this.chkTechnicalSupportIncluded.Checked = true;
            this.chkTechnicalSupportIncluded.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTechnicalSupportIncluded.Location = new System.Drawing.Point(52, 403);
            this.chkTechnicalSupportIncluded.Name = "chkTechnicalSupportIncluded";
            this.chkTechnicalSupportIncluded.Size = new System.Drawing.Size(337, 28);
            this.chkTechnicalSupportIncluded.TabIndex = 164;
            this.chkTechnicalSupportIncluded.Text = "Free Technical Support Included";
            this.chkTechnicalSupportIncluded.UseVisualStyleBackColor = true;
            // 
            // numIncludedCredit
            // 
            this.numIncludedCredit.Location = new System.Drawing.Point(52, 341);
            this.numIncludedCredit.Name = "numIncludedCredit";
            this.numIncludedCredit.Size = new System.Drawing.Size(120, 29);
            this.numIncludedCredit.TabIndex = 163;
            // 
            // txtContractName
            // 
            this.txtContractName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContractName.Location = new System.Drawing.Point(52, 118);
            this.txtContractName.Name = "txtContractName";
            this.txtContractName.Size = new System.Drawing.Size(289, 29);
            this.txtContractName.TabIndex = 161;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(48, 290);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(174, 24);
            this.label28.TabIndex = 160;
            this.label28.Text = "Included Credit %";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(48, 75);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(148, 24);
            this.label27.TabIndex = 158;
            this.label27.Text = "Contract Name";
            // 
            // btnAddNewContract
            // 
            this.btnAddNewContract.AutoEllipsis = true;
            this.btnAddNewContract.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddNewContract.BackColor = System.Drawing.Color.Transparent;
            this.btnAddNewContract.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddNewContract.BackgroundImage")));
            this.btnAddNewContract.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddNewContract.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddNewContract.FlatAppearance.BorderSize = 0;
            this.btnAddNewContract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewContract.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnAddNewContract.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewContract.ImageIndex = 9;
            this.btnAddNewContract.ImageList = this.imageList1;
            this.btnAddNewContract.Location = new System.Drawing.Point(52, 481);
            this.btnAddNewContract.Name = "btnAddNewContract";
            this.btnAddNewContract.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnAddNewContract.Size = new System.Drawing.Size(234, 55);
            this.btnAddNewContract.TabIndex = 50;
            this.btnAddNewContract.Text = "Add New Contract";
            this.btnAddNewContract.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddNewContract.UseCompatibleTextRendering = true;
            this.btnAddNewContract.UseVisualStyleBackColor = false;
            this.btnAddNewContract.Click += new System.EventHandler(this.btnConfirmNewContract_Click);
            // 
            // tabCustomerEnquiry
            // 
            this.tabCustomerEnquiry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabCustomerEnquiry.Controls.Add(this.btnDivertCallToTechnicalSupport);
            this.tabCustomerEnquiry.Controls.Add(this.rtxtEnquiryNote);
            this.tabCustomerEnquiry.Controls.Add(this.label10);
            this.tabCustomerEnquiry.Controls.Add(this.lblAmount);
            this.tabCustomerEnquiry.Controls.Add(this.txtCName);
            this.tabCustomerEnquiry.Controls.Add(this.txtPhone);
            this.tabCustomerEnquiry.Controls.Add(this.txtEmail);
            this.tabCustomerEnquiry.Controls.Add(this.label19);
            this.tabCustomerEnquiry.Controls.Add(this.label20);
            this.tabCustomerEnquiry.Controls.Add(this.label22);
            this.tabCustomerEnquiry.Controls.Add(this.lblSubTotal);
            this.tabCustomerEnquiry.Controls.Add(this.cmbCustomerIDSearch);
            this.tabCustomerEnquiry.Controls.Add(this.label18);
            this.tabCustomerEnquiry.Controls.Add(this.dgvCustomers);
            this.tabCustomerEnquiry.Controls.Add(this.btnFindCustomer);
            this.tabCustomerEnquiry.Controls.Add(this.btnDivertCallToSales);
            this.tabCustomerEnquiry.Controls.Add(this.btnCreateCustomerEnquiry);
            this.tabCustomerEnquiry.Controls.Add(this.btnAnswerCall);
            this.tabCustomerEnquiry.Controls.Add(this.btnHoldCall);
            this.tabCustomerEnquiry.Controls.Add(this.btnEndCall);
            this.tabCustomerEnquiry.ImageIndex = 4;
            this.tabCustomerEnquiry.Location = new System.Drawing.Point(4, 68);
            this.tabCustomerEnquiry.Name = "tabCustomerEnquiry";
            this.tabCustomerEnquiry.Padding = new System.Windows.Forms.Padding(3);
            this.tabCustomerEnquiry.Size = new System.Drawing.Size(1306, 661);
            this.tabCustomerEnquiry.TabIndex = 6;
            this.tabCustomerEnquiry.Text = "Call Enquiry";
            this.tabCustomerEnquiry.UseVisualStyleBackColor = true;
            // 
            // btnDivertCallToTechnicalSupport
            // 
            this.btnDivertCallToTechnicalSupport.AutoEllipsis = true;
            this.btnDivertCallToTechnicalSupport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDivertCallToTechnicalSupport.BackColor = System.Drawing.Color.Transparent;
            this.btnDivertCallToTechnicalSupport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDivertCallToTechnicalSupport.BackgroundImage")));
            this.btnDivertCallToTechnicalSupport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDivertCallToTechnicalSupport.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDivertCallToTechnicalSupport.Enabled = false;
            this.btnDivertCallToTechnicalSupport.FlatAppearance.BorderSize = 0;
            this.btnDivertCallToTechnicalSupport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivertCallToTechnicalSupport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivertCallToTechnicalSupport.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnDivertCallToTechnicalSupport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDivertCallToTechnicalSupport.ImageIndex = 23;
            this.btnDivertCallToTechnicalSupport.ImageList = this.imageList1;
            this.btnDivertCallToTechnicalSupport.Location = new System.Drawing.Point(1031, 592);
            this.btnDivertCallToTechnicalSupport.Name = "btnDivertCallToTechnicalSupport";
            this.btnDivertCallToTechnicalSupport.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnDivertCallToTechnicalSupport.Size = new System.Drawing.Size(253, 61);
            this.btnDivertCallToTechnicalSupport.TabIndex = 191;
            this.btnDivertCallToTechnicalSupport.Text = "Divert Call To Technical Support";
            this.btnDivertCallToTechnicalSupport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDivertCallToTechnicalSupport.UseCompatibleTextRendering = true;
            this.btnDivertCallToTechnicalSupport.UseVisualStyleBackColor = false;
            this.btnDivertCallToTechnicalSupport.Click += new System.EventHandler(this.btnDivertCallToTechnicalSupport_Click);
            // 
            // rtxtEnquiryNote
            // 
            this.rtxtEnquiryNote.Location = new System.Drawing.Point(604, 397);
            this.rtxtEnquiryNote.Name = "rtxtEnquiryNote";
            this.rtxtEnquiryNote.Size = new System.Drawing.Size(403, 96);
            this.rtxtEnquiryNote.TabIndex = 190;
            this.rtxtEnquiryNote.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(600, 370);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 24);
            this.label10.TabIndex = 189;
            this.label10.Text = "Enquiry Note";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(866, 146);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(0, 24);
            this.lblAmount.TabIndex = 180;
            // 
            // txtCName
            // 
            this.txtCName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCName.Location = new System.Drawing.Point(254, 420);
            this.txtCName.Name = "txtCName";
            this.txtCName.Size = new System.Drawing.Size(263, 29);
            this.txtCName.TabIndex = 174;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(254, 513);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(263, 29);
            this.txtPhone.TabIndex = 176;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(254, 606);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(263, 29);
            this.txtEmail.TabIndex = 178;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(254, 562);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(145, 24);
            this.label19.TabIndex = 179;
            this.label19.Text = "Email Address";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(254, 469);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(152, 24);
            this.label20.TabIndex = 177;
            this.label20.Text = "Phone Number";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(254, 376);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(160, 24);
            this.label22.TabIndex = 175;
            this.label22.Text = "Customer Name";
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(297, 589);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(0, 24);
            this.lblSubTotal.TabIndex = 173;
            // 
            // cmbCustomerIDSearch
            // 
            this.cmbCustomerIDSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCustomerIDSearch.FormattingEnabled = true;
            this.cmbCustomerIDSearch.Location = new System.Drawing.Point(13, 48);
            this.cmbCustomerIDSearch.Name = "cmbCustomerIDSearch";
            this.cmbCustomerIDSearch.Size = new System.Drawing.Size(313, 32);
            this.cmbCustomerIDSearch.TabIndex = 172;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(9, 18);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(124, 24);
            this.label18.TabIndex = 170;
            this.label18.Text = "Customer ID";
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(13, 101);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.Size = new System.Drawing.Size(1039, 244);
            this.dgvCustomers.TabIndex = 169;
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
            this.btnFindCustomer.Location = new System.Drawing.Point(354, 34);
            this.btnFindCustomer.Name = "btnFindCustomer";
            this.btnFindCustomer.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btnFindCustomer.Size = new System.Drawing.Size(209, 61);
            this.btnFindCustomer.TabIndex = 171;
            this.btnFindCustomer.Text = "Find Customer";
            this.btnFindCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFindCustomer.UseCompatibleTextRendering = true;
            this.btnFindCustomer.UseVisualStyleBackColor = false;
            // 
            // btnDivertCallToSales
            // 
            this.btnDivertCallToSales.AutoEllipsis = true;
            this.btnDivertCallToSales.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDivertCallToSales.BackColor = System.Drawing.Color.Transparent;
            this.btnDivertCallToSales.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDivertCallToSales.BackgroundImage")));
            this.btnDivertCallToSales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDivertCallToSales.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDivertCallToSales.Enabled = false;
            this.btnDivertCallToSales.FlatAppearance.BorderSize = 0;
            this.btnDivertCallToSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDivertCallToSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivertCallToSales.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnDivertCallToSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDivertCallToSales.ImageIndex = 23;
            this.btnDivertCallToSales.ImageList = this.imageList1;
            this.btnDivertCallToSales.Location = new System.Drawing.Point(1031, 514);
            this.btnDivertCallToSales.Name = "btnDivertCallToSales";
            this.btnDivertCallToSales.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnDivertCallToSales.Size = new System.Drawing.Size(253, 61);
            this.btnDivertCallToSales.TabIndex = 130;
            this.btnDivertCallToSales.Text = "Divert Call To Sales";
            this.btnDivertCallToSales.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDivertCallToSales.UseCompatibleTextRendering = true;
            this.btnDivertCallToSales.UseVisualStyleBackColor = false;
            this.btnDivertCallToSales.Click += new System.EventHandler(this.btnDivertCallToSales_Click);
            // 
            // btnCreateCustomerEnquiry
            // 
            this.btnCreateCustomerEnquiry.AutoEllipsis = true;
            this.btnCreateCustomerEnquiry.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCreateCustomerEnquiry.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateCustomerEnquiry.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCreateCustomerEnquiry.BackgroundImage")));
            this.btnCreateCustomerEnquiry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreateCustomerEnquiry.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCreateCustomerEnquiry.FlatAppearance.BorderSize = 0;
            this.btnCreateCustomerEnquiry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateCustomerEnquiry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCustomerEnquiry.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnCreateCustomerEnquiry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateCustomerEnquiry.ImageIndex = 15;
            this.btnCreateCustomerEnquiry.ImageList = this.imageList1;
            this.btnCreateCustomerEnquiry.Location = new System.Drawing.Point(604, 592);
            this.btnCreateCustomerEnquiry.Name = "btnCreateCustomerEnquiry";
            this.btnCreateCustomerEnquiry.Padding = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.btnCreateCustomerEnquiry.Size = new System.Drawing.Size(320, 61);
            this.btnCreateCustomerEnquiry.TabIndex = 128;
            this.btnCreateCustomerEnquiry.Text = "Create Customer Enquiry";
            this.btnCreateCustomerEnquiry.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreateCustomerEnquiry.UseCompatibleTextRendering = true;
            this.btnCreateCustomerEnquiry.UseVisualStyleBackColor = false;
            this.btnCreateCustomerEnquiry.Click += new System.EventHandler(this.btnCreateCustomerEnquiry_Click);
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
            this.btnAnswerCall.Location = new System.Drawing.Point(13, 360);
            this.btnAnswerCall.Name = "btnAnswerCall";
            this.btnAnswerCall.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btnAnswerCall.Size = new System.Drawing.Size(167, 61);
            this.btnAnswerCall.TabIndex = 121;
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
            this.btnHoldCall.Location = new System.Drawing.Point(13, 438);
            this.btnHoldCall.Name = "btnHoldCall";
            this.btnHoldCall.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnHoldCall.Size = new System.Drawing.Size(167, 61);
            this.btnHoldCall.TabIndex = 122;
            this.btnHoldCall.Text = "Hold Call";
            this.btnHoldCall.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHoldCall.UseCompatibleTextRendering = true;
            this.btnHoldCall.UseVisualStyleBackColor = false;
            this.btnHoldCall.Click += new System.EventHandler(this.btnHoldCall_Click);
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
            this.btnEndCall.ImageIndex = 24;
            this.btnEndCall.ImageList = this.imageList1;
            this.btnEndCall.Location = new System.Drawing.Point(13, 525);
            this.btnEndCall.Name = "btnEndCall";
            this.btnEndCall.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.btnEndCall.Size = new System.Drawing.Size(167, 61);
            this.btnEndCall.TabIndex = 123;
            this.btnEndCall.Text = "End Call";
            this.btnEndCall.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEndCall.UseCompatibleTextRendering = true;
            this.btnEndCall.UseVisualStyleBackColor = false;
            this.btnEndCall.Click += new System.EventHandler(this.btnEndCall_Click);
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
            this.btnDash.Location = new System.Drawing.Point(1205, 7);
            this.btnDash.Name = "btnDash";
            this.btnDash.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnDash.Size = new System.Drawing.Size(137, 55);
            this.btnDash.TabIndex = 51;
            this.btnDash.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDash.UseCompatibleTextRendering = true;
            this.btnDash.UseVisualStyleBackColor = false;
            this.btnDash.Click += new System.EventHandler(this.btnDash_Click);
            // 
            // CustomerManagementDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 733);
            this.ControlBox = false;
            this.Controls.Add(this.btnDash);
            this.Controls.Add(this.CustControl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomerManagementDepartment";
            this.Text = "CustomerManagement";
            this.Load += new System.EventHandler(this.CustomerManagementDepartment_Load);
            this.tabAddCust.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabMngC.ResumeLayout(false);
            this.tabMngC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMngCust)).EndInit();
            this.CustControl.ResumeLayout(false);
            this.tabManageContracts.ResumeLayout(false);
            this.tabManageContracts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContracts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIncludedCredit)).EndInit();
            this.tabCustomerEnquiry.ResumeLayout(false);
            this.tabCustomerEnquiry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private System.Windows.Forms.BindingSource clientBindingSource1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnDash;
        private System.Windows.Forms.TabPage tabAddCust;
        private System.Windows.Forms.TextBox txtCustWorkTel;
        private System.Windows.Forms.TextBox txtCustEmail;
        private System.Windows.Forms.TextBox txtCustMobile;
        private System.Windows.Forms.Button btnCReg;
        private System.Windows.Forms.Button btnCReset;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TabPage tabMngC;
        private System.Windows.Forms.Button btnSearchCust;
        private System.Windows.Forms.DataGridView dgvMngCust;
        private System.Windows.Forms.TextBox txtUpFullName;
        private System.Windows.Forms.TextBox txtUpGender;
        private System.Windows.Forms.TextBox txtUpWorkTel;
        private System.Windows.Forms.TextBox txtUpCountry;
        private System.Windows.Forms.TextBox txtUpCity;
        private System.Windows.Forms.TextBox txtUpPostalCode;
        private System.Windows.Forms.TextBox txtUpSuburb;
        private System.Windows.Forms.TextBox txtUpAddressLine1;
        private System.Windows.Forms.TextBox txtUpEmail;
        private System.Windows.Forms.TextBox txtUpMobile;
        private System.Windows.Forms.TextBox txtUpTitle;
        private System.Windows.Forms.TextBox txtUpName;
        private System.Windows.Forms.TextBox txtUpSurname;
        private System.Windows.Forms.TextBox txtUpAddressLine2;
        private System.Windows.Forms.TextBox txtSearchCust;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblCID;
        private System.Windows.Forms.Button btnCustRemove;
        private System.Windows.Forms.Button btnSaveCust;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.TabControl CustControl;
        private System.Windows.Forms.Button btnViewCustomerAdditionalInfo;
        private System.Windows.Forms.TabPage tabManageContracts;
        private System.Windows.Forms.Button btnAddNewContract;
        private System.Windows.Forms.TabPage tabCustomerEnquiry;
        private System.Windows.Forms.Button btnDivertCallToTechnicalSupport;
        private System.Windows.Forms.RichTextBox rtxtEnquiryNote;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtCName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.ComboBox cmbCustomerIDSearch;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Button btnFindCustomer;
        private System.Windows.Forms.Button btnDivertCallToSales;
        private System.Windows.Forms.Button btnCreateCustomerEnquiry;
        private System.Windows.Forms.Button btnAnswerCall;
        private System.Windows.Forms.Button btnHoldCall;
        private System.Windows.Forms.Button btnEndCall;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbContractType;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCustCountry;
        private System.Windows.Forms.TextBox txtCustCity;
        private System.Windows.Forms.TextBox txtCustPostalCode;
        private System.Windows.Forms.TextBox txtCustSuburb;
        private System.Windows.Forms.TextBox txtCustAddressLine1;
        private System.Windows.Forms.TextBox txtCustAddressLine2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.TextBox txtBank;
        private System.Windows.Forms.TextBox txtBranch;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtCustFullName;
        private System.Windows.Forms.TextBox txtRSAID;
        private System.Windows.Forms.TextBox txtCustGender;
        private System.Windows.Forms.TextBox txtCustSurname;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.TextBox txtCustTitle;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DateTimePicker dtCustDOB;
        private System.Windows.Forms.DataGridView dgvContracts;
        private System.Windows.Forms.CheckBox chkTechnicalSupportIncluded;
        private System.Windows.Forms.NumericUpDown numIncludedCredit;
        private System.Windows.Forms.TextBox txtContractName;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.DateTimePicker dtContractEndDate;
        private System.Windows.Forms.ComboBox cmbServiceLevel;
        private System.Windows.Forms.Label label29;
    }
}