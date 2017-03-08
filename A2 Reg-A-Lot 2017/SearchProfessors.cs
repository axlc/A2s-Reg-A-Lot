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
    public partial class SearchProfessors : Form
    {
        public Form PreviousForm { get; set; }
        public List<int> ProfessorId { get; private set; }

        public SearchProfessors()
        {
            InitializeComponent();
            ProfessorId = new List<int>();
        }

        private void btnSearchProfessors_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Attempt to search for professors using specified details.");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            RegistrarMenu frm = new RegistrarMenu();
            PreviousForm.Show();
            this.Close();
        }

        private void SearchProfessors_Load(object sender, EventArgs e)
        {
            DBOQuery query = new DBOQuery();


            ProfessorId = query.GetListOfRoles(2);
            string fname;
            string lname;


            foreach (int number in ProfessorId)
            {
                List<string> contactDetails = query.GetContactDetails(number);
                //studentId.Add(number);
                fname = contactDetails[0];
                lname = contactDetails[1];
                string name = fname + " " + lname;
                lbxProfessors.Items.Add(name);

            }
        }

        private void clickProfessor(object sender, EventArgs e)
        {
            MessageBox.Show("hey you clicked a different professor");
            DBOQuery Query = new DBOQuery();



            List<string> contactDetails = Query.GetContactDetails(ProfessorId[lbxProfessors.SelectedIndex]);
            string Name = contactDetails[0] + contactDetails[1];
            txtFirstName.Text = contactDetails[0];
            txtLastName.Text = contactDetails[1];
            txtAddress.Text = contactDetails[2];
            txtCity.Text = contactDetails[4];
            txtState.Text = contactDetails[5];
            txtZipcode.Text = contactDetails[6];
            txtFax.Text = contactDetails[8];
            txtEmail.Text = contactDetails[9];
            textBox2.Text = contactDetails[7];
        }
    }
}
