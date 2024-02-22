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
            Console.WriteLine("Nhap kich thuoc cua hinh:");
            int size = int.Parse(Console.ReadLine());

            Console.WriteLine("\nPattern A:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if ((i + j) % 2 == 0)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nPattern B:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == 0 || i == size - 1 || j == 0 || j == size - 1)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nPattern C:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == 0 || i == j || j == size - 1)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nPattern D:");
            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("# ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nPattern E:");
            for (int i = size; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("# ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nPattern F:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("  ");
                }
                for (int k = i; k < size; k++)
                {
                    Console.Write("# ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nPattern G:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size - i - 1; j++)
                {
                    Console.Write("  ");
                }
                for (int k = 0; k <= i; k++)
                {
                    Console.Write("# ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nPattern H:");
            for (int i = 0; i < size; i++)
            {
                if (i == 0 || i == size - 1)
                {
                    for (int j = 0; j < size; j++)
                    {
                        Console.Write("# ");
                    }
                }
                else
                {
                    Console.Write("#");
                    for (int j = 1; j < size - 1; j++)
                    {
                        Console.Write("  ");
                    }
                    Console.Write(" #");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nPattern I:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("  ");
                }
                Console.Write("# ");
                Console.WriteLine();
            }
            for (int i = 0; i < size; i++)
            {
                Console.Write("# ");
            }
            Console.WriteLine();

            Console.WriteLine("\nPattern K:");
            for (int i = 0; i < size; i++)
            {
                if (i == 0 || i == size - 1)
                {
                    for (int j = 0; j < size; j++)
                    {
                        Console.Write("# ");
                    }
                }
                else
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write("  ");
                    }
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nPattern L:");
            for (int i = 0; i < size; i++)
            {
                if (i == size - 1)
                {
                    for (int j = 0; j < size; j++)
                    {
                        Console.Write("# ");
                    }
                }
                else
                {
                    for (int j = 0; j < i; j++)
                    {
                        Console.Write("  ");
                    }
                    Console.Write("#");
                    for (int j = i + 1; j < size - 1; j++)
                    {
                        Console.Write("  ");
                    }
                    Console.Write("#");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nPattern M:");
            for (int i = 0; i < size; i++)
            {
                if (i == 0 || i == size - 1)
                {
                    for (int j = 0; j < size; j++)
                    {
                        Console.Write("# ");
                    }
                }
                else if (i <= size / 2)
                {
                    Console.Write("# ");
                    for (int j = 0; j < i - 1; j++)
                    {
                        Console.Write("  ");
                    }
                    Console.Write("# ");
                    for (int j = 0; j < size - 3 - 2 * i; j++)
                    {
                        Console.Write("  ");
                    }
                    if (i != 1)
                    {
                        Console.Write("# ");
                    }
                }
                else
                {
                    for (int j = 0; j < size - i - 1; j++)
                    {
                        Console.Write("  ");
                    }
                    Console.Write("# ");
                    for (int j = 0; j < 2 * (i - size / 2) - 1; j++)
                    {
                        Console.Write("  ");
                    }
                    Console.Write("# ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
