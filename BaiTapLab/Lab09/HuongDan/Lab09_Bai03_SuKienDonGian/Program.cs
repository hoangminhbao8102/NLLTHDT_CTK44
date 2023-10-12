using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_Bai03_SuKienDonGian
{
    public class Program
    {
        static void Main(string[] args)
        {
            MangSoNguyen mangNguyen = new MangSoNguyen();

            mangNguyen.ThemThanhCong += new XuLyThem(XuatPhanTu);

            mangNguyen.NhapNgauNhien(100);

            mangNguyen.XuatMang();

            Console.ReadKey();
        }

        static void XuatPhanTu(int phanTu)
        {
            Console.Write("Phan tu moi : {0}\r\n", phanTu);
        }
    }
}
