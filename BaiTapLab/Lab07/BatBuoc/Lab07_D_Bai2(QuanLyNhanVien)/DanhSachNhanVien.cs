using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_D_Bai2_QuanLyNhanVien_
{
    class DanhSachNhanVien
    {
        private NhanVien[] danhSach;
        private int soLuong;

        public int SoLuong
        {
            get { return soLuong; }
        }

        public NhanVien this[int index]
        {
            get { return danhSach[index]; }
        }

        public DanhSachNhanVien()
        {
            danhSach = new NhanVien[10]; // Giả sử bắt đầu với kích thước mảng là 10
            soLuong = 0;
        }

        public void Them(NhanVien nv)
        {
            if (soLuong == danhSach.Length)
            {
                // Mở rộng mảng nếu cần
                Array.Resize(ref danhSach, soLuong * 2);
            }
            danhSach[soLuong++] = nv;
        }

        public NhanVien TimTheoMa(int maNV)
        {
            for (int i = 0; i < soLuong; i++)
            {
                if (danhSach[i].MaSo == maNV)
                {
                    return danhSach[i];
                }
            }
            return null; // Trả về null nếu không tìm thấy
        }

        public int TimViTri(int maNV)
        {
            for (int i = 0; i < soLuong; i++)
            {
                if (danhSach[i].MaSo == maNV)
                {
                    return i;
                }
            }
            return -1; // Trả về -1 nếu không tìm thấy
        }

        public void Xuat()
        {
            for (int i = 0; i < soLuong; i++)
            {
                Console.WriteLine(danhSach[i].ToString()); // Gọi phương thức ToString() đã được ghi đè
            }
        }

        //d. Xuất danh sách toàn bộ nhân viên (Yêu cầu: Canh lề các cột).
        public void XuatDanhSachCanhLe()
        {
            Console.WriteLine("{0,-10} {1,-20} {2,-10} {3,-15}", "Mã NV", "Họ Tên", "Giới Tính", "Ngày Bắt Đầu");
            foreach (var nv in danhSach)
            {
                Console.WriteLine("{0,-10} {1,-20} {2,-10} {3,-15:yyyy-MM-dd}", nv.MaSo, nv.HoTen, nv.GioiTinh, nv.NgayBDLV);
            }
        }

        //e. Sắp xếp danh sách nhân viên tăng dần theo họ tên.
        public void SapXepTheoTen()
        {
            Array.Sort(danhSach, 0, soLuong, Comparer<NhanVien>.Create((x, y) => x.HoTen.CompareTo(y.HoTen)));
        }

        //f.Xuất danh sách nhân viên, phân loại theo nhân viên hợp đồng và nhân viên theo giờ
        public void XuatNhanVienTheoLoai()
        {
            Console.WriteLine("Nhân viên hợp đồng:");
            foreach (var nv in danhSach)
            {
                if (nv is NhanVienHopDong)
                    Console.WriteLine(nv.ToString());
            }
            Console.WriteLine("\nNhân viên theo giờ:");
            foreach (var nv in danhSach)
            {
                if (nv is NhanVienTheoGio)
                    Console.WriteLine(nv.ToString());
            }
        }

        //g.Xuất bảng lương của nhân viên có mã(manv) cho trước.Trong đó có các cột: tháng, số ngày/giờ công, tiền lương tháng đó.
        public void XuatBangLuong(int maNV, DanhSachChamCong chamCongs)
        {
            var nhanVien = TimTheoMa(maNV);
            if (nhanVien == null)
            {
                Console.WriteLine("Không tìm thấy nhân viên với mã số cung cấp.");
                return;
            }

            Console.WriteLine("Tháng | Số Ngày/Giờ Công | Tiền Lương");
            for (int i = 0; i < chamCongs.SoLuong; i++)
            {
                var cc = chamCongs[i];  // Sử dụng indexer để truy cập ChamCong
                if (cc.MaNV == maNV)
                {
                    double tienLuong = nhanVien.TinhLuong(cc.Thang);
                    Console.WriteLine($"{cc.Thang} | {cc.SoCong} | {tienLuong}");
                }
            }
        }

        //h.Tính tổng tiền lương của nhân viên.
        public double TinhTongLuong(int maNV, DanhSachChamCong chamCongs)
        {
            double tongLuong = 0;
            for (int i = 0; i < chamCongs.SoLuong; i++)
            {
                var cc = chamCongs[i];
                if (cc.MaNV == maNV)
                {
                    var nv = TimTheoMa(maNV);
                    if (nv != null)
                    {
                        tongLuong += nv.TinhLuong(cc.Thang);
                    }
                }
            }
            return tongLuong;
        }

        //i.Xuất thông tin chi tiết về nhân viên có mã (manv), kể cả bảng lương và tổng lương.
        public void XuatThongTinChiTiet(int maNV, DanhSachChamCong chamCongs)
        {
            var nv = TimTheoMa(maNV);
            if (nv != null)
            {
                Console.WriteLine(nv.ToString());
                XuatBangLuong(maNV, chamCongs); // Truyền chamCongs như một tham số
                Console.WriteLine($"Tổng lương: {TinhTongLuong(maNV, chamCongs)}");
            }
            else
            {
                Console.WriteLine("Không tìm thấy nhân viên.");
            }
        }

        //j.Tìm các nhân viên nữ có thâm niên công tác ít nhất là 2 năm.
        public void TimNhanVienNuThamNien()
        {
            foreach (var nv in danhSach)
            {
                if (nv.GioiTinh.ToLower() == "female" && (DateTime.Today.Year - nv.NgayBDLV.Year) >= 2)
                {
                    Console.WriteLine(nv.ToString());
                }
            }
        }

        //k.Tìm các nhân viên theo tháng không làm việc trong tháng 7.
        public void TimNhanVienKhongLamViecThang7(DanhSachChamCong chamCongs)
        {
            HashSet<int> maNVsLamViecThang7 = new HashSet<int>();
            for (int i = 0; i < chamCongs.SoLuong; i++)
            {
                var cc = chamCongs[i];
                if (cc.Thang == 7)
                {
                    maNVsLamViecThang7.Add(cc.MaNV);
                }
            }

            foreach (var nv in danhSach)
            {
                if (!maNVsLamViecThang7.Contains(nv.MaSo))
                {
                    Console.WriteLine(nv.ToString());
                }
            }
        }

        //l.Tìm nhân viên (hợp đồng) có hệ số lương cao nhất tại công ty
        public void TimNhanVienHopDongHeSoLuongCaoNhat()
        {
            NhanVienHopDong nvMax = null;
            double heSoLuongMax = double.MinValue;

            foreach (var nv in danhSach)
            {
                if (nv is NhanVienHopDong nvh && nvh.HeSoLuong > heSoLuongMax)
                {
                    nvMax = nvh;
                    heSoLuongMax = nvh.HeSoLuong;
                }
            }

            if (nvMax != null)
            {
                Console.WriteLine(nvMax.ToString());
            }
        }

        //m.Tìm nhân viên (theo giờ) có mức thưởng cao nhất trong tháng 12.
        public void TimNhanVienTheoGioThuongCaoNhatThang12(DanhSachChamCong chamCongs)
        {
            NhanVienTheoGio nvMax = null;
            double thuongMax = double.MinValue;

            for (int i = 0; i < chamCongs.SoLuong; i++)
            {
                ChamCong cc = chamCongs[i];
                if (cc.Thang == 12)
                {
                    var nv = TimTheoMa(cc.MaNV);
                    if (nv is NhanVienTheoGio nvg)
                    {
                        double thuong = nvg.TinhLuong(cc.Thang);
                        if (thuong > thuongMax)
                        {
                            nvMax = nvg;
                            thuongMax = thuong;
                        }
                    }
                }
            }

            if (nvMax != null)
            {
                Console.WriteLine(nvMax.ToString());
            }
        }

        //n.Tìm nhân viên được trả lương nhiều nhất trong tháng 12.
        public NhanVien TimNhanVienLuongCaoNhatThang12()
        {
            NhanVien nhanVienLuongCaoNhat = null;
            double luongCaoNhat = 0;

            foreach (var nv in danhSach)
            {
                double luongThang12 = nv.TinhLuong(12); // Giả sử TinhLuong trả về lương cho tháng cụ thể
                if (luongThang12 > luongCaoNhat)
                {
                    luongCaoNhat = luongThang12;
                    nhanVienLuongCaoNhat = nv;
                }
            }

            return nhanVienLuongCaoNhat; // Trả về nhân viên có lương tháng 12 cao nhất
        }

        //o.Tìm những nhân viên đến hạn được nâng lương (có thâm niên là 3, 6, 9, … năm).
        public void TimNhanVienDenHanNangLuong()
        {
            foreach (var nv in danhSach)
            {
                int thamNien = DateTime.Today.Year - nv.NgayBDLV.Year;
                if (thamNien > 0 && thamNien % 3 == 0)  // Mỗi 3 năm nâng lương một lần
                {
                    Console.WriteLine(nv.ToString());
                }
            }
        }

        //p.Nâng hệ số lương lên 0.33 cho tất cả các nhân viên đến hạn được nâng lương.
        public void NangHeSoLuong()
        {
            foreach (var nv in danhSach)
            {
                if (nv is NhanVienHopDong nvh)
                {
                    int thamNien = DateTime.Today.Year - nvh.NgayBDLV.Year;
                    if (thamNien > 0 && thamNien % 3 == 0)  // Mỗi 3 năm nâng lương một lần
                    {
                        nvh.HeSoLuong += 0.33;
                    }
                }
            }
        }

        //q.Liệt kê danh sách nhân viên có họ(honv) cho trước
        public void LietKeNhanVienTheoHo(string ho)
        {
            foreach (var nv in danhSach)
            {
                if (nv.HoTen.StartsWith(ho))
                {
                    Console.WriteLine(nv.ToString());
                }
            }
        }

        //r.Tìm tháng có số tiền lương phải trả cao nhất.
        public void TimThangLuongCaoNhat(DanhSachChamCong chamCongs)
        {
            double[] luongTheoThang = new double[13]; // Mảng lưu trữ tổng lương từ tháng 1 đến 12

            for (int i = 0; i < chamCongs.SoLuong; i++)
            {
                var cc = chamCongs[i];
                var nv = TimTheoMa(cc.MaNV);
                if (nv != null)
                {
                    luongTheoThang[cc.Thang] += nv.TinhLuong(cc.Thang);
                }
            }

            int thangLuongCaoNhat = 0;
            double maxLuong = 0;

            for (int thang = 1; thang <= 12; thang++)
            {
                if (luongTheoThang[thang] > maxLuong)
                {
                    maxLuong = luongTheoThang[thang];
                    thangLuongCaoNhat = thang;
                }
            }

            Console.WriteLine($"Tháng {thangLuongCaoNhat} có tổng lương cao nhất: {maxLuong}");
        }

        //s.Tìm nhân viên có phụ cấp cao nhất.
        public void TimNhanVienPhuCapCaoNhat()
        {
            NhanVienHopDong nvMax = null;
            double phuCapMax = double.MinValue;

            foreach (var nv in danhSach)
            {
                if (nv is NhanVienHopDong nvh && nvh.PhuCap > phuCapMax)
                {
                    nvMax = nvh;
                    phuCapMax = nvh.PhuCap;
                }
            }

            if (nvMax != null)
            {
                Console.WriteLine($"Nhân viên có phụ cấp cao nhất: {nvMax.HoTen} với phụ cấp là {phuCapMax}");
            }
        }

        //t.Tính tổng tiền lương phải trả cho các nhân viên hợp đồng trong tháng cho trước.
        public double TinhTongLuongHopDongThang(int thang, DanhSachChamCong chamCongs)
        {
            double tongLuong = 0;
            for (int i = 0; i < chamCongs.SoLuong; i++)
            {
                var cc = chamCongs[i];
                if (cc.Thang == thang)
                {
                    var nv = TimTheoMa(cc.MaNV);
                    if (nv is NhanVienHopDong nvh)
                    {
                        tongLuong += nvh.TinhLuong(thang);
                    }
                }
            }
            return tongLuong;
        }

        //u.Tính tổng tiền lương phải trả cho các nhân viên làm việc theo giờ trong tháng cho trước.
        public double TinhTongLuongTheoGioThang(int thang, DanhSachChamCong chamCongs)
        {
            double tongLuong = 0;
            for (int i = 0; i < chamCongs.SoLuong; i++)
            {
                var cc = chamCongs[i];
                if (cc.Thang == thang)
                {
                    var nv = TimTheoMa(cc.MaNV);
                    if (nv is NhanVienTheoGio nvg)
                    {
                        tongLuong += nvg.TinhLuong(thang);
                    }
                }
            }
            return tongLuong;
        }

        //v.Tính tổng tiền lương phải trả cho tất cả nhân viên trong một năm.
        public double TinhTongLuongNam()
        {
            double tongLuongNam = 0;
            for (int thang = 1; thang <= 12; thang++)
            {
                foreach (var nv in danhSach)
                {
                    tongLuongNam += nv.TinhLuong(thang);
                }
            }
            return tongLuongNam;
        }

        //w.Tính tổng số giờ công của tất cả các nhân viên làm việc theo giờ trong tháng 12
        public int TinhTongGioCongThang12(DanhSachChamCong chamCongs)
        {
            int tongSoGio = 0;
            for (int i = 0; i < chamCongs.SoLuong; i++)
            {
                var cc = chamCongs[i];
                if (cc.Thang == 12 && TimTheoMa(cc.MaNV) is NhanVienTheoGio)
                {
                    tongSoGio += cc.SoCong;
                }
            }
            return tongSoGio;
        }

        //x.Tính tổng số ngày công của các nhân viên hợp đồng trong một năm.
        public int TinhTongNgayCongHopDongNam(DanhSachChamCong chamCongs)
        {
            int tongSoNgay = 0;
            for (int i = 0; i < chamCongs.SoLuong; i++)
            {
                var cc = chamCongs[i];
                if (TimTheoMa(cc.MaNV) is NhanVienHopDong)
                {
                    tongSoNgay += cc.SoCong;
                }
            }
            return tongSoNgay;
        }

        //y.Xóa tất cả những nhân viên làm việc theo giờ.
        public void XoaNhanVienTheoGio()
        {
            danhSach = danhSach.Where(nv => !(nv is NhanVienTheoGio)).ToArray();
            soLuong = danhSach.Length;
        }
    }
}
