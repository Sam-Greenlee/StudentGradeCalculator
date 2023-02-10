/*
 * Author: Samuel Greenlee
 * Project: Assignment Six
 * Date  : April 23, 2020
 * Desc  : This program reads in students for a course from a text file
 */

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradeCalculator
{
    class StudentDA
    {
        private const string path = @"C:\Users\Samuel Greenlee\OneDrive - Southeast Community College\School (SCC)\Classes\C#.Net\Assignments\Assignment Six Folder\Text Files\Students.txt";

        public static List<StudentDir> GetAllDirectoryEntry()
        {
            List<StudentDir> studentListings = new List<StudentDir>();

            StreamReader textIn = new StreamReader(new FileStream(path, FileMode.Open, FileAccess.Read));

            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine();
                string[] columns = row.Split(',');

                StudentDir aListing = new StudentDir();
                aListing.studentNumber = Convert.ToInt16(columns[0]);
                aListing.firstName = columns[1];
                aListing.lastName = columns[2];

                studentListings.Add(aListing);
            }
            List<QuizInfoDir> allQuizes = QuizInfoDA.GetAllDirectoryEntry();

            foreach(var allQuiz in allQuizes)
            {
                foreach (var allStudents in studentListings)
                {
                    if(allStudents.studentNumber == allQuiz.studentNumber)
                    {
                        allStudents.Grade.Add(allQuiz);
                    }
                }
            }

            return studentListings;
        }
        public static void DatabaseUpload(List<StudentDir> studentListings)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Samuel Greenlee\OneDrive - Southeast Community College\School (SCC)\Classes\C#.Net\Assignments\Assignment Six Folder\StudentGradeCalculator\StudentGradeCalculator\SchoolData.mdf"";Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionString);

            //Try catch
            try
            {
                //Create a SQL command
                string insertStatement = "insert  CourseInfo (Instructor, StuId, FirstName, LastName, Score, Grade) values (@aInstructor, @aStuId, @aFirstName, @aLastName, @aScore, @aGrade)";

                SqlCommand insertCommand = new SqlCommand(insertStatement, conn);

                //Open the connection
                conn.Open();

                //Loop through incomeing students
                foreach (StudentDir studentdir in studentListings)
                {
                    //Add parameters
                    insertCommand.Parameters.AddWithValue("@aInstructor", "Samuel Greenlee");
                    insertCommand.Parameters.AddWithValue("@aStuId", studentdir.studentNumber);
                    insertCommand.Parameters.AddWithValue("@aFirstName", studentdir.firstName);
                    insertCommand.Parameters.AddWithValue("@aLastName", studentdir.lastName);
                    studentdir.CalculateAverage();
                    insertCommand.Parameters.AddWithValue("@aScore", studentdir.grades);
                    insertCommand.Parameters.AddWithValue("@aGrade", studentdir.CalculateLetterGrade());

                    //Execute command
                    insertCommand.ExecuteNonQuery();

                    //Clear parameters
                    insertCommand.Parameters.Clear();
                }
            }

            //Finality
            catch
            (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Close the connection if it is not null
                conn.Close();
            }

        }
    }

}
