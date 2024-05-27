using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_E_Bai04
{
    public class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 1000; i <= 2000; i++)
            {
                Console.Write($"{i} ");
                count++;
                if (count == 5)
                {
                    Console.WriteLine(); // Xuống dòng sau khi in 5 số
                    count = 0; // Đặt lại bộ đếm
                }
            }
            Console.ReadKey();
        }
    }
}
