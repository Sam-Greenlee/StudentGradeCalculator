/*
 * Author: Samuel Greenlee
 * Project: Assignment Six
 * Date  : April 23, 2020
 * Desc  : This program reads in students for a course from a text file
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentGradeCalculator
{
    class QuizInfoDA
    {
        private const string path = @"C:\Users\Samuel Greenlee\OneDrive - Southeast Community College\School (SCC)\Classes\C#.Net\Assignments\Assignment Six Folder\Text Files\StuQuizzes.txt";

        public static List<QuizInfoDir> GetAllDirectoryEntry()
        {
            List<QuizInfoDir> quizListing = new List<QuizInfoDir>();

            StreamReader textIn = new StreamReader(new FileStream(path, FileMode.Open, FileAccess.Read));

            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine();
                string[] columns = row.Split(',');

                QuizInfoDir aListing = new QuizInfoDir();
                aListing.studentNumber = Convert.ToInt16(columns[0]);
                aListing.quizNumber = Convert.ToInt16(columns[1]);
                aListing.numberOfQuestions = Convert.ToInt16(columns[2]);
                aListing.numberOfCorrectQuestions = Convert.ToInt16(columns[3]);

                quizListing.Add(aListing);
            }

            return quizListing;
        }
    }
}
