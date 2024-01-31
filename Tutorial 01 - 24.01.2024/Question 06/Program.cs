using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_06
{
    internal class Program
    {
        static string getGrade(int marks)
        {
            if (marks >= 75 && marks <= 100)
                return "A";
            else if (marks >= 60 && marks <= 74)
                return "B";
            else if (marks >= 50 && marks <= 59)
                return "C";
            else if (marks >= 40 && marks <= 49)
                return "D";
            else
                return "Fail";
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Student Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("\nEnter Exam Marks: ");
            int marks = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                if (marks < 0 || marks > 100)
                {
                    Console.WriteLine("Invalid marks. Please enter a valid mark between 0 and 100: ");
                    marks = Convert.ToInt32(Console.ReadLine());
                }
                else
                    break;
            }

            string grade = getGrade(marks);

            Console.WriteLine($"\nStudent Name: {name}\nGrade: {grade}");
            Console.ReadLine();
        }
    }
}
