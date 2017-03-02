using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A2_Reg_A_Lot_2017
{
    public partial class RegistrarMenu : Form
    {

        public RegistrarMenu()
        {
            InitializeComponent();
        }

        private void btnManageCourses_Click(object sender, EventArgs e)
        {
            //Opens the Course Manager Window
            RegistrarCourseManager frm = new RegistrarCourseManager();
            frm.Show();
            frm.PreviousForm = this;
            this.Hide();
        }

        private void btnProfessorSearch_Click(object sender, EventArgs e)
        {
            //Opens the Professor Search Window
            SearchProfessors frm = new SearchProfessors();
            frm.Show();
            frm.PreviousForm = this;
            this.Hide();
        }

        private void btnStudentSearch_Click(object sender, EventArgs e)
        {
            //Opens the Student Search Window
            // To show studend information
            SearchStudents frm = new SearchStudents();
            frm.Show();
            frm.PreviousForm = this;
            this.Hide();
        }

        private void btnModifyProfessor_Click(object sender, EventArgs e)
        {
            //Opens window to create new professors or modify existing ones
            UpdateProfessor frm = new UpdateProfessor();
            frm.Show();
            frm.PreviousForm = this;
            this.Hide();
        }

        private void btnModifyStudent_Click(object sender, EventArgs e)
        {
            // Opens the UpdateStudent window to allow for editing of student info or creationg of a new student
            UpdateStudent frm = new UpdateStudent();
            frm.PreviousForm = this;
            frm.Show();
            this.Hide();

        }

        private void RegistrarMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            StudentBilling frm = new StudentBilling();
            frm.Show();
        }
    }
}
