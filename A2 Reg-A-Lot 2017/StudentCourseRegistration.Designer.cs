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
            this.btnRemoveCourse = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.columnCourseTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSection = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnProfessor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnSchedule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTuition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxConfirmStudentRegistration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(232, 308);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(109, 39);
            this.btnConfirm.TabIndex = 7;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(347, 308);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 39);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // gbxConfirmStudentRegistration
            // 
            this.gbxConfirmStudentRegistration.Controls.Add(this.dataGridView1);
            this.gbxConfirmStudentRegistration.Controls.Add(this.lblTotalCost);
            this.gbxConfirmStudentRegistration.Controls.Add(this.label2);
            this.gbxConfirmStudentRegistration.Controls.Add(this.btnRemoveCourse);
            this.gbxConfirmStudentRegistration.Location = new System.Drawing.Point(12, 12);
            this.gbxConfirmStudentRegistration.Name = "gbxConfirmStudentRegistration";
            this.gbxConfirmStudentRegistration.Size = new System.Drawing.Size(665, 287);
            this.gbxConfirmStudentRegistration.TabIndex = 5;
            this.gbxConfirmStudentRegistration.TabStop = false;
            this.gbxConfirmStudentRegistration.Text = "The following courses will be registered";
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.ForeColor = System.Drawing.Color.Red;
            this.lblTotalCost.Location = new System.Drawing.Point(50, 263);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(240, 13);
            this.lblTotalCost.TabIndex = 22;
            this.lblTotalCost.Text = "ADD UP THE TUITION AND DISPLAY IT HERE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Total:";
            // 
            // btnRemoveCourse
            // 
            this.btnRemoveCourse.Location = new System.Drawing.Point(581, 256);
            this.btnRemoveCourse.Name = "btnRemoveCourse";
            this.btnRemoveCourse.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveCourse.TabIndex = 2;
            this.btnRemoveCourse.Text = "Remove";
            this.btnRemoveCourse.UseVisualStyleBackColor = true;
            this.btnRemoveCourse.Click += new System.EventHandler(this.btnRemoveCourse_Click);
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
            this.columnStartDate,
            this.columnTuition});
            this.dataGridView1.Location = new System.Drawing.Point(13, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(643, 228);
            this.dataGridView1.TabIndex = 23;
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
            // columnStartDate
            // 
            this.columnStartDate.HeaderText = "Start Date";
            this.columnStartDate.Name = "columnStartDate";
            this.columnStartDate.ReadOnly = true;
            // 
            // columnTuition
            // 
            this.columnTuition.HeaderText = "Tuition";
            this.columnTuition.Name = "columnTuition";
            this.columnTuition.ReadOnly = true;
            // 
            // StudentCourseRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 355);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gbxConfirmStudentRegistration);
            this.Name = "StudentCourseRegistration";
            this.Text = "Register for Courses";
            this.gbxConfirmStudentRegistration.ResumeLayout(false);
            this.gbxConfirmStudentRegistration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox gbxConfirmStudentRegistration;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRemoveCourse;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCourseTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSection;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnProfessor;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnSchedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTuition;
    }
}