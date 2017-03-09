using System;
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
    public partial class UpdateStudent : Form
    {
        public Form PreviousForm { get; set; }
        public List<int> StudentId { get; private set; }

        public UpdateStudent()
        {
            InitializeComponent();
            StudentId = new List<int>();
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
            CreateNewStudent frm = new CreateNewStudent();
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

        private void UpdateStudent_Load(object sender, EventArgs e)
        {
            DBOQuery query = new DBOQuery();


            StudentId = query.GetListOfRoles(1);
            string fname;
            string lname;


            foreach (int number in StudentId)
            {
                List<string> contactDetails = query.GetContactDetails(number);
                //studentId.Add(number);
                fname = contactDetails[0];
                lname = contactDetails[1];
                string name = fname + " " + lname;
                lbxStudents.Items.Add(name);

            }
        }

        private void clickStudentList(object sender, EventArgs e)
        {
            DBOQuery Query = new DBOQuery();



            List<string> contactDetails = Query.GetContactDetails(StudentId[lbxStudents.SelectedIndex]);
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
