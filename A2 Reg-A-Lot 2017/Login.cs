using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using A2_Reg_A_Lot_2017;
namespace A2_Reg_A_Lot_2017
{
    public partial class Login : Form
    {


       
        public Login()
        {
            InitializeComponent();

        }

        private void linkCreateAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // When link is clicked. Open the CreateAccount form 
            CreateAccount frm = new CreateAccount();
            frm.Show();
            frm.PreviousForm = this;
            this.Hide();

            //Hide login page when button is clicked 
            // this.Hide();
        }

// ----------------------- TESTING BUTTONS (Login as Student, Professor, or Registrar)  ----------------------------- Kavin \\
        private void btnTestRegistrar_Click(object sender, EventArgs e)
        {
            // TEST BUTTON: REGISTRAR         

            RegistrarMenu frm = new RegistrarMenu();
            frm.Show();
            
        }

        private void btnTestProfessor_Click(object sender, EventArgs e)
        {
            // TEST BUTTON : PROFESSOR

            ProfessorMenu frm = new ProfessorMenu();
            frm.Show();

        }

        private void btnTestStudent_Click(object sender, EventArgs e)
        {
            // TEST BUTTON : STUDENT   
            StudentMenu frm = new StudentMenu();
            frm.Show();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            StudentMenu studentFrm = new StudentMenu();
            ProfessorMenu professorFrm = new ProfessorMenu();
            RegistrarMenu registrarFrm = new RegistrarMenu();

           

            string Password = txtPassword.Text;
            string UserName = txtUsername.Text;
            int UserId;
            DBOQuery Query = new DBOQuery();

            if (Int32.TryParse(UserName, out UserId))
            {
                if (Query.UserLogOn(UserId, Password) == true)
                {
                    MessageBox.Show("login succesful");
                    if (Query.GetRoleFromUserID(UserId) == "Student")
                    {
                        studentFrm.Show();
                    }
                    else if (Query.GetRoleFromUserID(UserId) == "Professor")
                    {
                        professorFrm.Show();
                    }
                    else if (Query.GetRoleFromUserID(UserId) == "Registrar")
                    {
                        registrarFrm.Show();
                    }
                }
                else MessageBox.Show("Check UserName & Password");


            }
            else MessageBox.Show("Check UserName");
        }
    }
}
