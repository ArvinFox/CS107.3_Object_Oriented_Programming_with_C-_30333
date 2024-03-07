using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_01
{
    internal class Program
    {
        public class Course
        {
            private string courseName;
            private string instructorName;
            private double grade;

            public string CourseName
            {
                get { return courseName; }
            }
            public double Grade
            {
                get { return grade; }
                set 
                { 
                    if (value >=0 && value <=100)
                    {
                        grade = value;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid mark!");
                    }
                }
            }
            public string InstructorName
            {
                get { return instructorName; }
                set { instructorName = value; }
            }

            public Course(string courseName)
            {
                this.courseName = courseName;
            }
            public string SetInstructorName()
            {
                Console.WriteLine("Enter the Instructor Name: ");
                string name = Console.ReadLine();

                while (name == null)
                {
                    Console.WriteLine("Instructor name cannot be empty.");
                    name = Console.ReadLine();
                }
                return name;
            }
            private string CalculateLetterGrade()
            {
                if (grade>=75)
                {
                    return "A";
                }
                else if (grade>=65)
                {
                    return "B";
                }
                else if (grade>=55)
                {
                    return "C";
                }
                else if (grade>=35)
                {
                    return "S";
                }
                else
                {
                    return "F";
                }
            }
            public void PrintCourseInfo()
            {
                Console.WriteLine("\n");
                Console.WriteLine($"Course name: {CourseName}");
                Console.WriteLine($"Course Instructor: {InstructorName}");
                Console.WriteLine($"Course Grade: {CalculateLetterGrade()}");
                
            }
            
        }

        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the course name: ");
            string coursename = Console.ReadLine();
            while (coursename == "")
            {
                Console.WriteLine("Enter a valid course name: ");
                coursename = Console.ReadLine();
            }

            Course mycourse = new Course(coursename);
            
            mycourse.InstructorName = mycourse.SetInstructorName();

            Console.WriteLine("Enter the course marks: ");
            double marks = Convert.ToDouble(Console.ReadLine());
            mycourse.Grade = marks;

            mycourse.PrintCourseInfo();

            Console.ReadLine(); 
        }
    }
}
