namespace WindowsFormsApplication1
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.dashControl = new System.Windows.Forms.TabControl();
            this.tabDash = new System.Windows.Forms.TabPage();
            this.btnExit = new System.Windows.Forms.Button();
            this.LoggedInAs = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnProductDepartment = new System.Windows.Forms.Button();
            this.btnTechnicalSupportDepartment = new System.Windows.Forms.Button();
            this.EmployeeManagementDepartment = new System.Windows.Forms.Button();
            this.btnSalesManagementDepartment = new System.Windows.Forms.Button();
            this.btnCustomerDepartment = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.dashControl.SuspendLayout();
            this.tabDash.SuspendLayout();
            this.SuspendLayout();
            // 
            // dashControl
            // 
            this.dashControl.Controls.Add(this.tabDash);
            this.dashControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashControl.ImageList = this.imageList1;
            this.dashControl.Location = new System.Drawing.Point(0, 0);
            this.dashControl.Name = "dashControl";
            this.dashControl.SelectedIndex = 0;
            this.dashControl.Size = new System.Drawing.Size(1380, 740);
            this.dashControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.dashControl.TabIndex = 0;
            // 
            // tabDash
            // 
            this.tabDash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabDash.Controls.Add(this.label1);
            this.tabDash.Controls.Add(this.btnExit);
            this.tabDash.Controls.Add(this.LoggedInAs);
            this.tabDash.Controls.Add(this.label8);
            this.tabDash.Controls.Add(this.label7);
            this.tabDash.Controls.Add(this.label6);
            this.tabDash.Controls.Add(this.label5);
            this.tabDash.Controls.Add(this.label4);
            this.tabDash.Controls.Add(this.btnProductDepartment);
            this.tabDash.Controls.Add(this.btnTechnicalSupportDepartment);
            this.tabDash.Controls.Add(this.EmployeeManagementDepartment);
            this.tabDash.Controls.Add(this.btnSalesManagementDepartment);
            this.tabDash.Controls.Add(this.btnCustomerDepartment);
            this.tabDash.ImageIndex = 0;
            this.tabDash.Location = new System.Drawing.Point(4, 57);
            this.tabDash.Name = "tabDash";
            this.tabDash.Padding = new System.Windows.Forms.Padding(3);
            this.tabDash.Size = new System.Drawing.Size(1372, 679);
            this.tabDash.TabIndex = 1;
            this.tabDash.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::WFPresentationLayer.Properties.Resources._962417_power_button_icon_With_Clipping_Path__Stock_Photo;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnExit.Location = new System.Drawing.Point(658, 476);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(134, 109);
            this.btnExit.TabIndex = 35;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // LoggedInAs
            // 
            this.LoggedInAs.AutoSize = true;
            this.LoggedInAs.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoggedInAs.Location = new System.Drawing.Point(639, 7);
            this.LoggedInAs.Name = "LoggedInAs";
            this.LoggedInAs.Size = new System.Drawing.Size(0, 31);
            this.LoggedInAs.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(964, 588);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(343, 44);
            this.label8.TabIndex = 33;
            this.label8.Text = "Technical Support";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(955, 286);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(364, 44);
            this.label7.TabIndex = 32;
            this.label7.Text = "Sales Management";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(72, 588);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(442, 44);
            this.label6.TabIndex = 31;
            this.label6.Text = "Employee Management";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(527, 377);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(402, 44);
            this.label5.TabIndex = 30;
            this.label5.Text = "Product Management";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(438, 44);
            this.label4.TabIndex = 29;
            this.label4.Text = "Customer Management";
            // 
            // btnProductDepartment
            // 
            this.btnProductDepartment.BackColor = System.Drawing.Color.Transparent;
            this.btnProductDepartment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProductDepartment.BackgroundImage")));
            this.btnProductDepartment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProductDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold);
            this.btnProductDepartment.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnProductDepartment.Location = new System.Drawing.Point(576, 112);
            this.btnProductDepartment.Name = "btnProductDepartment";
            this.btnProductDepartment.Size = new System.Drawing.Size(296, 262);
            this.btnProductDepartment.TabIndex = 28;
            this.btnProductDepartment.UseVisualStyleBackColor = false;
            this.btnProductDepartment.Click += new System.EventHandler(this.btnProductDepartment_Click);
            // 
            // btnTechnicalSupportDepartment
            // 
            this.btnTechnicalSupportDepartment.BackColor = System.Drawing.Color.Transparent;
            this.btnTechnicalSupportDepartment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTechnicalSupportDepartment.BackgroundImage")));
            this.btnTechnicalSupportDepartment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTechnicalSupportDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold);
            this.btnTechnicalSupportDepartment.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTechnicalSupportDepartment.Location = new System.Drawing.Point(985, 365);
            this.btnTechnicalSupportDepartment.Name = "btnTechnicalSupportDepartment";
            this.btnTechnicalSupportDepartment.Size = new System.Drawing.Size(296, 220);
            this.btnTechnicalSupportDepartment.TabIndex = 27;
            this.btnTechnicalSupportDepartment.UseVisualStyleBackColor = false;
            this.btnTechnicalSupportDepartment.Click += new System.EventHandler(this.btnTechnicalSupportDepartment_Click);
            // 
            // EmployeeManagementDepartment
            // 
            this.EmployeeManagementDepartment.BackColor = System.Drawing.Color.Black;
            this.EmployeeManagementDepartment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EmployeeManagementDepartment.BackgroundImage")));
            this.EmployeeManagementDepartment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EmployeeManagementDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold);
            this.EmployeeManagementDepartment.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EmployeeManagementDepartment.Location = new System.Drawing.Point(133, 365);
            this.EmployeeManagementDepartment.Name = "EmployeeManagementDepartment";
            this.EmployeeManagementDepartment.Size = new System.Drawing.Size(296, 220);
            this.EmployeeManagementDepartment.TabIndex = 26;
            this.EmployeeManagementDepartment.UseVisualStyleBackColor = false;
            this.EmployeeManagementDepartment.Click += new System.EventHandler(this.EmployeeManagementDepartment_Click);
            // 
            // btnSalesManagementDepartment
            // 
            this.btnSalesManagementDepartment.BackColor = System.Drawing.Color.Transparent;
            this.btnSalesManagementDepartment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalesManagementDepartment.BackgroundImage")));
            this.btnSalesManagementDepartment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalesManagementDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold);
            this.btnSalesManagementDepartment.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSalesManagementDepartment.Location = new System.Drawing.Point(985, 21);
            this.btnSalesManagementDepartment.Name = "btnSalesManagementDepartment";
            this.btnSalesManagementDepartment.Size = new System.Drawing.Size(296, 262);
            this.btnSalesManagementDepartment.TabIndex = 25;
            this.btnSalesManagementDepartment.UseVisualStyleBackColor = false;
            this.btnSalesManagementDepartment.Click += new System.EventHandler(this.btnSalesManagementDepartment_Click);
            // 
            // btnCustomerDepartment
            // 
            this.btnCustomerDepartment.BackColor = System.Drawing.Color.Transparent;
            this.btnCustomerDepartment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCustomerDepartment.BackgroundImage")));
            this.btnCustomerDepartment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCustomerDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold);
            this.btnCustomerDepartment.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCustomerDepartment.Location = new System.Drawing.Point(143, 21);
            this.btnCustomerDepartment.Name = "btnCustomerDepartment";
            this.btnCustomerDepartment.Size = new System.Drawing.Size(296, 262);
            this.btnCustomerDepartment.TabIndex = 24;
            this.btnCustomerDepartment.UseVisualStyleBackColor = false;
            this.btnCustomerDepartment.Click += new System.EventHandler(this.btnCustomerDepartment_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "DmoticsBluW_icon300px.png");
            this.imageList1.Images.SetKeyName(1, "shs.png");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(685, 588);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 44);
            this.label1.TabIndex = 36;
            this.label1.Text = "Exit";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1380, 740);
            this.ControlBox = false;
            this.Controls.Add(this.dashControl);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.dashControl.ResumeLayout(false);
            this.tabDash.ResumeLayout(false);
            this.tabDash.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl dashControl;
        private System.Windows.Forms.TabPage tabDash;
        private System.Windows.Forms.Button btnProductDepartment;
        private System.Windows.Forms.Button btnTechnicalSupportDepartment;
        private System.Windows.Forms.Button EmployeeManagementDepartment;
        private System.Windows.Forms.Button btnSalesManagementDepartment;
        private System.Windows.Forms.Button btnCustomerDepartment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label LoggedInAs;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
    }
}