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

            // Makes Text boxes editable for end-user to update their information:
                txtFirstName.ReadOnly = false;
                txtLastName.ReadOnly = false;
                txtAddress.ReadOnly = false;
                txtCity.ReadOnly = false;
                txtState.ReadOnly = false;
                txtZipcode.ReadOnly = false;
                txtFax.ReadOnly = false;
                txtEmail.ReadOnly = false;
                txtPhone.ReadOnly = false;


            //While text boxes are editable Confirm and Cancel buttons appear
                btnConfirm.Visible = true;
                btnCancel.Visible = true;

        }

        private void btnDropCourse_Click(object sender, EventArgs e)
        {
            //Opens the Drop Courses window: StudentDropCourse
            StudentDropCourse frm = new StudentDropCourse();
            frm.Show();
            frm.PreviousForm = this;
            this.Hide();
        }

        private void btnRegisterCourse_Click(object sender, EventArgs e)
        {
            //Open the Course Selection window for registration
            StudentSelectCourse frm = new StudentSelectCourse();
            frm.Show();
            frm.PreviousForm = this;
            this.Hide();
            
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

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicking confirm should update the changes in the database, and make textboxes ReadOnly again");
            txtFirstName.ReadOnly = true;
            txtLastName.ReadOnly = true;
            txtAddress.ReadOnly = true;
            txtCity.ReadOnly = true;
            txtState.ReadOnly = true;
            txtZipcode.ReadOnly = true;
            txtFax.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtPhone.ReadOnly = true;

            //On click, it will hide Confirm & Cancel buttons:
            btnCancel.Visible = false;
            btnConfirm.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Should cancel the changes and change text boxes back to ReadOnly");
            txtFirstName.ReadOnly = true;
            txtLastName.ReadOnly = true;
            txtAddress.ReadOnly = true;
            txtCity.ReadOnly = true;
            txtState.ReadOnly = true;
            txtZipcode.ReadOnly = true;
            txtFax.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtPhone.ReadOnly = true;

            //On click, it will hide Confirm & Cancel buttons:
            btnCancel.Visible = false;
            btnConfirm.Visible = false;

        }

        private void lblStartDate_Click(object sender, EventArgs e)
        {

        }
    }
}
