using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_E_Bai08
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Nhập chiều dài, chiều rộng và chiều cao của hình hộp chữ nhật
            Console.Write("Nhập chiều dài của hình hộp chữ nhật:");
            double length = double.Parse(Console.ReadLine());

            Console.Write("Nhập chiều rộng của hình hộp chữ nhật:");
            double width = double.Parse(Console.ReadLine());

            Console.Write("Nhập chiều cao của hình hộp chữ nhật:");
            double height = double.Parse(Console.ReadLine());

            // Tính tổng diện tích các mặt của hình hộp
            double surfaceArea = 2 * (length * width + width * height + height * length);

            // Tính thể tích của hình hộp
            double volume = length * width * height;

            // In kết quả
            Console.WriteLine($"Tổng diện tích các mặt của hình hộp là: {surfaceArea} đơn vị diện tích.");
            Console.WriteLine($"Thể tích của hình hộp là: {volume} đơn vị thể tích.");
            Console.ReadKey();
        }
    }
}
