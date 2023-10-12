using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_Bai05_CongTacBongDen
{
    public class Program
    {
        static void Main(string[] args)
        {
            CongTac cauDao = new CongTac();

            Tivi samsung = new Tivi(cauDao);
            BongDen rangDong = new BongDen(cauDao);

            cauDao.NhanCongTac();

            Console.WriteLine("".PadRight(80, '='));

            cauDao.NhanCongTac();

            Console.WriteLine("".PadRight(80, '='));

            Console.ReadKey();
        }
    }
}
