using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_D_Bai04
{
    public class Program
    {
        // Hàm kiểm tra số hoàn hảo
        static bool IsPerfectNumber(int n)
        {
            if (n < 1) return false; // Số hoàn hảo phải là số nguyên dương

            int sum = 0;
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }

            return sum == n;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập một số nguyên dương: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                bool isPerfect = IsPerfectNumber(number);
                if (isPerfect)
                {
                    Console.WriteLine($"{number} là một số hoàn hảo.");
                }
                else
                {
                    Console.WriteLine($"{number} không phải là số hoàn hảo.");
                }
            }
            else
            {
                Console.WriteLine("Dữ liệu nhập không hợp lệ. Vui lòng nhập một số nguyên.");
            }
            Console.ReadKey();
        }
    }
}
