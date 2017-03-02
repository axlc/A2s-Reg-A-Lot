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
    public partial class ProfessorAddCourse : Form
    {
        public Form PreviousForm { get; set; }
        public ProfessorAddCourse()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            // A Professor has chosen to register for a new course to teach
            MessageBox.Show("The selected course will be added to your courses.");
            /* NEEDS:
            - Is this okay? Y/N Window 
            - To Add courses to Professor's list of courses.
            - Error message if no course was selected
            */
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Back button hides this window
            ProfessorMenu frm = new ProfessorMenu();
            PreviousForm.Show();
            this.Close();
        }
    }
}
