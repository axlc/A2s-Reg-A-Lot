namespace A2_Reg_A_Lot_2017
{
    partial class CreateUpdateProfessor
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.txtZipcode = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblFname = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.lblDisplayEmail = new System.Windows.Forms.Label();
            this.lblAddressB = new System.Windows.Forms.Label();
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
            this.gbxProfessorInfo.SuspendLayout();
            this.gbxProfessorSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(496, 304);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(43, 40);
            this.btnBack.TabIndex = 78;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gbxProfessorInfo
            // 
            this.gbxProfessorInfo.Controls.Add(this.txtEmail);
            this.gbxProfessorInfo.Controls.Add(this.txtFax);
            this.gbxProfessorInfo.Controls.Add(this.txtZipcode);
            this.gbxProfessorInfo.Controls.Add(this.txtState);
            this.gbxProfessorInfo.Controls.Add(this.txtCity);
            this.gbxProfessorInfo.Controls.Add(this.txtAddress2);
            this.gbxProfessorInfo.Controls.Add(this.txtAddress1);
            this.gbxProfessorInfo.Controls.Add(this.txtLastName);
            this.gbxProfessorInfo.Controls.Add(this.txtFirstName);
            this.gbxProfessorInfo.Controls.Add(this.lblFname);
            this.gbxProfessorInfo.Controls.Add(this.label30);
            this.gbxProfessorInfo.Controls.Add(this.lblDisplayEmail);
            this.gbxProfessorInfo.Controls.Add(this.lblAddressB);
            this.gbxProfessorInfo.Controls.Add(this.lblDisplayCity);
            this.gbxProfessorInfo.Controls.Add(this.lblAddressA);
            this.gbxProfessorInfo.Controls.Add(this.lblDisplayState);
            this.gbxProfessorInfo.Controls.Add(this.lblDisplayZipCode);
            this.gbxProfessorInfo.Controls.Add(this.lblDisplayFax);
            this.gbxProfessorInfo.Location = new System.Drawing.Point(308, 39);
            this.gbxProfessorInfo.Name = "gbxProfessorInfo";
            this.gbxProfessorInfo.Size = new System.Drawing.Size(236, 257);
            this.gbxProfessorInfo.TabIndex = 77;
            this.gbxProfessorInfo.TabStop = false;
            this.gbxProfessorInfo.Text = "Professor Information";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Control;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Location = new System.Drawing.Point(115, 224);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(100, 13);
            this.txtEmail.TabIndex = 99;
            // 
            // txtFax
            // 
            this.txtFax.BackColor = System.Drawing.SystemColors.Control;
            this.txtFax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFax.Location = new System.Drawing.Point(115, 200);
            this.txtFax.Name = "txtFax";
            this.txtFax.ReadOnly = true;
            this.txtFax.Size = new System.Drawing.Size(100, 13);
            this.txtFax.TabIndex = 98;
            // 
            // txtZipcode
            // 
            this.txtZipcode.BackColor = System.Drawing.SystemColors.Control;
            this.txtZipcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtZipcode.Location = new System.Drawing.Point(115, 176);
            this.txtZipcode.Name = "txtZipcode";
            this.txtZipcode.ReadOnly = true;
            this.txtZipcode.Size = new System.Drawing.Size(100, 13);
            this.txtZipcode.TabIndex = 97;
            // 
            // txtState
            // 
            this.txtState.BackColor = System.Drawing.SystemColors.Control;
            this.txtState.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtState.Location = new System.Drawing.Point(115, 152);
            this.txtState.Name = "txtState";
            this.txtState.ReadOnly = true;
            this.txtState.Size = new System.Drawing.Size(100, 13);
            this.txtState.TabIndex = 96;
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.SystemColors.Control;
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCity.Location = new System.Drawing.Point(115, 128);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(100, 13);
            this.txtCity.TabIndex = 95;
            // 
            // txtAddress2
            // 
            this.txtAddress2.BackColor = System.Drawing.SystemColors.Control;
            this.txtAddress2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress2.Location = new System.Drawing.Point(115, 104);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.ReadOnly = true;
            this.txtAddress2.Size = new System.Drawing.Size(100, 13);
            this.txtAddress2.TabIndex = 94;
            // 
            // txtAddress1
            // 
            this.txtAddress1.BackColor = System.Drawing.SystemColors.Control;
            this.txtAddress1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress1.Location = new System.Drawing.Point(115, 78);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.ReadOnly = true;
            this.txtAddress1.Size = new System.Drawing.Size(100, 13);
            this.txtAddress1.TabIndex = 93;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.SystemColors.Control;
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastName.Location = new System.Drawing.Point(115, 54);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(100, 13);
            this.txtLastName.TabIndex = 92;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.SystemColors.Control;
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirstName.Location = new System.Drawing.Point(115, 30);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(100, 13);
            this.txtFirstName.TabIndex = 91;
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Location = new System.Drawing.Point(19, 32);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(58, 13);
            this.lblFname.TabIndex = 82;
            this.lblFname.Text = "First name:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(19, 54);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(59, 13);
            this.label30.TabIndex = 83;
            this.label30.Text = "Last name:";
            // 
            // lblDisplayEmail
            // 
            this.lblDisplayEmail.AutoSize = true;
            this.lblDisplayEmail.Location = new System.Drawing.Point(22, 222);
            this.lblDisplayEmail.Name = "lblDisplayEmail";
            this.lblDisplayEmail.Size = new System.Drawing.Size(35, 13);
            this.lblDisplayEmail.TabIndex = 90;
            this.lblDisplayEmail.Text = "Email:";
            // 
            // lblAddressB
            // 
            this.lblAddressB.AutoSize = true;
            this.lblAddressB.Location = new System.Drawing.Point(22, 102);
            this.lblAddressB.Name = "lblAddressB";
            this.lblAddressB.Size = new System.Drawing.Size(80, 13);
            this.lblAddressB.TabIndex = 89;
            this.lblAddressB.Text = "Address Line 2:";
            // 
            // lblDisplayCity
            // 
            this.lblDisplayCity.AutoSize = true;
            this.lblDisplayCity.Location = new System.Drawing.Point(22, 126);
            this.lblDisplayCity.Name = "lblDisplayCity";
            this.lblDisplayCity.Size = new System.Drawing.Size(27, 13);
            this.lblDisplayCity.TabIndex = 84;
            this.lblDisplayCity.Text = "City:";
            // 
            // lblAddressA
            // 
            this.lblAddressA.AutoSize = true;
            this.lblAddressA.Location = new System.Drawing.Point(19, 78);
            this.lblAddressA.Name = "lblAddressA";
            this.lblAddressA.Size = new System.Drawing.Size(80, 13);
            this.lblAddressA.TabIndex = 88;
            this.lblAddressA.Text = "Address Line 1:";
            // 
            // lblDisplayState
            // 
            this.lblDisplayState.AutoSize = true;
            this.lblDisplayState.Location = new System.Drawing.Point(22, 150);
            this.lblDisplayState.Name = "lblDisplayState";
            this.lblDisplayState.Size = new System.Drawing.Size(35, 13);
            this.lblDisplayState.TabIndex = 85;
            this.lblDisplayState.Text = "State:";
            // 
            // lblDisplayZipCode
            // 
            this.lblDisplayZipCode.AutoSize = true;
            this.lblDisplayZipCode.Location = new System.Drawing.Point(22, 174);
            this.lblDisplayZipCode.Name = "lblDisplayZipCode";
            this.lblDisplayZipCode.Size = new System.Drawing.Size(49, 13);
            this.lblDisplayZipCode.TabIndex = 86;
            this.lblDisplayZipCode.Text = "Zipcode:";
            // 
            // lblDisplayFax
            // 
            this.lblDisplayFax.AutoSize = true;
            this.lblDisplayFax.Location = new System.Drawing.Point(22, 198);
            this.lblDisplayFax.Name = "lblDisplayFax";
            this.lblDisplayFax.Size = new System.Drawing.Size(27, 13);
            this.lblDisplayFax.TabIndex = 87;
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
            this.btnEditProfessor.Location = new System.Drawing.Point(312, 304);
            this.btnEditProfessor.Name = "btnEditProfessor";
            this.btnEditProfessor.Size = new System.Drawing.Size(75, 40);
            this.btnEditProfessor.TabIndex = 79;
            this.btnEditProfessor.Text = "Edit Info";
            this.btnEditProfessor.UseVisualStyleBackColor = true;
            this.btnEditProfessor.Click += new System.EventHandler(this.btnEditProfessor_Click);
            // 
            // btnCreateProfessor
            // 
            this.btnCreateProfessor.Location = new System.Drawing.Point(400, 304);
            this.btnCreateProfessor.Name = "btnCreateProfessor";
            this.btnCreateProfessor.Size = new System.Drawing.Size(75, 41);
            this.btnCreateProfessor.TabIndex = 80;
            this.btnCreateProfessor.Text = "Add New Professor";
            this.btnCreateProfessor.UseVisualStyleBackColor = true;
            this.btnCreateProfessor.Click += new System.EventHandler(this.btnCreateProfessor_Click);
            // 
            // CreateUpdateProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 359);
            this.Controls.Add(this.btnCreateProfessor);
            this.Controls.Add(this.btnEditProfessor);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gbxProfessorInfo);
            this.Controls.Add(this.lbxProfessors);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.gbxProfessorSearch);
            this.Name = "CreateUpdateProfessor";
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
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.TextBox txtZipcode;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label lblDisplayEmail;
        private System.Windows.Forms.Label lblAddressB;
        private System.Windows.Forms.Label lblDisplayCity;
        private System.Windows.Forms.Label lblAddressA;
        private System.Windows.Forms.Label lblDisplayState;
        private System.Windows.Forms.Label lblDisplayZipCode;
        private System.Windows.Forms.Label lblDisplayFax;
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
    }
}