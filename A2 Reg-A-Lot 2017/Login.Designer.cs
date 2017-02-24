namespace A2_Reg_A_Lot_2017
{
    partial class Login
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.linkCreateAccount = new System.Windows.Forms.LinkLabel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.btnTestRegistrar = new System.Windows.Forms.Button();
            this.btnTestProfessor = new System.Windows.Forms.Button();
            this.btnTestStudent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(126, 169);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 13;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // linkCreateAccount
            // 
            this.linkCreateAccount.AutoSize = true;
            this.linkCreateAccount.Location = new System.Drawing.Point(45, 206);
            this.linkCreateAccount.Name = "linkCreateAccount";
            this.linkCreateAccount.Size = new System.Drawing.Size(224, 13);
            this.linkCreateAccount.TabIndex = 12;
            this.linkCreateAccount.TabStop = true;
            this.linkCreateAccount.Text = "Don\'t have an account? Click here to sign up!";
            this.linkCreateAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCreateAccount_LinkClicked);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(99, 120);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(147, 20);
            this.txtPassword.TabIndex = 11;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(99, 90);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(147, 20);
            this.txtUsername.TabIndex = 10;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(36, 123);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(56, 13);
            this.lblPassword.TabIndex = 9;
            this.lblPassword.Text = "Password:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(36, 93);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(21, 13);
            this.lblUsername.TabIndex = 8;
            this.lblUsername.Text = "ID:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLogin.Location = new System.Drawing.Point(35, 49);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(254, 24);
            this.lblLogin.TabIndex = 7;
            this.lblLogin.Text = "Login to Made-Up College";
            // 
            // btnTestRegistrar
            // 
            this.btnTestRegistrar.Location = new System.Drawing.Point(391, 49);
            this.btnTestRegistrar.Name = "btnTestRegistrar";
            this.btnTestRegistrar.Size = new System.Drawing.Size(75, 54);
            this.btnTestRegistrar.TabIndex = 14;
            this.btnTestRegistrar.Text = "Test Registrar Login";
            this.btnTestRegistrar.UseVisualStyleBackColor = true;
            this.btnTestRegistrar.Click += new System.EventHandler(this.btnTestRegistrar_Click);
            // 
            // btnTestProfessor
            // 
            this.btnTestProfessor.Location = new System.Drawing.Point(391, 115);
            this.btnTestProfessor.Name = "btnTestProfessor";
            this.btnTestProfessor.Size = new System.Drawing.Size(75, 54);
            this.btnTestProfessor.TabIndex = 15;
            this.btnTestProfessor.Text = "Test  Professor Login";
            this.btnTestProfessor.UseVisualStyleBackColor = true;
            this.btnTestProfessor.Click += new System.EventHandler(this.btnTestProfessor_Click);
            // 
            // btnTestStudent
            // 
            this.btnTestStudent.Location = new System.Drawing.Point(391, 182);
            this.btnTestStudent.Name = "btnTestStudent";
            this.btnTestStudent.Size = new System.Drawing.Size(75, 54);
            this.btnTestStudent.TabIndex = 16;
            this.btnTestStudent.Text = "Test Student Login";
            this.btnTestStudent.UseVisualStyleBackColor = true;
            this.btnTestStudent.Click += new System.EventHandler(this.btnTestStudent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Buttons for testing user login";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTestStudent);
            this.Controls.Add(this.btnTestProfessor);
            this.Controls.Add(this.btnTestRegistrar);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.linkCreateAccount);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblLogin);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel linkCreateAccount;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnTestRegistrar;
        private System.Windows.Forms.Button btnTestProfessor;
        private System.Windows.Forms.Button btnTestStudent;
        private System.Windows.Forms.Label label1;
    }
}

