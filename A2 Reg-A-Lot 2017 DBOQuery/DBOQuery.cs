// Axl McCracken
// COSC-2330-001, Group A2
// DBOQuery.cs
//
// This class is an abstraction of the C# functions for database interaction
// that will relieve the user of the need to write SQL statements, and allow
// them to focus on making their code work.
//
// Work In Progress. Look for posts on Trello board for updates on this project.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data.Sql;

namespace A2_Reg_A_Lot_2017
{
    /// <summary>
    /// Axl's Class. Abstracts away the process of opening and querying the database. This class cannot be inherited.
    /// </summary>
    /// <remarks></remarks>
    public sealed class DBOQuery
    {
        private SqlConnection Connection;

        /// <summary>
        /// The Default Constructor. Automatically sets the ConnectionString to the project database.
        /// <para>TODO: Update his once we receive the login details.</para>
        /// </summary>
        public DBOQuery()
        {
            Connection = new SqlConnection();
            Connection.ConnectionString = "Server=cis1.actx.edu;Database=Project2;User Id=db2;Password=db20;";
        }
        
        /// <summary>
        /// Overloaded Constructor to allow the user to pass in the string "azure" to connect to the azure server.
        /// <para>Otherwise, connects to the actx server.</para>
        /// </summary>
        /// <param name="shortcut">pass in azure to connect to azure, pass in anything else to connect to actx server</param>
        public DBOQuery(string shortcut)
        {
            if (shortcut == "azure")
            {
                Connection = new SqlConnection();
                Connection.ConnectionString = "Server=tcp:group-a2.database.windows.net,1433;Initial Catalog=Project2;Persist Security Info=False;User ID=db2;Password=Group-A2;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            }
            else
            {
                Connection = new SqlConnection();
                Connection.ConnectionString = "Server=cis1.actx.edu;Database=Project2;User Id=db2;Password=db20;";
            }
        }

        /// <summary>
        /// Insert a new record into the ContactDetails Table
        /// </summary>
        /// <param name="User_ID">An int value for the user you are adding contact details to.</param>
        /// <param name="FirstName">Max of 50 characters.</param>
        /// <param name="LastName">Max of 50 characters.</param>
        /// <param name="AddressLine1">Max of 50 characters.</param>
        /// <param name="AddressLine2">Max of 50 characters.</param>
        /// <param name="AddressCity">Max of 35 characters.</param>
        /// <param name="AddressState">Max of 2 characters. Example: "TX"</param>
        /// <param name="AddressZipCode">Max of 10 characters. Example: "79101-1234"</param>
        /// <param name="PhoneNumber">Max of 10 characters 8069180180</param>
        /// <param name="FaxNumber">Max of 10 characters. Example: 8069184279</param>
        /// <param name="Email">Max of 255 characters.</param>
        /// <returns>Returns an integer value corresponding to the new records ContactDetail_ID</returns>
        public int InsertIntoContactDetails(int User_ID, string FirstName, string LastName,
                                             string AddressLine1, string AddressLine2, string AddressCity,
                                             string AddressState, string AddressZipCode, string PhoneNumber,
                                             string FaxNumber, string Email)
        {
            // Open the connection
            Connection.Open();

            // Create the command string
            string CommandString = string.Format("INSERT INTO dbo.ContactDetails " +
                                                 "OUTPUT INSERTED.ContactDetail_ID " +
                                                 "VALUES ('{0}', '{1}', '{2}', " +
                                                         "'{3}', '{4}', '{5}', " +
                                                         "'{6}', '{7}', '{8}', " +
                                                         "'{9}', '{10}');",
                                                         User_ID, FirstName, LastName,
                                                         AddressLine1, AddressLine2, AddressCity,
                                                         AddressState, AddressZipCode, PhoneNumber,
                                                         FaxNumber, Email);

            // To get the ID of the inserted row
            int newRow_ID = 0;
            // Do the insertion
            using (SqlCommand insertNewContactDetails = Connection.CreateCommand())
            {
                insertNewContactDetails.CommandText = CommandString;
                string id = insertNewContactDetails.ExecuteScalar().ToString();
                int.TryParse(id, out newRow_ID);
            }

            // Close the connection
            Connection.Close();

            // And we're done.
            return newRow_ID;
        }
        
        /// <summary>
        /// Insert a new record into the Courses Table
        /// </summary>
        /// <param name="CourseTitle">Max of 255 characters. Example: "Advanced Structured Languages"</param>
        /// <param name="CourseRubric">Max of 9 characters. Example: "COSC-2330"</param>
        /// <param name="CourseSection">Max of 3 characters. Example: "001"</param>
        /// <param name="CourseDescription">Max of 1024 characters.</param>
        /// <param name="CourseStartTime">A time with hours and minutes only. Example: "3:30PM"</param>
        /// <param name="CourseDuration">A duration with hours and minutes only. Example: "2:30"</param>
        /// <param name="CourseTuition">A double. Example: 250.0</param>
        /// <param name="CourseDepartment">Max of 25 characters. Example: "CIS"</param>
        /// <returns>Returns an integer value corresponding to the new records Course_ID</returns>
        public int InsertIntoCourses(string CourseTitle, string CourseRubric,
                                     string CourseSection, string CourseDescription,
                                     string CourseStartTime, string CourseDuration,
                                     double CourseTuition, string CourseDepartment)
        {
            // Open the connection
            Connection.Open();

            // Create the command string
            string CommandString = string.Format("INSERT INTO dbo.Courses " +
                                                 "OUTPUT INSERTED.Course_ID " +
                                                 "VALUES ('{0}', '{1}', " +
                                                         "'{2}', '{3}', " +
                                                         "'{4}', '{5}', " +
                                                         "'{6}', '{7}');",
                                                         CourseTitle, CourseRubric,
                                                         CourseSection, CourseDescription,
                                                         CourseStartTime, CourseDuration, // Use: StartTime - "3:30PM" CourseDuration - "3:00"
                                                         CourseTuition, CourseDepartment);

            // To get the ID of the inserted row
            int newRow_ID = 0;
            // Do the insertion
            using (SqlCommand insertNewUserCourse = Connection.CreateCommand())
            {
                insertNewUserCourse.CommandText = CommandString;
                string id = insertNewUserCourse.ExecuteScalar().ToString();
                int.TryParse(id, out newRow_ID);
            }

            // Close the connection
            Connection.Close();

            // And we're done.
            return newRow_ID;
        }

        /// <summary>
        /// Insert a new record into the Users Table
        /// </summary>
        /// <param name="UserPassword">Max of 30 characters. </param>
        /// <param name="UserType">1 for Student, 2 for Professor, 3 for Registrar, other for error.</param>
        /// <returns>Returns an integer value corresponding to the new records User_ID</returns>
        public int InsertIntoUsers(string UserPassword, int UserType)
        {
            if (UserType < 1 || UserType > 3)
            {
                throw new System.ArgumentException("UserType must be 1, 2 or 3 for Student, Professor or Registrar", "UserType");
            }
            
            // Open the connection
            Connection.Open();

            // Create the command string
            string CommandString = string.Format("INSERT INTO dbo.Users " +
                                                 "OUTPUT INSERTED.User_ID " +
                                                 "VALUES ('{0}', '{1}');",
                                                  UserPassword, UserType);

            // To get the ID of the inserted row
            int newRow_ID = 0;
            // Do the insertion
            using (SqlCommand insertNewUser = Connection.CreateCommand())
            {
                insertNewUser.CommandText = CommandString;
                string id = insertNewUser.ExecuteScalar().ToString();
                int.TryParse(id, out newRow_ID);
            }

            // Close the connection
            Connection.Close();

            // And we're done.
            return newRow_ID;
        }

        /// <summary>
        /// Insert a new record into the UserCourses Table
        /// </summary>
        /// <param name="User_ID">The user who is registering for the course.</param>
        /// <param name="Course_ID">The course the user is registering for.</param>
        /// <returns>Returns an integer value corresponding to the new records UserCourse_ID</returns>
        public int InsertIntoUserCourses(int User_ID, int Course_ID)
        {
            // Open the connection
            Connection.Open();

            // Create the command string
            string CommandString = string.Format("INSERT INTO dbo.UserCourses " +
                                                 "OUTPUT INSERTED.UserCourse_ID " +
                                                 "VALUES ('{0}', '{1}');",
                                                  User_ID, Course_ID);
            // To get the ID of the inserted row
            int newRow_ID = 0;
            // Do the insertion
            using (SqlCommand insertNewUserCourse = Connection.CreateCommand())
            {
                insertNewUserCourse.CommandText = CommandString;
                string id = insertNewUserCourse.ExecuteScalar().ToString();
                int.TryParse(id, out newRow_ID);
            }

            // Close the connection
            Connection.Close();

            // And we're done.
            return newRow_ID;
        }

        /// <summary>
        /// Check that a correct username and password were entered.
        /// </summary>
        /// <param name="User_ID"></param>
        /// <param name="password"></param>
        /// <returns>True if login succeeded, false if otherwise.</returns>
        public Boolean UserLogOn(int User_ID, string password)
        {
            Connection.Open();
            Boolean logonOutcome = false;

            string commandString = string.Format("SELECT * FROM dbo.Users WHERE User_ID='{0}' AND UserPassword='{1}';", User_ID, password);

            using (SqlCommand selectUserCredentials = Connection.CreateCommand())
            {
                selectUserCredentials.CommandText = commandString;

                int numRows = 0;
                using (SqlDataReader reader = selectUserCredentials.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        numRows++;
                    }
                }

                if(numRows == 1)
                {
                    logonOutcome = true;
                }
            }

            Connection.Close();

            return logonOutcome;
        }

        /// <summary>
        /// Get a list of all users of a certain role.
        /// </summary>
        /// <param name="userType">An integer value, 1 for students, 2 for professors 3 for registrars, other for errors.</param>
        /// <returns>A List&lt;int&gt; of User_IDs that match the given UserType. </returns>
        public List<int> GetListOfRoles(int userType)
        {
            if (userType < 1 || userType > 3)
            {
                throw new System.ArgumentException("UserType must be 1, 2 or 3 for Student, Professor or Registrar", "UserType");
            }

            Connection.Open();
            List<int> queryResults = new List<int>();

            string commandString = string.Format("SELECT [User_ID], [UserType] FROM [dbo].[Users] WHERE UserType='{0}';", userType);

            using (SqlCommand selectUsersByUserType = Connection.CreateCommand())
            {
                selectUsersByUserType.CommandText = commandString;

                using (SqlDataReader reader = selectUsersByUserType.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        queryResults.Add(reader.GetInt32(0));
                    }
                }
            }
            Connection.Close();
            return queryResults;
        }

        public List<string> GetContactDetails(int user_ID)
        {
            List<string> queryResults = new List<string>();
            Connection.Open();

            string commandString = string.Format("SELECT [FirstName], [LastName], [AddressLine1], [AddressLine2], [AddressCity], [AddressState], [AddressZipCode], [PhoneNumber], [FaxNumber], [Email] FROM [dbo].[ContactDetails] WHERE [User_ID]='{0}';", user_ID);

            using (SqlCommand selectContactDetailsByUserID = Connection.CreateCommand())
            {
                selectContactDetailsByUserID.CommandText = commandString;

                using (SqlDataReader reader = selectContactDetailsByUserID.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        for(int i = 0; i < 10; i++)
                            queryResults.Add(reader.GetString(i));
                    }
                }
            }

            Connection.Close();
            return queryResults;
        }

        public string GetRoleFromUserID(int user_ID)
        {
            int userType = 0;
            string role = "Error. Check the entered user_ID";
            Connection.Open();

            string commandString = string.Format("SELECT [UserType] FROM [dbo].[Users] WHERE [User_ID]='{0}';", user_ID);

            using (SqlCommand selectUsersByUserID = Connection.CreateCommand())
            {
                selectUsersByUserID.CommandText = commandString;

                using (SqlDataReader reader = selectUsersByUserID.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        userType = reader.GetInt32(0);
                    }
                }
            }

            if (userType == 1)
                role = "Student";
            else if (userType == 2)
                role = "Professor";
            else if (userType == 3)
                role = "Registrar";
            else
                role = "Undefined Role in Database.";

            Connection.Close();
            return role;
        }

        public int GetEnrollmentsByCourseID(int course_ID)
        {
            int enrollments = 0;
            Connection.Open();

            string commandString = string.Format("SELECT count([User_ID]) AS Enrollments FROM [dbo].[UserCourses] WHERE [Course_ID]={0} GROUP BY [Course_ID];", course_ID);

            using (SqlCommand selectUserCoursesEnrollments = Connection.CreateCommand())
            {
                selectUserCoursesEnrollments.CommandText = commandString;
                string result = selectUserCoursesEnrollments.ExecuteScalar().ToString();
                int.TryParse(result, out enrollments);
            }

            Connection.Close();
            return enrollments;
        }

        public int GetLatestCourseID()
        {
            int course_ID = 0;
            Connection.Open();

            string commandString = string.Format("SELECT [Course_ID] FROM [dbo].[Courses] ORDER BY [Course_ID] DESC");

            using (SqlCommand selectLatestCourseID = Connection.CreateCommand())
            {
                selectLatestCourseID.CommandText = commandString;
                string result = selectLatestCourseID.ExecuteScalar().ToString();
                int.TryParse(result, out course_ID);
            }
            Connection.Close();
            return course_ID;
        }

        public string GetCourseTitleByID(int course_ID)
        {
            string courseTitle = "";
            Connection.Open();

            string commandString = string.Format("SELECT [CourseTitle] FROM [dbo].[Courses] WHERE [Course_ID]='{0}';", course_ID);

            using (SqlCommand selectCourseTitlebyCourseID = Connection.CreateCommand())
            {
                selectCourseTitlebyCourseID.CommandText = commandString;

                using (SqlDataReader reader = selectCourseTitlebyCourseID.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        courseTitle = reader.GetString(0);
                    }
                }
            }

            Connection.Close();
            return courseTitle;
        }

        public List<List<string>> GetAllCourses()
        {
            List<List<string>> courses = new List<List<string>>();
            Connection.Open();

            string commandString = string.Format("SELECT * FROM [dbo].[Courses]");

            using (SqlCommand selectAllCourses = Connection.CreateCommand())
            {
                selectAllCourses.CommandText = commandString;

                using (SqlDataReader reader = selectAllCourses.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        List<string> courseDetails = new List<string>();

                        courseDetails.Add(reader.GetInt32(0).ToString());
                        courseDetails.Add(reader.GetString(1));
                        courseDetails.Add(reader.GetString(2));
                        courseDetails.Add(reader.GetString(3));
                        courseDetails.Add(reader.GetString(4));

                        TimeSpan startTime = reader.GetTimeSpan(5);
                        courseDetails.Add(startTime.ToString());

                        TimeSpan duration = reader.GetTimeSpan(6);
                        courseDetails.Add(duration.ToString());

                        courseDetails.Add(reader.GetDouble(7).ToString());
                        courseDetails.Add(reader.GetString(8));

                        courses.Add(courseDetails);
                    }
                }
            }

            Connection.Close();
            return courses;
        }
    }
}
