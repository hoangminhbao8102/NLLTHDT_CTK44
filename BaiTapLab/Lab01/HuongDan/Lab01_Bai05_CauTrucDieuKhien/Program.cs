using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_Bai05_CauTrucDieuKhien
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap gio hien tai (0..24): ");

            int GioHienTai;
            GioHienTai = int.Parse(Console.ReadLine());

            if (GioHienTai % 2 == 0)
            {
                Console.WriteLine("Gio chan");
            }
            else
            {
                Console.WriteLine("Gio le");
            }

            if (GioHienTai < 0 || GioHienTai > 24)
            {
                Console.WriteLine("Ban nhap gio sai");
            }
            else if (GioHienTai <= 12)
            {
                Console.WriteLine("Chao buoi sang");
            }
            else
            {
                Console.WriteLine("Chao buoi chieu");
            }

            int n = 10, tong = 0;

            for (int i = 1; i < n; i++)
            {
                tong += i;
            }

            Console.WriteLine("1 + 2 + ... + {0} = {1}", n, tong);

            double SoTienVay = 25000000, LaiSuat = 0.01, TienTra = 2000000;
            int SoThang = 0;

            while (SoTienVay > 0)
            {
                SoThang++;
                SoTienVay *= 1 + LaiSuat;
                SoTienVay -= TienTra;
            }

            Console.WriteLine("So thang phai tra tien : {0}",SoThang);

            int number = 0;

            do
            {
                Console.Write("Nhap mot so tu 0 den 10 : ");
                number = int.Parse(Console.ReadLine());
            } while (number < 0 || number > 10);

            char diem = 'B';
            switch (diem)
            {
                case 'A':
                    Console.WriteLine("Hoc luc GIOI");
                    break;
                case 'B':
                    Console.WriteLine("Hoc luc KHA");
                    break;
                case 'C':
                    Console.WriteLine("Hoc luc TRUNG BINH");
                    break;
                case 'D':
                    Console.WriteLine("Hoc luc YEU");
                    break;
                default:
                    Console.WriteLine("Khong xep loai");
                    break;
            }

            Console.ReadKey();
        }
    }
}
