using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_D_Bai06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập các hệ số của phương trình ax^2 + bx + c = 0");

            // Nhập các hệ số từ bàn phím
            Console.Write("Nhập hệ số a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Nhập hệ số b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Nhập hệ số c: ");
            double c = double.Parse(Console.ReadLine());

            // Tính delta
            double delta = b * b - 4 * a * c;

            if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"Phương trình có 2 nghiệm phân biệt: x1 = {x1}, x2 = {x2}");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"Phương trình có nghiệm kép: x1 = x2 = {x}");
            }
            else
            {
                Console.WriteLine("Phương trình không có nghiệm thực.");
            }
            Console.ReadKey();
        }
    }
}
