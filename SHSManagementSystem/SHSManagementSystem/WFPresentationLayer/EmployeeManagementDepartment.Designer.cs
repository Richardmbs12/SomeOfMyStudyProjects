namespace WindowsFormsApplication1
{
    partial class EmployeeManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeManagement));
            this.tabAddEmp = new System.Windows.Forms.TabPage();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtWorkTel = new System.Windows.Forms.TextBox();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtPostalCode = new System.Windows.Forms.TextBox();
            this.txtSuburb = new System.Windows.Forms.TextBox();
            this.txtAddressLine1 = new System.Windows.Forms.TextBox();
            this.txtAddressLine2 = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnConfirmEmployee = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnResetEmployee = new System.Windows.Forms.Button();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.dtDOB = new System.Windows.Forms.DateTimePicker();
            this.empControl = new System.Windows.Forms.TabControl();
            this.tabEmpMng = new System.Windows.Forms.TabPage();
            this.txtEmployeeDepartment = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
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
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.btnRemoveEmployee = new System.Windows.Forms.Button();
            this.btnSaveEmployee = new System.Windows.Forms.Button();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.lblStID = new System.Windows.Forms.Label();
            this.btnEmpSearch = new System.Windows.Forms.Button();
            this.lblEmpDOB = new System.Windows.Forms.Label();
            this.txtEmpSearch = new System.Windows.Forms.TextBox();
            this.dgvEMng = new System.Windows.Forms.DataGridView();
            this.tabConfirmEmployee = new System.Windows.Forms.TabPage();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnSubmitEmployee = new System.Windows.Forms.Button();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnDash = new System.Windows.Forms.Button();
            this.tabAddEmp.SuspendLayout();
            this.empControl.SuspendLayout();
            this.tabEmpMng.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEMng)).BeginInit();
            this.tabConfirmEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabAddEmp
            // 
            this.tabAddEmp.Controls.Add(this.txtFullName);
            this.tabAddEmp.Controls.Add(this.txtID);
            this.tabAddEmp.Controls.Add(this.txtGender);
            this.tabAddEmp.Controls.Add(this.txtWorkTel);
            this.tabAddEmp.Controls.Add(this.txtCountry);
            this.tabAddEmp.Controls.Add(this.txtCity);
            this.tabAddEmp.Controls.Add(this.txtPostalCode);
            this.tabAddEmp.Controls.Add(this.txtSuburb);
            this.tabAddEmp.Controls.Add(this.txtAddressLine1);
            this.tabAddEmp.Controls.Add(this.txtAddressLine2);
            this.tabAddEmp.Controls.Add(this.txtEmail);
            this.tabAddEmp.Controls.Add(this.txtMobile);
            this.tabAddEmp.Controls.Add(this.txtLastName);
            this.tabAddEmp.Controls.Add(this.txtFirstName);
            this.tabAddEmp.Controls.Add(this.txtTitle);
            this.tabAddEmp.Controls.Add(this.label1);
            this.tabAddEmp.Controls.Add(this.label2);
            this.tabAddEmp.Controls.Add(this.label4);
            this.tabAddEmp.Controls.Add(this.label3);
            this.tabAddEmp.Controls.Add(this.label6);
            this.tabAddEmp.Controls.Add(this.label7);
            this.tabAddEmp.Controls.Add(this.label8);
            this.tabAddEmp.Controls.Add(this.label9);
            this.tabAddEmp.Controls.Add(this.btnConfirmEmployee);
            this.tabAddEmp.Controls.Add(this.btnResetEmployee);
            this.tabAddEmp.Controls.Add(this.label34);
            this.tabAddEmp.Controls.Add(this.label33);
            this.tabAddEmp.Controls.Add(this.label32);
            this.tabAddEmp.Controls.Add(this.label31);
            this.tabAddEmp.Controls.Add(this.label30);
            this.tabAddEmp.Controls.Add(this.label26);
            this.tabAddEmp.Controls.Add(this.label25);
            this.tabAddEmp.Controls.Add(this.label24);
            this.tabAddEmp.Controls.Add(this.dtDOB);
            this.tabAddEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tabAddEmp.ImageKey = "7-512.png";
            this.tabAddEmp.Location = new System.Drawing.Point(4, 68);
            this.tabAddEmp.Name = "tabAddEmp";
            this.tabAddEmp.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddEmp.Size = new System.Drawing.Size(1498, 665);
            this.tabAddEmp.TabIndex = 1;
            this.tabAddEmp.Text = "Hire";
            this.tabAddEmp.UseVisualStyleBackColor = true;
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFullName.Location = new System.Drawing.Point(59, 414);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(327, 29);
            this.txtFullName.TabIndex = 181;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(59, 58);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(327, 29);
            this.txtID.TabIndex = 179;
            // 
            // txtGender
            // 
            this.txtGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGender.Location = new System.Drawing.Point(59, 503);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(327, 29);
            this.txtGender.TabIndex = 178;
            // 
            // txtWorkTel
            // 
            this.txtWorkTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWorkTel.Location = new System.Drawing.Point(591, 279);
            this.txtWorkTel.Name = "txtWorkTel";
            this.txtWorkTel.Size = new System.Drawing.Size(327, 29);
            this.txtWorkTel.TabIndex = 177;
            // 
            // txtCountry
            // 
            this.txtCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountry.Location = new System.Drawing.Point(1103, 601);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(284, 29);
            this.txtCountry.TabIndex = 176;
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(1103, 494);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(284, 29);
            this.txtCity.TabIndex = 175;
            // 
            // txtPostalCode
            // 
            this.txtPostalCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostalCode.Location = new System.Drawing.Point(1103, 387);
            this.txtPostalCode.Name = "txtPostalCode";
            this.txtPostalCode.Size = new System.Drawing.Size(284, 29);
            this.txtPostalCode.TabIndex = 173;
            // 
            // txtSuburb
            // 
            this.txtSuburb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSuburb.Location = new System.Drawing.Point(1103, 280);
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.Size = new System.Drawing.Size(284, 29);
            this.txtSuburb.TabIndex = 171;
            // 
            // txtAddressLine1
            // 
            this.txtAddressLine1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddressLine1.Location = new System.Drawing.Point(1103, 66);
            this.txtAddressLine1.Name = "txtAddressLine1";
            this.txtAddressLine1.Size = new System.Drawing.Size(284, 29);
            this.txtAddressLine1.TabIndex = 169;
            // 
            // txtAddressLine2
            // 
            this.txtAddressLine2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddressLine2.Location = new System.Drawing.Point(1103, 173);
            this.txtAddressLine2.Name = "txtAddressLine2";
            this.txtAddressLine2.Size = new System.Drawing.Size(284, 29);
            this.txtAddressLine2.TabIndex = 165;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(591, 372);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(327, 29);
            this.txtEmail.TabIndex = 154;
            // 
            // txtMobile
            // 
            this.txtMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobile.Location = new System.Drawing.Point(591, 186);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(327, 29);
            this.txtMobile.TabIndex = 153;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(59, 325);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(327, 29);
            this.txtLastName.TabIndex = 151;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(59, 236);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(327, 29);
            this.txtFirstName.TabIndex = 150;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(59, 147);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(327, 29);
            this.txtTitle.TabIndex = 149;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 182;
            this.label1.Text = "Full Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 24);
            this.label2.TabIndex = 180;
            this.label2.Text = "ID Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1103, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 24);
            this.label4.TabIndex = 174;
            this.label4.Text = "Postal Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1103, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 24);
            this.label3.TabIndex = 172;
            this.label3.Text = "Suburb";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1103, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 24);
            this.label6.TabIndex = 170;
            this.label6.Text = "AddressLine 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1103, 550);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 24);
            this.label7.TabIndex = 168;
            this.label7.Text = "Country";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1103, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 24);
            this.label8.TabIndex = 167;
            this.label8.Text = "AddressLine 2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1103, 443);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 24);
            this.label9.TabIndex = 166;
            this.label9.Text = "City";
            // 
            // btnConfirmEmployee
            // 
            this.btnConfirmEmployee.AutoEllipsis = true;
            this.btnConfirmEmployee.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConfirmEmployee.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmEmployee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfirmEmployee.BackgroundImage")));
            this.btnConfirmEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirmEmployee.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConfirmEmployee.FlatAppearance.BorderSize = 0;
            this.btnConfirmEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmEmployee.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnConfirmEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmEmployee.ImageIndex = 9;
            this.btnConfirmEmployee.ImageList = this.imageList1;
            this.btnConfirmEmployee.Location = new System.Drawing.Point(756, 536);
            this.btnConfirmEmployee.Name = "btnConfirmEmployee";
            this.btnConfirmEmployee.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnConfirmEmployee.Size = new System.Drawing.Size(239, 55);
            this.btnConfirmEmployee.TabIndex = 164;
            this.btnConfirmEmployee.Text = "Confirm Employee";
            this.btnConfirmEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmEmployee.UseCompatibleTextRendering = true;
            this.btnConfirmEmployee.UseVisualStyleBackColor = false;
            this.btnConfirmEmployee.Click += new System.EventHandler(this.btnConfirmEmployee_Click);
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
            this.imageList1.Images.SetKeyName(8, "Layer 5.png");
            this.imageList1.Images.SetKeyName(9, "checked-users-xxl.png");
            this.imageList1.Images.SetKeyName(10, "remove-user-xxl.png");
            this.imageList1.Images.SetKeyName(11, "228840-200.png");
            // 
            // btnResetEmployee
            // 
            this.btnResetEmployee.AutoEllipsis = true;
            this.btnResetEmployee.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnResetEmployee.BackColor = System.Drawing.Color.Transparent;
            this.btnResetEmployee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnResetEmployee.BackgroundImage")));
            this.btnResetEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnResetEmployee.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnResetEmployee.FlatAppearance.BorderSize = 0;
            this.btnResetEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetEmployee.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnResetEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResetEmployee.ImageIndex = 8;
            this.btnResetEmployee.ImageList = this.imageList1;
            this.btnResetEmployee.Location = new System.Drawing.Point(533, 536);
            this.btnResetEmployee.Name = "btnResetEmployee";
            this.btnResetEmployee.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnResetEmployee.Size = new System.Drawing.Size(156, 55);
            this.btnResetEmployee.TabIndex = 163;
            this.btnResetEmployee.Text = "Reset";
            this.btnResetEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResetEmployee.UseCompatibleTextRendering = true;
            this.btnResetEmployee.UseVisualStyleBackColor = false;
            this.btnResetEmployee.Click += new System.EventHandler(this.btnResetEmployee_Click);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.BackColor = System.Drawing.Color.Transparent;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(59, 105);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(50, 24);
            this.label34.TabIndex = 162;
            this.label34.Text = "Title";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(59, 194);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(104, 24);
            this.label33.TabIndex = 161;
            this.label33.Text = "Fist Name";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.Transparent;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(591, 142);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(154, 24);
            this.label32.TabIndex = 160;
            this.label32.Text = "Mobile Number";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(591, 328);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(145, 24);
            this.label31.TabIndex = 159;
            this.label31.Text = "Email Address";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(591, 235);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(94, 24);
            this.label30.TabIndex = 158;
            this.label30.Text = "Work Tel";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.Transparent;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(59, 283);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(108, 24);
            this.label26.TabIndex = 157;
            this.label26.Text = "Last Name";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Transparent;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(59, 461);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(80, 24);
            this.label25.TabIndex = 156;
            this.label25.Text = "Gender";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(59, 550);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(129, 24);
            this.label24.TabIndex = 155;
            this.label24.Text = "Date  of Birth";
            // 
            // dtDOB
            // 
            this.dtDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dtDOB.Location = new System.Drawing.Point(59, 592);
            this.dtDOB.Name = "dtDOB";
            this.dtDOB.Size = new System.Drawing.Size(327, 29);
            this.dtDOB.TabIndex = 152;
            // 
            // empControl
            // 
            this.empControl.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuPopup;
            this.empControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.empControl.Controls.Add(this.tabEmpMng);
            this.empControl.Controls.Add(this.tabAddEmp);
            this.empControl.Controls.Add(this.tabConfirmEmployee);
            this.empControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.empControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.empControl.HotTrack = true;
            this.empControl.ImageList = this.imageList1;
            this.empControl.ItemSize = new System.Drawing.Size(126, 64);
            this.empControl.Location = new System.Drawing.Point(0, 0);
            this.empControl.Name = "empControl";
            this.empControl.Padding = new System.Drawing.Point(8, 4);
            this.empControl.SelectedIndex = 0;
            this.empControl.ShowToolTips = true;
            this.empControl.Size = new System.Drawing.Size(1506, 737);
            this.empControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.empControl.TabIndex = 2;
            // 
            // tabEmpMng
            // 
            this.tabEmpMng.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabEmpMng.Controls.Add(this.txtEmployeeDepartment);
            this.tabEmpMng.Controls.Add(this.label18);
            this.tabEmpMng.Controls.Add(this.txtUpFullName);
            this.tabEmpMng.Controls.Add(this.txtUpGender);
            this.tabEmpMng.Controls.Add(this.txtUpWorkTel);
            this.tabEmpMng.Controls.Add(this.txtUpCountry);
            this.tabEmpMng.Controls.Add(this.txtUpCity);
            this.tabEmpMng.Controls.Add(this.txtUpPostalCode);
            this.tabEmpMng.Controls.Add(this.txtUpSuburb);
            this.tabEmpMng.Controls.Add(this.txtUpAddressLine1);
            this.tabEmpMng.Controls.Add(this.txtUpEmail);
            this.tabEmpMng.Controls.Add(this.txtUpMobile);
            this.tabEmpMng.Controls.Add(this.txtUpTitle);
            this.tabEmpMng.Controls.Add(this.txtUpName);
            this.tabEmpMng.Controls.Add(this.txtUpSurname);
            this.tabEmpMng.Controls.Add(this.txtUpAddressLine2);
            this.tabEmpMng.Controls.Add(this.label17);
            this.tabEmpMng.Controls.Add(this.label16);
            this.tabEmpMng.Controls.Add(this.label5);
            this.tabEmpMng.Controls.Add(this.label12);
            this.tabEmpMng.Controls.Add(this.label13);
            this.tabEmpMng.Controls.Add(this.label48);
            this.tabEmpMng.Controls.Add(this.btnRemoveEmployee);
            this.tabEmpMng.Controls.Add(this.btnSaveEmployee);
            this.tabEmpMng.Controls.Add(this.label43);
            this.tabEmpMng.Controls.Add(this.label44);
            this.tabEmpMng.Controls.Add(this.label45);
            this.tabEmpMng.Controls.Add(this.label47);
            this.tabEmpMng.Controls.Add(this.label49);
            this.tabEmpMng.Controls.Add(this.label51);
            this.tabEmpMng.Controls.Add(this.label52);
            this.tabEmpMng.Controls.Add(this.label53);
            this.tabEmpMng.Controls.Add(this.lblStID);
            this.tabEmpMng.Controls.Add(this.btnEmpSearch);
            this.tabEmpMng.Controls.Add(this.lblEmpDOB);
            this.tabEmpMng.Controls.Add(this.txtEmpSearch);
            this.tabEmpMng.Controls.Add(this.dgvEMng);
            this.tabEmpMng.ImageIndex = 1;
            this.tabEmpMng.Location = new System.Drawing.Point(4, 68);
            this.tabEmpMng.Name = "tabEmpMng";
            this.tabEmpMng.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmpMng.Size = new System.Drawing.Size(1498, 665);
            this.tabEmpMng.TabIndex = 3;
            this.tabEmpMng.Text = "Manage";
            this.tabEmpMng.UseVisualStyleBackColor = true;
            // 
            // txtEmployeeDepartment
            // 
            this.txtEmployeeDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeDepartment.Location = new System.Drawing.Point(370, 13);
            this.txtEmployeeDepartment.Name = "txtEmployeeDepartment";
            this.txtEmployeeDepartment.Size = new System.Drawing.Size(284, 29);
            this.txtEmployeeDepartment.TabIndex = 183;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(17, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(320, 24);
            this.label18.TabIndex = 184;
            this.label18.Text = "Selected Employee\'s Department";
            // 
            // txtUpFullName
            // 
            this.txtUpFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpFullName.Location = new System.Drawing.Point(21, 314);
            this.txtUpFullName.Name = "txtUpFullName";
            this.txtUpFullName.Size = new System.Drawing.Size(284, 29);
            this.txtUpFullName.TabIndex = 181;
            // 
            // txtUpGender
            // 
            this.txtUpGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpGender.Location = new System.Drawing.Point(21, 590);
            this.txtUpGender.Name = "txtUpGender";
            this.txtUpGender.Size = new System.Drawing.Size(284, 29);
            this.txtUpGender.TabIndex = 180;
            // 
            // txtUpWorkTel
            // 
            this.txtUpWorkTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpWorkTel.Location = new System.Drawing.Point(412, 520);
            this.txtUpWorkTel.Name = "txtUpWorkTel";
            this.txtUpWorkTel.Size = new System.Drawing.Size(284, 29);
            this.txtUpWorkTel.TabIndex = 178;
            // 
            // txtUpCountry
            // 
            this.txtUpCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpCountry.Location = new System.Drawing.Point(1127, 596);
            this.txtUpCountry.Name = "txtUpCountry";
            this.txtUpCountry.Size = new System.Drawing.Size(284, 29);
            this.txtUpCountry.TabIndex = 177;
            // 
            // txtUpCity
            // 
            this.txtUpCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpCity.Location = new System.Drawing.Point(1127, 515);
            this.txtUpCity.Name = "txtUpCity";
            this.txtUpCity.Size = new System.Drawing.Size(284, 29);
            this.txtUpCity.TabIndex = 176;
            // 
            // txtUpPostalCode
            // 
            this.txtUpPostalCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpPostalCode.Location = new System.Drawing.Point(1127, 434);
            this.txtUpPostalCode.Name = "txtUpPostalCode";
            this.txtUpPostalCode.Size = new System.Drawing.Size(284, 29);
            this.txtUpPostalCode.TabIndex = 173;
            // 
            // txtUpSuburb
            // 
            this.txtUpSuburb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpSuburb.Location = new System.Drawing.Point(1127, 353);
            this.txtUpSuburb.Name = "txtUpSuburb";
            this.txtUpSuburb.Size = new System.Drawing.Size(284, 29);
            this.txtUpSuburb.TabIndex = 171;
            // 
            // txtUpAddressLine1
            // 
            this.txtUpAddressLine1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpAddressLine1.Location = new System.Drawing.Point(765, 445);
            this.txtUpAddressLine1.Name = "txtUpAddressLine1";
            this.txtUpAddressLine1.Size = new System.Drawing.Size(284, 29);
            this.txtUpAddressLine1.TabIndex = 169;
            // 
            // txtUpEmail
            // 
            this.txtUpEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpEmail.Location = new System.Drawing.Point(412, 602);
            this.txtUpEmail.Name = "txtUpEmail";
            this.txtUpEmail.Size = new System.Drawing.Size(284, 29);
            this.txtUpEmail.TabIndex = 167;
            // 
            // txtUpMobile
            // 
            this.txtUpMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpMobile.Location = new System.Drawing.Point(412, 445);
            this.txtUpMobile.Name = "txtUpMobile";
            this.txtUpMobile.Size = new System.Drawing.Size(284, 29);
            this.txtUpMobile.TabIndex = 154;
            // 
            // txtUpTitle
            // 
            this.txtUpTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpTitle.Location = new System.Drawing.Point(21, 383);
            this.txtUpTitle.Name = "txtUpTitle";
            this.txtUpTitle.Size = new System.Drawing.Size(284, 29);
            this.txtUpTitle.TabIndex = 151;
            // 
            // txtUpName
            // 
            this.txtUpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpName.Location = new System.Drawing.Point(21, 452);
            this.txtUpName.Name = "txtUpName";
            this.txtUpName.Size = new System.Drawing.Size(284, 29);
            this.txtUpName.TabIndex = 152;
            // 
            // txtUpSurname
            // 
            this.txtUpSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpSurname.Location = new System.Drawing.Point(21, 521);
            this.txtUpSurname.Name = "txtUpSurname";
            this.txtUpSurname.Size = new System.Drawing.Size(284, 29);
            this.txtUpSurname.TabIndex = 153;
            // 
            // txtUpAddressLine2
            // 
            this.txtUpAddressLine2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpAddressLine2.Location = new System.Drawing.Point(765, 528);
            this.txtUpAddressLine2.Name = "txtUpAddressLine2";
            this.txtUpAddressLine2.Size = new System.Drawing.Size(284, 29);
            this.txtUpAddressLine2.TabIndex = 155;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(21, 282);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(106, 24);
            this.label17.TabIndex = 182;
            this.label17.Text = "Full Name";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(21, 558);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 24);
            this.label16.TabIndex = 179;
            this.label16.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1127, 396);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 24);
            this.label5.TabIndex = 174;
            this.label5.Text = "Postal Code";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1127, 315);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 24);
            this.label12.TabIndex = 172;
            this.label12.Text = "Suburb";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(765, 411);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(144, 24);
            this.label13.TabIndex = 170;
            this.label13.Text = "AddressLine 1";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.BackColor = System.Drawing.Color.Transparent;
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.Location = new System.Drawing.Point(412, 566);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(145, 24);
            this.label48.TabIndex = 168;
            this.label48.Text = "Email Address";
            // 
            // btnRemoveEmployee
            // 
            this.btnRemoveEmployee.AutoEllipsis = true;
            this.btnRemoveEmployee.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRemoveEmployee.BackColor = System.Drawing.Color.Transparent;
            this.btnRemoveEmployee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemoveEmployee.BackgroundImage")));
            this.btnRemoveEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemoveEmployee.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnRemoveEmployee.FlatAppearance.BorderSize = 0;
            this.btnRemoveEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveEmployee.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnRemoveEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemoveEmployee.ImageIndex = 10;
            this.btnRemoveEmployee.ImageList = this.imageList1;
            this.btnRemoveEmployee.Location = new System.Drawing.Point(765, 287);
            this.btnRemoveEmployee.Name = "btnRemoveEmployee";
            this.btnRemoveEmployee.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnRemoveEmployee.Size = new System.Drawing.Size(156, 55);
            this.btnRemoveEmployee.TabIndex = 166;
            this.btnRemoveEmployee.Text = "Remove";
            this.btnRemoveEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemoveEmployee.UseCompatibleTextRendering = true;
            this.btnRemoveEmployee.UseVisualStyleBackColor = false;
            this.btnRemoveEmployee.Click += new System.EventHandler(this.btnRemoveEmployee_Click);
            // 
            // btnSaveEmployee
            // 
            this.btnSaveEmployee.AutoEllipsis = true;
            this.btnSaveEmployee.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSaveEmployee.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveEmployee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveEmployee.BackgroundImage")));
            this.btnSaveEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveEmployee.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSaveEmployee.FlatAppearance.BorderSize = 0;
            this.btnSaveEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveEmployee.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnSaveEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveEmployee.ImageIndex = 9;
            this.btnSaveEmployee.ImageList = this.imageList1;
            this.btnSaveEmployee.Location = new System.Drawing.Point(543, 287);
            this.btnSaveEmployee.Name = "btnSaveEmployee";
            this.btnSaveEmployee.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnSaveEmployee.Size = new System.Drawing.Size(156, 55);
            this.btnSaveEmployee.TabIndex = 165;
            this.btnSaveEmployee.Text = "Save";
            this.btnSaveEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveEmployee.UseCompatibleTextRendering = true;
            this.btnSaveEmployee.UseVisualStyleBackColor = false;
            this.btnSaveEmployee.Click += new System.EventHandler(this.btnSaveEmployee_Click);
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.BackColor = System.Drawing.Color.Transparent;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(1127, 558);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(82, 24);
            this.label43.TabIndex = 164;
            this.label43.Text = "Country";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.BackColor = System.Drawing.Color.Transparent;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(765, 494);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(144, 24);
            this.label44.TabIndex = 163;
            this.label44.Text = "AddressLine 2";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.BackColor = System.Drawing.Color.Transparent;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(1127, 477);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(44, 24);
            this.label45.TabIndex = 162;
            this.label45.Text = "City";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.BackColor = System.Drawing.Color.Transparent;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.Location = new System.Drawing.Point(412, 486);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(94, 24);
            this.label47.TabIndex = 160;
            this.label47.Text = "Work Tel";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.BackColor = System.Drawing.Color.Transparent;
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label49.Location = new System.Drawing.Point(412, 409);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(154, 24);
            this.label49.TabIndex = 159;
            this.label49.Text = "Mobile Number";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.BackColor = System.Drawing.Color.Transparent;
            this.label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label51.Location = new System.Drawing.Point(21, 489);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(108, 24);
            this.label51.TabIndex = 158;
            this.label51.Text = "Last Name";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.BackColor = System.Drawing.Color.Transparent;
            this.label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.Location = new System.Drawing.Point(21, 420);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(111, 24);
            this.label52.TabIndex = 157;
            this.label52.Text = "First Name";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.BackColor = System.Drawing.Color.Transparent;
            this.label53.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.Location = new System.Drawing.Point(21, 351);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(50, 24);
            this.label53.TabIndex = 156;
            this.label53.Text = "Title";
            // 
            // lblStID
            // 
            this.lblStID.AutoSize = true;
            this.lblStID.BackColor = System.Drawing.Color.Transparent;
            this.lblStID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStID.Location = new System.Drawing.Point(41, 4);
            this.lblStID.Name = "lblStID";
            this.lblStID.Size = new System.Drawing.Size(0, 24);
            this.lblStID.TabIndex = 119;
            this.lblStID.Visible = false;
            // 
            // btnEmpSearch
            // 
            this.btnEmpSearch.AutoEllipsis = true;
            this.btnEmpSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEmpSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnEmpSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEmpSearch.BackgroundImage")));
            this.btnEmpSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmpSearch.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnEmpSearch.FlatAppearance.BorderSize = 0;
            this.btnEmpSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmpSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpSearch.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnEmpSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpSearch.ImageIndex = 4;
            this.btnEmpSearch.ImageList = this.imageList1;
            this.btnEmpSearch.Location = new System.Drawing.Point(1313, -2);
            this.btnEmpSearch.Name = "btnEmpSearch";
            this.btnEmpSearch.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnEmpSearch.Size = new System.Drawing.Size(156, 55);
            this.btnEmpSearch.TabIndex = 118;
            this.btnEmpSearch.Text = "Search";
            this.btnEmpSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmpSearch.UseCompatibleTextRendering = true;
            this.btnEmpSearch.UseVisualStyleBackColor = false;
            this.btnEmpSearch.Click += new System.EventHandler(this.btnEmpSearch_Click);
            // 
            // lblEmpDOB
            // 
            this.lblEmpDOB.AutoSize = true;
            this.lblEmpDOB.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpDOB.Location = new System.Drawing.Point(17, 569);
            this.lblEmpDOB.Name = "lblEmpDOB";
            this.lblEmpDOB.Size = new System.Drawing.Size(0, 24);
            this.lblEmpDOB.TabIndex = 115;
            this.lblEmpDOB.Visible = false;
            // 
            // txtEmpSearch
            // 
            this.txtEmpSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpSearch.Location = new System.Drawing.Point(1021, 16);
            this.txtEmpSearch.Name = "txtEmpSearch";
            this.txtEmpSearch.Size = new System.Drawing.Size(286, 29);
            this.txtEmpSearch.TabIndex = 77;
            // 
            // dgvEMng
            // 
            this.dgvEMng.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEMng.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEMng.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEMng.Location = new System.Drawing.Point(8, 51);
            this.dgvEMng.Name = "dgvEMng";
            this.dgvEMng.Size = new System.Drawing.Size(1461, 211);
            this.dgvEMng.TabIndex = 75;
            this.dgvEMng.SelectionChanged += new System.EventHandler(this.dgvEMng_SelectionChanged);
            // 
            // tabConfirmEmployee
            // 
            this.tabConfirmEmployee.Controls.Add(this.txtConfirmPassword);
            this.tabConfirmEmployee.Controls.Add(this.label15);
            this.tabConfirmEmployee.Controls.Add(this.btnSubmitEmployee);
            this.tabConfirmEmployee.Controls.Add(this.cmbDepartment);
            this.tabConfirmEmployee.Controls.Add(this.txtPassword);
            this.tabConfirmEmployee.Controls.Add(this.txtUserName);
            this.tabConfirmEmployee.Controls.Add(this.label10);
            this.tabConfirmEmployee.Controls.Add(this.label11);
            this.tabConfirmEmployee.Controls.Add(this.label14);
            this.tabConfirmEmployee.ImageIndex = 0;
            this.tabConfirmEmployee.Location = new System.Drawing.Point(4, 68);
            this.tabConfirmEmployee.Name = "tabConfirmEmployee";
            this.tabConfirmEmployee.Padding = new System.Windows.Forms.Padding(3);
            this.tabConfirmEmployee.Size = new System.Drawing.Size(1498, 665);
            this.tabConfirmEmployee.TabIndex = 4;
            this.tabConfirmEmployee.Text = "Confirm Employee";
            this.tabConfirmEmployee.UseVisualStyleBackColor = true;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.Location = new System.Drawing.Point(515, 306);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(327, 29);
            this.txtConfirmPassword.TabIndex = 187;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(515, 262);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(178, 24);
            this.label15.TabIndex = 186;
            this.label15.Text = "Confirm Password";
            // 
            // btnSubmitEmployee
            // 
            this.btnSubmitEmployee.AutoEllipsis = true;
            this.btnSubmitEmployee.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSubmitEmployee.BackColor = System.Drawing.Color.Transparent;
            this.btnSubmitEmployee.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSubmitEmployee.BackgroundImage")));
            this.btnSubmitEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubmitEmployee.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSubmitEmployee.FlatAppearance.BorderSize = 0;
            this.btnSubmitEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitEmployee.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnSubmitEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubmitEmployee.ImageIndex = 9;
            this.btnSubmitEmployee.ImageList = this.imageList1;
            this.btnSubmitEmployee.Location = new System.Drawing.Point(550, 511);
            this.btnSubmitEmployee.Name = "btnSubmitEmployee";
            this.btnSubmitEmployee.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnSubmitEmployee.Size = new System.Drawing.Size(279, 55);
            this.btnSubmitEmployee.TabIndex = 185;
            this.btnSubmitEmployee.Text = "Submit New Employee";
            this.btnSubmitEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSubmitEmployee.UseCompatibleTextRendering = true;
            this.btnSubmitEmployee.UseVisualStyleBackColor = false;
            this.btnSubmitEmployee.Click += new System.EventHandler(this.btnSubmitEmployee_Click);
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Items.AddRange(new object[] {
            "Product Department",
            "Technical Support Department",
            "Customer Department",
            "Administrator"});
            this.cmbDepartment.Location = new System.Drawing.Point(515, 405);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(327, 32);
            this.cmbDepartment.TabIndex = 184;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(515, 206);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(327, 29);
            this.txtPassword.TabIndex = 183;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(515, 113);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(327, 29);
            this.txtUserName.TabIndex = 178;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(515, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 24);
            this.label10.TabIndex = 182;
            this.label10.Text = "User Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(511, 361);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 24);
            this.label11.TabIndex = 181;
            this.label11.Text = "Department";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(515, 162);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 24);
            this.label14.TabIndex = 180;
            this.label14.Text = "Password";
            // 
            // btnDash
            // 
            this.btnDash.BackColor = System.Drawing.Color.Transparent;
            this.btnDash.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDash.BackgroundImage")));
            this.btnDash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDash.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDash.FlatAppearance.BorderSize = 0;
            this.btnDash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDash.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDash.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnDash.ImageList = this.imageList1;
            this.btnDash.Location = new System.Drawing.Point(1376, 8);
            this.btnDash.Name = "btnDash";
            this.btnDash.Size = new System.Drawing.Size(137, 52);
            this.btnDash.TabIndex = 52;
            this.btnDash.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDash.UseVisualStyleBackColor = false;
            this.btnDash.Click += new System.EventHandler(this.btnDash_Click);
            // 
            // EmployeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1506, 737);
            this.ControlBox = false;
            this.Controls.Add(this.btnDash);
            this.Controls.Add(this.empControl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmployeeManagement";
            this.Text = "EmployeeManagement";
            this.Load += new System.EventHandler(this.EmployeeManagement_Load);
            this.tabAddEmp.ResumeLayout(false);
            this.tabAddEmp.PerformLayout();
            this.empControl.ResumeLayout(false);
            this.tabEmpMng.ResumeLayout(false);
            this.tabEmpMng.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEMng)).EndInit();
            this.tabConfirmEmployee.ResumeLayout(false);
            this.tabConfirmEmployee.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabAddEmp;
        private System.Windows.Forms.TabControl empControl;
        private System.Windows.Forms.Button btnDash;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tabEmpMng;
        private System.Windows.Forms.TextBox txtEmpSearch;
        private System.Windows.Forms.DataGridView dgvEMng;
        private System.Windows.Forms.Label lblEmpDOB;
        private System.Windows.Forms.Button btnEmpSearch;
        private System.Windows.Forms.Label lblStID;
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
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Button btnRemoveEmployee;
        private System.Windows.Forms.Button btnSaveEmployee;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtWorkTel;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtPostalCode;
        private System.Windows.Forms.TextBox txtSuburb;
        private System.Windows.Forms.TextBox txtAddressLine1;
        private System.Windows.Forms.TextBox txtAddressLine2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnConfirmEmployee;
        private System.Windows.Forms.Button btnResetEmployee;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.DateTimePicker dtDOB;
        private System.Windows.Forms.TabPage tabConfirmEmployee;
        private System.Windows.Forms.Button btnSubmitEmployee;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtEmployeeDepartment;
        private System.Windows.Forms.Label label18;
    }
}