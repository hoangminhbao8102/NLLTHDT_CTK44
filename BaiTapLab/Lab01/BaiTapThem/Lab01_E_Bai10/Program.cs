using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_E_Bai10
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số n:");
            int n = int.Parse(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("Hãy nhập một số lớn hơn 0");
            }
            else
            {
                int[] fib = new int[n];
                if (n >= 1) fib[0] = 0;
                if (n >= 2) fib[1] = 1;

                for (int i = 2; i < n; i++)
                {
                    fib[i] = fib[i - 1] + fib[i - 2];
                }

                Console.WriteLine($"Dãy Fibonacci đầu tiên gồm {n} số là:");
                for (int i = 0; i < n; i++)
                {
                    Console.Write(fib[i] + (i < n - 1 ? ", " : ""));
                }
            }
            Console.ReadKey();
        }
    }
}
