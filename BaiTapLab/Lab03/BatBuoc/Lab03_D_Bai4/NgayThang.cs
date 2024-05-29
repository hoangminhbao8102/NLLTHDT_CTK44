using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_D_Bai4
{
    public class NgayThang
    {
        private int _ngay;
        private int _thang;
        private int _nam;

        public int Ngay
        {
            get { return _ngay; }
            set { _ngay = value; }
        }

        public int Thang
        {
            get { return _thang; }
            set { _thang = value; }
        }

        public int Nam
        {
            get { return _nam; }
            set { _nam = value; }
        }

        public NgayThang()
        {
            _ngay = 0;
            _thang = 0;
            _nam = 0;
        }

        public NgayThang(int ngay, int thang, int nam)
        {
            _ngay = ngay;
            _thang = thang;
            _nam = nam;
        }

        public void TimThuTrongTuan()
        {
            DateTime dt = new DateTime(_nam, _thang, _ngay);
            DayOfWeek dayOfWeek = dt.DayOfWeek;
            Console.WriteLine("Thứ trong tuần: " + dayOfWeek);
        }

        public int TinhCachBietTheoNgay(NgayThang d)
        {
            DateTime start = new DateTime(_nam, _thang, _ngay);
            DateTime end = new DateTime(d.Nam, d.Thang, d.Ngay);
            return (end - start).Days;
        }

        public int TinhCachBietTheoThang(NgayThang d)
        {
            return (d.Nam - _nam) * 12 + d.Thang - _thang;
        }

        public int TinhCachBietTheoNam(NgayThang d)
        {
            return d.Nam - _nam;
        }

        public bool LaNgayNamNhuan()
        {
            return DateTime.IsLeapYear(_nam) && _thang == 2 && _ngay == 29;
        }
    }
}
