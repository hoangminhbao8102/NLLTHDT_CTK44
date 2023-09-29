using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_Bai05_CacThaoTacTrenChuoi
{
    class Program
    {
        static void Main(string[] args)
        {
            string khoa = "Cong nghe Thong tin",
                   dhoc = "  Dai hoc Da Lat",
                   con = "Da";

            int cd = khoa.Length;
            Console.WriteLine("Chieu dai chuoi {0} la {1}", khoa, cd);

            string KetQua = khoa + dhoc;
            Console.WriteLine(KetQua);

            KetQua = khoa.ToUpper();
            Console.WriteLine(KetQua);

            KetQua = dhoc.ToLower();
            Console.WriteLine(KetQua);

            KetQua = dhoc.Trim();
            Console.WriteLine(KetQua);

            KetQua = khoa.Substring(0, 4);
            Console.WriteLine(KetQua);

            KetQua = khoa.Substring(10, 5);
            Console.WriteLine(KetQua);

            KetQua = dhoc.Insert(0, "Truong");
            Console.WriteLine(KetQua);

            KetQua = dhoc.Replace("Dai hoc", "University of");
            Console.WriteLine(KetQua);

            KetQua = dhoc.Remove(2, 7);
            Console.WriteLine(KetQua);

            KetQua = khoa.Remove(10);
            Console.WriteLine(KetQua);

            KetQua = khoa.Remove(khoa.Length - 3);
            Console.WriteLine(KetQua);

            KetQua = khoa.PadLeft(40);
            Console.WriteLine(KetQua);

            KetQua = khoa.PadLeft(40, '.');
            Console.WriteLine(KetQua);

            KetQua = khoa.PadRight(40);
            Console.WriteLine(KetQua);

            KetQua = khoa.PadRight(40, '+');
            Console.WriteLine(KetQua);

            KetQua = khoa.PadLeft((80 - khoa.Length) / 2);
            Console.WriteLine(KetQua);

            bool KiemTra = dhoc.Contains(con);
            if (KiemTra)
            {
                Console.WriteLine("Chuoi {0} co chua chuoi {1}", dhoc, con);
            }

            KiemTra = khoa.StartsWith("Cong");
            if (!KiemTra) 
            {
                Console.WriteLine("Chuoi {0} khong bat dau voi chuoi Cong", dhoc);
            }

            string DinhDang = "{0,5}  {1,-30}{2,-10}{3,5}";

            KetQua = string.Format(DinhDang, "STT", "Ho va Ten", "Lop", "Diem");
            Console.WriteLine(KetQua);

            KetQua = string.Format(DinhDang, 1, "Nguyen Thanh Phong", "CTK36", 5.5f);
            Console.WriteLine(KetQua);

            KetQua = string.Format(DinhDang, 12, "Trinh Hoa Binh", "CTK36CD", 7.25f);
            Console.WriteLine(KetQua);

            KetQua = string.Format(DinhDang, 100, "Phan Quoc Khanh", "CTK36LT", 6);
            Console.WriteLine(KetQua);

            Console.ReadKey();
        }
    }
}
