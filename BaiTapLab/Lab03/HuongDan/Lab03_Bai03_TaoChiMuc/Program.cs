using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_Bai03_TaoChiMuc
{
    class Program
    {
        static void Main(string[] args)
        {
            MangSoThuc array = new MangSoThuc();

            array.Them(10.5);
            array.Them(3.0);
            array.Them(1.75);
            array.Them(100.2);
            array.Them(-6.04);
            array.Them(3.33);
            array.Them(-89.345);
            array.Them(-12.19);
            array.Them(Math.Round(Math.PI, 3));
            array.Them(Math.Round(Math.E, 3));

            double GiaTri = array[3];

            Console.WriteLine("Array[3] = {0}", GiaTri);

            for (int i = 0; i < array.SoLuong; i++)
            {
                Console.Write("{0}\t", array[i]);
            }

            array[6] = 10.077;

            for (int i = 0; i < array.SoLuong; i++)
            {
                Console.Write("{0}\t", array[i]);
            }

            MangSoThuc mangSoThuc = new MangSoThuc();

            // Nhập mảng từ bàn phím
            Console.Write("Nhập số phần tử của mảng: ");
            int soPhanTu = int.Parse(Console.ReadLine());
            mangSoThuc.NhapTay(soPhanTu);

            // Xuất mảng ra màn hình
            mangSoThuc.XuatMang();

            // Nhập mảng cố định
            mangSoThuc.NhapCoDinh();

            // Xuất mảng ra màn hình
            mangSoThuc.XuatMang();

            // Nhập mảng ngẫu nhiên
            Console.Write("Nhập số phần tử của mảng: ");
            soPhanTu = int.Parse(Console.ReadLine());
            mangSoThuc.NhapNgauNhien(soPhanTu);

            // Xuất mảng ra màn hình
            mangSoThuc.XuatMang();

            // Tìm số âm trong mảng
            MangSoThuc mangSoAm = mangSoThuc.TimSoAm();
            Console.WriteLine("Các số âm trong mảng là:");
            mangSoAm.XuatMang();

            Console.ReadKey();
        }
    }
}
