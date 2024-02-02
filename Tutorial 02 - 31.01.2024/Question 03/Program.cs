using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_03
{
    internal class Program
    {
        class TemperatureTracker
        {
            public double[] temperature = new double[7];
        
            public void InputTemperature()
            {
                for (int i = 0; i < temperature.Length; i++)
                {
                    Console.WriteLine($"Enter {i+1} Day's Temperature: ");
                    while (!double.TryParse(Console.ReadLine(), out temperature[i]))
                    {
                        Console.WriteLine("Enter a Valid Temperature!");
                    }
                }
            }
            public void OutputTemperature() 
            {
                for (int i = 0; i < temperature.Length; i++)
                {
                    Console.WriteLine($"{i+1} Day Temperature: {temperature[i]} C");
                }
            }
        }

        static void Main(string[] args)
        {
            TemperatureTracker temp = new TemperatureTracker();
            temp.InputTemperature();
            temp.OutputTemperature();
            Console.ReadLine();
        }
    }
}
