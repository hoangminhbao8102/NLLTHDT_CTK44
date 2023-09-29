using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_Bai02_TruyenThamSo
{
    class Program
    {
        static void NhanDoi(double x)
        {
            x *= 2;
        }
        static void GapDoi(ref double x)
        {
            x *= 2;
        }

        static void HoanDoi(int x,int y)
        {
            int tam = x;
            x = y;
            y = tam;
        }

        static void HoanVi(ref int x, ref int y)
        {
            int tam = x;
            x = y;
            y = tam;
        }

        static bool ChiaHet(int SoBiChia, int SoChia, out int Thuong)
        {
            Thuong = SoBiChia / SoChia;
            return SoBiChia == Thuong * SoChia;
        }

        static void Main(string[] args)
        {
            double so = 10;

            NhanDoi(so);
            Console.WriteLine("Khong co ref: so = {0}", so);

            GapDoi(ref so);
            Console.WriteLine("Co dung ref: so = {0}", so);

            int p = 10, q = 15;
            Console.WriteLine("Ban dau : p = {0}, q = {1}", p, q);

            HoanDoi(p, q);
            Console.WriteLine("Hoan vi khong dung ref : p = {0}, q = {1}", p, q);

            HoanVi(ref p, ref q);
            Console.WriteLine("Hoan vi co dung ref : p = {0}, q = {1}", p, q);

            int a = 20, b = 4, t;
            bool kq = ChiaHet(a, b, out t);

            if (kq)
            {
                Console.WriteLine("{0} chia het cho {1}", a, b);
                Console.WriteLine("Thuong cua phep chia la : {0}", t);
            }
            Console.ReadKey();
        }
    }
}
