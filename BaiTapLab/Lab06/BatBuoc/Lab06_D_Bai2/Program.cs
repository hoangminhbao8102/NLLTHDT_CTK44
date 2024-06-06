using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_D_Bai2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            DanhSachHDH danhSach = new DanhSachHDH();

            danhSach.ThemHDH(new Linux("18.04", new DateTime(2018, 4, 26), 0));
            danhSach.ThemHDH(new Linux("20.04", new DateTime(2020, 4, 23), 0));
            danhSach.ThemHDH(new Ubuntu("18.04 LTS", new DateTime(2018, 4, 26), 0));
            danhSach.ThemHDH(new Ubuntu("20.04 LTS", new DateTime(2020, 4, 23), 0));
            danhSach.ThemHDH(new Windows("10 Home", new DateTime(2015, 7, 29), 120));
            danhSach.ThemHDH(new Windows("10 Professional", new DateTime(2015, 7, 29), 200));
            danhSach.ThemHDH(new Macintosh("OS X El Capitan", new DateTime(2015, 9, 30), 100));
            danhSach.ThemHDH(new Macintosh("OS X Yosemite", new DateTime(2014, 10, 16), 100));

            Console.WriteLine("Original List:");
            danhSach.XuatThongTin();

            Console.WriteLine("Sorted by Release Date Descending:");
            danhSach.SapXepGiamDanNgayPhatHanh();
            danhSach.XuatThongTin();

            Console.WriteLine("Sorted by Price Ascending:");
            danhSach.SapXepTangDanGia();
            danhSach.XuatThongTin();

            Console.WriteLine("Windows with Price > $150:");
            danhSach.TimHDHWindowsGiaLonHonM(150);

            Console.WriteLine("Released in 2012:");
            danhSach.TimHDHPhatHanhNam2012();

            Console.WriteLine("Version Professional:");
            danhSach.TimHDHPhienBanProfessional();

            Console.WriteLine("Released before 2010 with Price < $100:");
            danhSach.TimHDHPhatHanhTruoc2010GiaThapHonM(100);

            Console.WriteLine("List by Year of Release:");
            danhSach.LietKeHDHTheoNam();

            Console.ReadKey();
        }
    }
}
