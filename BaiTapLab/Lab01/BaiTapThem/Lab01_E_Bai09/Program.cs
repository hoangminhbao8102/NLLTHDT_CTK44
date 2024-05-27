using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_E_Bai09
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Write("Nhập số nguyên a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập số nguyên b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int originalA = a, originalB = b;

            // Tìm ước chung lớn nhất (ƯCLN) sử dụng thuật toán Euclid
            while (b != 0)
            {
                int t = b;
                b = a % b;
                a = t;
            }

            int gcd = a; // ƯCLN
            int lcm = (originalA / gcd) * originalB; // BCNN

            Console.WriteLine("Ước chung lớn nhất của {0} và {1} là: {2}", originalA, originalB, gcd);
            Console.WriteLine("Bội chung nhỏ nhất của {0} và {1} là: {2}", originalA, originalB, lcm);
            Console.ReadKey();
        }
    }
}
