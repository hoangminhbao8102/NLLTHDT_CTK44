using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_D_Bai2_QuanLyNhanVien_
{
    class ChamCong
    {
        private int _soNgayGio;
        private int _thang;

        public int SoCong
        {
            get { return _soNgayGio; }
        }

        public int Thang
        {
            get { return _thang; }
        }

        public ChamCong(int thang, int soCong)
        {
            _thang = thang;
            _soNgayGio = soCong;
        }

        public override string ToString()
        {
            return $"Tháng: {_thang}, Số ngày giờ công: {_soNgayGio}";
        }
    }
}
