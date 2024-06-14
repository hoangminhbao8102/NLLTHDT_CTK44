using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_D_Bai2_QuanLyNhanVien_
{
    class NhanVienHopDong : NhanVien
    {
        private double _heSoLuong;
        private int _phuCap;

        public double HeSoLuong
        {
            get { return _heSoLuong; }
            set { _heSoLuong = value; }
        }
        public int PhuCap
        {
            get { return _phuCap; }
            set { _phuCap = value; }
        }

        public NhanVienHopDong() : base()
        {
            _heSoLuong = 2.34; // Giá trị khởi điểm
            _phuCap = 0; // Khởi tạo phụ cấp bằng 0
        }

        public NhanVienHopDong(int manv, string ten, string phai, DateTime ngayBd, double heSoLuong, int phuCap) : base(manv, ten, phai, ngayBd)
        {
            _heSoLuong = heSoLuong;
            _phuCap = phuCap;
        }

        public override int TinhLuong(int thang)
        {
            ChamCong chamCongThang = _bangChamCong.TimTheoThang(thang);
            if (chamCongThang != null)
            {
                double tangHeSo = (TinhThamNien() / 3) * 0.33;
                double luong = (_heSoLuong + tangHeSo) * LUONG_CO_BAN * chamCongThang.SoCong + _phuCap;
                return (int)luong;
            }
            return 0;  // Trường hợp không có chấm công cho tháng đó
        }

        public int TinhThamNien()
        {
            return (DateTime.Today.Year - NgayBDLV.Year);
        }

        public override void XuatBangLuong()
        {
            int luongThangNay = TinhLuong(DateTime.Today.Month);
            Console.WriteLine($"Nhân viên hợp đồng {HoTen} (Mã số: {MaSo}) có lương tháng này: {luongThangNay} VND.");
        }
    }
}
