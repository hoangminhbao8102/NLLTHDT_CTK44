using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_E_Bai07
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] array = { 6, 28, 496, 8128, 2, 10, 15 }; // Mảng chứa các số để kiểm tra
            int count = 0;

            foreach (int num in array)
            {
                if (num < 1)
                    continue;

                int sum = 0;
                for (int i = 1; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        sum += i;
                    }
                }

                if (sum == num)
                {
                    count++;
                }
            }

            Console.WriteLine("Số lượng số hoàn chỉnh trong mảng là: " + count);
            Console.ReadKey();
        }
    }
}
