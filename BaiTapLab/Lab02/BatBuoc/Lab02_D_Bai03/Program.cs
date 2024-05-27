using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_D_Bai03
{
    public class Program
    {
        static double SineSeries(double x, int terms)
        {
            double sum = x; // Start with the first term of the series
            double term = x; // Initial term x^1/1!
            for (int n = 1; n < terms; n++)
            {
                // Update the term to x^(2n+1)/(2n+1)!
                term *= x * x / (2 * n) / (2 * n + 1);
                sum += 0.5 * term; // Each term is halved as per the series formula
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the value of x between -1 and 1:");
            double x = Convert.ToDouble(Console.ReadLine());
            if (x < -1 || x > 1)
            {
                Console.WriteLine("x must be between -1 and 1.");
            }
            else
            {
                Console.Write("Enter the number of terms in the series:");
                int terms = Convert.ToInt32(Console.ReadLine());
                double result = SineSeries(x, terms);
                Console.WriteLine($"The approximate sine value of {x} is {result}");
            }
            Console.ReadKey();
        }
    }
}
