namespace A2_Reg_A_Lot_2017
{
    partial class AddCourse
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
            this.btnRegisterP = new System.Windows.Forms.Button();
            this.gbxCourseSelectP = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.rtbCourseDescription = new System.Windows.Forms.RichTextBox();
            this.gbxCourseSelectP.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(275, 318);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 35);
            this.btnCancel.TabIndex = 75;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnRegisterP
            // 
            this.btnRegisterP.Location = new System.Drawing.Point(194, 318);
            this.btnRegisterP.Name = "btnRegisterP";
            this.btnRegisterP.Size = new System.Drawing.Size(75, 35);
            this.btnRegisterP.TabIndex = 74;
            this.btnRegisterP.Text = "Register";
            this.btnRegisterP.UseVisualStyleBackColor = true;
            // 
            // gbxCourseSelectP
            // 
            this.gbxCourseSelectP.Controls.Add(this.checkedListBox1);
            this.gbxCourseSelectP.Location = new System.Drawing.Point(12, 47);
            this.gbxCourseSelectP.Name = "gbxCourseSelectP";
            this.gbxCourseSelectP.Size = new System.Drawing.Size(519, 145);
            this.gbxCourseSelectP.TabIndex = 73;
            this.gbxCourseSelectP.TabStop = false;
            this.gbxCourseSelectP.Text = "Course Selection";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "A Course 1",
            "A Course 2",
            "A Course 3",
            "A Course 4",
            "A Course 5",
            "A Course 6",
            "A Course 7",
            "A Course 8"});
            this.checkedListBox1.Location = new System.Drawing.Point(9, 19);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(504, 109);
            this.checkedListBox1.TabIndex = 0;
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
            // rtbCourseDescription
            // 
            this.rtbCourseDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbCourseDescription.Location = new System.Drawing.Point(21, 205);
            this.rtbCourseDescription.Name = "rtbCourseDescription";
            this.rtbCourseDescription.ReadOnly = true;
            this.rtbCourseDescription.Size = new System.Drawing.Size(504, 102);
            this.rtbCourseDescription.TabIndex = 76;
            this.rtbCourseDescription.Text = "Text description for a course should come up  here if one was set";
            // 
            // AddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 361);
            this.Controls.Add(this.rtbCourseDescription);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnRegisterP);
            this.Controls.Add(this.gbxCourseSelectP);
            this.Controls.Add(this.label13);
            this.Name = "AddCourse";
            this.Text = "Add Course";
            this.gbxCourseSelectP.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRegisterP;
        private System.Windows.Forms.GroupBox gbxCourseSelectP;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox rtbCourseDescription;
    }
}