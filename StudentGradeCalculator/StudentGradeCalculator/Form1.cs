/*
 * Author: Samuel Greenlee
 * Project: Assignment Six
 * Date  : April 23, 2020
 * Desc  : This program reads in students for a course from a text file
 */

 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradeCalculator
{
    public partial class frmStudentGradeCalculator : Form
    {
        public frmStudentGradeCalculator()
        {
            InitializeComponent();
        }
        List<StudentDir> studentDirListing = new List<StudentDir>();

        List<QuizInfoDir> quizInfoDirListing = new List<QuizInfoDir>();

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGetStudents_Click(object sender, EventArgs e)
        {
            //This is the code that will get all the student information
            studentDirListing = StudentDA.GetAllDirectoryEntry();

            //This is the code that will format all the code that will display
            //  in the students listbox
            lstStudents.Items.Clear();
            foreach (StudentDir pd in studentDirListing)
            {
                lstStudents.Items.Add(pd);
            }
        }

        private void btnGetQuizzes_Click(object sender, EventArgs e)
        {
            StudentDir studentDirListing = (StudentDir)lstStudents.SelectedItem;

            //What will be displayed in the quiz list box
            lstQuizzes.Items.Clear();
            foreach (QuizInfoDir pd in studentDirListing.Grade)
            {
                lstQuizzes.Items.Add(pd.ToString());
            }
            lstQuizzes.Items.Add(studentDirListing.CalculateAverage());
            lstQuizzes.Items.Add(studentDirListing.CalculateLetterGrade());
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            StudentDA.DatabaseUpload(studentDirListing);
        }
    }
}
