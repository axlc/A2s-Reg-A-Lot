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
      public Form PreviousForm { get; set; }

        public StudentSelectCourse()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            //Move on to the confirm registration window
            StudentCourseRegistration frm = new StudentCourseRegistration();
            frm.Show();
            frm.PreviousForm = this;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Add selected courses to the courses to be added to the cart (Bottom window)
            MessageBox.Show("Add courses to the cart.");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            StudentMenu frm = new StudentMenu();
            PreviousForm.Show();
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
