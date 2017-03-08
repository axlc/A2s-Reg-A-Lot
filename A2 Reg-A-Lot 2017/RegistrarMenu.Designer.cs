namespace A2_Reg_A_Lot_2017
{
    partial class RegistrarMenu
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
            this.gbxRegistrarOptions = new System.Windows.Forms.GroupBox();
            this.btnModifyRegistrar = new System.Windows.Forms.Button();
            this.btnBilling = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModifyProfessor = new System.Windows.Forms.Button();
            this.btnModifyStudent = new System.Windows.Forms.Button();
            this.btnProfessorSearch = new System.Windows.Forms.Button();
            this.btnStudentSearch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnManageCourses = new System.Windows.Forms.Button();
            this.project2DataSet1 = new A2_Reg_A_Lot_2017.Project2DataSet1();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coursesTableAdapter = new A2_Reg_A_Lot_2017.Project2DataSet1TableAdapters.CoursesTableAdapter();
            this.columnCourseTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnProfessor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSchedule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTotalStudents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseSectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseStartTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDurationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseTuitionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDepartmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxMyCourses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbxRegistrarOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.project2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxMyCourses
            // 
            this.gbxMyCourses.Controls.Add(this.dataGridView1);
            this.gbxMyCourses.Location = new System.Drawing.Point(12, 12);
            this.gbxMyCourses.Name = "gbxMyCourses";
            this.gbxMyCourses.Size = new System.Drawing.Size(693, 349);
            this.gbxMyCourses.TabIndex = 74;
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
            this.columnProfessor,
            this.columnSchedule,
            this.columnTotalStudents,
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
            this.dataGridView1.Location = new System.Drawing.Point(15, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(544, 311);
            this.dataGridView1.TabIndex = 76;
            // 
            // gbxRegistrarOptions
            // 
            this.gbxRegistrarOptions.Controls.Add(this.btnModifyRegistrar);
            this.gbxRegistrarOptions.Controls.Add(this.btnBilling);
            this.gbxRegistrarOptions.Controls.Add(this.label1);
            this.gbxRegistrarOptions.Controls.Add(this.btnModifyProfessor);
            this.gbxRegistrarOptions.Controls.Add(this.btnModifyStudent);
            this.gbxRegistrarOptions.Controls.Add(this.btnProfessorSearch);
            this.gbxRegistrarOptions.Controls.Add(this.btnStudentSearch);
            this.gbxRegistrarOptions.Controls.Add(this.label6);
            this.gbxRegistrarOptions.Controls.Add(this.btnManageCourses);
            this.gbxRegistrarOptions.Location = new System.Drawing.Point(75, 368);
            this.gbxRegistrarOptions.Name = "gbxRegistrarOptions";
            this.gbxRegistrarOptions.Size = new System.Drawing.Size(630, 113);
            this.gbxRegistrarOptions.TabIndex = 75;
            this.gbxRegistrarOptions.TabStop = false;
            this.gbxRegistrarOptions.Text = "Course Options";
            // 
            // btnModifyRegistrar
            // 
            this.btnModifyRegistrar.Location = new System.Drawing.Point(372, 64);
            this.btnModifyRegistrar.Name = "btnModifyRegistrar";
            this.btnModifyRegistrar.Size = new System.Drawing.Size(99, 40);
            this.btnModifyRegistrar.TabIndex = 80;
            this.btnModifyRegistrar.Text = "Add/Update Registrar";
            this.btnModifyRegistrar.UseVisualStyleBackColor = true;
            this.btnModifyRegistrar.Click += new System.EventHandler(this.btnModifyRegistrar_Click);
            // 
            // btnBilling
            // 
            this.btnBilling.Location = new System.Drawing.Point(491, 24);
            this.btnBilling.Name = "btnBilling";
            this.btnBilling.Size = new System.Drawing.Size(114, 30);
            this.btnBilling.TabIndex = 79;
            this.btnBilling.Text = "Student Billing";
            this.btnBilling.UseVisualStyleBackColor = true;
            this.btnBilling.Click += new System.EventHandler(this.btnBilling_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(516, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 78;
            this.label1.Text = "Billing Option";
            // 
            // btnModifyProfessor
            // 
            this.btnModifyProfessor.Location = new System.Drawing.Point(162, 64);
            this.btnModifyProfessor.Name = "btnModifyProfessor";
            this.btnModifyProfessor.Size = new System.Drawing.Size(99, 40);
            this.btnModifyProfessor.TabIndex = 76;
            this.btnModifyProfessor.Text = "Add/Update Professor";
            this.btnModifyProfessor.UseVisualStyleBackColor = true;
            this.btnModifyProfessor.Click += new System.EventHandler(this.btnModifyProfessor_Click);
            // 
            // btnModifyStudent
            // 
            this.btnModifyStudent.Location = new System.Drawing.Point(267, 64);
            this.btnModifyStudent.Name = "btnModifyStudent";
            this.btnModifyStudent.Size = new System.Drawing.Size(99, 40);
            this.btnModifyStudent.TabIndex = 75;
            this.btnModifyStudent.Text = "Add/Update Student";
            this.btnModifyStudent.UseVisualStyleBackColor = true;
            this.btnModifyStudent.Click += new System.EventHandler(this.btnModifyStudent_Click);
            // 
            // btnProfessorSearch
            // 
            this.btnProfessorSearch.Location = new System.Drawing.Point(189, 24);
            this.btnProfessorSearch.Name = "btnProfessorSearch";
            this.btnProfessorSearch.Size = new System.Drawing.Size(99, 30);
            this.btnProfessorSearch.TabIndex = 74;
            this.btnProfessorSearch.Text = "View Professors";
            this.btnProfessorSearch.UseVisualStyleBackColor = true;
            this.btnProfessorSearch.Click += new System.EventHandler(this.btnProfessorSearch_Click);
            // 
            // btnStudentSearch
            // 
            this.btnStudentSearch.Location = new System.Drawing.Point(294, 24);
            this.btnStudentSearch.Name = "btnStudentSearch";
            this.btnStudentSearch.Size = new System.Drawing.Size(99, 30);
            this.btnStudentSearch.TabIndex = 73;
            this.btnStudentSearch.Text = "View Students";
            this.btnStudentSearch.UseVisualStyleBackColor = true;
            this.btnStudentSearch.Click += new System.EventHandler(this.btnStudentSearch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(249, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 72;
            this.label6.Text = "Manage Members";
            // 
            // btnManageCourses
            // 
            this.btnManageCourses.Location = new System.Drawing.Point(24, 24);
            this.btnManageCourses.Name = "btnManageCourses";
            this.btnManageCourses.Size = new System.Drawing.Size(114, 30);
            this.btnManageCourses.TabIndex = 66;
            this.btnManageCourses.Text = "Manage Courses";
            this.btnManageCourses.UseVisualStyleBackColor = true;
            this.btnManageCourses.Click += new System.EventHandler(this.btnManageCourses_Click);
            // 
            // project2DataSet1
            // 
            this.project2DataSet1.DataSetName = "Project2DataSet1";
            this.project2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "Courses";
            this.coursesBindingSource.DataSource = this.project2DataSet1;
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
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
            // columnTotalStudents
            // 
            this.columnTotalStudents.HeaderText = "Total Students";
            this.columnTotalStudents.Name = "columnTotalStudents";
            this.columnTotalStudents.ReadOnly = true;
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
            // RegistrarMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 489);
            this.Controls.Add(this.gbxRegistrarOptions);
            this.Controls.Add(this.gbxMyCourses);
            this.Name = "RegistrarMenu";
            this.Text = "Course Registrar Menu";
            this.Load += new System.EventHandler(this.RegistrarMenu_Load);
            this.gbxMyCourses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbxRegistrarOptions.ResumeLayout(false);
            this.gbxRegistrarOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.project2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxMyCourses;
        private System.Windows.Forms.GroupBox gbxRegistrarOptions;
        private System.Windows.Forms.Button btnProfessorSearch;
        private System.Windows.Forms.Button btnStudentSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnManageCourses;
        private System.Windows.Forms.Button btnModifyProfessor;
        private System.Windows.Forms.Button btnModifyStudent;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBilling;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModifyRegistrar;
        private Project2DataSet1 project2DataSet1;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private Project2DataSet1TableAdapters.CoursesTableAdapter coursesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCourseTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSection;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnProfessor;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTotalStudents;
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