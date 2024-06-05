using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_E_Bai2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Tạo một danh sách các hình 3D
            DanhSachHinh3D danhSach = new DanhSachHinh3D();

            // Thêm các hình vào danh sách
            danhSach.ThemHinh(new HinhHopChuNhat(3, 4, 5));
            danhSach.ThemHinh(new HinhTru(3, 5));
            danhSach.ThemHinh(new HinhCau(4));
            danhSach.ThemHinh(new HinhNon(3, 7));

            // Xuất thông tin của các hình
            Console.WriteLine("Thông tin các hình:");
            danhSach.XuatThongTin();

            // Sắp xếp các hình theo thể tích giảm dần và xuất thông tin
            danhSach.SapXepGiamDanTheoTheTich();
            Console.WriteLine("\nThông tin các hình sau khi sắp xếp giảm dần theo thể tích:");
            danhSach.XuatThongTin();

            // Tìm hình theo loại
            var hinhTru = danhSach.TimHinhTheoLoai<HinhTru>();
            if (hinhTru != null)
            {
                Console.WriteLine($"\nThông tin hình trụ tìm được: Thể tích = {hinhTru.TinhTheTich()}");
            }

            // Tìm hình cầu có thể tích nhỏ nhất
            var hinhCauNhoNhat = danhSach.TimHinhCauTheTichNhoNhat();
            if (hinhCauNhoNhat != null)
            {
                Console.WriteLine($"\nHình cầu có thể tích nhỏ nhất: Thể tích = {hinhCauNhoNhat.TinhTheTich()}");
            }

            // Tìm hình có thể tích lớn nhất không phải là hình nón hay hình cầu
            var hinhTheTichLonNhatKhongPhaiNonHoacCau = danhSach.TimHinhTheTichLonNhatKhongPhaiHinhNonHoacHinhCau();
            if (hinhTheTichLonNhatKhongPhaiNonHoacCau != null)
            {
                Console.WriteLine($"\nHình có thể tích lớn nhất không phải hình nón hoặc hình cầu: Thể tích = {hinhTheTichLonNhatKhongPhaiNonHoacCau.TinhTheTich()}");
            }

            Console.ReadKey();
        }
    }
}
