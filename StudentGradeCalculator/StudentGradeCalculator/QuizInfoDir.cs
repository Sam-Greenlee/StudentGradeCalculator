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
    class QuizInfoDir
    {
        public int studentNumber { get; set; }
        public int quizNumber { get; set; }
        public int numberOfQuestions { get; set; }
        public int numberOfCorrectQuestions { get; set; }


        public QuizInfoDir() { }

        public QuizInfoDir(int theStudentIdNumber, int theQuizNumber, int theNumberOfQuestions, int theNumberOfCorrectQuestions)
        {
            studentNumber = theStudentIdNumber;
            quizNumber = theQuizNumber;
            numberOfQuestions = theNumberOfQuestions;
            numberOfCorrectQuestions = theNumberOfCorrectQuestions;
        }

        public override string ToString()
        {
            return "Id " + studentNumber + " Quiz " + quizNumber + " Number Of Questions " + numberOfQuestions + " Number Of Correct " + numberOfCorrectQuestions;
        }
    }
}
