﻿namespace A2_Reg_A_Lot_2017
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
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblFname = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.lblDisplayEmail = new System.Windows.Forms.Label();
            this.lblAddressB = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.lblDisplayCity = new System.Windows.Forms.Label();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.lblFax = new System.Windows.Forms.Label();
            this.lblAddressA = new System.Windows.Forms.Label();
            this.lblDisplayState = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblDisplayZipCode = new System.Windows.Forms.Label();
            this.lblDisplayFax = new System.Windows.Forms.Label();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
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
            this.lbxStudents.Location = new System.Drawing.Point(17, 175);
            this.lbxStudents.Name = "lbxStudents";
            this.lbxStudents.Size = new System.Drawing.Size(279, 199);
            this.lbxStudents.TabIndex = 66;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 9);
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
            this.gbxStudentSearch.Location = new System.Drawing.Point(17, 39);
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
            this.gbxStudentInfo.Controls.Add(this.lblFirstName);
            this.gbxStudentInfo.Controls.Add(this.lblEmail);
            this.gbxStudentInfo.Controls.Add(this.lblFname);
            this.gbxStudentInfo.Controls.Add(this.label30);
            this.gbxStudentInfo.Controls.Add(this.lblDisplayEmail);
            this.gbxStudentInfo.Controls.Add(this.lblAddressB);
            this.gbxStudentInfo.Controls.Add(this.lblLastName);
            this.gbxStudentInfo.Controls.Add(this.lblZipCode);
            this.gbxStudentInfo.Controls.Add(this.lblDisplayCity);
            this.gbxStudentInfo.Controls.Add(this.lblAddress2);
            this.gbxStudentInfo.Controls.Add(this.lblFax);
            this.gbxStudentInfo.Controls.Add(this.lblAddressA);
            this.gbxStudentInfo.Controls.Add(this.lblDisplayState);
            this.gbxStudentInfo.Controls.Add(this.lblCity);
            this.gbxStudentInfo.Controls.Add(this.lblState);
            this.gbxStudentInfo.Controls.Add(this.lblDisplayZipCode);
            this.gbxStudentInfo.Controls.Add(this.lblDisplayFax);
            this.gbxStudentInfo.Controls.Add(this.lblAddress1);
            this.gbxStudentInfo.Location = new System.Drawing.Point(302, 58);
            this.gbxStudentInfo.Name = "gbxStudentInfo";
            this.gbxStudentInfo.Size = new System.Drawing.Size(260, 258);
            this.gbxStudentInfo.TabIndex = 68;
            this.gbxStudentInfo.TabStop = false;
            this.gbxStudentInfo.Text = "Student Information";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(97, 22);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(88, 13);
            this.lblFirstName.TabIndex = 54;
            this.lblFirstName.Text = "DisplayFirstName";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(97, 230);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(66, 13);
            this.lblEmail.TabIndex = 62;
            this.lblEmail.Text = "DisplayEmail";
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Location = new System.Drawing.Point(14, 22);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(58, 13);
            this.lblFname.TabIndex = 45;
            this.lblFname.Text = "First name:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(14, 48);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(59, 13);
            this.label30.TabIndex = 46;
            this.label30.Text = "Last name:";
            // 
            // lblDisplayEmail
            // 
            this.lblDisplayEmail.AutoSize = true;
            this.lblDisplayEmail.Location = new System.Drawing.Point(14, 230);
            this.lblDisplayEmail.Name = "lblDisplayEmail";
            this.lblDisplayEmail.Size = new System.Drawing.Size(35, 13);
            this.lblDisplayEmail.TabIndex = 53;
            this.lblDisplayEmail.Text = "Email:";
            // 
            // lblAddressB
            // 
            this.lblAddressB.AutoSize = true;
            this.lblAddressB.Location = new System.Drawing.Point(14, 100);
            this.lblAddressB.Name = "lblAddressB";
            this.lblAddressB.Size = new System.Drawing.Size(80, 13);
            this.lblAddressB.TabIndex = 52;
            this.lblAddressB.Text = "Address Line 2:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(97, 48);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(89, 13);
            this.lblLastName.TabIndex = 55;
            this.lblLastName.Text = "DisplayLastName";
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Location = new System.Drawing.Point(97, 178);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(80, 13);
            this.lblZipCode.TabIndex = 58;
            this.lblZipCode.Text = "DisplayZipcode";
            // 
            // lblDisplayCity
            // 
            this.lblDisplayCity.AutoSize = true;
            this.lblDisplayCity.Location = new System.Drawing.Point(14, 126);
            this.lblDisplayCity.Name = "lblDisplayCity";
            this.lblDisplayCity.Size = new System.Drawing.Size(27, 13);
            this.lblDisplayCity.TabIndex = 47;
            this.lblDisplayCity.Text = "City:";
            // 
            // lblAddress2
            // 
            this.lblAddress2.AutoSize = true;
            this.lblAddress2.Location = new System.Drawing.Point(97, 100);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(85, 13);
            this.lblAddress2.TabIndex = 61;
            this.lblAddress2.Text = "DisplayAddress2";
            // 
            // lblFax
            // 
            this.lblFax.AutoSize = true;
            this.lblFax.Location = new System.Drawing.Point(97, 204);
            this.lblFax.Name = "lblFax";
            this.lblFax.Size = new System.Drawing.Size(58, 13);
            this.lblFax.TabIndex = 59;
            this.lblFax.Text = "DisplayFax";
            // 
            // lblAddressA
            // 
            this.lblAddressA.AutoSize = true;
            this.lblAddressA.Location = new System.Drawing.Point(14, 74);
            this.lblAddressA.Name = "lblAddressA";
            this.lblAddressA.Size = new System.Drawing.Size(80, 13);
            this.lblAddressA.TabIndex = 51;
            this.lblAddressA.Text = "Address Line 1:";
            // 
            // lblDisplayState
            // 
            this.lblDisplayState.AutoSize = true;
            this.lblDisplayState.Location = new System.Drawing.Point(14, 152);
            this.lblDisplayState.Name = "lblDisplayState";
            this.lblDisplayState.Size = new System.Drawing.Size(35, 13);
            this.lblDisplayState.TabIndex = 48;
            this.lblDisplayState.Text = "State:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(97, 126);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(58, 13);
            this.lblCity.TabIndex = 56;
            this.lblCity.Text = "DisplayCity";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(97, 152);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(66, 13);
            this.lblState.TabIndex = 57;
            this.lblState.Text = "DisplayState";
            // 
            // lblDisplayZipCode
            // 
            this.lblDisplayZipCode.AutoSize = true;
            this.lblDisplayZipCode.Location = new System.Drawing.Point(14, 178);
            this.lblDisplayZipCode.Name = "lblDisplayZipCode";
            this.lblDisplayZipCode.Size = new System.Drawing.Size(49, 13);
            this.lblDisplayZipCode.TabIndex = 49;
            this.lblDisplayZipCode.Text = "Zipcode:";
            // 
            // lblDisplayFax
            // 
            this.lblDisplayFax.AutoSize = true;
            this.lblDisplayFax.Location = new System.Drawing.Point(14, 204);
            this.lblDisplayFax.Name = "lblDisplayFax";
            this.lblDisplayFax.Size = new System.Drawing.Size(27, 13);
            this.lblDisplayFax.TabIndex = 50;
            this.lblDisplayFax.Text = "Fax:";
            // 
            // lblAddress1
            // 
            this.lblAddress1.AutoSize = true;
            this.lblAddress1.Location = new System.Drawing.Point(97, 74);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(85, 13);
            this.lblAddress1.TabIndex = 60;
            this.lblAddress1.Text = "DisplayAddress1";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(390, 336);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 69;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // SearchStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 383);
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
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label lblDisplayEmail;
        private System.Windows.Forms.Label lblAddressB;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.Label lblDisplayCity;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.Label lblFax;
        private System.Windows.Forms.Label lblAddressA;
        private System.Windows.Forms.Label lblDisplayState;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblDisplayZipCode;
        private System.Windows.Forms.Label lblDisplayFax;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.Button btnBack;
    }
}