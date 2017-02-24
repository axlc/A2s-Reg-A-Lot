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

        private void lblFname_Click(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAddressA_Click(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDisplayCity_Click(object sender, EventArgs e)
        {

        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDisplayState_Click(object sender, EventArgs e)
        {

        }

        private void txtState_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDisplayZipCode_Click(object sender, EventArgs e)
        {

        }

        private void txtZipcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDisplayFax_Click(object sender, EventArgs e)
        {
            
        }

        private void txtFax_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDisplayEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
