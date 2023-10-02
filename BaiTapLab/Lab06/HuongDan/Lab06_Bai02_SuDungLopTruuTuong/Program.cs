using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_Bai02_SuDungLopTruuTuong
{
    public class Program
    {
        static void Main(string[] args)
        {
            //HinhHoc hinh = new HinhHoc(10);
            HinhTron vong = new HinhTron(5);
            HinhHoc tron = new HinhTron(5);
            HinhHoc vuong = new HinhVuong(5);
            HinhHoc cnhat = new HinhChuNhat(5, 3);

            vong.Xuat();
            tron.Xuat();
            vuong.Xuat();
            cnhat.Xuat();

            Console.WriteLine(vong.TinhDienTich());
            Console.WriteLine(tron.TinhDienTich());
            Console.WriteLine(vuong.TinhDienTich());
            Console.WriteLine(cnhat.TinhDienTich());

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

            Console.ReadKey();
        }
    }
}
