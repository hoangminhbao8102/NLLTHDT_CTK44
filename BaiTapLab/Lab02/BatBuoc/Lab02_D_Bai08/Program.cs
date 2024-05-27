using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_D_Bai08
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("SumA Iterative: " + SumA_Iterative(n));
            Console.WriteLine("SumA Recursive: " + SumA_Recursive(n));

            Console.WriteLine("SumB Iterative: " + SumB_Iterative(n));
            Console.WriteLine("SumB Recursive: " + SumB_Recursive(n));

            Console.WriteLine("SumC Iterative: " + SumC_Iterative(n));
            Console.WriteLine("SumC Recursive: " + SumC_Recursive(n));

            Console.WriteLine("SumD Iterative: " + SumD_Iterative(n));
            Console.WriteLine("SumD Recursive: " + SumD_Recursive(n));

            Console.WriteLine("SumE Iterative: " + SumE_Iterative(n));
            Console.WriteLine("SumE Recursive: " + SumE_Recursive(n));

            Console.WriteLine("SumF Iterative: " + SumF_Iterative(n));
            Console.WriteLine("SumF Recursive: " + SumF_Recursive(n));

            Console.WriteLine("SumG Iterative: " + SumG_Iterative(n));
            Console.WriteLine("SumG Recursive: " + SumG_Recursive(n));

            Console.WriteLine("SumH Iterative: " + SumH_Iterative(n));
            Console.WriteLine("SumH Recursive: " + SumH_Recursive(n));

            Console.WriteLine("SumI Iterative: " + SumI_Iterative(n));
            Console.WriteLine("SumI Recursive: " + SumI_Recursive(n)); 

            Console.ReadKey();
        }

        public static int SumA_Iterative(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            return sum + n;
        }

        public static int SumA_Recursive(int n)
        {
            if (n == 1)
                return 1 + n;
            return n + SumA_Recursive(n - 1) + n;
        }

        public static int SumB_Iterative(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i * i;
            }
            return sum + n * n;
        }

        public static int SumB_Recursive(int n)
        {
            if (n == 1)
                return 1 * 1 + n * n;
            return n * n + SumB_Recursive(n - 1) + n * n;
        }

        public static int SumC_Iterative(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i * i * i;
            }
            return sum + n * n * n;
        }

        public static int SumC_Recursive(int n)
        {
            if (n == 1)
                return 1 * 1 * 1 + n * n * n;
            return n * n * n + SumC_Recursive(n - 1) + n * n * n;
        }

        public static int SumD_Iterative(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            return sum * (n - 1) + (n - 1) * n;
        }

        public static int SumD_Recursive(int n)
        {
            if (n == 1)
                return (n - 1) * n;
            return n + SumD_Recursive(n - 1) * (n - 1) + (n - 1) * n;
        }

        public static int SumE_Iterative(int n)
        {
            int product = 1;
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                product *= i;
                sum += product;
            }
            return sum * (n - 2) * (n - 1) * n;
        }

        public static int SumE_Recursive(int n)
        {
            if (n == 1)
                return n;
            return Factorial(n) + SumE_Recursive(n - 1) * (n - 3) * (n - 2) * (n - 1) * n;
        }

        public static int Factorial(int x)
        {
            if (x == 1)
                return 1;
            return x * Factorial(x - 1);
        }

        public static double SumF_Iterative(int n)
        {
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += 1.0 / (i * (n - 1) * n);
            }
            return sum;
        }

        public static double SumF_Recursive(int n)
        {
            if (n == 1)
                return 1.0 / (n * (n - 1) * n);
            return 1.0 / (n * (n - 1) * n) + SumF_Recursive(n - 1);
        }

        public static double SumG_Iterative(int n)
        {
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += 1.0 / (Factorial(i) * (n - 2) * (n - 1) * n);
            }
            return sum;
        }

        public static double SumG_Recursive(int n)
        {
            if (n == 1)
                return 1.0 / (Factorial(n) * (n - 2) * (n - 1) * n);
            return 1.0 / (Factorial(n) * (n - 2) * (n - 1) * n) + SumG_Recursive(n - 1);
        }

        public static int SumH_Iterative(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += 2 * i;
            }
            return sum + (2 * n - 4) + (2 * n - 2) + 2 * n;
        }

        public static int SumH_Recursive(int n)
        {
            if (n == 1)
                return 2;
            return 2 * n + SumH_Recursive(n - 1) + (2 * n - 4) + (2 * n - 2) + 2 * n;
        }

        public static int SumI_Iterative(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += 2 * i - 1;
            }
            return sum;
        }

        public static int SumI_Recursive(int n)
        {
            if (n == 1)
                return 1;
            return 2 * n - 1 + SumI_Recursive(n - 1);
        }
    }
}
