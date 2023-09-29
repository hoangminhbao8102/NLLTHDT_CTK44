using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_Bai02_TuKhoaThis
{
    class Program
    {
        static void Main(string[] args)
        {
            TaiKhoan nguon = new TaiKhoan(1234);

            Console.WriteLine("Ban dau:");
            Console.WriteLine(nguon);
            Console.WriteLine("================================");

            nguon.GuiTien(10000000);

            Console.WriteLine("Sau khi nap so tien 10 000 000");
            Console.WriteLine(nguon);
            Console.WriteLine("================================");

            if (nguon.RutTien(2500000))
            {
                Console.WriteLine("Rut tien thanh cong");
            }
            else
            {
                Console.WriteLine("So du khong du de rut");
            }

            Console.WriteLine("Sau khi nap so tien 2 500 000");
            Console.WriteLine(nguon);
            Console.WriteLine("================================");

            TaiKhoan dich = new TaiKhoan(9876, 3000000);

            bool KetQua = nguon.ChuyenKhoan(5000000, dich);
            if (KetQua)
            {
                Console.WriteLine("Chuyen khoan thanh cong");
                Console.WriteLine(nguon);
                Console.WriteLine(dich);
                Console.WriteLine("================================");
            }

            Console.ReadKey();
        }
    }
}
