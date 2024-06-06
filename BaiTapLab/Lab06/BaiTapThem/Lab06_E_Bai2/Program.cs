using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_E_Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            var danhSach = new DanhSachHinh3D();
            danhSach.ThemHinh(new HinhHopChuNhat(2, 3, 4));
            danhSach.ThemHinh(new HinhTru(1, 2));
            danhSach.ThemHinh(new HinhNon(1, 3));
            danhSach.ThemHinh(new HinhCau(1));

            danhSach.XuatThongTin();
            danhSach.SapXepGiamDanTheoTheTich();
            Console.WriteLine("\nSau khi sắp xếp giảm dần theo thể tích:");
            danhSach.XuatThongTin();

            var timHinh = danhSach.TimHinhTheoLoai("HinhTru");
            Console.WriteLine($"\nHình tìm được theo loại: {timHinh}");

            var hinhCauNhoNhat = danhSach.TimHinhCauCoTheTichNhoNhat();
            Console.WriteLine($"\nHình cầu có thể tích nhỏ nhất: {hinhCauNhoNhat}");

            var hinhLonNhatKhongPhaiNonHoacCau = danhSach.TimHinhCoTheTichLonNhatKhongPhaiLaNonHoacCau();
            Console.WriteLine($"\nHình có thể tích lớn nhất không phải là nón hay cầu: {hinhLonNhatKhongPhaiNonHoacCau}");

            Console.ReadKey();
        }
    }
}
