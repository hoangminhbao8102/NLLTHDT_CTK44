using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_E_Bai5
{
    public class SinhVien
    {
        private BangDiem _diemThi;
        private string _hoTen;
        private string _mssv;

        public BangDiem DiemThi 
        {
            get { return _diemThi; }
            set { _diemThi = value; } 
        }
        public string HoTen 
        {
            get { return _hoTen; }
            set { _hoTen = value; }
        }
        public string MSSV 
        {
            get { return _mssv; }
            set { _mssv = value; } 
        }

        public SinhVien()
        {
            _diemThi = new BangDiem();
            _hoTen = string.Empty;
            _mssv = string.Empty;
        }

        public int TinhHocPhi(int giaMotTc)
        {
            int totalSoTC = _diemThi.TinhTongSoTC();
            return totalSoTC * giaMotTc;
        }

        public override string ToString()
        {
            return $"Họ tên: {HoTen}, MSSV: {MSSV}, Điểm TB chí lũy: {_diemThi.TinhDiemTBChiLuy()}";
        }

        public void XuatCacMonHoc()
        {
            Console.WriteLine(_diemThi.ToString());
        }
    }
}
