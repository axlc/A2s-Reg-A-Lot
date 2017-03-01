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
        /// <para>An overloaded Constructor which allows you to specify the login credentials.</para>
        /// <para>Useful for testing specifying connection information if we get an Azure Cloud
        /// server set up before the project is due.</para>
        /// </summary>
        public DBOQuery(string server, string databaseName, string userID, string password)
        {
            Connection = new SqlConnection();
            Connection.ConnectionString = string.Format("Server={0};Database={1};User ID={2};Password={3}", server, databaseName, userID, password);
        }

        /// <summary>
        /// Insert a new record into the ContactDetails Table
        /// </summary>
        /// <param name="User_ID">An int value for the user you are adding contact details to.</param>
        /// <param name="FirstName">String value for first name.</param>
        /// <param name="LastName">String value for last name.</param>
        /// <param name="AddressLine1">String value for Address Line 1.</param>
        /// <param name="AddressLine2">String value for Address Line 2.</param>
        /// <param name="AddressCity">String value for City</param>
        /// <param name="AddressState">String value for 2 letter abbreviation for state.</param>
        /// <param name="AddressZipCode">79101-1123</param>
        /// <param name="PhoneNumber">String value for Phone Number</param>
        /// <param name="FaxNumber">String value for Fax Number</param>
        /// <param name="Email">String value for Email</param>   
        /// <returns>Returns an integer value corresponding to the new records ContactDetails_ID</returns>
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
        public int InsertIntoCourses(string CourseTitle, string CourseRubric,
                                     string CourseSection, string CourseDescription,
                                     string CourseStartTime, string CourseDuration,
                                     double Tuition)
        {
            // Open the connection
            Connection.Open();

            // Create the command string
            string CommandString = string.Format("INSERT INTO dbo.Courses " +
                                                 "OUTPUT INSERTED.Course_ID " +
                                                 "VALUES ('{0}', '{1}', " +
                                                         "'{2}', '{3}', " +
                                                         "'{4}', '{5}', " +
                                                         "'{6}');",
                                                         CourseTitle, CourseRubric,
                                                         CourseSection, CourseDescription,
                                                         CourseStartTime, CourseDuration, // Use: StartTime - "3:30PM" CourseDuration - "3:00"
                                                         Tuition);

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
        /// Insert a new user into the Users Table
        /// </summary>
        /// <param name="UserPassword">A string, no more than 30 characters</param>
        /// <param name="UserType">1 for student, 2 for professor, 3 for registrar, anything else for error.</param>
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
            using (SqlCommand insertNewContactDetails = Connection.CreateCommand())
            {
                insertNewContactDetails.CommandText = CommandString;
                string id = insertNewContactDetails.ExecuteScalar().ToString();
                int.TryParse(id, out newRow_ID);
                //Console.WriteLine("DLL: newRow = {0}", newRow_ID);
            }

            // Close the connection
            Connection.Close();

            // And we're done.
            return newRow_ID;
        }
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
        // TODO: Implement (required) Select Functions, Update Functions, and Delete Functions. (Around 15 of them at most?)
        // TODO: Use Mockaroo to create testdata for Courses.
    }
}
