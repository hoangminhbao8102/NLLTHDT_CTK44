using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_D_Bai01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập kích thước của hình:");
            int size = int.Parse(Console.ReadLine());

            // Pattern (a)
            Console.WriteLine("\nPattern (a):");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            // Pattern (b)
            Console.WriteLine("\nPattern (b):");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == size / 2 || j == size / 2)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }

            // Pattern (c)
            Console.WriteLine("\nPattern (c):");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == 0 || j == 0 || i == size - 1 || j == size - 1)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }

            // Pattern (a)
            Console.WriteLine("\nPattern (a):");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == 0 || j == 0 || i == size - 1 || j == size - 1)
                        Console.Write("# ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }

            // Pattern (b)
            Console.WriteLine("\nPattern (b):");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == j)
                        Console.Write("# ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }

            // Pattern (c)
            Console.WriteLine("\nPattern (c):");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i + j == size - 1)
                        Console.Write("# ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }

            // Pattern (d)
            Console.WriteLine("\nPattern (d):");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == j || i + j == size - 1)
                        Console.Write("# ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }

            // Pattern (e)
            Console.WriteLine("\nPattern (e):");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write("# ");
                }
                Console.WriteLine();
            }

            // Pattern (f)
            Console.WriteLine("\nPattern (f):");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i % 2 == 0)
                        Console.Write("# ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }

            // Pattern (g)
            Console.WriteLine("\nPattern (g):");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (j % 2 == 0)
                        Console.Write("# ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }

            // Pattern (h)
            Console.WriteLine("\nPattern (h):");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if ((i == 0 || i == size - 1) || (j == 0 || j == size - 1))
                        Console.Write("# ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }

            // Pattern (i)
            Console.WriteLine("\nPattern (i):");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if ((i == 0 || i == size - 1) || (j == 0 || j == size - 1) || i == j || i + j == size - 1)
                        Console.Write("# ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
