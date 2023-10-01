using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab05_D_Bai1_Lab05_Bai02_KeThuaKhongDaHinh_P2__.DanhSachHinhHoc;

namespace Lab05_D_Bai1_Lab05_Bai02_KeThuaKhongDaHinh_P2__
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

            Console.ReadKey();
        }
    }
}
