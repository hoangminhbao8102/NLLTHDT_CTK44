using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_Bai01_DelegateDonGian
{
    public delegate void ThaoTac(string chuoi);

    public class Program
    {
        static void Main(string[] args)
        {
            ThaoTac xuLy;

            xuLy = new ThaoTac(XuatChuoi);

            xuLy("Uy nhiem ham don gian");

            xuLy = XuatChuoi;

            xuLy("Goi ham lan thu 2");

            Console.WriteLine("==================================");

            xuLy += ChaoMung;
            xuLy += ChuHoa;

            xuLy("Trinh Thanh Tai");

            PhepToan toan = new PhepToan();

            TinhToan phepTinh = toan.Cong;

            int ketQua = phepTinh(5, 3);

            Console.WriteLine(ketQua);
            Console.WriteLine("==================================");

            Console.ReadKey();
        }

        static void XuatChuoi(string chuoi) 
        {
            Console.WriteLine(chuoi);
        }

        static void ChaoMung(string ten)
        {
            Console.WriteLine("Chao ban {0}", ten);
        }

        static void ChuHoa(string chuoi)
        {
            Console.WriteLine(chuoi.ToUpper());
        }
    }
}
