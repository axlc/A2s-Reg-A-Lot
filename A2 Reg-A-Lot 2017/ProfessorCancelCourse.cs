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
    public partial class ProfessorCancelCourse : Form
    {
        public Form PreviousForm {get;set;}
        public ProfessorCancelCourse()
        {
            InitializeComponent();
        }

        private void btnCancelCourseP_Click(object sender, EventArgs e)
        {
            //Cancel a selected course. The courses that should be listed are ones registered to the specific professor.
            MessageBox.Show("A course from this Professor's personal list will be canceled.");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Go back to ProfessorMenu
            ProfessorMenu frm = new ProfessorMenu();
            PreviousForm.Show();
            this.Close();

        }
    }
}
