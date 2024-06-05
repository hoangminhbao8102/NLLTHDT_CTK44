using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_E_Bai5
{
    public class ThoiGian
    {
        public int Gio { get; set; }
        public int Phut { get; set; }
        public int Giay { get; set; }

        public ThoiGian(int gio, int phut, int giay)
        {
            Gio = gio;
            Phut = phut;
            Giay = giay;
            Normalize();
        }

        // Chuẩn hóa thời gian nếu giây hoặc phút vượt quá 60
        private void Normalize()
        {
            Phut += Giay / 60;
            Giay %= 60;

            Gio += Phut / 60;
            Phut %= 60;

            // Giờ không chuẩn hóa trong phạm vi 0-23 vì có thể có thời gian > 24 giờ
        }

        // Tăng thời gian lên 1 giây
        public static ThoiGian operator ++(ThoiGian t)
        {
            t.Giay++;
            t.Normalize();
            return t;
        }

        // Giảm thời gian đi 1 giây
        public static ThoiGian operator --(ThoiGian t)
        {
            t.Giay--;
            if (t.Giay < 0)
            {
                t.Giay += 60;
                t.Phut--;
                if (t.Phut < 0)
                {
                    t.Phut += 60;
                    t.Gio--;
                    // Không xử lý trường hợp giờ < 0
                }
            }
            return t;
        }

        // So sánh hai thời gian
        public static bool operator >(ThoiGian t1, ThoiGian t2)
        {
            return (t1.Gio > t2.Gio) || (t1.Gio == t2.Gio && t1.Phut > t2.Phut) ||
                   (t1.Gio == t2.Gio && t1.Phut == t2.Phut && t1.Giay > t2.Giay);
        }

        public static bool operator >=(ThoiGian t1, ThoiGian t2)
        {
            return t1 > t2 || t1 == t2;
        }

        public static bool operator <(ThoiGian t1, ThoiGian t2)
        {
            return (t1.Gio < t2.Gio) || (t1.Gio == t2.Gio && t1.Phut < t2.Phut) ||
                   (t1.Gio == t2.Gio && t1.Phut == t2.Phut && t1.Giay < t2.Giay);
        }

        public static bool operator <=(ThoiGian t1, ThoiGian t2)
        {
            return t1 < t2 || t1 == t2;
        }

        public static bool operator ==(ThoiGian t1, ThoiGian t2)
        {
            return t1.Gio == t2.Gio && t1.Phut == t2.Phut && t1.Giay == t2.Giay;
        }

        public static bool operator !=(ThoiGian t1, ThoiGian t2)
        {
            return !(t1 == t2);
        }

        // Đảm bảo các phương thức Equals và GetHashCode được ghi đè phù hợp
        public override bool Equals(object obj)
        {
            if (obj is ThoiGian)
            {
                var other = (ThoiGian)obj;
                return this == other;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Gio.GetHashCode() ^ Phut.GetHashCode() ^ Giay.GetHashCode();
        }

        public override string ToString()
        {
            return $"{Gio:00}:{Phut:00}:{Giay:00}";
        }
    }
}
