using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_D_Bai3
{
    public class DanhSachHDH
    {
        private List<HeDieuHanh> danhSach = new List<HeDieuHanh>();

        public void ThemHeDieuHanh(HeDieuHanh hdh)
        {
            danhSach.Add(hdh);
        }

        public void NhapCoDinhDanhSach()
        {
            // Adding a predefined list of operating systems
            danhSach.Add(new Linux("Red Hat 8", new DateTime(2020, 5, 1), 200));
            danhSach.Add(new Linux("Fedora 32", new DateTime(2020, 4, 28), 500));
            danhSach.Add(new Ubuntu("Ubuntu 20.04", new DateTime(2020, 4, 23), 580));
            danhSach.Add(new Ubuntu("Ubuntu 18.04", new DateTime(2018, 4, 26), 450));
            danhSach.Add(new Windows("Windows 10", new DateTime(2015, 7, 29), 150));
            danhSach.Add(new Windows("Windows 7", new DateTime(2009, 10, 22), 120));
            danhSach.Add(new Macintosh("macOS Catalina", new DateTime(2019, 10, 7), 1000));
            danhSach.Add(new Macintosh("macOS Sierra", new DateTime(2016, 9, 20), 1500));
        }

        public void XuatDanhSachHDH()
        {
            foreach (var hdh in danhSach)
            {
                hdh.XuatThongTin();
            }
        }

        public void SapXepGiamDanTheoNgayPhatHanh()
        {
            danhSach = danhSach.OrderByDescending(hdh => hdh.NgayPhatHanh).ToList();
        }

        public void SapXepTangDanTheoGia()
        {
            danhSach = danhSach.OrderBy(hdh => hdh.GiaBan).ToList();
        }

        public List<HeDieuHanh> TimWindowsGiaLonHon(float gia)
        {
            return danhSach.Where(hdh => hdh is Windows && hdh.GiaBan > gia).ToList();
        }

        public List<HeDieuHanh> TimHDHPhatHanhNam2012()
        {
            return danhSach.Where(hdh => hdh.NgayPhatHanh.Year == 2012).ToList();
        }

        public List<HeDieuHanh> TimHDHPhienBanProfessional()
        {
            return danhSach.Where(hdh => hdh.PhienBan.Contains("Professional")).ToList();
        }

        public List<HeDieuHanh> TimHDHTruoc2010VaGiaThapHon(float gia)
        {
            return danhSach.Where(hdh => hdh.NgayPhatHanh.Year < 2010 && hdh.GiaBan < gia).ToList();
        }

        public void LietKeHDHTheoNam()
        {
            var groupedByYear = danhSach.GroupBy(hdh => hdh.NgayPhatHanh.Year);
            foreach (var group in groupedByYear)
            {
                Console.WriteLine($"Năm: {group.Key}");
                foreach (var hdh in group)
                {
                    hdh.XuatThongTin();
                }
            }
        }
    }
}
