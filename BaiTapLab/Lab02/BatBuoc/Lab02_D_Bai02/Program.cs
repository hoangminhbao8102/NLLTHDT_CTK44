using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_D_Bai02
{
    public class Program
    {
        static void Main(string[] args)
        {
            double x = Math.PI / 4; // Example angle in radians
            Console.WriteLine($"Sin({x}) = {Sin(x)}");
            Console.WriteLine($"Cos({x}) = {Cos(x)}");
            Console.ReadKey();
        }

        // Factorial function
        static double Factorial(int n)
        {
            double result = 1;
            for (int i = 1; i <= n; i++)
                result *= i;
            return result;
        }

        // Sine function using Taylor series
        static double Sin(double x)
        {
            return x - (Math.Pow(x, 3) / Factorial(3))
                     + (Math.Pow(x, 5) / Factorial(5))
                     - (Math.Pow(x, 7) / Factorial(7))
                     + (Math.Pow(x, 9) / Factorial(9));
        }

        // Cosine function using Taylor series
        static double Cos(double x)
        {
            return 1 - (Math.Pow(x, 2) / Factorial(2))
                     + (Math.Pow(x, 4) / Factorial(4))
                     - (Math.Pow(x, 6) / Factorial(6))
                     + (Math.Pow(x, 8) / Factorial(8));
        }
    }
}
