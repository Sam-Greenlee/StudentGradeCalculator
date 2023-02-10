/*
 * Author: Samuel Greenlee
 * Project: Assignment Six
 * Date  : April 23, 2020
 * Desc  : This program reads in students for a course from a text file
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeCalculator
{
    class StudentDir
    {
        public int studentNumber { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string emailAddress { get; set; }
        public double grades { get; set; }

        public StudentDir() { }

        public StudentDir(int theStudentNumber, string theFirstName, string theLastName)
        {
            studentNumber = theStudentNumber;
            firstName = theFirstName;
            lastName = theLastName;
        }

        public List<QuizInfoDir> Grade = new List<QuizInfoDir>();

        public void AddQuiz(QuizInfoDir quizinfodir)
        {
            Grade.Add(quizinfodir);
        }

        public string CalculateAverage()
        {
            List<double> quizScores = new List<double>();

            foreach(QuizInfoDir quizInfoDir in Grade)
            {
                quizScores.Add(quizInfoDir.numberOfCorrectQuestions / (double)quizInfoDir.numberOfQuestions);
            }

            grades = quizScores.Average() * 100;

            return "Average Score " + (quizScores.Average() * 100).ToString("f3");
        }

        public string CalculateLetterGrade()
        {
            string letterGrade;

            if (grades >= 90)
            {
                letterGrade = "A";
            }
            else if (grades >= 80)
            {
                letterGrade = "B";
            }
            else if (grades >= 70)
            {
                letterGrade = "C";
            }
            else if (grades >= 60)
            {
                letterGrade = "D";
            }
            else letterGrade = "F";

            return "Course Grade " + letterGrade;
        }





        public override string ToString()
        {
            return studentNumber + " " + firstName + " " + lastName;
        }
    }
}
