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
    public partial class CreateNewStudent : Form
    {

        public Form PreviousForm { get; set; }

        public CreateNewStudent()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Create a new student in the database");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            UpdateStudent frm = new UpdateStudent();
            PreviousForm.Show();
            this.Close();
        }

    }
}
