using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_Bai02_ThamSoLaDelegate
{
    public class Program
    {
        static void Main(string[] args)
        {
            MangSoNguyen mangNguyen = new MangSoNguyen();

            mangNguyen.NhapNgauNhien(100);

            mangNguyen.XuatMang();
            Console.WriteLine("".PadRight(80, '='));

            KiemTraDieuKien dieuKien = ChiaHetCho5;

            MangSoNguyen ketQua = mangNguyen.Tim(dieuKien);

            ketQua.XuatMang();
            Console.WriteLine("".PadRight(80, '='));

            ketQua = mangNguyen.Tim(LaSoNguyenTo);
            ketQua.XuatMang();

            Console.ReadKey();
        }

        static bool LaSoNguyenTo(int x)
        {
            if (x < 2)
            {
                return false;
            }

            for (int i = 2; i <= x / 2; i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static bool ChiaHetCho5(int x)
        {
            return x % 5 == 0;
        }
    }
}
