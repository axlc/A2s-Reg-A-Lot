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
    public partial class ProfessorMenu : Form
    {
        public ProfessorMenu()
        {
            InitializeComponent();
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Allow Professor to update their information.");
            /* NEEDS:
             - Confirm Button
             - Cancel Button
             - To update the information: Name, Address, City, State, Zipcode, etc.
              */
        }

        private void btnCancelCourses_Click(object sender, EventArgs e)
        {
            //Opens ProfessorCancelCourse window
            ProfessorCancelCourse frm = new ProfessorCancelCourse();
            frm.Show();

            //Hides Professor Main Menu !! ------------------------------ AFTER I figure out how to make a "back" button work
            // this.Hide();
        }

        private void btnAddCourses_Click(object sender, EventArgs e)
        {
            //Button opens the ProfessorAddCourse window to allow the professor to register to teach new courses.
            ProfessorAddCourse frm = new ProfessorAddCourse();
            frm.Show();

            // Hides the Professor main menu
            //this.Hide();
        }

        private void btnMyStudents_Click(object sender, EventArgs e)
        {
            // View students in the professor's courses
            // Opens ProfessorMyStudents window
            ProfessorMyStudents frm = new ProfessorMyStudents();
            frm.Show();
        }

        private void btnStudentSearch_Click(object sender, EventArgs e)
        {
            //Button brings up the Student Search Window SearchStudents
            SearchStudents frm = new SearchStudents();
            frm.Show();

        }
    }
}
