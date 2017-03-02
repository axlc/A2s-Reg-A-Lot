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
            this.gbxMyCourses = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.columnCourseTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnProfessor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSchedule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTotalStudents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxRegistrarOptions = new System.Windows.Forms.GroupBox();
            this.btnModifyProfessor = new System.Windows.Forms.Button();
            this.btnModifyStudent = new System.Windows.Forms.Button();
            this.btnProfessorSearch = new System.Windows.Forms.Button();
            this.btnStudentSearch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnManageCourses = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBilling = new System.Windows.Forms.Button();
            this.gbxMyCourses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbxRegistrarOptions.SuspendLayout();
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnCourseTitle,
            this.columnSection,
            this.columnProfessor,
            this.columnSchedule,
            this.columnTotalStudents});
            this.dataGridView1.Location = new System.Drawing.Point(15, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(544, 311);
            this.dataGridView1.TabIndex = 76;
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
            // columnTotalStudents
            // 
            this.columnTotalStudents.HeaderText = "Total Students";
            this.columnTotalStudents.Name = "columnTotalStudents";
            this.columnTotalStudents.ReadOnly = true;
            // 
            // gbxRegistrarOptions
            // 
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
            // btnModifyProfessor
            // 
            this.btnModifyProfessor.Location = new System.Drawing.Point(232, 64);
            this.btnModifyProfessor.Name = "btnModifyProfessor";
            this.btnModifyProfessor.Size = new System.Drawing.Size(99, 40);
            this.btnModifyProfessor.TabIndex = 76;
            this.btnModifyProfessor.Text = "Add/Update Professor";
            this.btnModifyProfessor.UseVisualStyleBackColor = true;
            this.btnModifyProfessor.Click += new System.EventHandler(this.btnModifyProfessor_Click);
            // 
            // btnModifyStudent
            // 
            this.btnModifyStudent.Location = new System.Drawing.Point(337, 64);
            this.btnModifyStudent.Name = "btnModifyStudent";
            this.btnModifyStudent.Size = new System.Drawing.Size(99, 40);
            this.btnModifyStudent.TabIndex = 75;
            this.btnModifyStudent.Text = "Add/Update Student";
            this.btnModifyStudent.UseVisualStyleBackColor = true;
            this.btnModifyStudent.Click += new System.EventHandler(this.btnModifyStudent_Click);
            // 
            // btnProfessorSearch
            // 
            this.btnProfessorSearch.Location = new System.Drawing.Point(232, 24);
            this.btnProfessorSearch.Name = "btnProfessorSearch";
            this.btnProfessorSearch.Size = new System.Drawing.Size(99, 30);
            this.btnProfessorSearch.TabIndex = 74;
            this.btnProfessorSearch.Text = "View Professors";
            this.btnProfessorSearch.UseVisualStyleBackColor = true;
            this.btnProfessorSearch.Click += new System.EventHandler(this.btnProfessorSearch_Click);
            // 
            // btnStudentSearch
            // 
            this.btnStudentSearch.Location = new System.Drawing.Point(337, 24);
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
            this.label6.Location = new System.Drawing.Point(221, 0);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(516, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 78;
            this.label1.Text = "Billing Option";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCourseTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSection;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnProfessor;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTotalStudents;
        private System.Windows.Forms.Button btnBilling;
        private System.Windows.Forms.Label label1;
    }
}