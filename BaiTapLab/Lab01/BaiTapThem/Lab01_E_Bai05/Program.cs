using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_E_Bai05
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số nguyên dương n:");
            int n = int.Parse(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine("Vui lòng nhập một số nguyên dương.");
                return;
            }

            int count = 0;
            while (n > 0)
            {
                count += n & 1; // Thêm 1 vào count nếu bit cuối cùng là 1
                n >>= 1;        // Dịch phải 1 bit
            }

            Console.WriteLine($"Số bit 1 trong biểu diễn nhị phân là: {count}");
            Console.ReadKey();
        }
    }
}
