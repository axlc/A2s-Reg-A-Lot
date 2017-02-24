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
    public partial class StudentSelectCourse : Form
    {
        public StudentSelectCourse()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Closes the Select Courses window
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Move on to the confirm registration window
            StudentCourseRegistration frm = new StudentCourseRegistration();
            frm.Show();
        }
    }
}
