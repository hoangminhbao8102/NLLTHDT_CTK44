using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_D_Bai3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Vector u = new Vector(5, -3);
            Vector v = new Vector(4, 9);

            Console.WriteLine("Vector u: " + u);
            Console.WriteLine("Vector v: " + v);
            Console.WriteLine("Độ dài vector u: " + u.DoDai);
            Console.WriteLine("Độ dài vector v: " + v.DoDai);
            Console.WriteLine("Góc hợp với Ox của u: " + u.TinhGocHopVoiOx() + " độ");
            Console.WriteLine("Góc hợp với Ox của v: " + v.TinhGocHopVoiOx() + " độ");
            Console.WriteLine("Tích vô hướng của u và v: " + u.TichVoHuong(v));

            Vector tong = u.Cong(v);
            Console.WriteLine("Vector tổng của u và v: " + tong);
            Console.WriteLine("Độ dài của vector tổng: " + tong.DoDai);
            Console.WriteLine("Góc giữa hai vector u và v: " + Vector.GocGiuaHaiVector(u, v) + " độ");
            Console.WriteLine("Hai vector song song: " + Vector.KiemTraSongSong(u, v));
            Console.WriteLine("Hai vector cùng chiều: " + Vector.CungChieu(u, v));

            Console.ReadKey();
        }
    }
}
