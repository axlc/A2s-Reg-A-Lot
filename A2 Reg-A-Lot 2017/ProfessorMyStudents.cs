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
    }
}
