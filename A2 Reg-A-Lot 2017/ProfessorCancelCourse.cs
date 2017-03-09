using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Reg_A_Lot_Class_Library;

namespace A2_Reg_A_Lot_2017
{
    public partial class ProfessorCancelCourse : Form
    {
        public Form PreviousForm { get; set; }
        public List<int> CourseID { get; set; }
        int UserID = CurrentUser.user_ID;
        DBOQuery Query = new DBOQuery();
        public ProfessorCancelCourse()
        {
            InitializeComponent();
            CourseID = new List<int>();
        }

        private void btnCancelCourseP_Click(object sender, EventArgs e)
        {
            int courseID = CourseID[clbProfessorCourses.SelectedIndex];
            Query.CancelRegistrationbyUserIDandCourseID(UserID, courseID);
            MessageBox.Show("The Courses were dropped.");
            UpdateList();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Go back to ProfessorMenu
            ProfessorMenu frm = new ProfessorMenu();
            PreviousForm.Show();
            this.Close();

        }

        private void ProfessorCancelCourse_Load(object sender, EventArgs e)
        {
            UpdateList();
            
        }

        public void UpdateList()
        {

            clbProfessorCourses.Items.Clear();
            int UserID = CurrentUser.user_ID;
            clbProfessorCourses.Items.Clear();
            DBOQuery query = new DBOQuery();
            CourseID = query.GetRegisteredCoursesByUserID(UserID);

            foreach (int course in CourseID)
            {
                clbProfessorCourses.Items.Add(query.GetCourseTitleByID(course));


            }

        }


    }
}
