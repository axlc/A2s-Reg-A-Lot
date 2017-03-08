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
        public Form PreviousForm {get;set;}
        public ProfessorCancelCourse()
        {
            InitializeComponent();
        }

        private void btnCancelCourseP_Click(object sender, EventArgs e)
        {
            DBOQuery Query = new DBOQuery();
            int UserID = CurrentUser.user_ID;
            String CourseTitle = clbProfessorCourses.Text;

            int courseID = Query.GetCourseIDbyTitle(CourseTitle);
            MessageBox.Show(CourseTitle);

            MessageBox.Show(courseID.ToString());

            Query.CancelRegistrationbyUserIDandCourseID(UserID, courseID);

            //Cancel a selected course. The courses that should be listed are ones registered to the specific professor.
            MessageBox.Show("A course from this Professor's personal list will be canceled.");
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
            // tried to populate the course list for the professor -OT.
            clbProfessorCourses.Items.Clear();
            DBOQuery query = new DBOQuery();
            List<List<string>> courses = query.GetAllCourses();
            foreach (var course in query.GetAllCourses())
            {
                //courses.Add(course);
                clbProfessorCourses.Items.Add(course[1]);
            }
        }
    }
}
