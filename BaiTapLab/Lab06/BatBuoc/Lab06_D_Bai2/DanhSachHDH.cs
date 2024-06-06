using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_D_Bai2
{
    class DanhSachHDH
    {
        private List<HeDieuHanh> danhSach;

        public DanhSachHDH()
        {
            danhSach = new List<HeDieuHanh>();
        }

        public void ThemHDH(HeDieuHanh hdh)
        {
            danhSach.Add(hdh);
        }

        public void XuatThongTin()
        {
            foreach (var hdh in danhSach)
            {
                hdh.XuatThongTin();
                Console.WriteLine();
            }
        }

        public void SapXepGiamDanNgayPhatHanh()
        {
            danhSach = danhSach.OrderByDescending(hdh => hdh.NgayPhatHanh).ToList();
        }

        public void SapXepTangDanGia()
        {
            danhSach = danhSach.OrderBy(hdh => hdh.GiaBan).ToList();
        }

        public void TimHDHWindowsGiaLonHonM(float m)
        {
            var filtered = danhSach.Where(hdh => hdh is Windows && hdh.GiaBan > m);
            foreach (var hdh in filtered)
            {
                hdh.XuatThongTin();
                Console.WriteLine();
            }
        }

        public void TimHDHPhatHanhNam2012()
        {
            var filtered = danhSach.Where(hdh => hdh.NgayPhatHanh.Year == 2012);
            foreach (var hdh in filtered)
            {
                hdh.XuatThongTin();
                Console.WriteLine();
            }
        }

        public void TimHDHPhienBanProfessional()
        {
            var filtered = danhSach.Where(hdh => hdh.PhienBan.Contains("Professional"));
            foreach (var hdh in filtered)
            {
                hdh.XuatThongTin();
                Console.WriteLine();
            }
        }

        public void TimHDHPhatHanhTruoc2010GiaThapHonM(float m)
        {
            var filtered = danhSach.Where(hdh => hdh.NgayPhatHanh.Year < 2010 && hdh.GiaBan < m);
            foreach (var hdh in filtered)
            {
                hdh.XuatThongTin();
                Console.WriteLine();
            }
        }

        public void LietKeHDHTheoNam()
        {
            var grouped = danhSach.GroupBy(hdh => hdh.NgayPhatHanh.Year).OrderBy(group => group.Key);
            foreach (var group in grouped)
            {
                Console.WriteLine($"Năm: {group.Key}");
                foreach (var hdh in group)
                {
                    hdh.XuatThongTin();
                    Console.WriteLine();
                }
            }
        }
    }
}
