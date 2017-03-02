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
    public partial class StudentBilling : Form
    {
        public StudentBilling()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            //Back button closes this window
            this.Close();
        }
    }
}
