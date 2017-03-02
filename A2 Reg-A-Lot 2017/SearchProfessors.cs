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

        public SearchProfessors()
        {
            InitializeComponent();
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
    }
}
