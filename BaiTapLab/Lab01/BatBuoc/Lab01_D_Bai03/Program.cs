using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_D_Bai03
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 7, y = -3;
            int z;

            // a. int x = 7, y = -3;
            Console.WriteLine($"a. x = {x}, y = {y}");

            // b. int z = x++ + x++;
            z = x++ + x++;
            Console.WriteLine($"b. z = {z}, x = {x}");

            // c. z = x++ + x++ + ++x;
            x = 7; // Reset x
            z = x++ + x++ + ++x;
            Console.WriteLine($"c. z = {z}, x = {x}");

            // d. z = ++x + y-- - ++y - x-- - x-- - ++y - x--;
            x = 7; // Reset x
            y = -3; // Reset y
            z = ++x + y-- - ++y - x-- - x-- - ++y - x--;
            Console.WriteLine($"d. z = {z}, x = {x}, y = {y}");

            // e. z = x++ + ++y - x-- + --y;
            x = 7; // Reset x
            y = -3; // Reset y
            z = x++ + ++y - x-- + --y;
            Console.WriteLine($"e. z = {z}, x = {x}, y = {y}");

            // f. z = x++ * y++ / ++x - --y % x++;
            x = 7; // Reset x
            y = -3; // Reset y
            z = x++ * y++ / ++x - --y % x++;
            Console.WriteLine($"f. z = {z}, x = {x}, y = {y}");

            // g. z = x++ + ++y - x-- + --y;
            x = 7; // Reset x
            y = -3; // Reset y
            z = x++ + ++y - x-- + --y;
            Console.WriteLine($"g. z = {z}, x = {x}, y = {y}");
            Console.ReadKey();
        }
    }
}
