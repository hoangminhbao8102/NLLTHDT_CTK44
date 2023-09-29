using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_Bai02_KhaiBaoBienVaHang
{
    class Program
    {
        static void Main(string[] args)
        {
            const int THANG = 12;
            const float TOC_DO_CPU = 2.4f;
            const double PI = 3.14159;
            const char TAB = '\t';
            const string KHOA = "Cong nghe Thong tin";

            Console.WriteLine("So thang trong nam : {0}", THANG);
            Console.WriteLine("Toc do CPU         : {0}", TOC_DO_CPU);
            Console.WriteLine("Gia tri cua so PI  : {0}", PI);
            Console.WriteLine("Ky tu (phim) TAB   : {0}", TAB);
            Console.WriteLine("Khoa toi dang hoc  : {0}", KHOA);

            string HoVaTen;
            HoVaTen = "Trinh Hoa Binh";
            int Tuoi;
            Tuoi = 20;

            float DiemTrungBinh = 7.5f;
            char GioiTinh = 'M';
            bool DaTotNghiep = false;
            double ChieuCao = 1.65;

            Console.WriteLine("Ho va ten    : {0}", HoVaTen);
            Console.WriteLine("Tuoi         : {0}", Tuoi);
            Console.WriteLine("Gioi tinh    : {0}", GioiTinh);
            Console.WriteLine("Chieu cao    : {0} met", ChieuCao);
            Console.WriteLine("Diem T.Binh  : {0}", DiemTrungBinh);
            Console.WriteLine("Da tot nghiep: {0}", DaTotNghiep);

            double x, y;
            int p = 2, q = 3;
            char c, k = 'm';

            Console.ReadKey();
        }
    }
}
