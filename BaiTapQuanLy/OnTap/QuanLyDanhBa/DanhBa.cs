using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDanhBa
{
    class DanhBa
    {
        private List<ThueBao> danhSachThueBao = new List<ThueBao>();

        public void Them(ThueBao tb)
        {
            danhSachThueBao.Add(tb);
        }

        public void NhapTuFile(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                string str;
                while ((str = sr.ReadLine()) != null)
                {
                    Them(new ThueBao(str));
                }
            }
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, danhSachThueBao.Select((tb, index) => $"{index + 1}) {tb}"));
        }

        public int DemSoDTTheoThueBao(string CMND)
        {
            return danhSachThueBao.Count(tb => tb.SoCMND == CMND);
        }

        public int TimSoLanSoThueBaoXuatHienNhieuNhat()
        {
            return danhSachThueBao
                .GroupBy(tb => tb.SoCMND)
                .Max(g => g.Count());
        }

        private bool CoChua(ThueBao tb)
        {
            return danhSachThueBao.Any(t => t.SoCMND == tb.SoCMND);
        }

        public DanhBa TimThueBaoCoNhieuSDT()
        {
            DanhBa kq = new DanhBa();
            int max = TimSoLanSoThueBaoXuatHienNhieuNhat();
            foreach (var tb in danhSachThueBao.Where(tb => DemSoDTTheoThueBao(tb.SoCMND) == max && !kq.CoChua(tb)))
            {
                kq.Them(tb);
            }
            return kq;
        }

        private int KiemTraDieuKien(ThueBao tb1, ThueBao tb2, KieuSapXep k)
        {
            switch (k)
            {
                case KieuSapXep.TangTheoHoTen:
                    return string.Compare(tb1.HoTen, tb2.HoTen);
                case KieuSapXep.GiamTheoHoTen:
                    return string.Compare(tb2.HoTen, tb1.HoTen);
                case KieuSapXep.TangTheoNgaySinh:
                    return tb1.NgaySinh.CompareTo(tb2.NgaySinh);
                case KieuSapXep.GiamTheoNgaySinh:
                    return tb2.NgaySinh.CompareTo(tb1.NgaySinh);
                default:
                    throw new ArgumentException("Kiểu sắp xếp không hợp lệ!");
            }
        }

        public void SapXep(KieuSapXep k)
        {
            danhSachThueBao.Sort((tb1, tb2) => KiemTraDieuKien(tb1, tb2, k));
        }

        public void TimThanhPhoNhieuItThueBaoNhat()
        {
            if (danhSachThueBao.Count == 0)
            {
                Console.WriteLine("Danh bạ trống.");
                return;
            }

            var demThueBaoTheoThanhPho = danhSachThueBao
                .GroupBy(tb => tb.DiaChi.Split(',')[2].Trim()) // Giả sử thành phố nằm ở phần tử thứ 3 của địa chỉ
                .Select(grp => new { ThanhPho = grp.Key, SoLuong = grp.Count() })
                .ToList();

            var nhieuNhat = demThueBaoTheoThanhPho.OrderByDescending(item => item.SoLuong).First();
            var itNhat = demThueBaoTheoThanhPho.OrderBy(item => item.SoLuong).First();

            Console.WriteLine($"Thành phố có nhiều thuê bao nhất là {nhieuNhat.ThanhPho} với {nhieuNhat.SoLuong} thuê bao.");
            Console.WriteLine($"Thành phố có ít thuê bao nhất là {itNhat.ThanhPho} với {itNhat.SoLuong} thuê bao.");
        }

        public ThueBao TimThueBaoItSDTNhat()
        {
            return danhSachThueBao.OrderBy(tb => tb.DanhSachSoDienThoai.Count).FirstOrDefault();
        }

        public void SapXepTheoHoTenVaSoDienThoai(bool tangTheoHoTen = true)
        {
            if (tangTheoHoTen)
            {
                danhSachThueBao = danhSachThueBao.OrderBy(tb => tb.HoTen).ThenBy(tb => tb.DanhSachSoDienThoai.Count).ToList();
            }
            else
            {
                danhSachThueBao = danhSachThueBao.OrderByDescending(tb => tb.HoTen).ThenBy(tb => tb.DanhSachSoDienThoai.Count).ToList();
            }
        }

        public IEnumerable<(string ThanhPho, int SoLuong)> HienThiThanhPhoTheoSoLuongThueBao()
        {
            var counts = danhSachThueBao.GroupBy(tb => tb.DiaChi.Split(',')[2].Trim())
                                        .Select(grp => new
                                        {
                                            ThanhPho = grp.Key,
                                            SoLuong = grp.Count()
                                        })
                                        .ToList(); // Make sure to convert it to List or Array

            return counts.Select(c => (c.ThanhPho, c.SoLuong));
        }

        public void TimThangKhongCoDangKy()
        {
            HashSet<int> monthsWithSubscriptions = new HashSet<int>(danhSachThueBao.Select(tb => tb.NgayDangKy.Month));
            List<int> monthsWithoutSubscriptions = new List<int>();

            for (int month = 1; month <= 12; month++)
            {
                if (!monthsWithSubscriptions.Contains(month))
                {
                    monthsWithoutSubscriptions.Add(month);
                }
            }

            if (monthsWithoutSubscriptions.Count > 0)
            {
                Console.WriteLine("Các tháng không có đăng ký: " + string.Join(", ", monthsWithoutSubscriptions));
            }
            else
            {
                Console.WriteLine("Mỗi tháng đều có đăng ký.");
            }
        }

        public void TimKhachHangTheoGioiTinh(GioiTinh gioiTinh)
        {
            var khachHangTheoGioiTinh = danhSachThueBao.Where(tb => tb.GioiTinh == gioiTinh).ToList();

            foreach (var kh in khachHangTheoGioiTinh)
            {
                Console.WriteLine(kh);
            }
        }

        public void XoaKhachHangTheoTinh(string tinh)
        {
            danhSachThueBao = danhSachThueBao.Where(tb => !tb.DiaChi.Contains(tinh)).ToList();
            Console.WriteLine($"Đã xóa tất cả khách hàng ở tỉnh {tinh}.");
        }

        public void TangSoDienThoaiChoSinhThang1()
        {
            foreach (var tb in danhSachThueBao.Where(tb => tb.NgaySinh.Month == 1))
            {
                tb.SDT = tb.SoCMND; // Ví dụ đơn giản: gán số CMND làm số điện thoại mới
            }
        }

        public void TimNgayDangKyNhieuItNhat()
        {
            var ngayDangKyCounts = danhSachThueBao.GroupBy(tb => tb.NgayDangKy.Date)
                                                  .Select(grp => new { Ngay = grp.Key, SoLuong = grp.Count() })
                                                  .ToList();
            var nhieuNhat = ngayDangKyCounts.OrderByDescending(item => item.SoLuong).First();
            var itNhat = ngayDangKyCounts.OrderBy(item => item.SoLuong).First();

            Console.WriteLine($"Ngày có nhiều đăng ký nhất: {nhieuNhat.Ngay} ({nhieuNhat.SoLuong})");
            Console.WriteLine($"Ngày có ít đăng ký nhất: {itNhat.Ngay} ({itNhat.SoLuong})");
        }

        public void ThongKeTheoTinhVaThanhPho()
        {
            var thongKe = danhSachThueBao
                .GroupBy(tb => tb.DiaChi.Split(',')[4].Trim()) // Giả sử tỉnh nằm ở phần tử thứ 5 của địa chỉ
                .Select(tinhGroup => new
                {
                    Tinh = tinhGroup.Key,
                    ThanhPho = tinhGroup
                        .GroupBy(tb => tb.DiaChi.Split(',')[2].Trim())
                        .Select(tpGroup => new { ThanhPho = tpGroup.Key, SoLuong = tpGroup.Count(), DanhSach = tpGroup.ToList() })
                        .ToList()
                })
                .ToList();

            foreach (var tinh in thongKe)
            {
                Console.WriteLine($"Tỉnh: {tinh.Tinh} (tổng số thuê bao: {tinh.ThanhPho.Sum(tp => tp.SoLuong)})");
                foreach (var thanhPho in tinh.ThanhPho)
                {
                    Console.WriteLine($"\tThành Phố: {thanhPho.ThanhPho} (tổng số thuê bao: {thanhPho.SoLuong})");
                    foreach (var thueBao in thanhPho.DanhSach)
                    {
                        Console.WriteLine($"\t\t{thueBao.SoCMND}, {thueBao.HoTen}, {thueBao.DiaChi}, {thueBao.SDT}");
                    }
                }
            }
        }

        public void TimThanhPhoNhieuItThueBaoCoDinhDiDong()
        {
            var coDinh = danhSachThueBao.Where(tb => tb.LoaiThueBao == ThueBaoType.FixedLine)
                                .GroupBy(tb => tb.DiaChi)
                                .OrderByDescending(g => g.Count())
                                .FirstOrDefault()?.Key;

            var diDong = danhSachThueBao.Where(tb => tb.LoaiThueBao == ThueBaoType.Mobile)
                                .GroupBy(tb => tb.DiaChi)
                                .OrderBy(g => g.Count())
                                .FirstOrDefault()?.Key;

            Console.WriteLine($"Thành phố có nhiều thuê bao cố định nhất: {coDinh}");
            Console.WriteLine($"Thành phố có ít thuê bao di động nhất: {diDong}");
        }

        public ThueBao TimThueBaoItSoCoDinhNhat()
        {
            return danhSachThueBao.Where(tb => tb.LoaiThueBao == ThueBaoType.FixedLine)
                                   .OrderBy(tb => tb.DanhSachSoDienThoai.Count)
                                   .FirstOrDefault();
        }

        public void TimThangKhongCoDangKyLoaiThueBao(ThueBaoType loaiThueBao)
        {
            HashSet<int> months = new HashSet<int>(
                danhSachThueBao.Where(tb => tb.LoaiThueBao == loaiThueBao).Select(tb => tb.NgayDangKy.Month));

            for (int i = 1; i <= 12; i++)
            {
                if (!months.Contains(i))
                    Console.WriteLine($"Tháng {i} không có đăng ký thuê bao {loaiThueBao}");
            }
        }

        public DanhBa TimThueBaoDiDongTheoGioiTinh(GioiTinh gioiTinh)
        {
            DanhBa danhBaMoi = new DanhBa();
            var thueBaos = danhSachThueBao.Where(tb => tb.GioiTinh == gioiTinh && tb.LoaiThueBao == ThueBaoType.Mobile).ToList();
            foreach (var thueBao in thueBaos)
            {
                danhBaMoi.Them(thueBao);
            }
            return danhBaMoi;
        }

        public void XoaThueBaoTheoNgayLapDat(DateTime ngayLapDat)
        {
            danhSachThueBao = danhSachThueBao.Where(tb => !tb.NgayLapDat.HasValue || tb.NgayLapDat.Value != ngayLapDat).ToList();
            Console.WriteLine("Đã xóa các thuê bao theo ngày lắp đặt.");
        }

        public DanhBa TimKhachHangDiDongTheoNhaCungCap(string nhaCungCap)
        {
            DanhBa danhBaMoi = new DanhBa();
            var thueBaos = danhSachThueBao.Where(tb => tb.LoaiThueBao == ThueBaoType.Mobile && tb.NhaCungCap == nhaCungCap).ToList();

            foreach (var thueBao in thueBaos)
            {
                danhBaMoi.Them(thueBao);
            }

            return danhBaMoi;
        }

        public void HienThiSoLuongThueBaoTheoLoai()
        {
            var soLuongCoDinh = danhSachThueBao.Count(tb => tb.LoaiThueBao == ThueBaoType.FixedLine);
            var soLuongDiDong = danhSachThueBao.Count(tb => tb.LoaiThueBao == ThueBaoType.Mobile);

            Console.WriteLine($"Số lượng thuê bao cố định: {soLuongCoDinh}");
            Console.WriteLine($"Số lượng thuê bao di động: {soLuongDiDong}");
        }

        public void HienThiSoLuongThueBaoCoDinhTheoNhaCungCap()
        {
            var nhomTheoNhaCungCap = danhSachThueBao.Where(tb => tb.LoaiThueBao == ThueBaoType.FixedLine)
                                                    .GroupBy(tb => tb.NhaCungCap)
                                                    .ToDictionary(g => g.Key, g => g.Count());

            foreach (var nhom in nhomTheoNhaCungCap)
            {
                Console.WriteLine($"Nhà cung cấp: {nhom.Key}, Số lượng thuê bao cố định: {nhom.Value}");
            }
        }
    }
}
