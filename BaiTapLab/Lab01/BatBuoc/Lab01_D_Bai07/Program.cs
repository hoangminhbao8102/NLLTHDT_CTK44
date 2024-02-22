using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_D_Bai07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Nhập vào một số nguyên dương:");
            int number = int.Parse(Console.ReadLine());

            // Xuất số ở dạng nhị phân
            string binary = Convert.ToString(number, 2);
            Console.WriteLine($"Số {number} ở dạng nhị phân là: {binary}");

            // Xuất số ở dạng bát phân
            string octal = Convert.ToString(number, 8);
            Console.WriteLine($"Số {number} ở dạng bát phân là: {octal}");

            // Xuất số ở dạng thập lục phân
            string hexadecimal = Convert.ToString(number, 16);
            Console.WriteLine($"Số {number} ở dạng thập lục phân là: {hexadecimal}");
            Console.ReadKey();
        }
    }
}
