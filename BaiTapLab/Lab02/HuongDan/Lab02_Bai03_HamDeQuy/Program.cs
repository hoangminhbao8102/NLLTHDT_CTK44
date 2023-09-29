using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_Bai03_HamDeQuy
{
    class Program
    {
        static long GiaiThuaDeQuy(int n)
        {
            if (n < 2)
            {
                return 1;
            }
            else
            {
                return n * GiaiThuaDeQuy(n - 1);
            }
        }

        static long GiaiThuaLap(int n)
        {
            if (n < 2)
            {
                return 1;
            }
            long Tich = 1;
            for (int i = 2; i <= n; i++)
            {
                Tich *= i;
            }
            return Tich;
        }

        static long FiboDeQuy(int n)
        {
            if (n <= 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return FiboDeQuy(n - 1) + FiboDeQuy(n - 2);
            }
        }

        static long FiboLap(int n)
        {
            if (n <= 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }

            long Truoc = 0, Giua = 1, Buoc = 2, Sau = 0;
            while (Buoc <= n)
            {
                Sau = Truoc + Giua;
                Truoc = Giua;
                Giua = Sau;
            }
            return Sau;
        }

        static void Main(string[] args)
        {
            int so = 10;

            long gtn = GiaiThuaDeQuy(so);
            Console.WriteLine("{0}! = {1}", so, gtn);

            gtn = GiaiThuaLap(so);
            Console.WriteLine("{0}! = {1}", so, gtn);

            long fibo = FiboDeQuy(so);
            Console.WriteLine("Fibonacci({0}) = {1}", so, fibo);

            for (int i = 0; i <= so; i++)
            {
                fibo = FiboDeQuy(i);
                Console.WriteLine("Fibonacci({0}) = {1}", i, fibo);
            }

            fibo = FiboLap(so);
            Console.WriteLine("Fibonacci({0}) = {1}", so, fibo);

            for (int i = 0; i <= so; i++)
            {
                fibo = FiboLap(i);
                Console.WriteLine("Fibonacci({0}) = {1}", i, fibo);
            }

            Console.ReadKey();
        }
    }
}
