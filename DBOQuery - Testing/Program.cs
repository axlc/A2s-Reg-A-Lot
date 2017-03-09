using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A2_Reg_A_Lot_2017;


// TODO: Implement (required) Select Functions, Update Functions, and Delete Functions. (Around 15 of them at most?)
// TODO: Implement the cancellation of courses by the registrar
// TODO: Update the ERD and upload it to trello.


namespace DBOQuery___Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Connect to the azure server, if at school, remove "azure" and leave parentheses blank to connect to school.
            DBOQuery TestFunctions = new DBOQuery();

            // Decide which tests to perform by changing the boolean values. 
            bool[] testsToPerform = new bool[15] {
                // Add New Users and Contact Details:
                false,
                
                // Log On:
                false,

                // Add New Courses and Registrations:
                false,

                // Get a list of User_IDs for all Students, Professors and Registrars
                false,

                // Get the contact details for a given User_ID
                true,

                // Get the role for a given User_ID
                false,

                // Display Courses with Openings
                false,

                // Get the CourseTitle for a given Course_ID
                false,

                // Get a list of all course information
                false,

                // Get a list of all courses that have an enrollment of less than 'x'
                false,

                // Get the bill information for a specific user
                false,

                // Update contact info for a given user
                false,

                // Get a list of courses without a professor
                false,

                // Get the professor who teaches a course by course_id
                false,

                // Get list of course ids by student id
                false
            };

            // Add New Users and Contact Details:
            if (testsToPerform[0])
            {
                int newUser_ID = 0;

                newUser_ID = TestFunctions.InsertIntoUsers("thisisapassword", 2);
                int User_ID = newUser_ID;
                string FirstName = "This Isa";
                string LastName = "Users Name";
                string AddressLine1 = "121 anywhere street";
                string AddressLine2 = "";
                string AddressCity = "Bob Town"; // This is a real city?! Wow.
                string AddressState = "TX";
                string AddressZipCode = "76458";
                string PhoneNumber = "9403033031";
                string FaxNumber = "";
                string Email = "robert@bobtown.tx.gov";
                TestFunctions.InsertIntoContactDetails(User_ID, FirstName, LastName,
                              AddressLine1, AddressLine2, AddressCity, AddressState,
                              AddressZipCode, PhoneNumber, FaxNumber, Email);


                newUser_ID = TestFunctions.InsertIntoUsers("joeStudentsPassword", 1);
                User_ID = newUser_ID;
                FirstName = "Joe";
                LastName = "Student";
                AddressLine1 = "122 anywhere street";
                AddressLine2 = "";
                AddressCity = "Bob Town"; // This is a real city?! Wow.
                AddressState = "TX";
                AddressZipCode = "76458";
                PhoneNumber = "9403033032";
                FaxNumber = "";
                Email = "joe@bobtowncollege.com";
                TestFunctions.InsertIntoContactDetails(User_ID, FirstName, LastName,
                              AddressLine1, AddressLine2, AddressCity, AddressState,
                              AddressZipCode, PhoneNumber, FaxNumber, Email);


                newUser_ID = TestFunctions.InsertIntoUsers("bobProfessorsPassword", 2);
                User_ID = newUser_ID;
                FirstName = "Bob";
                LastName = "Professor";
                AddressLine1 = "123 anywhere street";
                AddressLine2 = "";
                AddressCity = "Bob Town"; // This is a real city?! Wow.
                AddressState = "TX";
                AddressZipCode = "76458";
                PhoneNumber = "9403033033";
                FaxNumber = "";
                Email = "bob@bobtowncollege.com";
                TestFunctions.InsertIntoContactDetails(User_ID, FirstName, LastName,
                              AddressLine1, AddressLine2, AddressCity, AddressState,
                              AddressZipCode, PhoneNumber, FaxNumber, Email);


                newUser_ID = TestFunctions.InsertIntoUsers("paulRegistrarPassword", 3);
                User_ID = newUser_ID;
                FirstName = "Paul";
                LastName = "Registrar";
                AddressLine1 = "124 anywhere street";
                AddressLine2 = "";
                AddressCity = "Bob Town"; // This is a real city?! Wow.
                AddressState = "TX";
                AddressZipCode = "76458";
                PhoneNumber = "9403033034";
                FaxNumber = "";
                Email = "paul@bobtowncollege.com";
                TestFunctions.InsertIntoContactDetails(User_ID, FirstName, LastName,
                              AddressLine1, AddressLine2, AddressCity, AddressState,
                              AddressZipCode, PhoneNumber, FaxNumber, Email);


                newUser_ID = TestFunctions.InsertIntoUsers("julieStudentsPassword", 1);
                User_ID = newUser_ID;
                FirstName = "Julie";
                LastName = "Student";
                AddressLine1 = "125 anywhere street";
                AddressLine2 = "";
                AddressCity = "Bob Town"; // This is a real city?! Wow.
                AddressState = "TX";
                AddressZipCode = "76458";
                PhoneNumber = "9403033035";
                FaxNumber = "";
                Email = "julie@bobtowncollege.com";
                TestFunctions.InsertIntoContactDetails(User_ID, FirstName, LastName,
                              AddressLine1, AddressLine2, AddressCity, AddressState,
                              AddressZipCode, PhoneNumber, FaxNumber, Email);


                newUser_ID = TestFunctions.InsertIntoUsers("barbProfessorsPassword", 2);
                User_ID = newUser_ID;
                FirstName = "Barb";
                LastName = "Professor";
                AddressLine1 = "126 anywhere street";
                AddressLine2 = "";
                AddressCity = "Bob Town"; // This is a real city?! Wow.
                AddressState = "TX";
                AddressZipCode = "76458";
                PhoneNumber = "9403033036";
                FaxNumber = "";
                Email = "barb@bobtowncollege.com";
                TestFunctions.InsertIntoContactDetails(User_ID, FirstName, LastName,
                              AddressLine1, AddressLine2, AddressCity, AddressState,
                              AddressZipCode, PhoneNumber, FaxNumber, Email);


                newUser_ID = TestFunctions.InsertIntoUsers("pamRegistrarsPassword", 3);
                User_ID = newUser_ID;
                FirstName = "Pam";
                LastName = "Registrar";
                AddressLine1 = "127 anywhere street";
                AddressLine2 = "";
                AddressCity = "Bob Town"; // This is a real city?! Wow.
                AddressState = "TX";
                AddressZipCode = "76458";
                PhoneNumber = "9403033037";
                FaxNumber = "";
                Email = "pam@bobtowncollege.com";
                TestFunctions.InsertIntoContactDetails(User_ID, FirstName, LastName,
                              AddressLine1, AddressLine2, AddressCity, AddressState,
                              AddressZipCode, PhoneNumber, FaxNumber, Email);
            }

            // Log On:
            if (testsToPerform[1])
            {
                Console.WriteLine("Expecting Login Success");
                int user_id = 2;
                string password = "joeStudentsPassword";
                if (TestFunctions.UserLogOn(user_id, password))
                {
                    Console.WriteLine("Logon Successful!");
                }
                else
                {
                    Console.WriteLine("Login Failure!");
                }
                Console.ReadKey();

                user_id = -1;
                password = "nonsensical gibberish";
                Console.WriteLine("\nExpecting Login Failure");
                if (TestFunctions.UserLogOn(user_id, password))
                {
                    Console.WriteLine("Logon Successful!");
                }
                else
                {
                    Console.WriteLine("Login Failure!");
                }
                Console.ReadKey();

                user_id = 3;
                password = "nonsensical gibberish";
                Console.WriteLine("\nExpecting Login Failure");
                if (TestFunctions.UserLogOn(user_id, password))
                {
                    Console.WriteLine("Logon Successful!");
                }
                else
                {
                    Console.WriteLine("Login Failure!");
                }
                Console.ReadKey();

                user_id = -1;
                password = "thisisapassword";
                Console.WriteLine("\nExpecting Login Failure");
                if (TestFunctions.UserLogOn(user_id, password))
                {
                    Console.WriteLine("Logon Successful!");
                }
                else
                {
                    Console.WriteLine("Login Failure!");
                }
                Console.ReadKey();
            }

            // Add New Courses and Registrations:
            if (testsToPerform[2])
            {
                List<int> Course_IDs = new List<int>();
                // Set the details
                //string CourseTitle = "The Beginning of Bob Town";
                //string CourseRubric = "HIST-0101";
                //string CourseSection = "001";
                //string CourseDescription = "A brief history of Bob Town";
                //string CourseStartTime = "8:00AM";
                //string CourseDuration = "1:45";
                //double CourseTuition = 250;
                //string CourseDepartment = "History";
                ////Add the course to the database
                ////Course_IDs.Add(TestFunctions.InsertIntoCourses(CourseTitle, CourseRubric, CourseSection, CourseDescription,
                ////                                               CourseStartTime, CourseDuration, CourseTuition, CourseDepartment));


                //// Set the details
                //CourseTitle = "Introduction to College Algebra";
                //CourseRubric = "MATH-0101";
                //CourseSection = "001";
                //CourseDescription = "Algebraic!";
                //CourseStartTime = "10:00AM";
                //CourseDuration = "1:45";
                //CourseTuition = 250;
                //CourseDepartment = "Mathematics";
                ////Add the course to the database
                ////Course_IDs.Add(TestFunctions.InsertIntoCourses(CourseTitle, CourseRubric, CourseSection, CourseDescription,
                ////                                               CourseStartTime, CourseDuration, CourseTuition, CourseDepartment));

                //// Set the details
                //CourseTitle = "Basic Writing";
                //CourseRubric = "ENGL-0150";
                //CourseSection = "001";
                //CourseDescription = "LERN HOW RIGHT GOODER";
                //CourseStartTime = "12:00PM";
                //CourseDuration = "1:45";
                //CourseTuition = 250;
                //CourseDepartment = "English";
                ////Add the course to the database
                ////Course_IDs.Add(TestFunctions.InsertIntoCourses(CourseTitle, CourseRubric, CourseSection, CourseDescription,
                ////                                               CourseStartTime, CourseDuration, CourseTuition, CourseDepartment));


                //// Set the details
                //CourseTitle = "Advanced Structured Languages";
                //CourseRubric = "COSC-2330";
                //CourseSection = "001";
                //CourseDescription = "Further applications of programming techniques. Topics may include file access methods, data structures and modular programming, program testing and documentation, and other topics not normally covered in an introductory computer programming course.";
                //CourseStartTime = "2:00PM";
                //CourseDuration = "1:45";
                //CourseTuition = 250;
                //CourseDepartment = "CIS";
                ////Add the course to the database
                ////Course_IDs.Add(TestFunctions.InsertIntoCourses(CourseTitle, CourseRubric, CourseSection, CourseDescription,
                ////                                               CourseStartTime, CourseDuration, CourseTuition, CourseDepartment));

                //// Set the details
                //CourseTitle = "The Beginning of Bob Town";
                //CourseRubric = "HIST-0101";
                //CourseSection = "002";
                //CourseDescription = "A brief history of Bob Town";
                //CourseStartTime = "8:00AM";
                //CourseDuration = "1:45";
                //CourseTuition = 250;
                //CourseDepartment = "History";
                ////Add the course to the database
                ////Course_IDs.Add(TestFunctions.InsertIntoCourses(CourseTitle, CourseRubric, CourseSection, CourseDescription,
                ////                                               CourseStartTime, CourseDuration, CourseTuition, CourseDepartment));


                //// Set the details
                //CourseTitle = "Introduction to College Algebra";
                //CourseRubric = "MATH-0101";
                //CourseSection = "002";
                //CourseDescription = "Algebraic!";
                //CourseStartTime = "10:00AM";
                //CourseDuration = "1:45";
                //CourseTuition = 250;
                //CourseDepartment = "Mathematics";
                ////Add the course to the database
                ////Course_IDs.Add(TestFunctions.InsertIntoCourses(CourseTitle, CourseRubric, CourseSection, CourseDescription,
                ////                                               CourseStartTime, CourseDuration, CourseTuition, CourseDepartment));

                //// Set the details
                //CourseTitle = "Basic Writing";
                //CourseRubric = "ENGL-0150";
                //CourseSection = "002";
                //CourseDescription = "LERN HOW RIGHT GOODER";
                //CourseStartTime = "12:00PM";
                //CourseDuration = "1:45";
                //CourseTuition = 250;
                //CourseDepartment = "English";
                ////Add the course to the database
                ////Course_IDs.Add(TestFunctions.InsertIntoCourses(CourseTitle, CourseRubric, CourseSection, CourseDescription,
                ////                                               CourseStartTime, CourseDuration, CourseTuition, CourseDepartment));


                //// Set the details
                //CourseTitle = "Advanced Structured Languages";
                //CourseRubric = "COSC-2330";
                //CourseSection = "002";
                //CourseDescription = "Further applications of programming techniques. Topics may include file access methods, data structures and modular programming, program testing and documentation, and other topics not normally covered in an introductory computer programming course.";
                //CourseStartTime = "2:00PM";
                //CourseDuration = "1:45";
                //CourseTuition = 250;
                //CourseDepartment = "CIS";
                //Add the course to the database
                //Course_IDs.Add(TestFunctions.InsertIntoCourses(CourseTitle, CourseRubric, CourseSection, CourseDescription,
                //                                               CourseStartTime, CourseDuration, CourseTuition, CourseDepartment));

                // Perform Registration. For now, every student will attend every class.
                // The business logic is where we'll start testing to see if there are schedule conflicts.
                int holder = 0;

                for (int i = 1; i <= 8; i++)
                {
                    if (i % 2 == 0)
                        Course_IDs.Add(i);
                }


                for (int i = 1; i <= 8; i++)
                    Course_IDs.Add(i);


                foreach (var course in Course_IDs)
                {
                    holder = TestFunctions.InsertIntoUserCourses(2, course);
                    Console.WriteLine("New Record ID: {0}", holder);

                    holder = TestFunctions.InsertIntoUserCourses(5, course);
                    Console.WriteLine("New Record ID: {0}", holder);

                    //holder = TestFunctions.InsertIntoUserCourses(23, course);
                    //Console.WriteLine("New Record ID: {0}", holder);

                    //holder = TestFunctions.InsertIntoUserCourses(26, course);
                    //Console.WriteLine("New Record ID: {0}", holder);

                    //holder = TestFunctions.InsertIntoUserCourses(30, course);
                    //Console.WriteLine("New Record ID: {0}", holder);

                    //holder = TestFunctions.InsertIntoUserCourses(33, course);
                    //Console.WriteLine("New Record ID: {0}", holder);

                    Console.ReadKey();
                }
            }

            // Get a list of User_IDs for all Students, Professors and Registrars
            if (testsToPerform[3])
            {
                Console.WriteLine("Students:");
                foreach (int User_ID in TestFunctions.GetListOfRoles(1))
                {
                    Console.WriteLine("{0}", User_ID);
                }
                Console.ReadKey();
                Console.WriteLine("Professors:");
                foreach (int User_ID in TestFunctions.GetListOfRoles(2))
                {
                    Console.WriteLine("{0}", User_ID);
                }
                Console.ReadKey();
                Console.WriteLine("Registrars:");
                foreach (int User_ID in TestFunctions.GetListOfRoles(3))
                {
                    Console.WriteLine("{0}", User_ID);
                }
                Console.ReadKey();
            }

            // Get the contact details for a given User_ID
            if (testsToPerform[4])
            {
                List<string> labels = new List<string>();
                labels.Add("FirstName");
                labels.Add("LastName");
                labels.Add("AddressLine1");
                labels.Add("AddressLine2");
                labels.Add("AddressCity");
                labels.Add("AddressState");
                labels.Add("AddressZipCode");
                labels.Add("PhoneNumber");
                labels.Add("FaxNumber");
                labels.Add("Email");

                int i = 0;
                foreach (string contactDetail in TestFunctions.GetContactDetails(8))
                {
                    Console.WriteLine("{0}: {1}", labels[i++], contactDetail);
                }
                Console.ReadKey();
            }

            // Get the role for a given User_ID
            if (testsToPerform[5])
            {
                Console.WriteLine("Should display like below:\nStudent\nProfessor\nRegistrar\n");
                Console.WriteLine(TestFunctions.GetRoleFromUserID(2));
                Console.WriteLine(TestFunctions.GetRoleFromUserID(3));
                Console.WriteLine(TestFunctions.GetRoleFromUserID(4));
                Console.ReadKey();
            }

            // Display Courses with Openings
            if (testsToPerform[6])
            {
                Console.WriteLine("Courses with Openings: ");
                int upperBound = TestFunctions.GetLatestCourseID();
                for (int i = 1; i <= upperBound; i++)
                {
                    int currentEnrollment = TestFunctions.GetEnrollmentsByCourseID(i);
                    int freeSpaces = 10 - currentEnrollment;
                    if (freeSpaces > 0)
                    {
                        Console.WriteLine("Course_ID {0} has {1} space(s) remaining.", i, freeSpaces);
                    }
                    else
                    {
                        Console.WriteLine("Course_ID {0} has {1} spaces filled. (Class is full)", i, currentEnrollment);
                    }
                }

                Console.ReadKey();
            }

            // Get the CourseTitle for a given Course_ID
            if (testsToPerform[7])
            {
                Console.WriteLine("Should display like below:\nIntroduction to College Algebra\nBasic Writing\nAdvanced Structured Languages\n");
                Console.WriteLine(TestFunctions.GetCourseTitleByID(2));
                Console.WriteLine(TestFunctions.GetCourseTitleByID(3));
                Console.WriteLine(TestFunctions.GetCourseTitleByID(4));
                Console.ReadKey();
            }

            // Get a list of all course information
            if (testsToPerform[8])
            {
                List<List<string>> courses = TestFunctions.GetAllCourses();

                foreach (List<string> course in courses)
                {
                    foreach (string courseDetail in course)
                    {
                        Console.WriteLine(courseDetail);
                    }
                    Console.WriteLine("");
                }
                Console.ReadKey();
            }

            // Get a list of courses that don't have enough enrollments
            if (testsToPerform[9])
            {
                Dictionary<int, int> underEnrolledCourses = TestFunctions.GetUnderEnrolledCourses(6);
                foreach(KeyValuePair<int, int> course in underEnrolledCourses)
                {
                    string courseName = TestFunctions.GetCourseTitleByID(course.Key);
                    int enrollment = course.Value;
                    Console.WriteLine("{0} (Course_ID: {1}) has an enrollment of {2}",courseName, course.Key, enrollment);
                }
                Console.ReadKey();
            }

            // Get a bill for the requested user.
            if (testsToPerform[10])
            {
                int userID = 2;
                List<string> bill = TestFunctions.GetBillInformation(userID);

                foreach(string billDetail in bill)
                {
                    Console.WriteLine(billDetail);
                }
                Console.ReadKey();
            }

            // Update a users contact details
            if (testsToPerform[11])
            {
                int userID = 1;

                // This function is very literal. If you include blank information, the new record will be blank.
                // Make sure to call GetContactDetails on your user so you can pass in the details that aren't changing.
                List<string> oldContactDetails = TestFunctions.GetContactDetails(userID);

                Console.Write("Old Details:");
                foreach (string detail in oldContactDetails)
                {
                    Console.WriteLine(detail);
                }

                List<string> newContactDetails = new List<string>();

                // We want to update bob loblaws address and remove his fax number. Here's how we'd do this:
                newContactDetails.Add(oldContactDetails[0]); // FirstName
                newContactDetails.Add(oldContactDetails[1]); // LastName

                newContactDetails.Add("276 Anywhere Street"); // AddressLine1

                newContactDetails.Add(oldContactDetails[3]); // AddressLine2
                newContactDetails.Add(oldContactDetails[4]); // AddressCity
                newContactDetails.Add(oldContactDetails[5]); // AddressState
                newContactDetails.Add(oldContactDetails[6]); // AddressZipCode
                newContactDetails.Add(oldContactDetails[7]); // PhoneNumber

                newContactDetails.Add("");                   // FaxNumber

                newContactDetails.Add(oldContactDetails[9]); // Email

                TestFunctions.UpdateUserContactDetails(userID, newContactDetails);

                List<string> updatedDetails = TestFunctions.GetContactDetails(userID);

                Console.Write("New Details:");
                foreach (string detail in updatedDetails)
                {
                    Console.WriteLine(detail);
                }
            }

            // Get a list of courses with no professor
            if (testsToPerform[12])
            {
                List<int> courses = TestFunctions.GetCoursesWithNoProfessor();
                foreach (int course in courses)
                {
                    Console.WriteLine("Course_ID: {0} has no professor to teach it.", course);
                }
                Console.ReadKey();
            }

            // Get a courses professor by the course id
            if (testsToPerform[13])
            {
                int Course_ID = 5;
                int Professor_ID = TestFunctions.GetProfessorByCourseID(Course_ID);
                List<string> ProfessorContactDetails = TestFunctions.GetContactDetails(Professor_ID);
                string ProfessorName = ProfessorContactDetails[0] + " " + ProfessorContactDetails[1];
                Console.WriteLine("Professor of Course_ID: {0}\n" +
                                  "    Name: {1}\n" +
                                  " User_ID: {2}\n",
                                  Course_ID, ProfessorName, Professor_ID);
                Console.ReadKey();
            }

            // Get list of courses registered by a single user_id
            if (testsToPerform[14])
            {
                int User_ID = 2;
                List<int> EnrolledCourses = TestFunctions.GetRegisteredCoursesByUserID(User_ID);

                Console.WriteLine("User_ID {0}'s Registration Details: ", User_ID);
                foreach(int course in EnrolledCourses)
                {
                    Console.WriteLine("  Course_ID: {0}\n" +
                                      "Course_Name: {1}\n", 
                                      course, TestFunctions.GetCourseTitleByID(course));
                }
                Console.ReadKey();
            }
        }
    }
}
