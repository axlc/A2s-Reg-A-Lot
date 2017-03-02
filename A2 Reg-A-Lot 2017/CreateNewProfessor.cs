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
            MessageBox.Show("Save this information as a new Professor in the database.");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Discard changes");
            PreviousForm.Show();
            this.Close();
        }
    }
}
