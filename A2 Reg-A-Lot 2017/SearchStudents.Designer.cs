namespace A2_Reg_A_Lot_2017
{
    partial class SearchStudents
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
            this.lbxStudents = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.gbxStudentSearch = new System.Windows.Forms.GroupBox();
            this.btnSearchStudents = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblByName = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.lstCourses = new System.Windows.Forms.ListBox();
            this.lblById = new System.Windows.Forms.Label();
            this.lblByCourse = new System.Windows.Forms.Label();
            this.gbxStudentInfo = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.txtZipcode = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFname = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.lblDisplayEmail = new System.Windows.Forms.Label();
            this.lblDisplayCity = new System.Windows.Forms.Label();
            this.lblAddressA = new System.Windows.Forms.Label();
            this.lblDisplayState = new System.Windows.Forms.Label();
            this.lblDisplayZipCode = new System.Windows.Forms.Label();
            this.lblDisplayFax = new System.Windows.Forms.Label();
            this.gbxStudentSearch.SuspendLayout();
            this.gbxStudentInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxStudents
            // 
            this.lbxStudents.FormattingEnabled = true;
            this.lbxStudents.Items.AddRange(new object[] {
            "Student 1",
            "Student 2",
            "Student 3",
            "Student 4",
            "Student 5",
            "Student 6",
            "Student 7",
            "Student 8",
            "Student 9",
            "Student 10",
            "Student 11",
            "Student 12",
            "Student 13",
            "Student 14",
            "Student 15",
            "etc."});
            this.lbxStudents.Location = new System.Drawing.Point(13, 174);
            this.lbxStudents.Name = "lbxStudents";
            this.lbxStudents.Size = new System.Drawing.Size(279, 199);
            this.lbxStudents.TabIndex = 66;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(8, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(158, 25);
            this.label13.TabIndex = 65;
            this.label13.Text = "Find Students";
            // 
            // gbxStudentSearch
            // 
            this.gbxStudentSearch.Controls.Add(this.btnSearchStudents);
            this.gbxStudentSearch.Controls.Add(this.txtId);
            this.gbxStudentSearch.Controls.Add(this.lblByName);
            this.gbxStudentSearch.Controls.Add(this.txtStudentName);
            this.gbxStudentSearch.Controls.Add(this.lstCourses);
            this.gbxStudentSearch.Controls.Add(this.lblById);
            this.gbxStudentSearch.Controls.Add(this.lblByCourse);
            this.gbxStudentSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxStudentSearch.Location = new System.Drawing.Point(13, 38);
            this.gbxStudentSearch.Name = "gbxStudentSearch";
            this.gbxStudentSearch.Size = new System.Drawing.Size(279, 128);
            this.gbxStudentSearch.TabIndex = 64;
            this.gbxStudentSearch.TabStop = false;
            this.gbxStudentSearch.Text = "Search for a Student";
            // 
            // btnSearchStudents
            // 
            this.btnSearchStudents.Location = new System.Drawing.Point(141, 94);
            this.btnSearchStudents.Name = "btnSearchStudents";
            this.btnSearchStudents.Size = new System.Drawing.Size(75, 23);
            this.btnSearchStudents.TabIndex = 65;
            this.btnSearchStudents.Text = "Search";
            this.btnSearchStudents.UseVisualStyleBackColor = true;
            this.btnSearchStudents.Click += new System.EventHandler(this.btnSearchStudents_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(115, 44);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(138, 20);
            this.txtId.TabIndex = 8;
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
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(115, 19);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(138, 20);
            this.txtStudentName.TabIndex = 1;
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
            this.lstCourses.Location = new System.Drawing.Point(115, 68);
            this.lstCourses.Name = "lstCourses";
            this.lstCourses.Size = new System.Drawing.Size(138, 17);
            this.lstCourses.TabIndex = 7;
            // 
            // lblById
            // 
            this.lblById.AutoSize = true;
            this.lblById.Location = new System.Drawing.Point(22, 46);
            this.lblById.Name = "lblById";
            this.lblById.Size = new System.Drawing.Size(72, 13);
            this.lblById.TabIndex = 2;
            this.lblById.Text = "Search by ID:";
            // 
            // lblByCourse
            // 
            this.lblByCourse.AutoSize = true;
            this.lblByCourse.Location = new System.Drawing.Point(22, 69);
            this.lblByCourse.Name = "lblByCourse";
            this.lblByCourse.Size = new System.Drawing.Size(78, 13);
            this.lblByCourse.TabIndex = 6;
            this.lblByCourse.Text = "Filter by course";
            // 
            // gbxStudentInfo
            // 
            this.gbxStudentInfo.Controls.Add(this.textBox2);
            this.gbxStudentInfo.Controls.Add(this.lblPhone);
            this.gbxStudentInfo.Controls.Add(this.textBox1);
            this.gbxStudentInfo.Controls.Add(this.label1);
            this.gbxStudentInfo.Controls.Add(this.txtEmail);
            this.gbxStudentInfo.Controls.Add(this.txtFax);
            this.gbxStudentInfo.Controls.Add(this.txtZipcode);
            this.gbxStudentInfo.Controls.Add(this.txtState);
            this.gbxStudentInfo.Controls.Add(this.txtCity);
            this.gbxStudentInfo.Controls.Add(this.txtAddress);
            this.gbxStudentInfo.Controls.Add(this.txtLastName);
            this.gbxStudentInfo.Controls.Add(this.txtFirstName);
            this.gbxStudentInfo.Controls.Add(this.lblFname);
            this.gbxStudentInfo.Controls.Add(this.label30);
            this.gbxStudentInfo.Controls.Add(this.lblDisplayEmail);
            this.gbxStudentInfo.Controls.Add(this.lblDisplayCity);
            this.gbxStudentInfo.Controls.Add(this.lblAddressA);
            this.gbxStudentInfo.Controls.Add(this.lblDisplayState);
            this.gbxStudentInfo.Controls.Add(this.lblDisplayZipCode);
            this.gbxStudentInfo.Controls.Add(this.lblDisplayFax);
            this.gbxStudentInfo.Location = new System.Drawing.Point(304, 40);
            this.gbxStudentInfo.Name = "gbxStudentInfo";
            this.gbxStudentInfo.Size = new System.Drawing.Size(250, 288);
            this.gbxStudentInfo.TabIndex = 68;
            this.gbxStudentInfo.TabStop = false;
            this.gbxStudentInfo.Text = "Student Information";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(386, 335);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 69;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Control;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(120, 248);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 13);
            this.textBox2.TabIndex = 143;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(24, 248);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(41, 13);
            this.lblPhone.TabIndex = 142;
            this.lblPhone.Text = "Phone:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(120, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(100, 13);
            this.textBox1.TabIndex = 141;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 140;
            this.label1.Text = "Gender:";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Control;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Location = new System.Drawing.Point(120, 224);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(100, 13);
            this.txtEmail.TabIndex = 139;
            // 
            // txtFax
            // 
            this.txtFax.BackColor = System.Drawing.SystemColors.Control;
            this.txtFax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFax.Location = new System.Drawing.Point(120, 200);
            this.txtFax.Name = "txtFax";
            this.txtFax.ReadOnly = true;
            this.txtFax.Size = new System.Drawing.Size(100, 13);
            this.txtFax.TabIndex = 138;
            // 
            // txtZipcode
            // 
            this.txtZipcode.BackColor = System.Drawing.SystemColors.Control;
            this.txtZipcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtZipcode.Location = new System.Drawing.Point(120, 176);
            this.txtZipcode.Name = "txtZipcode";
            this.txtZipcode.ReadOnly = true;
            this.txtZipcode.Size = new System.Drawing.Size(100, 13);
            this.txtZipcode.TabIndex = 137;
            // 
            // txtState
            // 
            this.txtState.BackColor = System.Drawing.SystemColors.Control;
            this.txtState.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtState.Location = new System.Drawing.Point(120, 152);
            this.txtState.Name = "txtState";
            this.txtState.ReadOnly = true;
            this.txtState.Size = new System.Drawing.Size(100, 13);
            this.txtState.TabIndex = 136;
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.SystemColors.Control;
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCity.Location = new System.Drawing.Point(120, 128);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(100, 13);
            this.txtCity.TabIndex = 135;
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.SystemColors.Control;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Location = new System.Drawing.Point(120, 104);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(100, 13);
            this.txtAddress.TabIndex = 134;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.SystemColors.Control;
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastName.Location = new System.Drawing.Point(120, 54);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(100, 13);
            this.txtLastName.TabIndex = 133;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.SystemColors.Control;
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirstName.Location = new System.Drawing.Point(120, 30);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(100, 13);
            this.txtFirstName.TabIndex = 132;
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Location = new System.Drawing.Point(24, 32);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(58, 13);
            this.lblFname.TabIndex = 124;
            this.lblFname.Text = "First name:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(24, 54);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(59, 13);
            this.label30.TabIndex = 125;
            this.label30.Text = "Last name:";
            // 
            // lblDisplayEmail
            // 
            this.lblDisplayEmail.AutoSize = true;
            this.lblDisplayEmail.Location = new System.Drawing.Point(27, 222);
            this.lblDisplayEmail.Name = "lblDisplayEmail";
            this.lblDisplayEmail.Size = new System.Drawing.Size(35, 13);
            this.lblDisplayEmail.TabIndex = 131;
            this.lblDisplayEmail.Text = "Email:";
            // 
            // lblDisplayCity
            // 
            this.lblDisplayCity.AutoSize = true;
            this.lblDisplayCity.Location = new System.Drawing.Point(27, 126);
            this.lblDisplayCity.Name = "lblDisplayCity";
            this.lblDisplayCity.Size = new System.Drawing.Size(27, 13);
            this.lblDisplayCity.TabIndex = 126;
            this.lblDisplayCity.Text = "City:";
            // 
            // lblAddressA
            // 
            this.lblAddressA.AutoSize = true;
            this.lblAddressA.Location = new System.Drawing.Point(24, 104);
            this.lblAddressA.Name = "lblAddressA";
            this.lblAddressA.Size = new System.Drawing.Size(48, 13);
            this.lblAddressA.TabIndex = 130;
            this.lblAddressA.Text = "Address:";
            // 
            // lblDisplayState
            // 
            this.lblDisplayState.AutoSize = true;
            this.lblDisplayState.Location = new System.Drawing.Point(27, 150);
            this.lblDisplayState.Name = "lblDisplayState";
            this.lblDisplayState.Size = new System.Drawing.Size(35, 13);
            this.lblDisplayState.TabIndex = 127;
            this.lblDisplayState.Text = "State:";
            // 
            // lblDisplayZipCode
            // 
            this.lblDisplayZipCode.AutoSize = true;
            this.lblDisplayZipCode.Location = new System.Drawing.Point(27, 174);
            this.lblDisplayZipCode.Name = "lblDisplayZipCode";
            this.lblDisplayZipCode.Size = new System.Drawing.Size(49, 13);
            this.lblDisplayZipCode.TabIndex = 128;
            this.lblDisplayZipCode.Text = "Zipcode:";
            // 
            // lblDisplayFax
            // 
            this.lblDisplayFax.AutoSize = true;
            this.lblDisplayFax.Location = new System.Drawing.Point(27, 198);
            this.lblDisplayFax.Name = "lblDisplayFax";
            this.lblDisplayFax.Size = new System.Drawing.Size(27, 13);
            this.lblDisplayFax.TabIndex = 129;
            this.lblDisplayFax.Text = "Fax:";
            // 
            // SearchStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 388);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gbxStudentInfo);
            this.Controls.Add(this.lbxStudents);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.gbxStudentSearch);
            this.Name = "SearchStudents";
            this.Text = "Find Students";
            this.gbxStudentSearch.ResumeLayout(false);
            this.gbxStudentSearch.PerformLayout();
            this.gbxStudentInfo.ResumeLayout(false);
            this.gbxStudentInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxStudents;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox gbxStudentSearch;
        private System.Windows.Forms.Button btnSearchStudents;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblByName;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.ListBox lstCourses;
        private System.Windows.Forms.Label lblById;
        private System.Windows.Forms.Label lblByCourse;
        private System.Windows.Forms.GroupBox gbxStudentInfo;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.TextBox txtZipcode;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label lblDisplayEmail;
        private System.Windows.Forms.Label lblDisplayCity;
        private System.Windows.Forms.Label lblAddressA;
        private System.Windows.Forms.Label lblDisplayState;
        private System.Windows.Forms.Label lblDisplayZipCode;
        private System.Windows.Forms.Label lblDisplayFax;
    }
}