using System;

namespace Lab01_Bai03_NhapXuat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap ho va ten cua ban : ");
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
