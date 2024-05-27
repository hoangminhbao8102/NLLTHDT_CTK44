using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_E_Bai02
{
    public class Program
    {
        static void Main(string[] args)
        {
            int rows = 8;  // Max rows for Power of 2 and Pascal's Triangles

            // Generate and print Power of 2 Triangle
            Console.WriteLine("Power of 2 Triangle:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows - i; j++)
                {
                    Console.Write("   "); // Space padding for alignment
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write($"{(int)Math.Pow(2, j),4} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(); // Blank line for spacing between triangles

            // Generate and print Pascal's Triangle
            Console.WriteLine("Pascal's Triangle:");
            int[][] triangle = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                triangle[i] = new int[i + 1];
                triangle[i][0] = 1;
                triangle[i][i] = 1;
                for (int j = 1; j < i; j++)
                {
                    triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows - i; j++)
                {
                    Console.Write("  ");  // Space padding for alignment
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write($"{triangle[i][j],3} ");
                }
                Console.WriteLine();
            }

            // Triangle (m) - Simple Ascending Triangle
            Console.WriteLine("Triangle (m):");
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(); // Space between triangles

            // Triangle (n) - Full Triangle with Sequential Numbers
            Console.WriteLine("Triangle (n):");
            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <= rows; j++)
                {
                    if (j <= i)
                        Console.Write($"{j} ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(); // Space between triangles

            // Triangle (o) - Descending Triangle
            Console.WriteLine("Triangle (o):");
            for (int i = rows; i >= 1; i--)
            {
                for (int j = i; j >= 1; j--)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(); // Space between triangles

            // Triangle (p) - Mirrored Descending Triangle
            Console.WriteLine("Triangle (p):");
            for (int i = rows; i >= 1; i--)
            {
                for (int j = 1; j <= rows - i; j++)
                {
                    Console.Write("  ");
                }
                for (int j = i; j >= 1; j--)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }

            // Triangle (q)
            Console.WriteLine("Triangle (q):");
            for (int i = 0; i < rows; i++)
            {
                // Print leading spaces
                for (int space = 1; space < rows - i; space++)
                    Console.Write(" ");

                int num = 1; // Starting number in each row

                // Calculate value using binomial coefficient
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(num + " ");
                    num = num * (i - j) / (j + 1);
                }

                Console.WriteLine();
            }

            // Triangle (r)
            Console.WriteLine("Triangle (r):");
            // Create the full Pascal's triangle in a 2D array
            int[][] t = new int[rows][];
            for (int i = 0; i < rows; i++)
            {
                t[i] = new int[i + 1];
                t[i][0] = 1; // First element is always 1
                t[i][i] = 1; // Last element is always 1

                for (int j = 1; j < i; j++)
                {
                    t[i][j] = t[i - 1][j - 1] + t[i - 1][j];
                }
            }

            // Print the triangle from bottom to top
            for (int i = rows - 1; i >= 0; i--)
            {
                // Print leading spaces
                for (int space = 0; space < rows - i; space++)
                    Console.Write(" ");

                // Print numbers
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(t[i][j] + " ");
                }

                Console.WriteLine();
            }

            // Triangle (s)
            Console.WriteLine("Triangle (s):");
            for (int i = 1; i <= rows; i++)
            {
                // Printing spaces before the numbers in each row
                for (int space = 1; space <= rows - i; space++)
                {
                    Console.Write("  "); // Two spaces for alignment
                }

                // Printing ascending numbers
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }

                // Printing descending numbers
                for (int j = i - 1; j >= 1; j--)
                {
                    Console.Write(j + " ");
                }

                // Move to the next line
                Console.WriteLine();
            }

            // Triangle (t)
            Console.WriteLine("Triangle (t):");
            for (int i = rows; i >= 1; i--)
            {
                // Printing spaces before the numbers in each row
                for (int space = 1; space <= rows - i; space++)
                {
                    Console.Write("  "); // Two spaces for alignment
                }

                // Printing ascending numbers
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }

                // Printing descending numbers
                for (int j = i - 1; j >= 1; j--)
                {
                    Console.Write(j + " ");
                }

                // Move to the next line
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
