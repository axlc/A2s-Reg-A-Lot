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
    public partial class ProfessorMenu : Form
    {
        public ProfessorMenu()
        {
            
            InitializeComponent();
        }

        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Allow Professor to update their information.");
            /* NEEDS:
             - Confirm Button
             - Cancel Button
             - To update the information: Name, Address, City, State, Zipcode, etc.
              */
        }

        private void btnCancelCourses_Click(object sender, EventArgs e)
        {
            //Opens ProfessorCancelCourse window:
            ProfessorCancelCourse frm = new ProfessorCancelCourse();
            frm.Show();
            frm.PreviousForm = this;
            this.Hide();

            //Hides Professor Main Menu !! ------------------------------ AFTER I figure out how to make a "back" button work
            // this.Hide();
        }

        private void btnAddCourses_Click(object sender, EventArgs e)
        {
            //Button opens the ProfessorAddCourse window to allow the professor to register to teach new courses.
            ProfessorAddCourse frm = new ProfessorAddCourse();
            frm.Show();
            frm.PreviousForm = this;
            this.Hide();

            // Hides the Professor main menu
            //this.Hide();
        }

        private void btnMyStudents_Click(object sender, EventArgs e)
        {
            // View students in the professor's courses
            // Opens ProfessorMyStudents window
            ProfessorMyStudents frm = new ProfessorMyStudents();
            frm.Show();
            frm.PreviousForm = this;
            this.Hide();
        }

        private void btnStudentSearch_Click(object sender, EventArgs e)
        {
            //Button brings up the Student Search Window SearchStudents
            SearchStudents frm = new SearchStudents();
            frm.Show();
            frm.PreviousForm = this;
            this.Hide();
        }

        private void btnUpdateInfo_Click_1(object sender, EventArgs e)
        {
           



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

        private void btnConfirm_Click(object sender, EventArgs e)
        {
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

        private void ProfessorMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project2DataSet.Courses' table. You can move, or remove it, as needed.
            this.coursesTableAdapter.Fill(this.project2DataSet.Courses);
            DBOQuery Query = new DBOQuery();
            int UserID = CurrentUser.user_ID;


            List<string> contactDetails = Query.GetContactDetails(UserID);
            string Name = contactDetails[0] + contactDetails[1];
            txtFirstName.Text = contactDetails[0];
            txtLastName.Text = contactDetails[1];
            txtAddress.Text = contactDetails[2];
            txtCity.Text = contactDetails[4];
            txtState.Text = contactDetails[5];
            txtZipcode.Text = contactDetails[6];
            txtFax.Text = contactDetails[8];
            txtEmail.Text = contactDetails[9];
            txtPhone.Text = contactDetails[7];



        }
    }
}
