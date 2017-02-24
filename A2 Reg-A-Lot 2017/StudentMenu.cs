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
    public partial class StudentMenu : Form
    {
        public StudentMenu()
        {
            InitializeComponent();
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Allow Student to update their information");
            /* NEEDS:
             - Confirm Button
             - Cancel Button
             - To update the information: Name, Address, City, State, Zipcode, etc.
              */
        }

        private void btnDropCourse_Click(object sender, EventArgs e)
        {
            //Opens the Drop Courses window: StudentDropCourse
            StudentDropCourse frm = new StudentDropCourse();
            frm.Show();
        }

        private void btnRegisterCourse_Click(object sender, EventArgs e)
        {
            //Open the Course Selection window for registration
            StudentSelectCourse frm = new StudentSelectCourse();
            frm.Show();
        }
    }
}
