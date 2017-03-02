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
  
    public partial class RegistrarCourseManager : Form
    {

        public Form PreviousForm { get; set; }

        public RegistrarCourseManager()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // Take user back to Registrar Menu (Close this window)
            PreviousForm.Show();
            this.Close();
        }

        private void btnCancelCourse_Click(object sender, EventArgs e)
        {
            // This will allow the registrar to add a selected course to the list of cancelled courses
            MessageBox.Show("Selected Course moves to the cancelled courses list below.");
        }

        private void btnCreateCourse_Click(object sender, EventArgs e)
        {
            CreateCourse frm = new CreateCourse();
            frm.PreviousForm = this;
            frm.Show();
            this.Hide();
        }

        private void btnResumeCourse_Click(object sender, EventArgs e)
        {
            // This will allow the registrar to "uncancel" or resume a course they select in the canceled courses list
            MessageBox.Show("A selected cancelled course will resume, and students can register for it.");
        }

        private void btnDeleteCourse_Click(object sender, EventArgs e)
        {
            // Allows for Registrar to delete a cancelled course
            MessageBox.Show("The selected cancelled course will be deleted. / Are you sure? window probably needed.");
        }
    }
}
