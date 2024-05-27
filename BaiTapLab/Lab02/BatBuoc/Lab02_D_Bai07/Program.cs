using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_D_Bai07
{
    public class Program
    {
        // Iterative method to find GCD
        static int GCD_Iterative(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        // Recursive method to find GCD
        static int GCD_Recursive(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            return GCD_Recursive(b, a % b);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter two integers:");

            Console.Write("a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("b: ");
            int b = int.Parse(Console.ReadLine());

            int gcdIterative = GCD_Iterative(a, b);
            int gcdRecursive = GCD_Recursive(a, b);

            Console.WriteLine($"GCD of {a} and {b} (Iterative): {gcdIterative}");
            Console.WriteLine($"GCD of {a} and {b} (Recursive): {gcdRecursive}");
            Console.ReadKey();
        }
    }
}
