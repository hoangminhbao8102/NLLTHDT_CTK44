using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_Bai01_BatCacNgoaiLe
{
    public class Program
    {
        static void Main(string[] args)
        {
            ViDuNgoaiLe viDu = new ViDuNgoaiLe();

            int k = viDu.BatLoiKieuDuLieu();

            Console.WriteLine("Gia tri vua nhap : {0}", k);

            k = viDu.BatLoiVaXuatLoi();

            Console.WriteLine("Gia tri vua nhap : {0}", k);

            k = viDu.ChiRoLoiMuonBat();

            Console.WriteLine("Gia tri vua nhap : {0}", k);

            k = viDu.BatNhieuLoaiNgoaiLeKhacNhau();

            Console.WriteLine("Gia tri vua nhap : {0}", k);

            k = viDu.SuDungKhoiFinally();

            Console.WriteLine("Gia tri vua nhap : {0}", k);

            Console.ReadKey();
        }
    }
}
