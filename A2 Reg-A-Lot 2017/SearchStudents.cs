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
    public partial class SearchStudents : Form
    {
        public Form PreviousForm { get; set; }

        public SearchStudents()
        {
            InitializeComponent();
        }

        private void btnSearchStudents_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Attempt to search for a student using specified conditions");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Back button closes this window
            ProfessorMenu frm = new ProfessorMenu();
            PreviousForm.Show();
            this.Close();
        }
    }
}
