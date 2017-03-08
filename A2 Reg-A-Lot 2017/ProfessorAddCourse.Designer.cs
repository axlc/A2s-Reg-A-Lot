namespace A2_Reg_A_Lot_2017
{
    partial class ProfessorAddCourse
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
            this.gbxCourseDescription = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.gboxProfessorCourseRegistration = new System.Windows.Forms.GroupBox();
            this.clbAllNewCourses = new System.Windows.Forms.CheckedListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.gbxCourseDescription.SuspendLayout();
            this.gboxProfessorCourseRegistration.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxCourseDescription
            // 
            this.gbxCourseDescription.Controls.Add(this.label1);
            this.gbxCourseDescription.Location = new System.Drawing.Point(21, 199);
            this.gbxCourseDescription.Name = "gbxCourseDescription";
            this.gbxCourseDescription.Size = new System.Drawing.Size(504, 100);
            this.gbxCourseDescription.TabIndex = 76;
            this.gbxCourseDescription.TabStop = false;
            this.gbxCourseDescription.Text = "Course Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 13);
            this.label1.TabIndex = 72;
            this.label1.Text = "Course Description should be displayed here idk with what";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(275, 305);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 35);
            this.btnBack.TabIndex = 75;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(194, 305);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 35);
            this.btnRegister.TabIndex = 74;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // gboxProfessorCourseRegistration
            // 
            this.gboxProfessorCourseRegistration.Controls.Add(this.clbAllNewCourses);
            this.gboxProfessorCourseRegistration.Location = new System.Drawing.Point(12, 47);
            this.gboxProfessorCourseRegistration.Name = "gboxProfessorCourseRegistration";
            this.gboxProfessorCourseRegistration.Size = new System.Drawing.Size(519, 145);
            this.gboxProfessorCourseRegistration.TabIndex = 73;
            this.gboxProfessorCourseRegistration.TabStop = false;
            this.gboxProfessorCourseRegistration.Text = "Course Selection";
            // 
            // clbAllNewCourses
            // 
            this.clbAllNewCourses.FormattingEnabled = true;
            this.clbAllNewCourses.Location = new System.Drawing.Point(9, 19);
            this.clbAllNewCourses.Name = "clbAllNewCourses";
            this.clbAllNewCourses.Size = new System.Drawing.Size(504, 109);
            this.clbAllNewCourses.TabIndex = 0;
            this.clbAllNewCourses.SelectedIndexChanged += new System.EventHandler(this.clbAllNewCourses_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(339, 25);
            this.label13.TabIndex = 72;
            this.label13.Text = "Register to teach a new course";
            // 
            // ProfessorAddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 348);
            this.Controls.Add(this.gbxCourseDescription);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.gboxProfessorCourseRegistration);
            this.Controls.Add(this.label13);
            this.Name = "ProfessorAddCourse";
            this.Text = "Professor Registration";
            this.Load += new System.EventHandler(this.ProfessorAddCourse_Load);
            this.gbxCourseDescription.ResumeLayout(false);
            this.gbxCourseDescription.PerformLayout();
            this.gboxProfessorCourseRegistration.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCourseDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.GroupBox gboxProfessorCourseRegistration;
        private System.Windows.Forms.CheckedListBox clbAllNewCourses;
        private System.Windows.Forms.Label label13;
    }
}