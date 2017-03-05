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
            DBOQuery Query = new DBOQuery();

            string CourseTitle = txtNewCourseTitle.Text;
            string CourseRubric = txtNewCourseCode.Text;
            string CourseSection = txtNewcourseSection.Text;
            string CourseStartTime = txtNewCourseStart.Text;
            string CourseDuration = txtNewCourseDuration.Text;
            string rawCourseTuition = txtNewCourseTuition.Text;
            double CourseTuition;
            string CourseDepartment = txtDepartment.Text;
            string CourseDescription = rtbNewCourseDescription.Text;


            while (CourseTitle != "" & CourseRubric != "" & CourseSection != "" & CourseStartTime != ""
                & CourseStartTime != "" & CourseDuration != "" & rawCourseTuition != ""
                & CourseDepartment != "" & CourseDescription != "")
            {

                if (Double.TryParse(rawCourseTuition, out CourseTuition))
                {
                    Query.InsertIntoCourses(CourseTitle, CourseRubric, CourseSection, CourseDescription, CourseStartTime, CourseDuration, CourseTuition, CourseDepartment);
                    break;
                }
                else
                {
                    MessageBox.Show("Course Tuition is not a number");
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            PreviousForm.Show();
            this.Close();
        }

        private void txtNewCourseStartDate_Click(object sender, EventArgs e)
        {

        }
    }
}
