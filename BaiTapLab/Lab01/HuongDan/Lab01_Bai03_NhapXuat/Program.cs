using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_Bai03_NhapXuat
{
    class Program
    {
        static void Main(string[] args)
        {
            string HoTen;
            HoTen = Console.ReadLine();

            Console.WriteLine("Chuoi ban da nhap la : {0}", HoTen);

            Console.Write("Nhap gioi tinh cua ban {Nam = M, Nu = F}:");
            char GioiTinh;

            GioiTinh = Console.ReadKey().KeyChar;

            Console.WriteLine("Gioi tinh cua ban la : {0}", GioiTinh);

            Console.Write("Nhap nam sinh cua ban : ");
            int NamSinh;

            NamSinh = int.Parse(Console.ReadLine());

            Console.WriteLine("Ban sinh nam : {0}", NamSinh);

            Console.ReadKey();
        }
    }
}
