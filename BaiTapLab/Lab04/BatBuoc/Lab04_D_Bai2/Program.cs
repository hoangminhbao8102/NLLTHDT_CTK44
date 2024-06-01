using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_D_Bai2
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create Octal objects
            Octal oct1 = new Octal(10); // Represents octal 12 (decimal 10)
            Octal oct2 = new Octal(20); // Represents octal 24 (decimal 20)

            // Perform arithmetic operations
            Octal sum = oct1 + oct2;
            Octal difference = oct1 - oct2;
            Octal product = oct1 * oct2;
            Octal quotient = oct1 / oct2;
            Octal remainder = oct1 % oct2;

            // Output the results of arithmetic operations
            Console.WriteLine("Sum: " + sum.ToString());
            Console.WriteLine("Difference: " + difference.ToString());
            Console.WriteLine("Product: " + product.ToString());
            Console.WriteLine("Quotient: " + quotient.ToString());
            Console.WriteLine("Remainder: " + remainder.ToString());

            // Increment and decrement
            oct1++;
            oct2--;

            // Output the results after increment and decrement
            Console.WriteLine("Incremented oct1: " + oct1.ToString());
            Console.WriteLine("Decremented oct2: " + oct2.ToString());

            // Comparisons
            bool isLess = oct1 < oct2;
            bool isEqual = oct1 == oct2;

            // Output the results of comparisons
            Console.WriteLine("oct1 < oct2: " + isLess);
            Console.WriteLine("oct1 == oct2: " + isEqual);

            // Catch division by zero example
            try
            {
                Octal zero = new Octal(0);
                Octal result = oct1 / zero;
                Console.WriteLine("Division result: " + result.ToString());
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Caught exception: " + ex.Message);
            }

            Console.ReadKey();
        }
    }
}
