using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_D_Bai2_QuanLyNhanVien_
{
    abstract class NhanVien
    {
        protected DanhSachChamCong _bangChamCong;
        protected string _gioiTinh;
        protected string _hoTen;
        private int _maSo;
        protected DateTime _ngayBd;
        public int LUONG_CO_BAN;

        public string GioiTinh
        {
            get { return _gioiTinh; } 
            set { _gioiTinh = value; } 
        }
        public string HoTen
        {
            get { return _hoTen; }
            set { _hoTen = value; }
        }
        public int MaSo
        {
            get { return _maSo; }
            set { _maSo = value; }
        }
        public DateTime NgayBDLV
        {
            get { return _ngayBd; }
            set { _ngayBd = value; }
        }

        protected NhanVien()
        {
            _bangChamCong = new DanhSachChamCong();
            _gioiTinh = "Chưa xác định";
            _hoTen = "Chưa rõ";
            _maSo = -1;
            _ngayBd = DateTime.MinValue;
            LUONG_CO_BAN = 1050000; // Ví dụ, lương cơ bản mặc định là 1,050,000 đồng
        }

        protected NhanVien(int manv, string ten, string phai, DateTime ngayBd)
        {
            _maSo = manv;
            _hoTen = ten;
            _gioiTinh = phai;
            _ngayBd = ngayBd;
            _bangChamCong = new DanhSachChamCong();
            LUONG_CO_BAN = 1050000; // Ví dụ, lương cơ bản mặc định là 1,050,000 đồng
        }

        public abstract int TinhLuong(int thang);
        public abstract void XuatBangLuong();
        public virtual void ThemChamCong() 
        {
            ChamCong cc = new ChamCong(_maSo, DateTime.Now.Month, 1); // Giả sử mỗi lần thêm chấm công là chấm công cho một ngày
            _bangChamCong.Them(cc);
        }
    }
}
