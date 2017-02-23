namespace A2_Reg_A_Lot_2017
{
    partial class StudentCourseRegistration
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
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.gbxConfirmStudentRegistration = new System.Windows.Forms.GroupBox();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRemoveCourse = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.gbxConfirmStudentRegistration.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(232, 225);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(109, 39);
            this.btnConfirm.TabIndex = 7;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(347, 225);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 39);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gbxConfirmStudentRegistration
            // 
            this.gbxConfirmStudentRegistration.Controls.Add(this.lblTotalCost);
            this.gbxConfirmStudentRegistration.Controls.Add(this.label2);
            this.gbxConfirmStudentRegistration.Controls.Add(this.label1);
            this.gbxConfirmStudentRegistration.Controls.Add(this.label12);
            this.gbxConfirmStudentRegistration.Controls.Add(this.label11);
            this.gbxConfirmStudentRegistration.Controls.Add(this.label10);
            this.gbxConfirmStudentRegistration.Controls.Add(this.label9);
            this.gbxConfirmStudentRegistration.Controls.Add(this.label8);
            this.gbxConfirmStudentRegistration.Controls.Add(this.btnRemoveCourse);
            this.gbxConfirmStudentRegistration.Controls.Add(this.listBox1);
            this.gbxConfirmStudentRegistration.Location = new System.Drawing.Point(12, 12);
            this.gbxConfirmStudentRegistration.Name = "gbxConfirmStudentRegistration";
            this.gbxConfirmStudentRegistration.Size = new System.Drawing.Size(660, 202);
            this.gbxConfirmStudentRegistration.TabIndex = 5;
            this.gbxConfirmStudentRegistration.TabStop = false;
            this.gbxConfirmStudentRegistration.Text = "The following courses will be registered";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(50, 173);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(34, 13);
            this.lblTotalCost.TabIndex = 22;
            this.lblTotalCost.Text = "$0.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Total:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(580, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Cost";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(461, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Start Date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(358, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Schedule";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(253, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Professor";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(155, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Section";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Course Title";
            // 
            // btnRemoveCourse
            // 
            this.btnRemoveCourse.Location = new System.Drawing.Point(558, 168);
            this.btnRemoveCourse.Name = "btnRemoveCourse";
            this.btnRemoveCourse.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveCourse.TabIndex = 2;
            this.btnRemoveCourse.Text = "Remove";
            this.btnRemoveCourse.UseVisualStyleBackColor = true;
            this.btnRemoveCourse.Click += new System.EventHandler(this.btnRemoveCourse_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "TEMPORARY PLACEHOLDER",
            "We want to try to use a datagrid control bound to the data used here I think"});
            this.listBox1.Location = new System.Drawing.Point(9, 41);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(635, 121);
            this.listBox1.TabIndex = 1;
            // 
            // StudentCourseRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 277);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbxConfirmStudentRegistration);
            this.Name = "StudentCourseRegistration";
            this.Text = "Register for Courses";
            this.gbxConfirmStudentRegistration.ResumeLayout(false);
            this.gbxConfirmStudentRegistration.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gbxConfirmStudentRegistration;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnRemoveCourse;
        private System.Windows.Forms.ListBox listBox1;
    }
}