using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab05_D_Bai2_Lab05_Bai02_KeThuaKhongDaHinh_P3__.DanhSachHinhHoc;

namespace Lab05_D_Bai2_Lab05_Bai02_KeThuaKhongDaHinh_P3__
{
    class Program
    {
        static void Main(string[] args)
        {
            DanhSachHinhHoc mang = new DanhSachHinhHoc();
            mang.NhapCoDinh();

            Console.WriteLine("So hinh hoc trong danh sach {0}", mang.SoLuong);

            mang.Xuat();

            DanhSachHinhHoc dsHCN = mang.TimHinhTheoLoai(LoaiHinh.HinhChuNhat);
            dsHCN.Xuat();

            Console.WriteLine("================================================");
            DanhSachHinhHoc hinhLon = mang.TimHinhCoDienTichLonNhat();
            hinhLon.Xuat();

            Console.WriteLine("================================================");
            DanhSachHinhHoc hcnLon = dsHCN.TimHinhCoDienTichLonNhat();
            hcnLon.Xuat();

            mang.SapTangTheoDienTich();

            Console.WriteLine("================================================");
            mang.Xuat();

            Console.WriteLine("================================================");
            DanhSachHinhHoc dsVuong = mang.TimHinhTheoLoai(LoaiHinh.HinhVuong);
            dsVuong.SapTangTheoDienTich();
            dsVuong.Xuat();

            // Sắp xếp tăng theo diện tích
            Console.WriteLine("================================================");
            mang.SapXep(KieuSapXep.TangTheoDienTich);
            mang.Xuat();

            // Sắp xếp giảm theo diện tích
            Console.WriteLine("================================================");
            mang.SapXep(KieuSapXep.GiamTheoDienTich);
            mang.Xuat();

            // Sắp xếp theo hình vuông tăng theo diện tích
            Console.WriteLine("================================================");
            mang.SapXep(KieuSapXep.SapTheoHinhVuongTangTheoDienTich);
            mang.Xuat();

            // Sắp xếp theo hình tròn giảm theo bán kính
            Console.WriteLine("================================================");
            mang.SapXep(KieuSapXep.SapTheoHinhTronGiamTheoBanKinh);
            mang.Xuat();

            // Tìm hình có diện tích nhỏ nhất

            // Tìm hình tròn có diện tích nhỏ nhất

            // Sắp các hình giảm dần theo diện tích

            // Đếm số lượng hình theo loại
            
            // Tính tổng diện tích các hình

            // Tìm hình có diện tích lớn nhất theo loại hình học cho trước

            // Tìm vị trí của hình h trong danh sách

            // Xóa một hình tại vị trí cho trước

            // Tìm hình theo diện tích

            // Xóa một hình học khỏi danh sách

            // Xóa tất cả các hình theo loại cho trước

            // Tìm hình có chu vi nhỏ nhất

            // Xuất danh sách hình theo loại cho trước và sắp tăng hoặc giảm

            // Tính tổng chu vi các hình theo loại

            // Tìm những hình có diện tích bằng bình phương của chu vi

            Console.ReadKey();
        }
    }
}
