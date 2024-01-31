using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_04
{
    internal class Program
    {
        static int Fibonacci(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }

            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive integer: ");
            int n = Convert.ToInt32(Console.ReadLine());

            string result = "";
            Console.WriteLine();

            for (int i = 0; i <= n; i++)
            {
                result += Convert.ToString(Fibonacci(i)) + " ";
            }

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
