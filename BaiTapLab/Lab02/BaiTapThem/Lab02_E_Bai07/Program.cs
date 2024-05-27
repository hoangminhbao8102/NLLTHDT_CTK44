using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_E_Bai07
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if (IsProductOfPrimeFactors(i))
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }

        static bool IsPrime(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        static int ProductOfPrimeFactors(int number)
        {
            int product = 1;
            for (int i = 2; i <= number; i++)
            {
                while (number % i == 0)
                {
                    if (IsPrime(i))
                    {
                        product *= i;
                    }
                    number /= i;
                }
            }
            return product;
        }

        static bool IsProductOfPrimeFactors(int number)
        {
            return ProductOfPrimeFactors(number) == number;
        }
    }
}
