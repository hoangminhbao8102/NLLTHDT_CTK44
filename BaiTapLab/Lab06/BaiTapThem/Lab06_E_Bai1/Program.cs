using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_E_Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            DanhSachHamSo ds = new DanhSachHamSo();
            ds.NhapCacHamSo();
            ds.XuatCacHamSo();

            Console.WriteLine("Enter a value for x:");
            double x = Convert.ToDouble(Console.ReadLine());

            ds.XuatHamSoVaGiaTriTaiX(x);
            ds.XuatHamSoGiamDanTaiX(x);
            ds.DemHamSo();
            ds.TimBacCuaHamDaThuc();
            ds.XuatHamDaThucBacCaoNhat();

            Console.ReadKey();
        }
    }
}
