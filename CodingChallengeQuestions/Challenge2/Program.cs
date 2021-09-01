using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;


//Write a program which will ask the user to input a certain number of students
//ask the user how many tests were administered to the students.
//For each student, ask the user to input the first name of the student,
//the last name of the student, and each numerical grade of the tests for the student.
//For each student, calculate the grade average and a letter grade
//Create a class that holds all the student’s information and any methods needed.
//Then output each student’s first and last name, grade average, and letter grade to the user.

namespace Challenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The number of Student");
            int numberOfStudent = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nhow many tests were administered to the students.");
            int tests = Convert.ToInt32(Console.ReadLine());


            StudentInfo(numberOfStudent, tests);

            Console.ReadLine();
        }

        static void StudentInfo(int numberOfStudents, int tests)
        {
            string firstName = string.Empty;
            string lastName = string.Empty;
            int numericalGrade = 0;

            int scoreSummation = 0;
            int gradeAverage = 0;
            string letterGrade = string.Empty;

            Console.WriteLine("\nFor each student, input the first name of the student, the last name of the student, and each numerical grade of the tests for the student.");
            for (int i = 0; i < numberOfStudents; i++)
            {
                int std1 = i;
                Console.WriteLine($"\nInput the first name of the student {++std1}");
                firstName = Console.ReadLine();

                Console.WriteLine($"\nThe last name of the student{std1}");
                lastName = Console.ReadLine();

                for (int j = 0; j < tests; j++)
                {
                    int std2 = j;
                    Console.WriteLine($"\nEnter numerical grade of the tests {++std2} for the student");
                    numericalGrade = Convert.ToInt32(Console.ReadLine());

                    scoreSummation += numericalGrade;
                }

                gradeAverage = scoreSummation / tests;
                Console.WriteLine($"\nAverage is {gradeAverage}\n");

                if (gradeAverage >= 90 && gradeAverage <= 100)
                    letterGrade = "A";
                else if (gradeAverage <= 89 && gradeAverage >= 80)
                    letterGrade = "B";
                else if (gradeAverage <= 79 && gradeAverage >= 70)
                    letterGrade = "C";
                else if (gradeAverage <= 69 && gradeAverage >= 60)
                    letterGrade = "D";
                else
                    letterGrade = "F";

                Console.WriteLine($"\nLetterel Grade is {letterGrade}");

                Student student = new Student
                { 
                    FirstName = firstName, 
                    LastName = lastName, 
                    GradeAverage = gradeAverage, 
                    LetterelGrade = letterGrade 
                };

                Console.WriteLine($"\nFirst name is {student.FirstName}");
                Console.WriteLine($"Last name is {student.LastName}");
                Console.WriteLine($"Grade average is {student.GradeAverage}");
                Console.WriteLine($"LetterelGrade is {student.LetterelGrade}\n");

                scoreSummation = 0;
                gradeAverage = 0;

            }
        }

    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int GradeAverage { get; set; }
        public string LetterelGrade { get; set; }
    }
}
