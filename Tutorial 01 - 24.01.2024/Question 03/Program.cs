using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive integer: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num <= 0)
            {
                Console.WriteLine("\nERROR");
            } else
            {
                int sum = 0;
                for (int i = 1; i <= num; i++)
                {
                    sum += i;
                }

                Console.WriteLine("\nSum: " + sum);
            }

            Console.ReadLine();
        }
    }
}
