using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_D_Bai01
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập chiều dài: ");
            double d = double.Parse(Console.ReadLine());

            Console.Write("Nhập chiều rộng: ");
            double r = double.Parse(Console.ReadLine());

            Console.Write("Nhập chiều cao: ");
            double h = double.Parse(Console.ReadLine());


            Console.WriteLine("Tổng diện tích mặt: " + TongDienTichMat(d, r, h));
            Console.WriteLine("Thể tích: " + TheTich(d, r, h));

            Console.ReadKey();
        }

        public static double TongDienTichMat(double d, double r, double h)
        {
            return 2 * (d * r + r * h + h * d);
        }

        public static double TheTich(double d, double r, double h) 
        {
            return d * r * h;
        }
    }
}
