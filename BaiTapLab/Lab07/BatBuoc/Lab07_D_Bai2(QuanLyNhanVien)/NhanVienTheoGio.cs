using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_D_Bai2_QuanLyNhanVien_
{
    class NhanVienTheoGio : NhanVien
    {
        private int _tienGio;

        public int MucLuong
        {
            get { return _tienGio; }
            set { _tienGio = value; }
        }

        public NhanVienTheoGio()
        {
            _tienGio = 0; // Khởi tạo tiền công mỗi giờ là 0
        }

        public NhanVienTheoGio(int manv, string ten, string phai, DateTime ngayBd, int tienGio) : base(manv, ten, phai, ngayBd)
        {
            _tienGio = tienGio; // Thiết lập tiền công mỗi giờ
        }

        public override int TinhLuong(int thang)
        {
            ChamCong chamCongThang = _bangChamCong.TimTheoThang(thang);
            if (chamCongThang != null)
            {
                int soGioLam = chamCongThang.SoCong; // Giả sử SoCong là số giờ làm việc
                double thuong = 0; // Khởi tạo thưởng là 0

                // Tính thưởng dựa trên số giờ làm việc
                if (soGioLam > 150)
                    thuong = 15 * _tienGio; // Thưởng cho 15 giờ làm việc
                else
                    thuong = soGioLam / 15.0 * _tienGio; // Thưởng tương ứng với 1/15 số giờ làm việc

                int luongThang = (int)(soGioLam * _tienGio + thuong); // Tính lương tổng cộng kèm thưởng
                return luongThang;
            }
            return 0; // Trả về 0 nếu không có thông tin chấm công
        }

        public override void XuatBangLuong()
        {
            int luongThangNay = TinhLuong(DateTime.Today.Month);
            Console.WriteLine($"Nhân viên theo giờ {HoTen} (Mã số: {MaSo}) có lương tháng này: {luongThangNay} VND.");
        }
    }
}
