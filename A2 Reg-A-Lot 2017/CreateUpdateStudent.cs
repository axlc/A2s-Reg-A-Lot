﻿using System;
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
    public partial class CreateUpdateStudent : Form
    {
        public CreateUpdateStudent()
        {
            InitializeComponent();
        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The textboxes should become editable.");
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

            // Confirm & Cancel buttons will appear when text boxes become editable
            btnConfirm.Visible = true;
            btnCancel.Visible = true;
        }

        private void btnCreateStudent_Click(object sender, EventArgs e)
        {
            // The text boxes should become editable and allow for the creation of a new Student to add to the database or so
            // Basically using the same Confirm and Cancel idea as above in the Idea 1 comment ^ Assuming that works
            MessageBox.Show("Should allow for the creation of a new Student.");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Closes the window
            this.Close();
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
    }
}
