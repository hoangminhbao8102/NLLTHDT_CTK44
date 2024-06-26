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
        ThueBao[] a = new ThueBao[100];
        int length = 0;
        public void Them(ThueBao tb)
        {
            a[length++] = tb;
        }
        public void NhapTuFile()
        {
            string path = @"data.txt";
            StreamReader sr = new StreamReader(path);
            string str = "";
            while ((str = sr.ReadLine()) != null) 
            {
                Them(new ThueBao(str));
            }
        }
        public override string ToString() 
        {
            string s = "";
            for (int i = 0; i < length; i++)
            {
                int k = i + 1;
                s += k.ToString() + ") " + a[i];
            }
            return s;
        }

        public int DemSoDTTheoThueBao(string CMND)
        {
            int dem = 0;
            for (int i = 0; i < length; i++)
            {
                if (a[i].SoCMND==CMND)
                {
                    dem++;
                }
            }
            return dem;
        }
        public int TimSoLanSoThueBaoXuatHienNhieuNhat()
        {
            int max = -1;
            for (int i = 0; i < length; i++)
            {
                int dem = DemSoDTTheoThueBao(a[i].SoCMND);
                if (dem > max)
                    max = dem;
            }
            return max;
        }
        bool CoChua(ThueBao tb)
        {
            for (int i = 0; i < length; i++)
            {
                if (a[i].SoCMND == tb.SoCMND) 
                {
                    return true;
                }
            }
            return false;
        }
        public DanhBa TimThueBaoCoNhieuSDT()
        {
            DanhBa kq = new DanhBa();
            int max = TimSoLanSoThueBaoXuatHienNhieuNhat();
            for (int i = 0; i < length; i++)
            {
                if (DemSoDTTheoThueBao(a[i].SoCMND) == max && !kq.CoChua(a[i])) 
                {
                    kq.Them(a[i]);
                }
            }
            return kq;
        }

        public enum KieuSapXep
        {
            TangTheoHoTen,
            GiamTheoHoTen,
            TangTheoNgaySinh,
            GiamTheoNgaySinh
        }
        public int KiemTraDieuKien(ThueBao tb1, ThueBao tb2, KieuSapXep k)
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
            for (int i = 0; i < length - 1; i++) 
            {
                for (int j = i + 1; j < length; j++) 
                {
                    if (KiemTraDieuKien(a[i], a[j], k) == 1) 
                    {
                        ThueBao tam = a[i];
                        a[i] = a[j];
                        a[j] = tam;
                    }
                }
            }
        }
        //1.	Tìm thành phố có nhiều thuê bao nhất, có ít thuê bao nhất.
        public void TimThanhPhoNhieuItThueBaoNhat()
        {
            if (a.Length == 0)
            {
                Console.WriteLine("Danh bạ trống.");
                return;
            }

            var demThueBaoTheoThanhPho = a
                .GroupBy(tb => tb.DiaChi.Split(',')[2].Trim()) // Giả sử thành phố nằm ở phần tử thứ 3 của địa chỉ
                .Select(grp => new { ThanhPho = grp.Key, SoLuong = grp.Count() })
                .ToList();

            var nhieuNhat = demThueBaoTheoThanhPho.OrderByDescending(item => item.SoLuong).First();
            var itNhat = demThueBaoTheoThanhPho.OrderBy(item => item.SoLuong).First();

            Console.WriteLine($"Thành phố có nhiều thuê bao nhất là {nhieuNhat.ThanhPho} với {nhieuNhat.SoLuong} thuê bao.");
            Console.WriteLine($"Thành phố có ít thuê bao nhất là {itNhat.ThanhPho} với {itNhat.SoLuong} thuê bao.");
        }
        //2.	Tìm thuê bao sở hữu ít số điện thoại nhất.
        public ThueBao TimThueBaoItSDTNhat()
        {
            return a.OrderBy(tb => tb.DanhSachSoDienThoai.Count).FirstOrDefault();
        }
        //3.	Sắp xếp khách hàng tăng giảm theo họ tên, số lượng số điện thoại sở hữu.
        public void SapXepTheoHoTenVaSoDienThoai(bool tangTheoHoTen = true)
        {
            Comparison<ThueBao> comparison = (x, y) => string.Compare(x.HoTen, y.HoTen);
            if (!tangTheoHoTen)
            {
                comparison = (x, y) => string.Compare(y.HoTen, x.HoTen);
            }

            Array.Sort(a, comparison);
        }
        //4.	Hiển thị danh sách các thành phố theo chiều tăng, giảm của số lượng thuê bao.
        public void HienThiThanhPhoTheoSoLuongThueBao()
        {
            var thanhPhoCounts = a.GroupBy(tb => tb.DiaChi.Split(',')[2].Trim()) // Giả sử thành phố nằm ở phần tử thứ 3 của địa chỉ
                                   .Select(grp => new { ThanhPho = grp.Key, SoLuong = grp.Count() })
                                   .OrderByDescending(grp => grp.SoLuong);

            foreach (var item in thanhPhoCounts)
            {
                Console.WriteLine($"Thành phố: {item.ThanhPho}, Số lượng thuê bao: {item.SoLuong}");
            }
        }
        //5.	Tìm tháng không có thuê bao nào đăng ký.
        public void TimThangKhongCoDangKy()
        {
            HashSet<int> monthsWithSubscriptions = new HashSet<int>(a.Select(tb => tb.NgayDangKy.Month));
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
        //6.	Tìm tất cả các khách hàng theo giới tính.
        public void TimKhachHangTheoGioiTinh(GioiTinh gioiTinh)
        {
            var khachHangTheoGioiTinh = a.Where(tb => tb.GioiTinh == gioiTinh).ToList();

            foreach (var kh in khachHangTheoGioiTinh)
            {
                Console.WriteLine(kh);
            }
        }
        //7.	Xóa tất cả khách hàng thuộc một tỉnh nào đó.
        public void XoaKhachHangTheoTinh(string tinh)
        {
            a = a.Where(tb => !tb.DiaChi.Contains(tinh)).ToArray();
            Console.WriteLine($"Đã xóa tất cả khách hàng ở tỉnh {tinh}.");
        }
        //8.	Tất cả khách hàng nào sinh tháng 1 thì được tặng thêm một số điện thoại mới có số là cmnd.
        public void TangSoDienThoaiChoSinhThang1()
        {
            foreach (var tb in a.Where(tb => tb.NgaySinh.Month == 1))
            {
                // Giả sử cách thêm số điện thoại mới vào danh sách hoặc cơ sở dữ liệu
                tb.SDT = tb.SoCMND; // Ví dụ đơn giản: gán số CMND làm số điện thoại mới
            }
        }
        //9.	Tìm ngày có nhiều khách hàng đăng ký nhất, ít người đăng ký nhất.
        public void TimNgayDangKyNhieuItNhat()
        {
            var ngayDangKyCounts = a.GroupBy(tb => tb.NgayDangKy.Date)
                                                  .Select(grp => new { Ngay = grp.Key, SoLuong = grp.Count() })
                                                  .ToList();
            var nhieuNhat = ngayDangKyCounts.OrderByDescending(item => item.SoLuong).First();
            var itNhat = ngayDangKyCounts.OrderBy(item => item.SoLuong).First();

            Console.WriteLine($"Ngày có nhiều đăng ký nhất: {nhieuNhat.Ngay} ({nhieuNhat.SoLuong})");
            Console.WriteLine($"Ngày có ít đăng ký nhất: {itNhat.Ngay} ({itNhat.SoLuong})");
        }
        //10.	Thống kê và hiển thị dữ liệu theo từng tỉnh và mỗi tỉnh hiển thị theo thành phố theo mẫu sau:
        //Tỉnh: Lâm Đồng (tổng số thuê bao: 4)

        //    Thành Phố: Dalat(tổng số thuê bao: 2)
        //1)	001, nguyen van a, 01 PDTV, Dalat, Lam Dong, 123
        //2)	002, nguyen van b, 01 PDTV, Dalat, Lam Dong, 123
        //Thành phố bảo lộc: (Tổng số thuê bao: 2)
        //---Hiển thị danh sách thuê bao ở thành phố bảo lộc
        //Tỉnh Khánh Hòa(Tổng số….)

        //    Thành Phố: Nha Trang(tổng số thuê bao:……)
        //	---Danh sách thuê bao
        public void ThongKeTheoTinhVaThanhPho()
        {
            var thongKe = a
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
        //Yêu cầu thêm:
        //Ứng dụng cần quản lý thêm thuê bao cố định và thuê bao di động.Đối với thuê bao cố định quản lý thêm thuộc tính ngày lắp đặt, đối với thuê báo di động quản lý thêm thuộc tính nhà dịch vụ(ví dụ: VNPT, Viettel…)
        //Bổ sung các thuộc tính cần thiết và thực hiện các yêu cầu sau:
        //11.	Tìm thành phố có nhiều thuê bao cố định nhất, có ít thuê bao nhất di động nhất.
        public void TimThanhPhoNhieuItThueBaoCoDinhDiDong()
        {
            var coDinh = a.Where(tb => tb.LoaiThueBao == ThueBaoType.FixedLine)
                                .GroupBy(tb => tb.DiaChi)
                                .OrderByDescending(g => g.Count())
                                .FirstOrDefault()?.Key;

            var diDong = a.Where(tb => tb.LoaiThueBao == ThueBaoType.Mobile)
                                .GroupBy(tb => tb.DiaChi)
                                .OrderBy(g => g.Count())
                                .FirstOrDefault()?.Key;

            Console.WriteLine($"Thành phố có nhiều thuê bao cố định nhất: {coDinh}");
            Console.WriteLine($"Thành phố có ít thuê bao di động nhất: {diDong}");
        }
        //12.	Tìm thuê bao sở hữu ít số điện thoại cố định nhất.
        public ThueBao TimThueBaoItSoCoDinhNhat()
        {
            return a.Where(tb => tb.LoaiThueBao == ThueBaoType.FixedLine)
                                   .OrderBy(tb => tb.DanhSachSoDienThoai.Count)
                                   .FirstOrDefault();
        }
        //13.	Tìm tháng không có thuê bao nào đăng ký số cố định, di động.
        public void TimThangKhongCoDangKyLoaiThueBao(ThueBaoType loaiThueBao)
        {
            HashSet<int> months = new HashSet<int>(
                a.Where(tb => tb.LoaiThueBao == loaiThueBao).Select(tb => tb.NgayDangKy.Month));

            for (int i = 1; i <= 12; i++)
            {
                if (!months.Contains(i))
                    Console.WriteLine($"Tháng {i} không có đăng ký thuê bao {loaiThueBao}");
            }
        }
        //14.	Tìm tất cả các thuê bao di động theo giới tính.
        public DanhBa TimThueBaoDiDongTheoGioiTinh(GioiTinh gioiTinh)
        {
            DanhBa danhBaMoi = new DanhBa();
            var thueBaos = a.Where(tb => tb.GioiTinh == gioiTinh && tb.LoaiThueBao == ThueBaoType.Mobile).ToList();
            foreach (var thueBao in thueBaos)
            {
                danhBaMoi.Them(thueBao);
            }
            return danhBaMoi;
        }
        //15.	Xóa tất cả thuê bao theo ngày lắp đặt.
        public void XoaThueBaoTheoNgayLapDat(DateTime ngayLapDat)
        {
            a = a.Where(tb => !tb.NgayLapDat.HasValue || tb.NgayLapDat.Value != ngayLapDat).ToArray();
            Console.WriteLine("Đã xóa các thuê bao theo ngày lắp đặt.");
        }
        //16.	Tìm khách hàng di động theo nhà cung cấp dịch vụ
        public DanhBa TimKhachHangDiDongTheoNhaCungCap(string nhaCungCap)
        {
            DanhBa danhBaMoi = new DanhBa();
            var thueBaos = a.Where(tb => tb.LoaiThueBao == ThueBaoType.Mobile && tb.NhaCungCap == nhaCungCap).ToList();

            foreach (var thueBao in thueBaos)
            {
                danhBaMoi.Them(thueBao);
            }

            return danhBaMoi;
        }

        //17.	Hiển thị số lượng thuê bao của từng loại hình thuê bao
        public void HienThiSoLuongThueBaoTheoLoai()
        {
            var soLuongCoDinh = a.Count(tb => tb.LoaiThueBao == ThueBaoType.FixedLine);
            var soLuongDiDong = a.Count(tb => tb.LoaiThueBao == ThueBaoType.Mobile);

            Console.WriteLine($"Số lượng thuê bao cố định: {soLuongCoDinh}");
            Console.WriteLine($"Số lượng thuê bao di động: {soLuongDiDong}");
        }
        //18.	Hiển thị số lượng thuê bao cố định theo từng nhà cung cấp dịch vụ
        public void HienThiSoLuongThueBaoCoDinhTheoNhaCungCap()
        {
            var nhomTheoNhaCungCap = a.Where(tb => tb.LoaiThueBao == ThueBaoType.FixedLine)
                                                     .GroupBy(tb => tb.NhaCungCap)
                                                     .ToDictionary(g => g.Key, g => g.Count());

            foreach (var nhom in nhomTheoNhaCungCap)
            {
                Console.WriteLine($"Nhà cung cấp: {nhom.Key}, Số lượng thuê bao cố định: {nhom.Value}");
            }
        }
    }
}
