using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_Bai02_PhatSinhNgoaiLe
{
    public class Program
    {
        static void Main(string[] args)
        {
            MangSoNguyen mangNguyen = new MangSoNguyen();

            mangNguyen.NhapNgauNhien(100);

            mangNguyen.XuatMang();

            try
            {
                Console.WriteLine(mangNguyen[-1]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("".PadRight(80, '='));

            try
            {
                mangNguyen.Them(2567);
            }
            catch (LoiMienGiaTri ex)
            {
                Console.WriteLine("Khong the them phan tu moi");
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
