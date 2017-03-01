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
    public partial class StudentCourseRegistration : Form
    {

        public Form PreviousForm { get; set; }

        public StudentCourseRegistration()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // Confirm and register courses the student has selected and send thsoe courses to their registered list of courses
            MessageBox.Show("The courses you've selected will be registered to your courses.");
            /* NEEDS:
             - Are you sure? Y/N window
             - To send selected courses to the student's list of courses if YES^
             - To possibly state the total in this window
             */
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Closes the Confirm Registration window and takes user back to course select
            // Should go back to previous form
            PreviousForm.Show();
            this.Close();
        }

        private void btnRemoveCourse_Click(object sender, EventArgs e)
        {
            // Removes the selected checklisted course(s) from the cart
            MessageBox.Show("Selected courses have been removed from the cart.");
        }
    }
}
