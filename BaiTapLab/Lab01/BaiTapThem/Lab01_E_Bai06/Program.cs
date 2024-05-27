using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_E_Bai06
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] array = { 3, 4, 5, 17, 10, 23, 15 };
            Console.WriteLine("Các vị trí của số nguyên tố trong mảng:");

            for (int i = 0; i < array.Length; i++)
            {
                bool isPrime = true;
                if (array[i] <= 1)
                {
                    isPrime = false;
                }
                else if (array[i] == 2)
                {
                    isPrime = true;
                }
                else if (array[i] % 2 == 0)
                {
                    isPrime = false;
                }
                else
                {
                    for (int j = 3; j * j <= array[i]; j += 2)
                    {
                        if (array[i] % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine($"Phần tử {array[i]} là số nguyên tố tại vị trí {i}");
                }
            }
            Console.ReadKey();
        }
    }
}
