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
    public partial class ProfessorMyStudents : Form
    {
        public Form PreviousForm { get; set; }
        public ProfessorMyStudents()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Back button closes the My Students Window
            ProfessorMenu frm = new ProfessorMenu();
            PreviousForm.Show();
            this.Close();
        }

        private void ProfessorMyStudents_Load(object sender, EventArgs e)
        {
            //// Attempted to get list of students from the database but...there is not getStudents method - OT
            //DBOQuery query = new DBOQuery();
            //int id = 0;
            //string fName;
            //string lName;
            //List<int> studentId = query.GetListOfRoles(1);
            //foreach (int number in studentId)
            //{
            //    List<string> contactDetails = query.GetContactDetails(number);
            //    string name = contactDetails[0] + contactDetails[1];
            //    lstMyStudents.Items.Add(name);
            //}



            ////string Name = contactDetails[0] + contactDetails[1];


        }

        //This is the search button
        private void button1_Click(object sender, EventArgs e)
        {
            //string name = txtStudentName.Text;  Attempt to search by name - OT
            string rawStudentID = txtStudentID.Text;
            int studentID = Int32.Parse(rawStudentID);
            DBOQuery Query = new DBOQuery();

            if (int.TryParse(rawStudentID, out studentID))
            {
                List<string> contactDetails = Query.GetContactDetails(studentID);
                string Name = contactDetails[0] + contactDetails[1];
                // MessageBox.Show("HEY");//MessageBox.Show(contactDetails[0]);
            }
 
           
            MessageBox.Show("Attempt to search for a student using specified conditions");
        }
    }
}
