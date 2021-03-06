﻿namespace A2_Reg_A_Lot_2017
{
    partial class UpdateRegistrar
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCreateRegistrar = new System.Windows.Forms.Button();
            this.gbxStudentInfo = new System.Windows.Forms.GroupBox();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.txtZipcode = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblFname = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.lblDisplayEmail = new System.Windows.Forms.Label();
            this.lblDisplayCity = new System.Windows.Forms.Label();
            this.lblAddressA = new System.Windows.Forms.Label();
            this.lblDisplayState = new System.Windows.Forms.Label();
            this.lblDisplayZipCode = new System.Windows.Forms.Label();
            this.lblDisplayFax = new System.Windows.Forms.Label();
            this.btnEditRegistrar = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lbxRegistrar = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.gbxStudentSearch = new System.Windows.Forms.GroupBox();
            this.btnSearchStudents = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblByName = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.lblById = new System.Windows.Forms.Label();
            this.gbxStudentInfo.SuspendLayout();
            this.gbxStudentSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(487, 320);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 138;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(406, 320);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 137;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Visible = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCreateRegistrar
            // 
            this.btnCreateRegistrar.Location = new System.Drawing.Point(118, 380);
            this.btnCreateRegistrar.Name = "btnCreateRegistrar";
            this.btnCreateRegistrar.Size = new System.Drawing.Size(75, 41);
            this.btnCreateRegistrar.TabIndex = 136;
            this.btnCreateRegistrar.Text = "Add New Registrar";
            this.btnCreateRegistrar.UseVisualStyleBackColor = true;
            this.btnCreateRegistrar.Click += new System.EventHandler(this.btnCreateRegistrar_Click);
            // 
            // gbxStudentInfo
            // 
            this.gbxStudentInfo.Controls.Add(this.txtPhone);
            this.gbxStudentInfo.Controls.Add(this.txtZipcode);
            this.gbxStudentInfo.Controls.Add(this.txtEmail);
            this.gbxStudentInfo.Controls.Add(this.txtFax);
            this.gbxStudentInfo.Controls.Add(this.txtState);
            this.gbxStudentInfo.Controls.Add(this.txtCity);
            this.gbxStudentInfo.Controls.Add(this.txtAddress);
            this.gbxStudentInfo.Controls.Add(this.txtLastName);
            this.gbxStudentInfo.Controls.Add(this.txtFirstName);
            this.gbxStudentInfo.Controls.Add(this.lblPhone);
            this.gbxStudentInfo.Controls.Add(this.lblFname);
            this.gbxStudentInfo.Controls.Add(this.label30);
            this.gbxStudentInfo.Controls.Add(this.lblDisplayEmail);
            this.gbxStudentInfo.Controls.Add(this.lblDisplayCity);
            this.gbxStudentInfo.Controls.Add(this.lblAddressA);
            this.gbxStudentInfo.Controls.Add(this.lblDisplayState);
            this.gbxStudentInfo.Controls.Add(this.lblDisplayZipCode);
            this.gbxStudentInfo.Controls.Add(this.lblDisplayFax);
            this.gbxStudentInfo.Location = new System.Drawing.Point(314, 41);
            this.gbxStudentInfo.Name = "gbxStudentInfo";
            this.gbxStudentInfo.Size = new System.Drawing.Size(250, 264);
            this.gbxStudentInfo.TabIndex = 133;
            this.gbxStudentInfo.TabStop = false;
            this.gbxStudentInfo.Text = "Registrar Information";
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Location = new System.Drawing.Point(89, 210);
            this.txtPhone.Mask = "(999) 000-0000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(139, 13);
            this.txtPhone.TabIndex = 180;
            this.txtPhone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtZipcode
            // 
            this.txtZipcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtZipcode.Location = new System.Drawing.Point(89, 137);
            this.txtZipcode.Mask = "00000-9999";
            this.txtZipcode.Name = "txtZipcode";
            this.txtZipcode.ReadOnly = true;
            this.txtZipcode.Size = new System.Drawing.Size(139, 13);
            this.txtZipcode.TabIndex = 181;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Location = new System.Drawing.Point(89, 185);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(139, 13);
            this.txtEmail.TabIndex = 177;
            // 
            // txtFax
            // 
            this.txtFax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFax.Location = new System.Drawing.Point(89, 161);
            this.txtFax.Name = "txtFax";
            this.txtFax.ReadOnly = true;
            this.txtFax.Size = new System.Drawing.Size(139, 13);
            this.txtFax.TabIndex = 176;
            // 
            // txtState
            // 
            this.txtState.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtState.Location = new System.Drawing.Point(89, 113);
            this.txtState.Name = "txtState";
            this.txtState.ReadOnly = true;
            this.txtState.Size = new System.Drawing.Size(139, 13);
            this.txtState.TabIndex = 174;
            // 
            // txtCity
            // 
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCity.Location = new System.Drawing.Point(89, 89);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(139, 13);
            this.txtCity.TabIndex = 173;
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Location = new System.Drawing.Point(89, 65);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(139, 13);
            this.txtAddress.TabIndex = 172;
            // 
            // txtLastName
            // 
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastName.Location = new System.Drawing.Point(89, 46);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(139, 13);
            this.txtLastName.TabIndex = 171;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirstName.Location = new System.Drawing.Point(89, 22);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(139, 13);
            this.txtFirstName.TabIndex = 170;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(23, 210);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(41, 13);
            this.lblPhone.TabIndex = 169;
            this.lblPhone.Text = "Phone:";
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Location = new System.Drawing.Point(23, 22);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(58, 13);
            this.lblFname.TabIndex = 160;
            this.lblFname.Text = "First name:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(23, 46);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(59, 13);
            this.label30.TabIndex = 161;
            this.label30.Text = "Last name:";
            // 
            // lblDisplayEmail
            // 
            this.lblDisplayEmail.AutoSize = true;
            this.lblDisplayEmail.Location = new System.Drawing.Point(26, 185);
            this.lblDisplayEmail.Name = "lblDisplayEmail";
            this.lblDisplayEmail.Size = new System.Drawing.Size(35, 13);
            this.lblDisplayEmail.TabIndex = 167;
            this.lblDisplayEmail.Text = "Email:";
            // 
            // lblDisplayCity
            // 
            this.lblDisplayCity.AutoSize = true;
            this.lblDisplayCity.Location = new System.Drawing.Point(26, 89);
            this.lblDisplayCity.Name = "lblDisplayCity";
            this.lblDisplayCity.Size = new System.Drawing.Size(27, 13);
            this.lblDisplayCity.TabIndex = 162;
            this.lblDisplayCity.Text = "City:";
            // 
            // lblAddressA
            // 
            this.lblAddressA.AutoSize = true;
            this.lblAddressA.Location = new System.Drawing.Point(23, 65);
            this.lblAddressA.Name = "lblAddressA";
            this.lblAddressA.Size = new System.Drawing.Size(48, 13);
            this.lblAddressA.TabIndex = 166;
            this.lblAddressA.Text = "Address:";
            // 
            // lblDisplayState
            // 
            this.lblDisplayState.AutoSize = true;
            this.lblDisplayState.Location = new System.Drawing.Point(26, 113);
            this.lblDisplayState.Name = "lblDisplayState";
            this.lblDisplayState.Size = new System.Drawing.Size(35, 13);
            this.lblDisplayState.TabIndex = 163;
            this.lblDisplayState.Text = "State:";
            // 
            // lblDisplayZipCode
            // 
            this.lblDisplayZipCode.AutoSize = true;
            this.lblDisplayZipCode.Location = new System.Drawing.Point(26, 137);
            this.lblDisplayZipCode.Name = "lblDisplayZipCode";
            this.lblDisplayZipCode.Size = new System.Drawing.Size(49, 13);
            this.lblDisplayZipCode.TabIndex = 164;
            this.lblDisplayZipCode.Text = "Zipcode:";
            // 
            // lblDisplayFax
            // 
            this.lblDisplayFax.AutoSize = true;
            this.lblDisplayFax.Location = new System.Drawing.Point(26, 161);
            this.lblDisplayFax.Name = "lblDisplayFax";
            this.lblDisplayFax.Size = new System.Drawing.Size(27, 13);
            this.lblDisplayFax.TabIndex = 165;
            this.lblDisplayFax.Text = "Fax:";
            // 
            // btnEditRegistrar
            // 
            this.btnEditRegistrar.Location = new System.Drawing.Point(321, 311);
            this.btnEditRegistrar.Name = "btnEditRegistrar";
            this.btnEditRegistrar.Size = new System.Drawing.Size(75, 40);
            this.btnEditRegistrar.TabIndex = 135;
            this.btnEditRegistrar.Text = "Edit Info";
            this.btnEditRegistrar.UseVisualStyleBackColor = true;
            this.btnEditRegistrar.Click += new System.EventHandler(this.btnEditRegistrar_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(487, 379);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(77, 40);
            this.btnBack.TabIndex = 134;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lbxRegistrar
            // 
            this.lbxRegistrar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lbxRegistrar.FormattingEnabled = true;
            this.lbxRegistrar.Location = new System.Drawing.Point(15, 175);
            this.lbxRegistrar.Name = "lbxRegistrar";
            this.lbxRegistrar.Size = new System.Drawing.Size(279, 199);
            this.lbxRegistrar.TabIndex = 132;
            this.lbxRegistrar.SelectedIndexChanged += new System.EventHandler(this.clickProfessorList);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(10, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(199, 25);
            this.label13.TabIndex = 131;
            this.label13.Text = "Manage Registrar";
            // 
            // gbxStudentSearch
            // 
            this.gbxStudentSearch.Controls.Add(this.btnSearchStudents);
            this.gbxStudentSearch.Controls.Add(this.txtId);
            this.gbxStudentSearch.Controls.Add(this.lblByName);
            this.gbxStudentSearch.Controls.Add(this.txtStudentName);
            this.gbxStudentSearch.Controls.Add(this.lblById);
            this.gbxStudentSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxStudentSearch.Location = new System.Drawing.Point(15, 39);
            this.gbxStudentSearch.Name = "gbxStudentSearch";
            this.gbxStudentSearch.Size = new System.Drawing.Size(279, 128);
            this.gbxStudentSearch.TabIndex = 130;
            this.gbxStudentSearch.TabStop = false;
            this.gbxStudentSearch.Text = "Search for a Student";
            // 
            // btnSearchStudents
            // 
            this.btnSearchStudents.Location = new System.Drawing.Point(145, 87);
            this.btnSearchStudents.Name = "btnSearchStudents";
            this.btnSearchStudents.Size = new System.Drawing.Size(75, 23);
            this.btnSearchStudents.TabIndex = 65;
            this.btnSearchStudents.Text = "Search";
            this.btnSearchStudents.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(114, 56);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(138, 20);
            this.txtId.TabIndex = 8;
            // 
            // lblByName
            // 
            this.lblByName.AutoSize = true;
            this.lblByName.Location = new System.Drawing.Point(21, 34);
            this.lblByName.Name = "lblByName";
            this.lblByName.Size = new System.Drawing.Size(87, 13);
            this.lblByName.TabIndex = 0;
            this.lblByName.Text = "Search by name:";
            this.lblByName.Click += new System.EventHandler(this.lblByName_Click);
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(114, 31);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(138, 20);
            this.txtStudentName.TabIndex = 1;
            // 
            // lblById
            // 
            this.lblById.AutoSize = true;
            this.lblById.Location = new System.Drawing.Point(21, 58);
            this.lblById.Name = "lblById";
            this.lblById.Size = new System.Drawing.Size(72, 13);
            this.lblById.TabIndex = 2;
            this.lblById.Text = "Search by ID:";
            // 
            // UpdateRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 430);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCreateRegistrar);
            this.Controls.Add(this.gbxStudentInfo);
            this.Controls.Add(this.btnEditRegistrar);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lbxRegistrar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.gbxStudentSearch);
            this.Name = "UpdateRegistrar";
            this.Text = "UpdateRegistrar";
            this.Load += new System.EventHandler(this.UpdateRegistrar_Load);
            this.gbxStudentInfo.ResumeLayout(false);
            this.gbxStudentInfo.PerformLayout();
            this.gbxStudentSearch.ResumeLayout(false);
            this.gbxStudentSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCreateRegistrar;
        private System.Windows.Forms.GroupBox gbxStudentInfo;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.MaskedTextBox txtZipcode;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label lblDisplayEmail;
        private System.Windows.Forms.Label lblDisplayCity;
        private System.Windows.Forms.Label lblAddressA;
        private System.Windows.Forms.Label lblDisplayState;
        private System.Windows.Forms.Label lblDisplayZipCode;
        private System.Windows.Forms.Label lblDisplayFax;
        private System.Windows.Forms.Button btnEditRegistrar;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ListBox lbxRegistrar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox gbxStudentSearch;
        private System.Windows.Forms.Button btnSearchStudents;
        private System.Windows.Forms.Label lblByName;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Label lblById;
        private System.Windows.Forms.TextBox txtId;
    }
}