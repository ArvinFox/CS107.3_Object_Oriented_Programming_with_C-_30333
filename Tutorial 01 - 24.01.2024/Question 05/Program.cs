using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nMultiplication table for {num}: ");

            for (int i = 1; i <= 15; i++)
            {
                int product = num * i;
                Console.WriteLine($"{num} x {i} = {product}");
            }

            Console.ReadLine();
        }
    }
}
