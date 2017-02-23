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
            this.lblProfessors = new System.Windows.Forms.Label();
            this.lblTotalStudents = new System.Windows.Forms.Label();
            this.lblSchedule = new System.Windows.Forms.Label();
            this.lblSection = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lstPLACEHOLDER1 = new System.Windows.Forms.ListBox();
            this.gbxRegistrarOptions = new System.Windows.Forms.GroupBox();
            this.btnProfessorSearch = new System.Windows.Forms.Button();
            this.btnStudentSearch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnManageCourses = new System.Windows.Forms.Button();
            this.gbxMyCourses.SuspendLayout();
            this.gbxRegistrarOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxMyCourses
            // 
            this.gbxMyCourses.Controls.Add(this.lblProfessors);
            this.gbxMyCourses.Controls.Add(this.lblTotalStudents);
            this.gbxMyCourses.Controls.Add(this.lblSchedule);
            this.gbxMyCourses.Controls.Add(this.lblSection);
            this.gbxMyCourses.Controls.Add(this.lblCourse);
            this.gbxMyCourses.Controls.Add(this.lstPLACEHOLDER1);
            this.gbxMyCourses.Location = new System.Drawing.Point(12, 12);
            this.gbxMyCourses.Name = "gbxMyCourses";
            this.gbxMyCourses.Size = new System.Drawing.Size(452, 349);
            this.gbxMyCourses.TabIndex = 74;
            this.gbxMyCourses.TabStop = false;
            this.gbxMyCourses.Text = "My Courses";
            // 
            // lblProfessors
            // 
            this.lblProfessors.AutoSize = true;
            this.lblProfessors.Location = new System.Drawing.Point(274, 21);
            this.lblProfessors.Name = "lblProfessors";
            this.lblProfessors.Size = new System.Drawing.Size(51, 13);
            this.lblProfessors.TabIndex = 7;
            this.lblProfessors.Text = "Professor";
            // 
            // lblTotalStudents
            // 
            this.lblTotalStudents.AutoSize = true;
            this.lblTotalStudents.Location = new System.Drawing.Point(350, 21);
            this.lblTotalStudents.Name = "lblTotalStudents";
            this.lblTotalStudents.Size = new System.Drawing.Size(76, 13);
            this.lblTotalStudents.TabIndex = 6;
            this.lblTotalStudents.Text = "Total Students";
            // 
            // lblSchedule
            // 
            this.lblSchedule.AutoSize = true;
            this.lblSchedule.Location = new System.Drawing.Point(196, 21);
            this.lblSchedule.Name = "lblSchedule";
            this.lblSchedule.Size = new System.Drawing.Size(52, 13);
            this.lblSchedule.TabIndex = 4;
            this.lblSchedule.Text = "Schedule";
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Location = new System.Drawing.Point(120, 21);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(43, 13);
            this.lblSection.TabIndex = 2;
            this.lblSection.Text = "Section";
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(21, 21);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(71, 13);
            this.lblCourse.TabIndex = 1;
            this.lblCourse.Text = "Course Name";
            // 
            // lstPLACEHOLDER1
            // 
            this.lstPLACEHOLDER1.FormattingEnabled = true;
            this.lstPLACEHOLDER1.Items.AddRange(new object[] {
            "TEMPORARY PLACEHOLDER",
            "We want to try to use a datagrid control bound to the data used here I think"});
            this.lstPLACEHOLDER1.Location = new System.Drawing.Point(16, 41);
            this.lstPLACEHOLDER1.Name = "lstPLACEHOLDER1";
            this.lstPLACEHOLDER1.Size = new System.Drawing.Size(419, 290);
            this.lstPLACEHOLDER1.TabIndex = 0;
            // 
            // gbxRegistrarOptions
            // 
            this.gbxRegistrarOptions.Controls.Add(this.btnProfessorSearch);
            this.gbxRegistrarOptions.Controls.Add(this.btnStudentSearch);
            this.gbxRegistrarOptions.Controls.Add(this.label6);
            this.gbxRegistrarOptions.Controls.Add(this.btnManageCourses);
            this.gbxRegistrarOptions.Location = new System.Drawing.Point(12, 367);
            this.gbxRegistrarOptions.Name = "gbxRegistrarOptions";
            this.gbxRegistrarOptions.Size = new System.Drawing.Size(452, 67);
            this.gbxRegistrarOptions.TabIndex = 75;
            this.gbxRegistrarOptions.TabStop = false;
            this.gbxRegistrarOptions.Text = "Course Options";
            // 
            // btnProfessorSearch
            // 
            this.btnProfessorSearch.Location = new System.Drawing.Point(237, 23);
            this.btnProfessorSearch.Name = "btnProfessorSearch";
            this.btnProfessorSearch.Size = new System.Drawing.Size(99, 30);
            this.btnProfessorSearch.TabIndex = 74;
            this.btnProfessorSearch.Text = "View Professors";
            this.btnProfessorSearch.UseVisualStyleBackColor = true;
            this.btnProfessorSearch.Click += new System.EventHandler(this.btnProfessorSearch_Click);
            // 
            // btnStudentSearch
            // 
            this.btnStudentSearch.Location = new System.Drawing.Point(342, 23);
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
            this.btnManageCourses.Location = new System.Drawing.Point(25, 23);
            this.btnManageCourses.Name = "btnManageCourses";
            this.btnManageCourses.Size = new System.Drawing.Size(114, 30);
            this.btnManageCourses.TabIndex = 66;
            this.btnManageCourses.Text = "Manage Courses";
            this.btnManageCourses.UseVisualStyleBackColor = true;
            this.btnManageCourses.Click += new System.EventHandler(this.btnManageCourses_Click);
            // 
            // RegistrarMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 443);
            this.Controls.Add(this.gbxRegistrarOptions);
            this.Controls.Add(this.gbxMyCourses);
            this.Name = "RegistrarMenu";
            this.Text = "Course Registrar Menu";
            this.gbxMyCourses.ResumeLayout(false);
            this.gbxMyCourses.PerformLayout();
            this.gbxRegistrarOptions.ResumeLayout(false);
            this.gbxRegistrarOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxMyCourses;
        private System.Windows.Forms.Label lblTotalStudents;
        private System.Windows.Forms.Label lblSchedule;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.ListBox lstPLACEHOLDER1;
        private System.Windows.Forms.Label lblProfessors;
        private System.Windows.Forms.GroupBox gbxRegistrarOptions;
        private System.Windows.Forms.Button btnProfessorSearch;
        private System.Windows.Forms.Button btnStudentSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnManageCourses;
    }
}