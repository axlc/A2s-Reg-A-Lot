namespace A2_Reg_A_Lot_2017
{
    partial class StudentDropCourse
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
            this.btnConfirmDrop = new System.Windows.Forms.Button();
            this.gbxLMyCourses = new System.Windows.Forms.GroupBox();
            this.clbMyCourses = new System.Windows.Forms.CheckedListBox();
            this.gbxLMyCourses.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(186, 220);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 32);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirmDrop
            // 
            this.btnConfirmDrop.Location = new System.Drawing.Point(89, 220);
            this.btnConfirmDrop.Name = "btnConfirmDrop";
            this.btnConfirmDrop.Size = new System.Drawing.Size(78, 32);
            this.btnConfirmDrop.TabIndex = 4;
            this.btnConfirmDrop.Text = "Confirm";
            this.btnConfirmDrop.UseVisualStyleBackColor = true;
            this.btnConfirmDrop.Click += new System.EventHandler(this.btnConfirmDrop_Click);
            // 
            // gbxLMyCourses
            // 
            this.gbxLMyCourses.Controls.Add(this.clbMyCourses);
            this.gbxLMyCourses.Location = new System.Drawing.Point(12, 12);
            this.gbxLMyCourses.Name = "gbxLMyCourses";
            this.gbxLMyCourses.Size = new System.Drawing.Size(337, 202);
            this.gbxLMyCourses.TabIndex = 3;
            this.gbxLMyCourses.TabStop = false;
            this.gbxLMyCourses.Text = "Select a course you would like to drop";
            this.gbxLMyCourses.Enter += new System.EventHandler(this.gbxLMyCourses_Enter);
            // 
            // clbMyCourses
            // 
            this.clbMyCourses.FormattingEnabled = true;
            this.clbMyCourses.Items.AddRange(new object[] {
            "List Courses from student\'s registered courses",
            "1",
            "2",
            "3",
            "4"});
            this.clbMyCourses.Location = new System.Drawing.Point(7, 20);
            this.clbMyCourses.Name = "clbMyCourses";
            this.clbMyCourses.Size = new System.Drawing.Size(322, 169);
            this.clbMyCourses.TabIndex = 0;
            this.clbMyCourses.SelectedIndexChanged += new System.EventHandler(this.clbMyCourses_SelectedIndexChanged);
            // 
            // StudentDropCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 259);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirmDrop);
            this.Controls.Add(this.gbxLMyCourses);
            this.Name = "StudentDropCourse";
            this.Text = "Drop Course";
            this.gbxLMyCourses.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirmDrop;
        private System.Windows.Forms.GroupBox gbxLMyCourses;
        private System.Windows.Forms.CheckedListBox clbMyCourses;
    }
}