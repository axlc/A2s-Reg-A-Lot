namespace A2_Reg_A_Lot_2017
{
    partial class ProfessorCancelCourse
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCancelCourseP = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clbProfessorCourses = new System.Windows.Forms.CheckedListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.gbxCourseDescription.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxCourseDescription
            // 
            this.gbxCourseDescription.Controls.Add(this.label1);
            this.gbxCourseDescription.Location = new System.Drawing.Point(21, 199);
            this.gbxCourseDescription.Name = "gbxCourseDescription";
            this.gbxCourseDescription.Size = new System.Drawing.Size(504, 100);
            this.gbxCourseDescription.TabIndex = 81;
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
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(275, 305);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 35);
            this.btnCancel.TabIndex = 80;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCancelCourseP
            // 
            this.btnCancelCourseP.Location = new System.Drawing.Point(194, 305);
            this.btnCancelCourseP.Name = "btnCancelCourseP";
            this.btnCancelCourseP.Size = new System.Drawing.Size(75, 35);
            this.btnCancelCourseP.TabIndex = 79;
            this.btnCancelCourseP.Text = "Confirm";
            this.btnCancelCourseP.UseVisualStyleBackColor = true;
            this.btnCancelCourseP.Click += new System.EventHandler(this.btnCancelCourseP_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clbProfessorCourses);
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(519, 145);
            this.groupBox1.TabIndex = 78;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Course Selection";
            // 
            // clbProfessorCourses
            // 
            this.clbProfessorCourses.FormattingEnabled = true;
            this.clbProfessorCourses.Items.AddRange(new object[] {
            "MY Course 1",
            "MY Course 2",
            "MY Course 3"});
            this.clbProfessorCourses.Location = new System.Drawing.Point(9, 19);
            this.clbProfessorCourses.Name = "clbProfessorCourses";
            this.clbProfessorCourses.Size = new System.Drawing.Size(504, 109);
            this.clbProfessorCourses.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 9);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(264, 25);
            this.label13.TabIndex = 77;
            this.label13.Text = "Cancel a current course";
            // 
            // ProfessorCancelCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 353);
            this.Controls.Add(this.gbxCourseDescription);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCancelCourseP);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label13);
            this.Name = "ProfessorCancelCourse";
            this.Text = "Cancel Course";
            this.gbxCourseDescription.ResumeLayout(false);
            this.gbxCourseDescription.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCourseDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCancelCourseP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox clbProfessorCourses;
        private System.Windows.Forms.Label label13;
    }
}