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
            HinhHoc hinh = new HinhHoc();

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
            Console.WriteLine("================================================");
            DanhSachHinhHoc hinhNhoNhat = mang.TimHinhCoDienTichNhoNhat();
            hinhNhoNhat.Xuat();

            // Tìm hình tròn có diện tích nhỏ nhất
            Console.WriteLine("================================================");
            DanhSachHinhHoc hinhTronNhoNhat = mang.TimHinhTronNhoNhat();
            hinhTronNhoNhat.Xuat();

            // Sắp các hình giảm dần theo diện tích
            Console.WriteLine("================================================");
            mang.SapGiamTheoDienTich();
            mang.Xuat();

            // Đếm số lượng hình theo loại
            Console.WriteLine("================================================");
            int soLuongHinh = mang.DemSoLuongHinh(LoaiHinh.HinhChuNhat);
            Console.WriteLine("So luong hinh chu nhat: {0}", soLuongHinh);

            // Tính tổng diện tích các hình
            Console.WriteLine("================================================");
            double tongDienTich = mang.TinhTongDienTich();
            Console.WriteLine("Tong dien tich: {0}", tongDienTich);

            // Tìm hình có diện tích lớn nhất theo loại hình học cho trước
            Console.WriteLine("================================================");
            DanhSachHinhHoc hinhLonNhatTheoLoai = mang.TimHinhCoDienTichLonNhat(LoaiHinh.HinhChuNhat);
            hinhLonNhatTheoLoai.Xuat();

            // Tìm vị trí của hình h trong danh sách
            Console.WriteLine("================================================");
            Console.WriteLine("Nhap vi tri: ");
            int viTri = int.Parse(Console.ReadLine()); 
            hinh = new HinhHoc();
            viTri = mang.TimViTriCuaHinh(hinh);
            Console.WriteLine("Vi tri cua hinh: {0}", viTri);

            // Xóa một hình tại vị trí cho trước
            Console.WriteLine("================================================");
            bool xoaTaiViTri = mang.XoaTaiViTri(viTri);
            Console.WriteLine("Xoa tai vi tri: {0}", xoaTaiViTri);

            // Tìm hình theo diện tích
            Console.WriteLine("================================================");
            DanhSachHinhHoc hinhTheoDTich = mang.TimHinhTheoDTich(10.5);
            hinhTheoDTich.Xuat();

            // Xóa một hình học khỏi danh sách
            Console.WriteLine("================================================");
            hinh = new HinhHoc();
            bool xoaHinh = mang.XoaHinh(hinh);
            Console.WriteLine("Xoa hinh: {0}", xoaHinh);

            // Xóa tất cả các hình theo loại cho trước
            Console.WriteLine("================================================");
            mang.XoaHinhTheoLoai(LoaiHinh.HinhVuong);
            mang.Xuat();

            // Tìm hình có chu vi nhỏ nhất
            Console.WriteLine("================================================");
            DanhSachHinhHoc hinhChuViNhoNhat = mang.TimHinhCoChuViNhoNhat();
            hinhChuViNhoNhat.Xuat();

            // Xuất danh sách hình theo loại cho trước và sắp tăng hoặc giảm
            Console.WriteLine("================================================");
            mang.XuatHinhTheoChieuTangGiam(LoaiHinh.HinhChuNhat, true);

            // Tính tổng chu vi các hình theo loại
            Console.WriteLine("================================================");
            double tongChuVi = mang.TinhTongChuVi(LoaiHinh.HinhChuNhat);
            Console.WriteLine("Tong chu vi hinh chu nhat: {0}", tongChuVi);

            // Tìm những hình có diện tích bằng bình phương của chu vi
            Console.WriteLine("================================================");
            DanhSachHinhHoc hinhDienTichBangBinhPhuongChuVi = mang.TimHinhCoDienTichBangBinhPhuongChuVi();
            hinhDienTichBangBinhPhuongChuVi.Xuat();

            Console.ReadKey();
        }
    }
}
