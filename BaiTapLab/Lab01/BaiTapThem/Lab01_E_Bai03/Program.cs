using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_E_Bai03
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số nguyên dương n: ");
            int n = int.Parse(Console.ReadLine());

            long factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            Console.WriteLine($"Giai thừa của {n} là: {factorial}");
            Console.ReadKey();
        }
    }
}
