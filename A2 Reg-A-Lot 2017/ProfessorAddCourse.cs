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
    public partial class ProfessorAddCourse : Form
    {
        public Form PreviousForm { get; set; }
        public ProfessorAddCourse()
        {
            InitializeComponent();
            DBOQuery Query = new DBOQuery();
            Query.GetAllCourses();
            List<List<string>> courses = Query.GetAllCourses();
            clbAllNewCourses.Items.Add(courses);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {   DBOQuery Query = new DBOQuery();
            int UserID = CurrentUser.user_ID;
           
            String CourseTitle = clbAllNewCourses.Text;
          int courseID = Query.GetCourseIDbyTitle(CourseTitle);
MessageBox.Show(CourseTitle);
            
            MessageBox.Show(courseID.ToString());

            Query.InsertIntoUserCourses(UserID,courseID);

            // A Professor has chosen to register for a new course to teach
            
            /* NEEDS:
            - Is this okay? Y/N Window 
            - To Add courses to Professor's list of courses.
            - Error message if no course was selected
            */
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Back button hides this window
            ProfessorMenu frm = new ProfessorMenu();
            PreviousForm.Show();
            this.Close();
        }

        private void ProfessorAddCourse_Load(object sender, EventArgs e)
        {
            // tried to populate the course list for the professor -OT.
            clbAllNewCourses.Items.Clear();
            DBOQuery query = new DBOQuery();
            List<List<string>> courses = query.GetAllCourses();
            foreach (var course in query.GetAllCourses())
            {
                //courses.Add(course);
                clbAllNewCourses.Items.Add(course[1]);
            }
            
        }

        private void clbAllNewCourses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
