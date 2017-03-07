﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Reg_A_Lot_Class_Library;

namespace A2_Reg_A_Lot_2017
{
    public partial class UpdateProfessor : Form
    {
        public Form PreviousForm { get; set; }
        public UpdateProfessor()
        {
            InitializeComponent();
        }

        private void btnEditProfessor_Click(object sender, EventArgs e)
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

        private void btnCreateProfessor_Click(object sender, EventArgs e)
        {
            CreateNewProfessor frm = new CreateNewProfessor();
            frm.Show();
            frm.PreviousForm = this;
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            RegistrarMenu frm = new RegistrarMenu();
            PreviousForm.Show();
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Clicking confirm should update the changes in the database, and make textboxes ReadOnly again");

            DBOQuery query = new DBOQuery();
            List<string> rawDetails = new List<string>();
            // This adds all the text from the fields from the form into a list.
            rawDetails.Add(txtFirstName.Text);
            rawDetails.Add(txtLastName.Text);
            rawDetails.Add(txtAddress.Text);
            rawDetails.Add(null);
            rawDetails.Add(txtCity.Text);
            rawDetails.Add(txtState.Text);
            rawDetails.Add(txtZipcode.Text);
            rawDetails.Add(txtPhone.Text);
            rawDetails.Add(txtFax.Text);
            rawDetails.Add(txtEmail.Text);
            
            // Takes the list and updates it into the database, based on the current user id
            query.UpdateUserContactDetails(CurrentUser.user_ID, rawDetails);

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
