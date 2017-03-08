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
            // Attempted to get list of students from the database but...there is not getStudents method - OT
            DBOQuery query = new DBOQuery();
            int id = 0;
            string fName;
            string lName;

            //foreach( string contact )
            //List<string> contactDetails = query.GetContactDetails(1);
            //string Name = contactDetails[0] + contactDetails[1];
            

        }
    }
}
