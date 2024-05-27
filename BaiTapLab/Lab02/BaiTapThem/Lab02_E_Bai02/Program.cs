using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_E_Bai02
{
    public class Program
    {
        static void Main(string[] args)
        {
            double x = 3; // Example value for x
            int terms = 10; // Number of terms in the series to compute
            Console.WriteLine($"e^{x} calculated using series expansion: {CalculateExponential(x, terms)}");
            Console.ReadKey();
        }

        static double CalculateExponential(double x, int terms)
        {
            double sum = 1.0; // The first term of the series
            double factorial = 1.0;
            double power = 1.0;

            for (int i = 1; i < terms; i++)
            {
                factorial *= i; // Update factorial to i!
                power *= x; // Update power to x^i
                sum += power / factorial; // Add the i-th term to the sum
            }

            return sum;
        }
    }
}
