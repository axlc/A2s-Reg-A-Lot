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
    public partial class CreateNewRegistrar : Form
    {
        public CreateNewRegistrar()
        {
            InitializeComponent();
        }

        public UpdateRegistrar PreviousForm { get; internal set; }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            // Saves the information types in the text boxes


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
                int newUserID = Query.InsertIntoUsers("TempPasswordForRegistrar", 3);
                Query.InsertIntoContactDetails(newUserID, FirstName, LastName, AddressLine, null, AddressCity, AddressState, AddressZipCode, FaxNumber, Email, PhoneNumber);
            }

        }

    }
}