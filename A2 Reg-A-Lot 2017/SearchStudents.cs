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
    public partial class SearchStudents : Form
    {
        public Form PreviousForm { get; set; }
        public List<int> StudentId { get; private set; }

        public SearchStudents()
        {
            InitializeComponent();
            
            StudentId = new List<int>();
        }

        private void btnSearchStudents_Click(object sender, EventArgs e)
        {
            string rawStudentID = txtId.Text;
            int studentID = Int32.Parse(rawStudentID);
            DBOQuery Query = new DBOQuery();

            if(int.TryParse(rawStudentID, out studentID))
            {   List<string> contactDetails = Query.GetContactDetails(studentID);
                string Name =contactDetails[0]+ contactDetails[1];
                // MessageBox.Show("HEY");//MessageBox.Show(contactDetails[0]);
               

                 lbxStudents.Items.Add(Name);

                txtFirstName.Text = contactDetails[0];
                txtLastName.Text = contactDetails[1];
                txtAddress.Text = contactDetails[2];
                txtCity.Text = contactDetails[4];
                txtState.Text = contactDetails[5];
                txtZipcode.Text = contactDetails[6];
                txtFax.Text = contactDetails[8];
                txtEmail.Text = contactDetails[9];
                txtPhoneNumber.Text = contactDetails[7];


                

               
            }

            MessageBox.Show("Attempt to search for a student using specified conditions");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Back button closes this window
            ProfessorMenu frm = new ProfessorMenu();
            PreviousForm.Show();
            this.Close();
        }

        public void SearchStudents_Load(object sender, EventArgs e)
        {
            // Attempted to get list of students from the database but...there is not getStudents method - OT
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
            //lbxStudents.Item
            MessageBox.Show("hey you clicked a different student");
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
            txtPhoneNumber.Text = contactDetails[7];


        }
    }
}
