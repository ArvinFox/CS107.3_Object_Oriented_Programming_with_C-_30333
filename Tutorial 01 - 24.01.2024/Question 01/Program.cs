using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_01
{
    internal class Program
    {
        static void CalculateArea(double length, double width)
        {
            double area = length * width;

            Console.WriteLine("\nArea: " + area);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length: ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nEnter the width: ");
            double width = Convert.ToDouble(Console.ReadLine());

            CalculateArea(length, width);
            Console.ReadLine();
        }
    }
}
