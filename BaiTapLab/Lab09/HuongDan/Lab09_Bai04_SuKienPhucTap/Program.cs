using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_Bai04_SuKienPhucTap
{
    public class Program
    {
        static void Main(string[] args)
        {
            CongTac cauDao = new CongTac();

            cauDao.BatTat += XuLySuKienBatCauDao;

            cauDao.NhanCongTac();

            Console.WriteLine("".PadRight(80, '='));

            cauDao.NhanCongTac();

            cauDao.BatTat -= XuLySuKienBatCauDao;

            Console.WriteLine("".PadRight(80, '='));

            cauDao.NhanCongTac();

            Console.ReadKey();
        }

        static Tivi samsung = new Tivi();
        static BongDen rangDong = new BongDen();

        static void XuLySuKienBatCauDao(object sender, EventArgs e)
        {
            CongTac cauDao = sender as CongTac;

            samsung.ChuyenTrangThai(cauDao.TrangThai);
            rangDong.ChuyenTrangThai(cauDao.TrangThai);
        }
    }
}
