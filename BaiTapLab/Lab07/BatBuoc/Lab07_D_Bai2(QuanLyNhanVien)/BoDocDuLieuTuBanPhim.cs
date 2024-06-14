using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_D_Bai2_QuanLyNhanVien_
{
    class BoDocDuLieuTuBanPhim : BoDocDuLieu
    {
        private const char SEPARATOR = ',';

        private void XuatCacLuaChon()
        {
            Console.WriteLine("========CHON CHUC NANG=======");
            Console.WriteLine("1. Nhap nhan vien hop dong");
            Console.WriteLine("2. Nhap nhan vien theo gio");
            Console.WriteLine("3. Nhap cham cong");
            Console.WriteLine("0. Dung viec nhap du lieu");
            Console.WriteLine("=============================");
            Console.WriteLine();
            Console.Write("Nhap mot so tu 0 den 3: ");
        }

        private int ChonChucNang()
        {
            int chon = 0;
            do
            {
                XuatCacLuaChon();
                chon = int.Parse(Console.ReadLine());
            } while (chon < 0 || chon > 3);
            return chon;
        }

        private NhanVienHopDong NhapNhanVienHopDong()
        {
            Console.WriteLine("\nNhap thong tin nhan vien hop dong:");
            Console.Write("Nhap ma so: ");
            int maSo = int.Parse(Console.ReadLine());

            Console.Write("Nhap ho ten: ");
            string hoTen = Console.ReadLine();

            Console.Write("Nhap gioi tinh: ");
            string gioiTinh = Console.ReadLine();

            Console.Write("Nhap ngay bat dau (yyyy-MM-dd): ");
            DateTime ngayBd = DateTime.Parse(Console.ReadLine());

            Console.Write("Nhap he so luong: ");
            double heSoLuong = double.Parse(Console.ReadLine());

            Console.Write("Nhap tien phu cap: ");
            int phuCap = int.Parse(Console.ReadLine());

            return new NhanVienHopDong(maSo, hoTen, gioiTinh, ngayBd, heSoLuong, phuCap);
        }

        private NhanVienTheoGio NhapNhanVienTheoGio()
        {
            Console.WriteLine("\nNhap thong tin nhan vien theo gio:");
            Console.Write("Nhap ma so: ");
            int maSo = int.Parse(Console.ReadLine());

            Console.Write("Nhap ho ten: ");
            string hoTen = Console.ReadLine();

            Console.Write("Nhap gioi tinh: ");
            string gioiTinh = Console.ReadLine();

            Console.Write("Nhap ngay bat dau (yyyy-MM-dd): ");
            DateTime ngayBd = DateTime.Parse(Console.ReadLine());

            Console.Write("Nhap tien cong moi gio: ");
            int tienCong = int.Parse(Console.ReadLine());

            return new NhanVienTheoGio(maSo, hoTen, gioiTinh, ngayBd, tienCong);
        }

        private ChamCong NhapChamCong()
        {
            Console.WriteLine("\nNhập thông tin chấm công:");
            Console.Write("Nhập mã nhân viên: ");
            int maNV = int.Parse(Console.ReadLine());

            Console.Write("Nhập tháng: ");
            int thang = int.Parse(Console.ReadLine());

            Console.Write("Nhập số ngày/giờ công: ");
            int soNgayGio = int.Parse(Console.ReadLine());

            return new ChamCong(maNV, thang, soNgayGio);
        }

        public override DanhSachChamCong DocDuLieuChamCong()
        {
            DanhSachChamCong danhSach = new DanhSachChamCong();

            while (true)
            {
                int chucNang = ChonChucNang();
                if (chucNang == 0)
                {
                    break;
                }

                if (chucNang == 3)
                {
                    danhSach.Them(NhapChamCong());
                }
            }

            return danhSach;
        }

        public override DanhSachNhanVien DocDuLieuNhanVien()
        {
            DanhSachNhanVien danhSach = new DanhSachNhanVien();

            while (true)
            {
                int chucNang = ChonChucNang();
                if (chucNang == 0)
                {
                    break;
                }

                switch (chucNang)
                {
                    case 1:
                        danhSach.Them(NhapNhanVienHopDong());
                        break;
                    case 2:
                        danhSach.Them(NhapNhanVienTheoGio());
                        break;
                }
            }

            return danhSach;
        }
    }
}
