using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_Bai03_DaHinhPhuongThuc
{
    public class Program
    {
        static void Main(string[] args)
        {
            HopThoai hop = new HopThoai();
            ICuaSo cua = hop;
            IKhungHinh hinh = hop;

            hop.HienThi();
            cua.HienThi();
            hinh.HienThi();

            Console.ReadKey();
        }
    }
}
