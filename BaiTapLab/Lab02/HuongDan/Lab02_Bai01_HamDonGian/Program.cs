using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_Bai01_HamDonGian
{
    class Program
    {
        static void XuatThongBao()
        {
            Console.WriteLine("Thong bao: ban dang doc thong bao :)");
        }

        static void XuatCauChao(string HoTen)
        {
            Console.WriteLine("Xin chao ban " + HoTen);
        }

        static int NhapSoNguyen()
        {
            int number = 0;
            number = int.Parse(Console.ReadLine());
            return number;
        }

        static double NhapSoThuc(double min, double max)
        {
            double number = 0;
            do
            {
                number = double.Parse(Console.ReadLine());
            } while (number < min || number > max);

            return number;
        }

        static void Main(string[] args)
        {
            XuatThongBao();

            XuatCauChao("Nguyen Van Phuc");

            string TenCuaToi = "Nguyen Van Phuc";
            XuatCauChao(TenCuaToi);

            int n = NhapSoNguyen();
            Console.WriteLine("So nguyen vua nhap : {0}", n);

            double SoThuc = NhapSoThuc(10.5, 19.1);

            Console.WriteLine("So thuc vua nhap: {0}", SoThuc);

            double nho = 10.5, lon = 19.1;
            SoThuc = NhapSoThuc(nho, lon);

            Console.WriteLine("So thuc vua nhap: {0}", SoThuc);

            Console.ReadKey();
        }
    }
}
