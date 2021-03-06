﻿namespace A2_Reg_A_Lot_2017
{
    partial class ProfessorMenu
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
            this.gbxMyCourses = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.columnCourseTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTotalStudents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSchedule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseSectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseStartTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDurationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseTuitionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDepartmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.project2DataSet = new A2_Reg_A_Lot_2017.Project2DataSet();
            this.gbxProfessorInfo = new System.Windows.Forms.GroupBox();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
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
            this.lblFname = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.lblDisplayEmail = new System.Windows.Forms.Label();
            this.lblDisplayCity = new System.Windows.Forms.Label();
            this.lblAddressA = new System.Windows.Forms.Label();
            this.lblDisplayState = new System.Windows.Forms.Label();
            this.lblDisplayZipCode = new System.Windows.Forms.Label();
            this.lblDisplayFax = new System.Windows.Forms.Label();
            this.btnUpdateInfo = new System.Windows.Forms.Button();
            this.imgProfessorPhoto = new System.Windows.Forms.PictureBox();
            this.gbxProfessorOptions = new System.Windows.Forms.GroupBox();
            this.btnStudentSearch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnMyStudents = new System.Windows.Forms.Button();
            this.btnCancelCourses = new System.Windows.Forms.Button();
            this.btnAddCourses = new System.Windows.Forms.Button();
            this.coursesTableAdapter = new A2_Reg_A_Lot_2017.Project2DataSetTableAdapters.CoursesTableAdapter();
            this.gbxMyCourses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project2DataSet)).BeginInit();
            this.gbxProfessorInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProfessorPhoto)).BeginInit();
            this.gbxProfessorOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxMyCourses
            // 
            this.gbxMyCourses.Controls.Add(this.dataGridView1);
            this.gbxMyCourses.Location = new System.Drawing.Point(278, 12);
            this.gbxMyCourses.Name = "gbxMyCourses";
            this.gbxMyCourses.Size = new System.Drawing.Size(570, 349);
            this.gbxMyCourses.TabIndex = 72;
            this.gbxMyCourses.TabStop = false;
            this.gbxMyCourses.Text = "My Courses";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnCourseTitle,
            this.columnSection,
            this.columnTotalStudents,
            this.columnSchedule,
            this.columnStartDate,
            this.courseIDDataGridViewTextBoxColumn,
            this.courseTitleDataGridViewTextBoxColumn,
            this.courseCodeDataGridViewTextBoxColumn,
            this.courseSectionDataGridViewTextBoxColumn,
            this.courseDescriptionDataGridViewTextBoxColumn,
            this.courseStartTimeDataGridViewTextBoxColumn,
            this.courseDurationDataGridViewTextBoxColumn,
            this.courseTuitionDataGridViewTextBoxColumn,
            this.courseDepartmentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.coursesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(557, 313);
            this.dataGridView1.TabIndex = 7;
            // 
            // columnCourseTitle
            // 
            this.columnCourseTitle.DataPropertyName = "CourseTitle";
            this.columnCourseTitle.HeaderText = "Course Title";
            this.columnCourseTitle.Name = "columnCourseTitle";
            this.columnCourseTitle.ReadOnly = true;
            // 
            // columnSection
            // 
            this.columnSection.DataPropertyName = "CourseSection";
            this.columnSection.HeaderText = "Section";
            this.columnSection.Name = "columnSection";
            this.columnSection.ReadOnly = true;
            // 
            // columnTotalStudents
            // 
            this.columnTotalStudents.HeaderText = "Total Students";
            this.columnTotalStudents.Name = "columnTotalStudents";
            this.columnTotalStudents.ReadOnly = true;
            // 
            // columnSchedule
            // 
            this.columnSchedule.DataPropertyName = "CourseStartTime";
            this.columnSchedule.HeaderText = "StartTime";
            this.columnSchedule.Name = "columnSchedule";
            this.columnSchedule.ReadOnly = true;
            // 
            // columnStartDate
            // 
            this.columnStartDate.HeaderText = "Start Date";
            this.columnStartDate.Name = "columnStartDate";
            this.columnStartDate.ReadOnly = true;
            // 
            // courseIDDataGridViewTextBoxColumn
            // 
            this.courseIDDataGridViewTextBoxColumn.DataPropertyName = "Course_ID";
            this.courseIDDataGridViewTextBoxColumn.HeaderText = "Course_ID";
            this.courseIDDataGridViewTextBoxColumn.Name = "courseIDDataGridViewTextBoxColumn";
            this.courseIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseTitleDataGridViewTextBoxColumn
            // 
            this.courseTitleDataGridViewTextBoxColumn.DataPropertyName = "CourseTitle";
            this.courseTitleDataGridViewTextBoxColumn.HeaderText = "CourseTitle";
            this.courseTitleDataGridViewTextBoxColumn.Name = "courseTitleDataGridViewTextBoxColumn";
            this.courseTitleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseCodeDataGridViewTextBoxColumn
            // 
            this.courseCodeDataGridViewTextBoxColumn.DataPropertyName = "CourseCode";
            this.courseCodeDataGridViewTextBoxColumn.HeaderText = "CourseCode";
            this.courseCodeDataGridViewTextBoxColumn.Name = "courseCodeDataGridViewTextBoxColumn";
            this.courseCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseSectionDataGridViewTextBoxColumn
            // 
            this.courseSectionDataGridViewTextBoxColumn.DataPropertyName = "CourseSection";
            this.courseSectionDataGridViewTextBoxColumn.HeaderText = "CourseSection";
            this.courseSectionDataGridViewTextBoxColumn.Name = "courseSectionDataGridViewTextBoxColumn";
            this.courseSectionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseDescriptionDataGridViewTextBoxColumn
            // 
            this.courseDescriptionDataGridViewTextBoxColumn.DataPropertyName = "CourseDescription";
            this.courseDescriptionDataGridViewTextBoxColumn.HeaderText = "CourseDescription";
            this.courseDescriptionDataGridViewTextBoxColumn.Name = "courseDescriptionDataGridViewTextBoxColumn";
            this.courseDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseStartTimeDataGridViewTextBoxColumn
            // 
            this.courseStartTimeDataGridViewTextBoxColumn.DataPropertyName = "CourseStartTime";
            this.courseStartTimeDataGridViewTextBoxColumn.HeaderText = "CourseStartTime";
            this.courseStartTimeDataGridViewTextBoxColumn.Name = "courseStartTimeDataGridViewTextBoxColumn";
            this.courseStartTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseDurationDataGridViewTextBoxColumn
            // 
            this.courseDurationDataGridViewTextBoxColumn.DataPropertyName = "CourseDuration";
            this.courseDurationDataGridViewTextBoxColumn.HeaderText = "CourseDuration";
            this.courseDurationDataGridViewTextBoxColumn.Name = "courseDurationDataGridViewTextBoxColumn";
            this.courseDurationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseTuitionDataGridViewTextBoxColumn
            // 
            this.courseTuitionDataGridViewTextBoxColumn.DataPropertyName = "CourseTuition";
            this.courseTuitionDataGridViewTextBoxColumn.HeaderText = "CourseTuition";
            this.courseTuitionDataGridViewTextBoxColumn.Name = "courseTuitionDataGridViewTextBoxColumn";
            this.courseTuitionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseDepartmentDataGridViewTextBoxColumn
            // 
            this.courseDepartmentDataGridViewTextBoxColumn.DataPropertyName = "CourseDepartment";
            this.courseDepartmentDataGridViewTextBoxColumn.HeaderText = "CourseDepartment";
            this.courseDepartmentDataGridViewTextBoxColumn.Name = "courseDepartmentDataGridViewTextBoxColumn";
            this.courseDepartmentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "Courses";
            this.coursesBindingSource.DataSource = this.project2DataSet;
            // 
            // project2DataSet
            // 
            this.project2DataSet.DataSetName = "Project2DataSet";
            this.project2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gbxProfessorInfo
            // 
            this.gbxProfessorInfo.Controls.Add(this.txtPhone);
            this.gbxProfessorInfo.Controls.Add(this.txtEmail);
            this.gbxProfessorInfo.Controls.Add(this.txtFax);
            this.gbxProfessorInfo.Controls.Add(this.txtZipcode);
            this.gbxProfessorInfo.Controls.Add(this.txtState);
            this.gbxProfessorInfo.Controls.Add(this.txtCity);
            this.gbxProfessorInfo.Controls.Add(this.txtAddress);
            this.gbxProfessorInfo.Controls.Add(this.txtLastName);
            this.gbxProfessorInfo.Controls.Add(this.txtFirstName);
            this.gbxProfessorInfo.Controls.Add(this.btnCancel);
            this.gbxProfessorInfo.Controls.Add(this.btnConfirm);
            this.gbxProfessorInfo.Controls.Add(this.lblPhone);
            this.gbxProfessorInfo.Controls.Add(this.lblFname);
            this.gbxProfessorInfo.Controls.Add(this.label30);
            this.gbxProfessorInfo.Controls.Add(this.lblDisplayEmail);
            this.gbxProfessorInfo.Controls.Add(this.lblDisplayCity);
            this.gbxProfessorInfo.Controls.Add(this.lblAddressA);
            this.gbxProfessorInfo.Controls.Add(this.lblDisplayState);
            this.gbxProfessorInfo.Controls.Add(this.lblDisplayZipCode);
            this.gbxProfessorInfo.Controls.Add(this.lblDisplayFax);
            this.gbxProfessorInfo.Controls.Add(this.btnUpdateInfo);
            this.gbxProfessorInfo.Controls.Add(this.imgProfessorPhoto);
            this.gbxProfessorInfo.Location = new System.Drawing.Point(12, 12);
            this.gbxProfessorInfo.Name = "gbxProfessorInfo";
            this.gbxProfessorInfo.Size = new System.Drawing.Size(260, 422);
            this.gbxProfessorInfo.TabIndex = 71;
            this.gbxProfessorInfo.TabStop = false;
            this.gbxProfessorInfo.Text = "Professor Information";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(87, 294);
            this.txtPhone.Mask = "(999) 000-0000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(139, 20);
            this.txtPhone.TabIndex = 160;
            this.txtPhone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Location = new System.Drawing.Point(87, 275);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(139, 13);
            this.txtEmail.TabIndex = 157;
            // 
            // txtFax
            // 
            this.txtFax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFax.Location = new System.Drawing.Point(87, 256);
            this.txtFax.Name = "txtFax";
            this.txtFax.ReadOnly = true;
            this.txtFax.Size = new System.Drawing.Size(139, 13);
            this.txtFax.TabIndex = 156;
            // 
            // txtZipcode
            // 
            this.txtZipcode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtZipcode.Location = new System.Drawing.Point(87, 237);
            this.txtZipcode.Name = "txtZipcode";
            this.txtZipcode.ReadOnly = true;
            this.txtZipcode.Size = new System.Drawing.Size(139, 13);
            this.txtZipcode.TabIndex = 155;
            // 
            // txtState
            // 
            this.txtState.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtState.Location = new System.Drawing.Point(97, 218);
            this.txtState.Name = "txtState";
            this.txtState.ReadOnly = true;
            this.txtState.Size = new System.Drawing.Size(139, 13);
            this.txtState.TabIndex = 154;
            // 
            // txtCity
            // 
            this.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCity.Location = new System.Drawing.Point(97, 199);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(139, 13);
            this.txtCity.TabIndex = 153;
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Location = new System.Drawing.Point(97, 180);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(139, 13);
            this.txtAddress.TabIndex = 152;
            // 
            // txtLastName
            // 
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastName.Location = new System.Drawing.Point(97, 161);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.ReadOnly = true;
            this.txtLastName.Size = new System.Drawing.Size(139, 13);
            this.txtLastName.TabIndex = 151;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirstName.Location = new System.Drawing.Point(97, 137);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.ReadOnly = true;
            this.txtFirstName.Size = new System.Drawing.Size(139, 13);
            this.txtFirstName.TabIndex = 150;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(178, 392);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 149;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(102, 392);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm.TabIndex = 148;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Visible = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(21, 294);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(41, 13);
            this.lblPhone.TabIndex = 147;
            this.lblPhone.Text = "Phone:";
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Location = new System.Drawing.Point(31, 137);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(58, 13);
            this.lblFname.TabIndex = 138;
            this.lblFname.Text = "First name:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(31, 161);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(59, 13);
            this.label30.TabIndex = 139;
            this.label30.Text = "Last name:";
            // 
            // lblDisplayEmail
            // 
            this.lblDisplayEmail.AutoSize = true;
            this.lblDisplayEmail.Location = new System.Drawing.Point(24, 275);
            this.lblDisplayEmail.Name = "lblDisplayEmail";
            this.lblDisplayEmail.Size = new System.Drawing.Size(35, 13);
            this.lblDisplayEmail.TabIndex = 145;
            this.lblDisplayEmail.Text = "Email:";
            // 
            // lblDisplayCity
            // 
            this.lblDisplayCity.AutoSize = true;
            this.lblDisplayCity.Location = new System.Drawing.Point(34, 199);
            this.lblDisplayCity.Name = "lblDisplayCity";
            this.lblDisplayCity.Size = new System.Drawing.Size(27, 13);
            this.lblDisplayCity.TabIndex = 140;
            this.lblDisplayCity.Text = "City:";
            // 
            // lblAddressA
            // 
            this.lblAddressA.AutoSize = true;
            this.lblAddressA.Location = new System.Drawing.Point(31, 180);
            this.lblAddressA.Name = "lblAddressA";
            this.lblAddressA.Size = new System.Drawing.Size(48, 13);
            this.lblAddressA.TabIndex = 144;
            this.lblAddressA.Text = "Address:";
            // 
            // lblDisplayState
            // 
            this.lblDisplayState.AutoSize = true;
            this.lblDisplayState.Location = new System.Drawing.Point(34, 218);
            this.lblDisplayState.Name = "lblDisplayState";
            this.lblDisplayState.Size = new System.Drawing.Size(35, 13);
            this.lblDisplayState.TabIndex = 141;
            this.lblDisplayState.Text = "State:";
            // 
            // lblDisplayZipCode
            // 
            this.lblDisplayZipCode.AutoSize = true;
            this.lblDisplayZipCode.Location = new System.Drawing.Point(24, 237);
            this.lblDisplayZipCode.Name = "lblDisplayZipCode";
            this.lblDisplayZipCode.Size = new System.Drawing.Size(49, 13);
            this.lblDisplayZipCode.TabIndex = 142;
            this.lblDisplayZipCode.Text = "Zipcode:";
            // 
            // lblDisplayFax
            // 
            this.lblDisplayFax.AutoSize = true;
            this.lblDisplayFax.Location = new System.Drawing.Point(24, 256);
            this.lblDisplayFax.Name = "lblDisplayFax";
            this.lblDisplayFax.Size = new System.Drawing.Size(27, 13);
            this.lblDisplayFax.TabIndex = 143;
            this.lblDisplayFax.Text = "Fax:";
            // 
            // btnUpdateInfo
            // 
            this.btnUpdateInfo.Location = new System.Drawing.Point(5, 392);
            this.btnUpdateInfo.Name = "btnUpdateInfo";
            this.btnUpdateInfo.Size = new System.Drawing.Size(85, 23);
            this.btnUpdateInfo.TabIndex = 137;
            this.btnUpdateInfo.Text = "Update Info";
            this.btnUpdateInfo.UseVisualStyleBackColor = true;
            this.btnUpdateInfo.Click += new System.EventHandler(this.btnUpdateInfo_Click_1);
            // 
            // imgProfessorPhoto
            // 
            this.imgProfessorPhoto.Location = new System.Drawing.Point(78, 24);
            this.imgProfessorPhoto.Name = "imgProfessorPhoto";
            this.imgProfessorPhoto.Size = new System.Drawing.Size(100, 100);
            this.imgProfessorPhoto.TabIndex = 63;
            this.imgProfessorPhoto.TabStop = false;
            // 
            // gbxProfessorOptions
            // 
            this.gbxProfessorOptions.Controls.Add(this.btnStudentSearch);
            this.gbxProfessorOptions.Controls.Add(this.label6);
            this.gbxProfessorOptions.Controls.Add(this.btnMyStudents);
            this.gbxProfessorOptions.Controls.Add(this.btnCancelCourses);
            this.gbxProfessorOptions.Controls.Add(this.btnAddCourses);
            this.gbxProfessorOptions.Location = new System.Drawing.Point(343, 370);
            this.gbxProfessorOptions.Name = "gbxProfessorOptions";
            this.gbxProfessorOptions.Size = new System.Drawing.Size(452, 67);
            this.gbxProfessorOptions.TabIndex = 73;
            this.gbxProfessorOptions.TabStop = false;
            this.gbxProfessorOptions.Text = "Course Options";
            // 
            // btnStudentSearch
            // 
            this.btnStudentSearch.Location = new System.Drawing.Point(342, 23);
            this.btnStudentSearch.Name = "btnStudentSearch";
            this.btnStudentSearch.Size = new System.Drawing.Size(99, 30);
            this.btnStudentSearch.TabIndex = 73;
            this.btnStudentSearch.Text = "View All Students";
            this.btnStudentSearch.UseVisualStyleBackColor = true;
            this.btnStudentSearch.Click += new System.EventHandler(this.btnStudentSearch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(221, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 72;
            this.label6.Text = "Student Options";
            // 
            // btnMyStudents
            // 
            this.btnMyStudents.Location = new System.Drawing.Point(236, 23);
            this.btnMyStudents.Name = "btnMyStudents";
            this.btnMyStudents.Size = new System.Drawing.Size(100, 30);
            this.btnMyStudents.TabIndex = 67;
            this.btnMyStudents.Text = "View My Students";
            this.btnMyStudents.UseVisualStyleBackColor = true;
            this.btnMyStudents.Click += new System.EventHandler(this.btnMyStudents_Click);
            // 
            // btnCancelCourses
            // 
            this.btnCancelCourses.Location = new System.Drawing.Point(17, 23);
            this.btnCancelCourses.Name = "btnCancelCourses";
            this.btnCancelCourses.Size = new System.Drawing.Size(90, 30);
            this.btnCancelCourses.TabIndex = 66;
            this.btnCancelCourses.Text = "Cancel Courses";
            this.btnCancelCourses.UseVisualStyleBackColor = true;
            this.btnCancelCourses.Click += new System.EventHandler(this.btnCancelCourses_Click);
            // 
            // btnAddCourses
            // 
            this.btnAddCourses.Location = new System.Drawing.Point(117, 23);
            this.btnAddCourses.Name = "btnAddCourses";
            this.btnAddCourses.Size = new System.Drawing.Size(79, 30);
            this.btnAddCourses.TabIndex = 65;
            this.btnAddCourses.Text = "Add Course";
            this.btnAddCourses.UseVisualStyleBackColor = true;
            this.btnAddCourses.Click += new System.EventHandler(this.btnAddCourses_Click);
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // ProfessorMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 449);
            this.Controls.Add(this.gbxProfessorOptions);
            this.Controls.Add(this.gbxMyCourses);
            this.Controls.Add(this.gbxProfessorInfo);
            this.Name = "ProfessorMenu";
            this.Text = "Professor Menu";
            this.Load += new System.EventHandler(this.ProfessorMenu_Load);
            this.gbxMyCourses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project2DataSet)).EndInit();
            this.gbxProfessorInfo.ResumeLayout(false);
            this.gbxProfessorInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProfessorPhoto)).EndInit();
            this.gbxProfessorOptions.ResumeLayout(false);
            this.gbxProfessorOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxMyCourses;
        private System.Windows.Forms.GroupBox gbxProfessorInfo;
        private System.Windows.Forms.PictureBox imgProfessorPhoto;
        private System.Windows.Forms.GroupBox gbxProfessorOptions;
        private System.Windows.Forms.Button btnStudentSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnMyStudents;
        private System.Windows.Forms.Button btnCancelCourses;
        private System.Windows.Forms.Button btnAddCourses;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.TextBox txtZipcode;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label lblDisplayEmail;
        private System.Windows.Forms.Label lblDisplayCity;
        private System.Windows.Forms.Label lblAddressA;
        private System.Windows.Forms.Label lblDisplayState;
        private System.Windows.Forms.Label lblDisplayZipCode;
        private System.Windows.Forms.Label lblDisplayFax;
        private System.Windows.Forms.Button btnUpdateInfo;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private Project2DataSet project2DataSet;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private Project2DataSetTableAdapters.CoursesTableAdapter coursesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCourseTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSection;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTotalStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseSectionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseStartTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDurationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseTuitionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDepartmentDataGridViewTextBoxColumn;
    }
}