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
    public partial class StudentDropCourse : Form

    {
        public Form PreviousForm { get; set; }

        public StudentDropCourse()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            StudentMenu frm = new StudentMenu();
            PreviousForm.Show(); 
            this.Close();
        }

        private void btnConfirmDrop_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The Courses were dropped.");
            this.Close();
        }

        private void gbxLMyCourses_Enter(object sender, EventArgs e)
        {

        }

        private void clbMyCourses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
