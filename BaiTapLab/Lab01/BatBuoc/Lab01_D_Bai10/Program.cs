using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_D_Bai10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập ngày:");
            int day = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhập tháng:");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhập năm:");
            int year = int.Parse(Console.ReadLine());

            int y0 = year - (14 - month) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = month + 12 * ((14 - month) / 12) - 2;
            int d0 = (day + x + (31 * m0) / 12) % 7;

            switch (d0)
            {
                case 0:
                    Console.WriteLine("Chủ nhật");
                    break;
                case 1:
                    Console.WriteLine("Thứ 2");
                    break;
                case 2:
                    Console.WriteLine("Thứ 3");
                    break;
                case 3:
                    Console.WriteLine("Thứ 4");
                    break;
                case 4:
                    Console.WriteLine("Thứ 5");
                    break;
                case 5:
                    Console.WriteLine("Thứ 6");
                    break;
                case 6:
                    Console.WriteLine("Thứ 7");
                    break;
                default:
                    Console.WriteLine("Lỗi! Ngày không hợp lệ.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
