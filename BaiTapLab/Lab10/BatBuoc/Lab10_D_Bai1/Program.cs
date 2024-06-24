using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_D_Bai1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            if (args.Length == 0)
            {
                Console.WriteLine("Vui lòng cung cấp đường dẫn tới tập tin văn bản.");
                return;
            }

            BoThongKe thongKe = new BoThongKe();
            thongKe.ThongKe(args[0]);
            thongKe.XuatKetQua();

            Console.ReadKey();
        }
    }
}
