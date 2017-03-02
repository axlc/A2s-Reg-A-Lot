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
    public partial class CreateCourse : Form
    {
        public Form PreviousForm { get; set; }

        public CreateCourse()
        {
            InitializeComponent();
        }

        private void btnCreateCourse_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A Course will be created");
            // Add course to database, tec.
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            PreviousForm.Show();
            this.Close();
        }
    }
}
