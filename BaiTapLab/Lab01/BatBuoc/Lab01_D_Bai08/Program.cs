using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_D_Bai08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập số nguyên dương n:");
            int n;
            while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            {
                Console.WriteLine("Vui lòng nhập lại số nguyên dương n:");
            }

            Console.WriteLine($"Các {n} số nguyên tố đầu tiên là:");
            int count = 0;
            int currentNumber = 2;

            while (count < n)
            {
                bool isPrime = true;
                for (int i = 2; i <= Math.Sqrt(currentNumber); i++)
                {
                    if (currentNumber % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.Write(currentNumber + " ");
                    count++;
                }
                currentNumber++;
            }
            Console.ReadKey();
        }
    }
}
