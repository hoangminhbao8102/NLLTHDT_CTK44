using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_D_Bai04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            double radius, height;

            // Nhập bán kính và chiều cao từ người dùng
            Console.WriteLine("Nhập bán kính của hình trụ:");
            radius = double.Parse(Console.ReadLine());

            Console.WriteLine("Nhập chiều cao của hình trụ:");
            height = double.Parse(Console.ReadLine());

            // Tính toán
            double circumference = 2 * Math.PI * radius;
            double baseArea = Math.PI * radius * radius;
            double lateralArea = 2 * Math.PI * radius * height;
            double totalArea = 2 * Math.PI * radius * (radius + height);
            double volume = Math.PI * radius * radius * height;

            // Xuất kết quả
            Console.WriteLine("Chu vi của hình trụ là: " + circumference);
            Console.WriteLine("Diện tích mặt đáy của hình trụ là: " + baseArea);
            Console.WriteLine("Diện tích bề mặt của hình trụ là: " + totalArea);
            Console.WriteLine("Thể tích của hình trụ là: " + volume);
            Console.ReadKey();
        }
    }
}
