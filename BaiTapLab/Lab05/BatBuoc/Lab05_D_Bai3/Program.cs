using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_D_Bai3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            var danhSachHDH = new DanhSachHDH();

            // Populate the list with predefined data
            danhSachHDH.NhapCoDinhDanhSach();

            // Outputting information about the created OS instances
            Console.WriteLine("Danh sách Hệ Điều Hành ban đầu:");
            danhSachHDH.XuatDanhSachHDH();

            // Sắp xếp giảm dần theo ngày phát hành và xuất kết quả
            Console.WriteLine("\nSắp xếp giảm dần theo ngày phát hành:");
            danhSachHDH.SapXepGiamDanTheoNgayPhatHanh();
            danhSachHDH.XuatDanhSachHDH();

            // Sắp xếp tăng dần theo giá và xuất kết quả
            Console.WriteLine("\nSắp xếp tăng dần theo giá:");
            danhSachHDH.SapXepTangDanTheoGia();
            danhSachHDH.XuatDanhSachHDH();

            // Tìm Windows có giá lớn hơn 100
            Console.WriteLine("\nTìm hệ điều hành Windows có giá bán lớn hơn 100 VND:");
            List<HeDieuHanh> windowsGiaLonHon = danhSachHDH.TimWindowsGiaLonHon(100);
            foreach (var hdh in windowsGiaLonHon)
            {
                hdh.XuatThongTin();
            }

            // Tìm HĐH phát hành năm 2012
            Console.WriteLine("\nTìm hệ điều hành phát hành năm 2012:");
            List<HeDieuHanh> hdhNam2012 = danhSachHDH.TimHDHPhatHanhNam2012();
            foreach (var hdh in hdhNam2012)
            {
                hdh.XuatThongTin();
            }

            // Tìm HĐH phiên bản Professional
            Console.WriteLine("\nTìm hệ điều hành phiên bản Professional:");
            List<HeDieuHanh> professionalHDH = danhSachHDH.TimHDHPhienBanProfessional();
            foreach (var hdh in professionalHDH)
            {
                hdh.XuatThongTin();
            }

            // Tìm HĐH trước năm 2010 và có giá thấp hơn 150
            Console.WriteLine("\nTìm hệ điều hành phát hành trước năm 2010 và có giá thấp hơn 150 VND:");
            List<HeDieuHanh> hdhTruoc2010VaGiaThap = danhSachHDH.TimHDHTruoc2010VaGiaThapHon(150);
            foreach (var hdh in hdhTruoc2010VaGiaThap)
            {
                hdh.XuatThongTin();
            }

            // Liệt kê HĐH theo năm
            Console.WriteLine("\nLiệt kê hệ điều hành theo năm phát hành:");
            danhSachHDH.LietKeHDHTheoNam();

            Console.ReadKey();
        }
    }
}
