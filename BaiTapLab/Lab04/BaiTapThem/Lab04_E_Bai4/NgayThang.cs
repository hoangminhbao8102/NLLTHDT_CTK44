using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_E_Bai4
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

        public static NgayThang operator ++(NgayThang d)
        {
            DateTime dt = new DateTime(d.Nam, d.Thang, d.Ngay).AddDays(1);
            return new NgayThang(dt.Day, dt.Month, dt.Year);
        }

        public static NgayThang operator --(NgayThang d)
        {
            DateTime dt = new DateTime(d.Nam, d.Thang, d.Ngay).AddDays(-1);
            return new NgayThang(dt.Day, dt.Month, dt.Year);
        }

        public static bool operator ==(NgayThang d1, NgayThang d2)
        {
            return d1.Nam == d2.Nam && d1.Thang == d2.Thang && d1.Ngay == d2.Ngay;
        }

        public static bool operator !=(NgayThang d1, NgayThang d2)
        {
            return !(d1 == d2);
        }

        public static bool operator <(NgayThang d1, NgayThang d2)
        {
            return new DateTime(d1.Nam, d1.Thang, d1.Ngay) < new DateTime(d2.Nam, d2.Thang, d2.Ngay);
        }

        public static bool operator >(NgayThang d1, NgayThang d2)
        {
            return new DateTime(d1.Nam, d1.Thang, d1.Ngay) > new DateTime(d2.Nam, d2.Thang, d2.Ngay);
        }

        public static bool operator <=(NgayThang d1, NgayThang d2)
        {
            return new DateTime(d1.Nam, d1.Thang, d1.Ngay) <= new DateTime(d2.Nam, d2.Thang, d2.Ngay);
        }

        public static bool operator >=(NgayThang d1, NgayThang d2)
        {
            return new DateTime(d1.Nam, d1.Thang, d1.Ngay) >= new DateTime(d2.Nam, d2.Thang, d2.Ngay);
        }

        public static explicit operator NgayThang(int daysSinceEpoch)
        {
            DateTime epoch = new DateTime(1970, 1, 1).AddDays(daysSinceEpoch);
            return new NgayThang(epoch.Day, epoch.Month, epoch.Year);
        }

        public override bool Equals(object obj)
        {
            // Kiểm tra xem obj có phải là NgayThang không
            if (obj is NgayThang other)
            {
                // So sánh trực tiếp các trường ngày, tháng, năm
                return this.Ngay == other.Ngay && this.Thang == other.Thang && this.Nam == other.Nam;
            }
            return false;
        }

        public override int GetHashCode()
        {
            // Sử dụng các trường để tính toán mã băm
            // Phương pháp này sử dụng phép toán XOR (^) để kết hợp mã băm của các trường
            // Đây là một cách phổ biến để tạo mã băm từ nhiều trường dữ liệu
            int hash = 17;
            hash = hash * 23 + Ngay.GetHashCode();
            hash = hash * 23 + Thang.GetHashCode();
            hash = hash * 23 + Nam.GetHashCode();
            return hash;
        }
    }
}
