namespace A2_Reg_A_Lot_2017
{
    partial class UpdateCreateProfessor
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
            this.btnBack = new System.Windows.Forms.Button();
            this.gbxProfessorInfo = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.txtZipcode = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFname = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.lblDisplayEmail = new System.Windows.Forms.Label();
            this.lblDisplayCity = new System.Windows.Forms.Label();
            this.lblAddressA = new System.Windows.Forms.Label();
            this.lblDisplayState = new System.Windows.Forms.Label();
            this.lblDisplayZipCode = new System.Windows.Forms.Label();
            this.lblDisplayFax = new System.Windows.Forms.Label();
            this.lbxProfessors = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.gbxProfessorSearch = new System.Windows.Forms.GroupBox();
            this.btnSearchProfessors = new System.Windows.Forms.Button();
            this.lblByName = new System.Windows.Forms.Label();
            this.txtProfessorName = new System.Windows.Forms.TextBox();
            this.lstCourses = new System.Windows.Forms.ListBox();
            this.lblByCourse = new System.Windows.Forms.Label();
            this.btnEditProfessor = new System.Windows.Forms.Button();
            this.btnCreateProfessor = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.gbxProfessorInfo.SuspendLayout();
            this.gbxProfessorSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(502, 353);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 40);
            this.btnBack.TabIndex = 78;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gbxProfessorInfo
            // 
            this.gbxProfessorInfo.Controls.Add(this.comboBox1);
            this.gbxProfessorInfo.Controls.Add(this.txtPhone);
            this.gbxProfessorInfo.Controls.Add(this.txtEmail);
            this.gbxProfessorInfo.Controls.Add(this.txtFax);
            this.gbxProfessorInfo.Controls.Add(this.txtZipcode);
            this.gbxProfessorInfo.Controls.Add(this.txtState);
            this.gbxProfessorInfo.Controls.Add(this.txtCity);
            this.gbxProfessorInfo.Controls.Add(this.txtAddress);
            this.gbxProfessorInfo.Controls.Add(this.txtLastName);
            this.gbxProfessorInfo.Controls.Add(this.txtFirstName);
            this.gbxProfessorInfo.Controls.Add(this.lblPhone);
            this.gbxProfessorInfo.Controls.Add(this.label1);
            this.gbxProfessorInfo.Controls.Add(this.lblFname);
            this.gbxProfessorInfo.Controls.Add(this.label30);
            this.gbxProfessorInfo.Controls.Add(this.lblDisplayEmail);
            this.gbxProfessorInfo.Controls.Add(this.lblDisplayCity);
            this.gbxProfessorInfo.Controls.Add(this.lblAddressA);
            this.gbxProfessorInfo.Controls.Add(this.lblDisplayState);
            this.gbxProfessorInfo.Controls.Add(this.lblDisplayZipCode);
            this.gbxProfessorInfo.Controls.Add(this.lblDisplayFax);
            this.gbxProfessorInfo.Location = new System.Drawing.Point(312, 32);
            this.gbxProfessorInfo.Name = "gbxProfessorInfo";
            this.gbxProfessorInfo.Size = new System.Drawing.Size(265, 263);
            this.gbxProfessorInfo.TabIndex = 77;
            this.gbxProfessorInfo.TabStop = false;
            this.gbxProfessorInfo.Text = "Professor Information";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(100, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(139, 21);
            this.comboBox1.TabIndex = 159;
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Location = new System.Drawing.Point(100, 238);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(139, 13);
            this.txtPhone.TabIndex = 158;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Location = new System.Drawing.Point(100, 213);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(139, 13);
            this.txtEmail.TabIndex = 157;
            // 
            // txtFax
            // 
            this.txtFax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFax.Location = new System.Drawing.Point(100, 189);
            this.txtFax.Name = "txtFax";
            this.txtFax.ReadOnly = true;
            this.txtFax.Size = new System.Drawing.Size(139, 13);
            this.txtFax.TabIndex = 156;
            // 
            // txtZipcode
            // 
            this.txtZipcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtZipcode.Location = new System.Drawing.Point(100, 165);
            this.txtZipcode.Name = "txtZipcode";
            this.txtZipcode.ReadOnly = true;
            this.txtZipcode.Size = new System.Drawing.Size(139, 13);
            this.txtZipcode.TabIndex = 155;
            // 
            // txtState
            // 
            this.txtState.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtState.Location = new System.Drawing.Point(100, 141);
            this.txtState.Name = "txtState";
            this.txtState.ReadOnly = true;
            this.txtState.Size = new System.Drawing.Size(139, 13);
            this.txtState.TabIndex = 154;
            // 
            // txtCity
            // 
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCity.Location = new System.Drawing.Point(100, 117);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(139, 13);
            this.txtCity.TabIndex = 153;
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Location = new System.Drawing.Point(100, 93);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(139, 13);
            this.txtAddress.TabIndex = 152;
            // 
            // txtLastName
            // 
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastName.Location = new System.Drawing.Point(100, 44);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(139, 13);
            this.txtLastName.TabIndex = 151;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirstName.Location = new System.Drawing.Point(100, 20);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(139, 13);
            this.txtFirstName.TabIndex = 150;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(34, 238);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(41, 13);
            this.lblPhone.TabIndex = 147;
            this.lblPhone.Text = "Phone:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 146;
            this.label1.Text = "Gender:";
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Location = new System.Drawing.Point(34, 20);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(58, 13);
            this.lblFname.TabIndex = 138;
            this.lblFname.Text = "First name:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(34, 44);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(59, 13);
            this.label30.TabIndex = 139;
            this.label30.Text = "Last name:";
            // 
            // lblDisplayEmail
            // 
            this.lblDisplayEmail.AutoSize = true;
            this.lblDisplayEmail.Location = new System.Drawing.Point(37, 213);
            this.lblDisplayEmail.Name = "lblDisplayEmail";
            this.lblDisplayEmail.Size = new System.Drawing.Size(35, 13);
            this.lblDisplayEmail.TabIndex = 145;
            this.lblDisplayEmail.Text = "Email:";
            // 
            // lblDisplayCity
            // 
            this.lblDisplayCity.AutoSize = true;
            this.lblDisplayCity.Location = new System.Drawing.Point(37, 117);
            this.lblDisplayCity.Name = "lblDisplayCity";
            this.lblDisplayCity.Size = new System.Drawing.Size(27, 13);
            this.lblDisplayCity.TabIndex = 140;
            this.lblDisplayCity.Text = "City:";
            // 
            // lblAddressA
            // 
            this.lblAddressA.AutoSize = true;
            this.lblAddressA.Location = new System.Drawing.Point(34, 93);
            this.lblAddressA.Name = "lblAddressA";
            this.lblAddressA.Size = new System.Drawing.Size(48, 13);
            this.lblAddressA.TabIndex = 144;
            this.lblAddressA.Text = "Address:";
            // 
            // lblDisplayState
            // 
            this.lblDisplayState.AutoSize = true;
            this.lblDisplayState.Location = new System.Drawing.Point(37, 141);
            this.lblDisplayState.Name = "lblDisplayState";
            this.lblDisplayState.Size = new System.Drawing.Size(35, 13);
            this.lblDisplayState.TabIndex = 141;
            this.lblDisplayState.Text = "State:";
            // 
            // lblDisplayZipCode
            // 
            this.lblDisplayZipCode.AutoSize = true;
            this.lblDisplayZipCode.Location = new System.Drawing.Point(37, 165);
            this.lblDisplayZipCode.Name = "lblDisplayZipCode";
            this.lblDisplayZipCode.Size = new System.Drawing.Size(49, 13);
            this.lblDisplayZipCode.TabIndex = 142;
            this.lblDisplayZipCode.Text = "Zipcode:";
            // 
            // lblDisplayFax
            // 
            this.lblDisplayFax.AutoSize = true;
            this.lblDisplayFax.Location = new System.Drawing.Point(37, 189);
            this.lblDisplayFax.Name = "lblDisplayFax";
            this.lblDisplayFax.Size = new System.Drawing.Size(27, 13);
            this.lblDisplayFax.TabIndex = 143;
            this.lblDisplayFax.Text = "Fax:";
            // 
            // lbxProfessors
            // 
            this.lbxProfessors.FormattingEnabled = true;
            this.lbxProfessors.Items.AddRange(new object[] {
            "Should list all Professors"});
            this.lbxProfessors.Location = new System.Drawing.Point(13, 143);
            this.lbxProfessors.Name = "lbxProfessors";
            this.lbxProfessors.Size = new System.Drawing.Size(279, 199);
            this.lbxProfessors.TabIndex = 76;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(8, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(216, 25);
            this.label13.TabIndex = 75;
            this.label13.Text = "Manage Professors";
            // 
            // gbxProfessorSearch
            // 
            this.gbxProfessorSearch.Controls.Add(this.btnSearchProfessors);
            this.gbxProfessorSearch.Controls.Add(this.lblByName);
            this.gbxProfessorSearch.Controls.Add(this.txtProfessorName);
            this.gbxProfessorSearch.Controls.Add(this.lstCourses);
            this.gbxProfessorSearch.Controls.Add(this.lblByCourse);
            this.gbxProfessorSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxProfessorSearch.Location = new System.Drawing.Point(13, 38);
            this.gbxProfessorSearch.Name = "gbxProfessorSearch";
            this.gbxProfessorSearch.Size = new System.Drawing.Size(279, 99);
            this.gbxProfessorSearch.TabIndex = 74;
            this.gbxProfessorSearch.TabStop = false;
            this.gbxProfessorSearch.Text = "Search for a Professor";
            // 
            // btnSearchProfessors
            // 
            this.btnSearchProfessors.Location = new System.Drawing.Point(142, 68);
            this.btnSearchProfessors.Name = "btnSearchProfessors";
            this.btnSearchProfessors.Size = new System.Drawing.Size(75, 23);
            this.btnSearchProfessors.TabIndex = 65;
            this.btnSearchProfessors.Text = "Search";
            this.btnSearchProfessors.UseVisualStyleBackColor = true;
            // 
            // lblByName
            // 
            this.lblByName.AutoSize = true;
            this.lblByName.Location = new System.Drawing.Point(22, 22);
            this.lblByName.Name = "lblByName";
            this.lblByName.Size = new System.Drawing.Size(87, 13);
            this.lblByName.TabIndex = 0;
            this.lblByName.Text = "Search by name:";
            // 
            // txtProfessorName
            // 
            this.txtProfessorName.Location = new System.Drawing.Point(115, 19);
            this.txtProfessorName.Name = "txtProfessorName";
            this.txtProfessorName.Size = new System.Drawing.Size(138, 20);
            this.txtProfessorName.TabIndex = 1;
            // 
            // lstCourses
            // 
            this.lstCourses.FormattingEnabled = true;
            this.lstCourses.Items.AddRange(new object[] {
            "CourseName 1",
            "CourseName 2",
            "CourseName 3",
            "CourseName 4",
            "CourseName 5",
            "CourseName 6",
            "CourseName 7"});
            this.lstCourses.Location = new System.Drawing.Point(115, 45);
            this.lstCourses.Name = "lstCourses";
            this.lstCourses.Size = new System.Drawing.Size(138, 17);
            this.lstCourses.TabIndex = 7;
            // 
            // lblByCourse
            // 
            this.lblByCourse.AutoSize = true;
            this.lblByCourse.Location = new System.Drawing.Point(22, 46);
            this.lblByCourse.Name = "lblByCourse";
            this.lblByCourse.Size = new System.Drawing.Size(78, 13);
            this.lblByCourse.TabIndex = 6;
            this.lblByCourse.Text = "Filter by course";
            // 
            // btnEditProfessor
            // 
            this.btnEditProfessor.Location = new System.Drawing.Point(324, 302);
            this.btnEditProfessor.Name = "btnEditProfessor";
            this.btnEditProfessor.Size = new System.Drawing.Size(75, 40);
            this.btnEditProfessor.TabIndex = 79;
            this.btnEditProfessor.Text = "Edit Info";
            this.btnEditProfessor.UseVisualStyleBackColor = true;
            this.btnEditProfessor.Click += new System.EventHandler(this.btnEditProfessor_Click);
            // 
            // btnCreateProfessor
            // 
            this.btnCreateProfessor.Location = new System.Drawing.Point(110, 353);
            this.btnCreateProfessor.Name = "btnCreateProfessor";
            this.btnCreateProfessor.Size = new System.Drawing.Size(75, 41);
            this.btnCreateProfessor.TabIndex = 80;
            this.btnCreateProfessor.Text = "Add New Professor";
            this.btnCreateProfessor.UseVisualStyleBackColor = true;
            this.btnCreateProfessor.Click += new System.EventHandler(this.btnCreateProfessor_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(502, 322);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 127;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(502, 298);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 126;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Visible = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // UpdateCreateProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 405);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCreateProfessor);
            this.Controls.Add(this.btnEditProfessor);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gbxProfessorInfo);
            this.Controls.Add(this.lbxProfessors);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.gbxProfessorSearch);
            this.Name = "UpdateCreateProfessor";
            this.Text = "Add or Update Professor";
            this.gbxProfessorInfo.ResumeLayout(false);
            this.gbxProfessorInfo.PerformLayout();
            this.gbxProfessorSearch.ResumeLayout(false);
            this.gbxProfessorSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox gbxProfessorInfo;
        private System.Windows.Forms.ListBox lbxProfessors;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox gbxProfessorSearch;
        private System.Windows.Forms.Button btnSearchProfessors;
        private System.Windows.Forms.Label lblByName;
        private System.Windows.Forms.TextBox txtProfessorName;
        private System.Windows.Forms.ListBox lstCourses;
        private System.Windows.Forms.Label lblByCourse;
        private System.Windows.Forms.Button btnEditProfessor;
        private System.Windows.Forms.Button btnCreateProfessor;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.TextBox txtZipcode;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label lblDisplayEmail;
        private System.Windows.Forms.Label lblDisplayCity;
        private System.Windows.Forms.Label lblAddressA;
        private System.Windows.Forms.Label lblDisplayState;
        private System.Windows.Forms.Label lblDisplayZipCode;
        private System.Windows.Forms.Label lblDisplayFax;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
    }
}