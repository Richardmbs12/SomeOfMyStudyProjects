namespace WindowsFormsApplication1
{
    partial class TechnicalSupportDepartment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TechnicalSupportDepartment));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnDash = new System.Windows.Forms.Button();
            this.tabTAdd = new System.Windows.Forms.TabPage();
            this.btnAssignTask = new System.Windows.Forms.Button();
            this.txtTrackingNumber = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtTaskDescription = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.dgvSchedule = new System.Windows.Forms.DataGridView();
            this.tabTSupportEnquiry = new System.Windows.Forms.TabPage();
            this.rTechnicalTaskDesc = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConfirmTEnquiry = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.rtxtEnquiryNote = new System.Windows.Forms.RichTextBox();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCustomerIDSearch = new System.Windows.Forms.ComboBox();
            this.btnFindCustomerEnquiry = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvEnquiries = new System.Windows.Forms.DataGridView();
            this.btnAnswerCall = new System.Windows.Forms.Button();
            this.btnHoldCall = new System.Windows.Forms.Button();
            this.btnEndCall = new System.Windows.Forms.Button();
            this.SupportControl = new System.Windows.Forms.TabControl();
            this.rtxtAddress = new System.Windows.Forms.RichTextBox();
            this.tabTAdd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).BeginInit();
            this.tabTSupportEnquiry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnquiries)).BeginInit();
            this.SupportControl.SuspendLayout();
            this.SuspendLayout();
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
            this.imageList1.Images.SetKeyName(9, "Update.png");
            this.imageList1.Images.SetKeyName(10, "SendManual.png");
            // 
            // btnDash
            // 
            this.btnDash.BackColor = System.Drawing.Color.Transparent;
            this.btnDash.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDash.BackgroundImage")));
            this.btnDash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDash.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDash.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDash.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDash.Location = new System.Drawing.Point(686, 3);
            this.btnDash.Name = "btnDash";
            this.btnDash.Size = new System.Drawing.Size(152, 54);
            this.btnDash.TabIndex = 105;
            this.btnDash.UseVisualStyleBackColor = false;
            this.btnDash.Click += new System.EventHandler(this.btnDash_Click);
            // 
            // tabTAdd
            // 
            this.tabTAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabTAdd.Controls.Add(this.rtxtAddress);
            this.tabTAdd.Controls.Add(this.btnAssignTask);
            this.tabTAdd.Controls.Add(this.txtTrackingNumber);
            this.tabTAdd.Controls.Add(this.txtCustomerID);
            this.tabTAdd.Controls.Add(this.txtTaskDescription);
            this.tabTAdd.Controls.Add(this.label10);
            this.tabTAdd.Controls.Add(this.label8);
            this.tabTAdd.Controls.Add(this.label15);
            this.tabTAdd.Controls.Add(this.label23);
            this.tabTAdd.Controls.Add(this.dgvSchedule);
            this.tabTAdd.Location = new System.Drawing.Point(4, 59);
            this.tabTAdd.Name = "tabTAdd";
            this.tabTAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabTAdd.Size = new System.Drawing.Size(876, 681);
            this.tabTAdd.TabIndex = 1;
            this.tabTAdd.Text = "Schedules";
            this.tabTAdd.UseVisualStyleBackColor = true;
            // 
            // btnAssignTask
            // 
            this.btnAssignTask.AutoEllipsis = true;
            this.btnAssignTask.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAssignTask.BackColor = System.Drawing.Color.Transparent;
            this.btnAssignTask.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAssignTask.BackgroundImage")));
            this.btnAssignTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAssignTask.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAssignTask.FlatAppearance.BorderSize = 0;
            this.btnAssignTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssignTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssignTask.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnAssignTask.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAssignTask.ImageIndex = 10;
            this.btnAssignTask.ImageList = this.imageList1;
            this.btnAssignTask.Location = new System.Drawing.Point(55, 612);
            this.btnAssignTask.Name = "btnAssignTask";
            this.btnAssignTask.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btnAssignTask.Size = new System.Drawing.Size(373, 61);
            this.btnAssignTask.TabIndex = 176;
            this.btnAssignTask.Text = "Assign Current Task";
            this.btnAssignTask.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAssignTask.UseCompatibleTextRendering = true;
            this.btnAssignTask.UseVisualStyleBackColor = false;
            this.btnAssignTask.Click += new System.EventHandler(this.btnAssignTask_Click);
            // 
            // txtTrackingNumber
            // 
            this.txtTrackingNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrackingNumber.Location = new System.Drawing.Point(55, 468);
            this.txtTrackingNumber.Name = "txtTrackingNumber";
            this.txtTrackingNumber.Size = new System.Drawing.Size(314, 29);
            this.txtTrackingNumber.TabIndex = 119;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerID.Location = new System.Drawing.Point(468, 467);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(313, 30);
            this.txtCustomerID.TabIndex = 117;
            // 
            // txtTaskDescription
            // 
            this.txtTaskDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaskDescription.Location = new System.Drawing.Point(55, 551);
            this.txtTaskDescription.Name = "txtTaskDescription";
            this.txtTaskDescription.Size = new System.Drawing.Size(306, 29);
            this.txtTaskDescription.TabIndex = 115;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(464, 425);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 24);
            this.label10.TabIndex = 118;
            this.label10.Text = "Customer ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(51, 524);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 24);
            this.label8.TabIndex = 116;
            this.label8.Text = "Task Description";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(464, 509);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(182, 24);
            this.label15.TabIndex = 114;
            this.label15.Text = "Customer Address";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(51, 425);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(172, 24);
            this.label23.TabIndex = 112;
            this.label23.Text = "Tracking Number";
            // 
            // dgvSchedule
            // 
            this.dgvSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSchedule.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedule.Location = new System.Drawing.Point(55, 25);
            this.dgvSchedule.Name = "dgvSchedule";
            this.dgvSchedule.Size = new System.Drawing.Size(726, 371);
            this.dgvSchedule.TabIndex = 111;
            this.dgvSchedule.SelectionChanged += new System.EventHandler(this.dgvSchedule_SelectionChanged);
            // 
            // tabTSupportEnquiry
            // 
            this.tabTSupportEnquiry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabTSupportEnquiry.Controls.Add(this.rTechnicalTaskDesc);
            this.tabTSupportEnquiry.Controls.Add(this.label5);
            this.tabTSupportEnquiry.Controls.Add(this.btnConfirmTEnquiry);
            this.tabTSupportEnquiry.Controls.Add(this.txtName);
            this.tabTSupportEnquiry.Controls.Add(this.rtxtEnquiryNote);
            this.tabTSupportEnquiry.Controls.Add(this.txtEmailAddress);
            this.tabTSupportEnquiry.Controls.Add(this.txtPhoneNumber);
            this.tabTSupportEnquiry.Controls.Add(this.label1);
            this.tabTSupportEnquiry.Controls.Add(this.label2);
            this.tabTSupportEnquiry.Controls.Add(this.label4);
            this.tabTSupportEnquiry.Controls.Add(this.label6);
            this.tabTSupportEnquiry.Controls.Add(this.cmbCustomerIDSearch);
            this.tabTSupportEnquiry.Controls.Add(this.btnFindCustomerEnquiry);
            this.tabTSupportEnquiry.Controls.Add(this.label3);
            this.tabTSupportEnquiry.Controls.Add(this.dgvEnquiries);
            this.tabTSupportEnquiry.Controls.Add(this.btnAnswerCall);
            this.tabTSupportEnquiry.Controls.Add(this.btnHoldCall);
            this.tabTSupportEnquiry.Controls.Add(this.btnEndCall);
            this.tabTSupportEnquiry.ImageIndex = 0;
            this.tabTSupportEnquiry.Location = new System.Drawing.Point(4, 59);
            this.tabTSupportEnquiry.Name = "tabTSupportEnquiry";
            this.tabTSupportEnquiry.Padding = new System.Windows.Forms.Padding(3);
            this.tabTSupportEnquiry.Size = new System.Drawing.Size(876, 681);
            this.tabTSupportEnquiry.TabIndex = 0;
            this.tabTSupportEnquiry.Text = "Technical Support Enquiry";
            this.tabTSupportEnquiry.UseVisualStyleBackColor = true;
            // 
            // rTechnicalTaskDesc
            // 
            this.rTechnicalTaskDesc.Location = new System.Drawing.Point(567, 316);
            this.rTechnicalTaskDesc.Name = "rTechnicalTaskDesc";
            this.rTechnicalTaskDesc.Size = new System.Drawing.Size(271, 184);
            this.rTechnicalTaskDesc.TabIndex = 208;
            this.rTechnicalTaskDesc.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(567, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 24);
            this.label5.TabIndex = 207;
            this.label5.Text = "Technical Task Desc";
            // 
            // btnConfirmTEnquiry
            // 
            this.btnConfirmTEnquiry.AutoEllipsis = true;
            this.btnConfirmTEnquiry.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConfirmTEnquiry.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmTEnquiry.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfirmTEnquiry.BackgroundImage")));
            this.btnConfirmTEnquiry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirmTEnquiry.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConfirmTEnquiry.FlatAppearance.BorderSize = 0;
            this.btnConfirmTEnquiry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmTEnquiry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmTEnquiry.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnConfirmTEnquiry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmTEnquiry.ImageIndex = 10;
            this.btnConfirmTEnquiry.ImageList = this.imageList1;
            this.btnConfirmTEnquiry.Location = new System.Drawing.Point(607, 609);
            this.btnConfirmTEnquiry.Name = "btnConfirmTEnquiry";
            this.btnConfirmTEnquiry.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btnConfirmTEnquiry.Size = new System.Drawing.Size(214, 61);
            this.btnConfirmTEnquiry.TabIndex = 206;
            this.btnConfirmTEnquiry.Text = "Confirm Technical Support Enquiry";
            this.btnConfirmTEnquiry.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmTEnquiry.UseCompatibleTextRendering = true;
            this.btnConfirmTEnquiry.UseVisualStyleBackColor = false;
            this.btnConfirmTEnquiry.Click += new System.EventHandler(this.btnConfirmTEnquiry_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(259, 413);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(263, 29);
            this.txtName.TabIndex = 204;
            // 
            // rtxtEnquiryNote
            // 
            this.rtxtEnquiryNote.Location = new System.Drawing.Point(563, 60);
            this.rtxtEnquiryNote.Name = "rtxtEnquiryNote";
            this.rtxtEnquiryNote.Size = new System.Drawing.Size(271, 184);
            this.rtxtEnquiryNote.TabIndex = 188;
            this.rtxtEnquiryNote.Text = "";
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailAddress.Location = new System.Drawing.Point(259, 563);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(263, 30);
            this.txtEmailAddress.TabIndex = 186;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(259, 488);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(263, 29);
            this.txtPhoneNumber.TabIndex = 184;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 24);
            this.label1.TabIndex = 205;
            this.label1.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 528);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 24);
            this.label2.TabIndex = 187;
            this.label2.Text = "Email Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(259, 453);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 24);
            this.label4.TabIndex = 185;
            this.label4.Text = "Phone Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(563, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 24);
            this.label6.TabIndex = 183;
            this.label6.Text = "Enquiry Note";
            // 
            // cmbCustomerIDSearch
            // 
            this.cmbCustomerIDSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCustomerIDSearch.FormattingEnabled = true;
            this.cmbCustomerIDSearch.Location = new System.Drawing.Point(31, 42);
            this.cmbCustomerIDSearch.Name = "cmbCustomerIDSearch";
            this.cmbCustomerIDSearch.Size = new System.Drawing.Size(212, 32);
            this.cmbCustomerIDSearch.TabIndex = 172;
            // 
            // btnFindCustomerEnquiry
            // 
            this.btnFindCustomerEnquiry.AutoEllipsis = true;
            this.btnFindCustomerEnquiry.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFindCustomerEnquiry.BackColor = System.Drawing.Color.Transparent;
            this.btnFindCustomerEnquiry.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFindCustomerEnquiry.BackgroundImage")));
            this.btnFindCustomerEnquiry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFindCustomerEnquiry.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnFindCustomerEnquiry.FlatAppearance.BorderSize = 0;
            this.btnFindCustomerEnquiry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindCustomerEnquiry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindCustomerEnquiry.ForeColor = System.Drawing.Color.Cornsilk;
            this.btnFindCustomerEnquiry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFindCustomerEnquiry.ImageIndex = 10;
            this.btnFindCustomerEnquiry.ImageList = this.imageList1;
            this.btnFindCustomerEnquiry.Location = new System.Drawing.Point(249, 28);
            this.btnFindCustomerEnquiry.Name = "btnFindCustomerEnquiry";
            this.btnFindCustomerEnquiry.Padding = new System.Windows.Forms.Padding(0, 0, 15, 0);
            this.btnFindCustomerEnquiry.Size = new System.Drawing.Size(273, 61);
            this.btnFindCustomerEnquiry.TabIndex = 171;
            this.btnFindCustomerEnquiry.Text = "Find Customer Enquiries";
            this.btnFindCustomerEnquiry.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFindCustomerEnquiry.UseCompatibleTextRendering = true;
            this.btnFindCustomerEnquiry.UseVisualStyleBackColor = false;
            this.btnFindCustomerEnquiry.Click += new System.EventHandler(this.btnFindCustomerEnquiry_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 24);
            this.label3.TabIndex = 170;
            this.label3.Text = "Customer ID";
            // 
            // dgvEnquiries
            // 
            this.dgvEnquiries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEnquiries.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEnquiries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEnquiries.Location = new System.Drawing.Point(31, 126);
            this.dgvEnquiries.Name = "dgvEnquiries";
            this.dgvEnquiries.Size = new System.Drawing.Size(491, 188);
            this.dgvEnquiries.TabIndex = 169;
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
            this.btnAnswerCall.Location = new System.Drawing.Point(31, 360);
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
            this.btnHoldCall.Location = new System.Drawing.Point(31, 439);
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
            this.btnEndCall.ImageIndex = 4;
            this.btnEndCall.ImageList = this.imageList1;
            this.btnEndCall.Location = new System.Drawing.Point(31, 532);
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
            // SupportControl
            // 
            this.SupportControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.SupportControl.Controls.Add(this.tabTSupportEnquiry);
            this.SupportControl.Controls.Add(this.tabTAdd);
            this.SupportControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SupportControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold);
            this.SupportControl.ImageList = this.imageList1;
            this.SupportControl.ItemSize = new System.Drawing.Size(123, 55);
            this.SupportControl.Location = new System.Drawing.Point(0, 0);
            this.SupportControl.Multiline = true;
            this.SupportControl.Name = "SupportControl";
            this.SupportControl.SelectedIndex = 0;
            this.SupportControl.ShowToolTips = true;
            this.SupportControl.Size = new System.Drawing.Size(884, 744);
            this.SupportControl.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.SupportControl.TabIndex = 1;
            // 
            // rtxtAddress
            // 
            this.rtxtAddress.Location = new System.Drawing.Point(468, 536);
            this.rtxtAddress.Name = "rtxtAddress";
            this.rtxtAddress.Size = new System.Drawing.Size(366, 128);
            this.rtxtAddress.TabIndex = 177;
            this.rtxtAddress.Text = "";
            // 
            // TechnicalSupportDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 744);
            this.ControlBox = false;
            this.Controls.Add(this.btnDash);
            this.Controls.Add(this.SupportControl);
            this.Name = "TechnicalSupportDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TechnicalSupportDepartment";
            this.tabTAdd.ResumeLayout(false);
            this.tabTAdd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedule)).EndInit();
            this.tabTSupportEnquiry.ResumeLayout(false);
            this.tabTSupportEnquiry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEnquiries)).EndInit();
            this.SupportControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDash;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TabPage tabTAdd;
        private System.Windows.Forms.Button btnAssignTask;
        private System.Windows.Forms.TextBox txtTrackingNumber;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtTaskDescription;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DataGridView dgvSchedule;
        private System.Windows.Forms.TabPage tabTSupportEnquiry;
        private System.Windows.Forms.Button btnConfirmTEnquiry;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RichTextBox rtxtEnquiryNote;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCustomerIDSearch;
        private System.Windows.Forms.Button btnFindCustomerEnquiry;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvEnquiries;
        private System.Windows.Forms.Button btnAnswerCall;
        private System.Windows.Forms.Button btnHoldCall;
        private System.Windows.Forms.Button btnEndCall;
        private System.Windows.Forms.TabControl SupportControl;
        private System.Windows.Forms.RichTextBox rTechnicalTaskDesc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rtxtAddress;
    }
}