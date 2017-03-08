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
    public partial class CreateNewProfessor : Form
    {
        public Form PreviousForm { get; set; }
        //For Go back buttons

        public CreateNewProfessor()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Save this information as a new Professor in the database.");

            DBOQuery Query = new DBOQuery();

            string FirstName = txtFirstName.Text;
            string LastName = txtLastName.Text;
            string AddressLine = txtAddress.Text;
           
            string AddressCity = txtCity.Text;
            string AddressState = txtState.Text;
            string AddressZipCode = txtZipcode.Text;
            string FaxNumber = txtFax.Text;
            string Email = txtEmail.Text;
            string PhoneNumber = txtPhone.Text;

            if (FirstName != "" & LastName != "")
            {
                int newUserID = Query.InsertIntoUsers("TempPasswordForProfessor", 2);
                Query.InsertIntoContactDetails(newUserID, FirstName, LastName, AddressLine, null, AddressCity, AddressState, AddressZipCode, FaxNumber, Email, PhoneNumber);
            }

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Discard changes");
            PreviousForm.Show();
            this.Close();
        }
    }
}
