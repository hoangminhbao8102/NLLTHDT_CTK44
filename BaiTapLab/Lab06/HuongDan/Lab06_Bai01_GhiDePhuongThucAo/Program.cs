using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_Bai01_GhiDePhuongThucAo
{
    class Program
    {
        static void Main(string[] args)
        {
            HinhTru tru = new HinhTru(5, 10);

            HinhTron tron = tru;

            tru.Ve();
            tron.Ve();

            Console.WriteLine(tron.TinhChuVi());
            Console.WriteLine(tru.TinhChuVi());

            Console.WriteLine(tron.TinhDienTich());
            Console.WriteLine(tru.TinhDienTich());

            HinhTru ong = (HinhTru)tron;
            Console.WriteLine(ong.TinhDienTich());

            tron = new HinhTru(5, 10);
            Console.WriteLine(tron.TinhDienTich());

            Console.ReadKey();
        }
    }
}
