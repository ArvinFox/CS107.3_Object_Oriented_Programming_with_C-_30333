using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace Question_02
{
    internal class Program
    {
        public class Employee
        {
            private int employeeID;
            private string FullName;
            private double Salary;

            public Employee(int id, string name, double salary)
            {
                employeeID = id;
                FullName = name;
                Salary = salary;
            }
            public int EmployeeID
            { get { return employeeID; } }

            public string FullNameEdit
            { 
                get { return FullName; } 
                set { FullName = value; }
            }

            public void DisplayEnployeeInfo()
            {
                Console.WriteLine($"Employee ID : {employeeID}");
                Console.WriteLine($"Full Name : {FullName}");
                Console.WriteLine($"Salary : {Salary}");
            }
        }
        static void Main(string[] args)
        {
            Employee newemp = new Employee(101, "John Doe", 50000);

            newemp.DisplayEnployeeInfo();
            Console.WriteLine($"Employee ID : {newemp.EmployeeID}");
            Console.WriteLine("\nEnter the new name of the employee : ");
            newemp.FullNameEdit = Console.ReadLine();
            Console.WriteLine($"Employee Name : {newemp.FullNameEdit}");
            Console.ReadLine();

            Console.WriteLine("Enter the new Salary : ");
            //newemp.Salary = Convert.ToDouble(Console.ReadLine());
            //In here we can see that we can't modify the salary amount due to its protection level (private)
        }
    }
}
