using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_D_Bai05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            double a, b, c;
            Console.WriteLine("Nhập độ dài ba cạnh của tam giác:");

            Console.Write("Nhập cạnh a: ");
            a = double.Parse(Console.ReadLine());

            Console.Write("Nhập cạnh b: ");
            b = double.Parse(Console.ReadLine());

            Console.Write("Nhập cạnh c: ");
            c = double.Parse(Console.ReadLine());

            // Sử dụng công thức Heron để tính diện tích tam giác
            double p = (a + b + c) / 2;
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            Console.WriteLine($"Diện tích của tam giác là: {s}");
            Console.ReadKey();
        }
    }
}
