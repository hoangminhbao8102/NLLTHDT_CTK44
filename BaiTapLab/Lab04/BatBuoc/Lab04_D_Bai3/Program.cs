using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_D_Bai3
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create Hexa objects using hexadecimal strings and uint
            Hexa hex1 = "1A3";
            Hexa hex2 = new Hexa(256);  // Equivalent to 100 in hexadecimal
            Hexa hex3 = "FF";          // 255 in decimal

            // Performing arithmetic operations
            Hexa sum = hex1 + hex2;
            Hexa difference = hex2 - hex1;
            Hexa product = hex1 * hex3;
            Hexa quotient = hex2 / hex1;
            Hexa remainder = hex2 % hex3;

            // Increment and decrement
            Hexa increment = ++hex3;
            Hexa decrement = --hex2;

            // Display results
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Difference: " + difference);
            Console.WriteLine("Product: " + product);
            Console.WriteLine("Quotient: " + quotient);
            Console.WriteLine("Remainder: " + remainder);
            Console.WriteLine("Incremented: " + increment);
            Console.WriteLine("Decremented: " + decrement);

            // Comparisons
            Console.WriteLine("Is hex1 greater than hex2? " + (hex1 > hex2));
            Console.WriteLine("Is hex2 less than or equal to hex3? " + (hex2 <= hex3));

            // Type conversion demonstrations
            uint num = (uint)hex1;  // Convert Hexa to uint
            int integerRepresentation = (int)hex1;  // Convert Hexa to int
            Console.WriteLine("Uint value of hex1: " + num);
            Console.WriteLine("Integer representation of hex1: " + integerRepresentation);

            Console.ReadKey();
        }
    }
}
