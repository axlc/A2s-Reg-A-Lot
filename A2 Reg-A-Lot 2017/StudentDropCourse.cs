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

    public partial class StudentDropCourse : Form

    {
        public Form PreviousForm { get; set; }
        public List<int> CourseID { get; set; }
        int UserID = CurrentUser.user_ID;
        DBOQuery Query = new DBOQuery();
        public StudentDropCourse()
        {
            InitializeComponent();
            CourseID = new List<int>();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            StudentMenu frm = new StudentMenu();
            PreviousForm.Show(); 
            this.Close();
        }

        private void btnConfirmDrop_Click(object sender, EventArgs e)
        {
            //String CourseTitle = clbMyCourses.Text;

            int courseID = CourseID[clbMyCourses.SelectedIndex];
            Query.CancelRegistrationbyUserIDandCourseID(UserID, courseID);
            MessageBox.Show("The Courses were dropped.");
            UpdateList();
         
        }

        private void gbxLMyCourses_Enter(object sender, EventArgs e)
        {

        }

        private void clbMyCourses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void UpdateList()
        {
            clbMyCourses.Items.Clear();
            int UserID = CurrentUser.user_ID;
            clbMyCourses.Items.Clear();
            DBOQuery query = new DBOQuery();
            CourseID = query.GetRegisteredCoursesByUserID(UserID);

            foreach (int course in CourseID)
            {
                clbMyCourses.Items.Add(query.GetCourseTitleByID(course));


            }

        }

        private void StudentDropCourse_Load(object sender, EventArgs e)
        {
            UpdateList();
        }
    }
}
