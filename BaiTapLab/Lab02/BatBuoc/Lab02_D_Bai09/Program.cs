using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_D_Bai09
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            FindSpecialNumbers();
            Console.ReadKey();
        }

        static void FindSpecialNumbers()
        {
            Console.WriteLine("Các số có 3 chữ số thỏa mãn điều kiện abc = a^3 + b^3 + c^3 là:");

            for (int i = 100; i <= 999; i++)
            {
                int a = i / 100;
                int b = (i / 10) % 10;
                int c = i % 10;

                if (i == Math.Pow(a, 3) + Math.Pow(b, 3) + Math.Pow(c, 3))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
