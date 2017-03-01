namespace A2_Reg_A_Lot_2017
{
    partial class StudentMenu
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
            this.gbxMyCourses = new System.Windows.Forms.GroupBox();
            this.gbxStudentInfo = new System.Windows.Forms.GroupBox();
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
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
            this.imgStudentPhoto = new System.Windows.Forms.PictureBox();
            this.btnUpdateInfo = new System.Windows.Forms.Button();
            this.btnDropCourse = new System.Windows.Forms.Button();
            this.btnRegisterCourse = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.columnCourseTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnProfessor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSchedule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxMyCourses.SuspendLayout();
            this.gbxStudentInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgStudentPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxMyCourses
            // 
            this.gbxMyCourses.Controls.Add(this.dataGridView1);
            this.gbxMyCourses.Location = new System.Drawing.Point(278, 12);
            this.gbxMyCourses.Name = "gbxMyCourses";
            this.gbxMyCourses.Size = new System.Drawing.Size(575, 380);
            this.gbxMyCourses.TabIndex = 68;
            this.gbxMyCourses.TabStop = false;
            this.gbxMyCourses.Text = "My Courses";
            // 
            // gbxStudentInfo
            // 
            this.gbxStudentInfo.Controls.Add(this.comboBox1);
            this.gbxStudentInfo.Controls.Add(this.txtPhone);
            this.gbxStudentInfo.Controls.Add(this.txtEmail);
            this.gbxStudentInfo.Controls.Add(this.txtFax);
            this.gbxStudentInfo.Controls.Add(this.txtZipcode);
            this.gbxStudentInfo.Controls.Add(this.txtState);
            this.gbxStudentInfo.Controls.Add(this.txtCity);
            this.gbxStudentInfo.Controls.Add(this.txtAddress);
            this.gbxStudentInfo.Controls.Add(this.txtLastName);
            this.gbxStudentInfo.Controls.Add(this.txtFirstName);
            this.gbxStudentInfo.Controls.Add(this.btnCancel);
            this.gbxStudentInfo.Controls.Add(this.btnConfirm);
            this.gbxStudentInfo.Controls.Add(this.lblPhone);
            this.gbxStudentInfo.Controls.Add(this.label1);
            this.gbxStudentInfo.Controls.Add(this.lblFname);
            this.gbxStudentInfo.Controls.Add(this.label30);
            this.gbxStudentInfo.Controls.Add(this.lblDisplayEmail);
            this.gbxStudentInfo.Controls.Add(this.lblDisplayCity);
            this.gbxStudentInfo.Controls.Add(this.lblAddressA);
            this.gbxStudentInfo.Controls.Add(this.lblDisplayState);
            this.gbxStudentInfo.Controls.Add(this.lblDisplayZipCode);
            this.gbxStudentInfo.Controls.Add(this.lblDisplayFax);
            this.gbxStudentInfo.Controls.Add(this.imgStudentPhoto);
            this.gbxStudentInfo.Controls.Add(this.btnUpdateInfo);
            this.gbxStudentInfo.Location = new System.Drawing.Point(12, 12);
            this.gbxStudentInfo.Name = "gbxStudentInfo";
            this.gbxStudentInfo.Size = new System.Drawing.Size(260, 422);
            this.gbxStudentInfo.TabIndex = 67;
            this.gbxStudentInfo.TabStop = false;
            this.gbxStudentInfo.Text = "Student Information";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(98, 181);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(139, 21);
            this.comboBox1.TabIndex = 136;
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Location = new System.Drawing.Point(98, 356);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(139, 13);
            this.txtPhone.TabIndex = 135;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Location = new System.Drawing.Point(98, 331);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(139, 13);
            this.txtEmail.TabIndex = 134;
            // 
            // txtFax
            // 
            this.txtFax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFax.Location = new System.Drawing.Point(98, 307);
            this.txtFax.Name = "txtFax";
            this.txtFax.ReadOnly = true;
            this.txtFax.Size = new System.Drawing.Size(139, 13);
            this.txtFax.TabIndex = 133;
            // 
            // txtZipcode
            // 
            this.txtZipcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtZipcode.Location = new System.Drawing.Point(98, 283);
            this.txtZipcode.Name = "txtZipcode";
            this.txtZipcode.ReadOnly = true;
            this.txtZipcode.Size = new System.Drawing.Size(139, 13);
            this.txtZipcode.TabIndex = 132;
            // 
            // txtState
            // 
            this.txtState.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtState.Location = new System.Drawing.Point(98, 259);
            this.txtState.Name = "txtState";
            this.txtState.ReadOnly = true;
            this.txtState.Size = new System.Drawing.Size(139, 13);
            this.txtState.TabIndex = 131;
            // 
            // txtCity
            // 
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCity.Location = new System.Drawing.Point(98, 235);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(139, 13);
            this.txtCity.TabIndex = 130;
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Location = new System.Drawing.Point(98, 211);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(139, 13);
            this.txtAddress.TabIndex = 129;
            // 
            // txtLastName
            // 
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastName.Location = new System.Drawing.Point(98, 162);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(139, 13);
            this.txtLastName.TabIndex = 127;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirstName.Location = new System.Drawing.Point(98, 138);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(139, 13);
            this.txtFirstName.TabIndex = 126;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(179, 393);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 125;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(103, 393);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 124;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Visible = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(32, 356);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(41, 13);
            this.lblPhone.TabIndex = 122;
            this.lblPhone.Text = "Phone:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 120;
            this.label1.Text = "Gender:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Location = new System.Drawing.Point(32, 138);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(58, 13);
            this.lblFname.TabIndex = 100;
            this.lblFname.Text = "First name:";
            this.lblFname.Click += new System.EventHandler(this.lblFname_Click);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(32, 162);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(59, 13);
            this.label30.TabIndex = 101;
            this.label30.Text = "Last name:";
            this.label30.Click += new System.EventHandler(this.label30_Click);
            // 
            // lblDisplayEmail
            // 
            this.lblDisplayEmail.AutoSize = true;
            this.lblDisplayEmail.Location = new System.Drawing.Point(35, 331);
            this.lblDisplayEmail.Name = "lblDisplayEmail";
            this.lblDisplayEmail.Size = new System.Drawing.Size(35, 13);
            this.lblDisplayEmail.TabIndex = 108;
            this.lblDisplayEmail.Text = "Email:";
            this.lblDisplayEmail.Click += new System.EventHandler(this.lblDisplayEmail_Click);
            // 
            // lblDisplayCity
            // 
            this.lblDisplayCity.AutoSize = true;
            this.lblDisplayCity.Location = new System.Drawing.Point(35, 235);
            this.lblDisplayCity.Name = "lblDisplayCity";
            this.lblDisplayCity.Size = new System.Drawing.Size(27, 13);
            this.lblDisplayCity.TabIndex = 102;
            this.lblDisplayCity.Text = "City:";
            // 
            // lblAddressA
            // 
            this.lblAddressA.AutoSize = true;
            this.lblAddressA.Location = new System.Drawing.Point(32, 211);
            this.lblAddressA.Name = "lblAddressA";
            this.lblAddressA.Size = new System.Drawing.Size(48, 13);
            this.lblAddressA.TabIndex = 106;
            this.lblAddressA.Text = "Address:";
            this.lblAddressA.Click += new System.EventHandler(this.lblAddressA_Click);
            // 
            // lblDisplayState
            // 
            this.lblDisplayState.AutoSize = true;
            this.lblDisplayState.Location = new System.Drawing.Point(35, 259);
            this.lblDisplayState.Name = "lblDisplayState";
            this.lblDisplayState.Size = new System.Drawing.Size(35, 13);
            this.lblDisplayState.TabIndex = 103;
            this.lblDisplayState.Text = "State:";
            this.lblDisplayState.Click += new System.EventHandler(this.lblDisplayState_Click);
            // 
            // lblDisplayZipCode
            // 
            this.lblDisplayZipCode.AutoSize = true;
            this.lblDisplayZipCode.Location = new System.Drawing.Point(35, 283);
            this.lblDisplayZipCode.Name = "lblDisplayZipCode";
            this.lblDisplayZipCode.Size = new System.Drawing.Size(49, 13);
            this.lblDisplayZipCode.TabIndex = 104;
            this.lblDisplayZipCode.Text = "Zipcode:";
            this.lblDisplayZipCode.Click += new System.EventHandler(this.lblDisplayZipCode_Click);
            // 
            // lblDisplayFax
            // 
            this.lblDisplayFax.AutoSize = true;
            this.lblDisplayFax.Location = new System.Drawing.Point(35, 307);
            this.lblDisplayFax.Name = "lblDisplayFax";
            this.lblDisplayFax.Size = new System.Drawing.Size(27, 13);
            this.lblDisplayFax.TabIndex = 105;
            this.lblDisplayFax.Text = "Fax:";
            this.lblDisplayFax.Click += new System.EventHandler(this.lblDisplayFax_Click);
            // 
            // imgStudentPhoto
            // 
            this.imgStudentPhoto.Location = new System.Drawing.Point(78, 24);
            this.imgStudentPhoto.Name = "imgStudentPhoto";
            this.imgStudentPhoto.Size = new System.Drawing.Size(100, 100);
            this.imgStudentPhoto.TabIndex = 63;
            this.imgStudentPhoto.TabStop = false;
            // 
            // btnUpdateInfo
            // 
            this.btnUpdateInfo.Location = new System.Drawing.Point(6, 393);
            this.btnUpdateInfo.Name = "btnUpdateInfo";
            this.btnUpdateInfo.Size = new System.Drawing.Size(85, 23);
            this.btnUpdateInfo.TabIndex = 44;
            this.btnUpdateInfo.Text = "Update Info";
            this.btnUpdateInfo.UseVisualStyleBackColor = true;
            this.btnUpdateInfo.Click += new System.EventHandler(this.btnUpdateInfo_Click);
            // 
            // btnDropCourse
            // 
            this.btnDropCourse.Location = new System.Drawing.Point(411, 401);
            this.btnDropCourse.Name = "btnDropCourse";
            this.btnDropCourse.Size = new System.Drawing.Size(151, 30);
            this.btnDropCourse.TabIndex = 66;
            this.btnDropCourse.Text = "Drop Courses";
            this.btnDropCourse.UseVisualStyleBackColor = true;
            this.btnDropCourse.Click += new System.EventHandler(this.btnDropCourse_Click);
            // 
            // btnRegisterCourse
            // 
            this.btnRegisterCourse.Location = new System.Drawing.Point(577, 401);
            this.btnRegisterCourse.Name = "btnRegisterCourse";
            this.btnRegisterCourse.Size = new System.Drawing.Size(163, 30);
            this.btnRegisterCourse.TabIndex = 65;
            this.btnRegisterCourse.Text = "Search or Register for Courses";
            this.btnRegisterCourse.UseVisualStyleBackColor = true;
            this.btnRegisterCourse.Click += new System.EventHandler(this.btnRegisterCourse_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnCourseTitle,
            this.columnSection,
            this.columnProfessor,
            this.columnSchedule,
            this.columnStartDate});
            this.dataGridView1.Location = new System.Drawing.Point(18, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 347);
            this.dataGridView1.TabIndex = 6;
            // 
            // columnCourseTitle
            // 
            this.columnCourseTitle.HeaderText = "Course Title";
            this.columnCourseTitle.Name = "columnCourseTitle";
            this.columnCourseTitle.ReadOnly = true;
            // 
            // columnSection
            // 
            this.columnSection.HeaderText = "Section";
            this.columnSection.Name = "columnSection";
            this.columnSection.ReadOnly = true;
            // 
            // columnProfessor
            // 
            this.columnProfessor.HeaderText = "Professor";
            this.columnProfessor.Name = "columnProfessor";
            this.columnProfessor.ReadOnly = true;
            // 
            // columnSchedule
            // 
            this.columnSchedule.HeaderText = "Schedule";
            this.columnSchedule.Name = "columnSchedule";
            this.columnSchedule.ReadOnly = true;
            // 
            // columnStartDate
            // 
            this.columnStartDate.HeaderText = "Start Date";
            this.columnStartDate.Name = "columnStartDate";
            this.columnStartDate.ReadOnly = true;
            // 
            // StudentMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 449);
            this.Controls.Add(this.gbxMyCourses);
            this.Controls.Add(this.gbxStudentInfo);
            this.Controls.Add(this.btnDropCourse);
            this.Controls.Add(this.btnRegisterCourse);
            this.Name = "StudentMenu";
            this.Text = "Student Menu";
            this.gbxMyCourses.ResumeLayout(false);
            this.gbxStudentInfo.ResumeLayout(false);
            this.gbxStudentInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgStudentPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxMyCourses;
        private System.Windows.Forms.GroupBox gbxStudentInfo;
        private System.Windows.Forms.PictureBox imgStudentPhoto;
        private System.Windows.Forms.Button btnUpdateInfo;
        private System.Windows.Forms.Button btnDropCourse;
        private System.Windows.Forms.Button btnRegisterCourse;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label lblDisplayEmail;
        private System.Windows.Forms.Label lblDisplayCity;
        private System.Windows.Forms.Label lblAddressA;
        private System.Windows.Forms.Label lblDisplayState;
        private System.Windows.Forms.Label lblDisplayZipCode;
        private System.Windows.Forms.Label lblDisplayFax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCourseTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSection;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnProfessor;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnStartDate;
    }
}