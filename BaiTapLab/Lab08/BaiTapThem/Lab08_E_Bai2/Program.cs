using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_E_Bai2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Tạo các đối tượng hình học
            HinhCau hinhCau = new HinhCau(radius: 3.5);
            HinhHopChuNhat hinhHopChuNhat = new HinhHopChuNhat(length: 4, width: 5, height: 6);
            HinhNon hinhNon = new HinhNon(radius: 3, height: 5);
            HinhTru hinhTru = new HinhTru(radius: 3, height: 7);
            HinhChop hinhChop = new HinhChop(baseArea: 10, height: 4);

            // Mảng các đối tượng I3DShape
            I3DShape[] shapes = { hinhCau, hinhHopChuNhat, hinhNon, hinhTru, hinhChop };

            // Tính và in thể tích của mỗi hình
            foreach (var shape in shapes)
            {
                Console.WriteLine($"Thể tích của {shape.GetType().Name} là: {shape.TinhTheTich():F2}");
            }

            // Mảng các đối tượng IMauSac
            IMauSac[] coloredObjects = { hinhCau, hinhHopChuNhat, hinhNon, hinhTru, hinhChop };

            // Tô màu cho mỗi đối tượng
            Color color = Color.Blue; // Chọn màu
            foreach (var obj in coloredObjects)
            {
                obj.ToMau(color);
            }

            Console.ReadKey();
        }
    }
}
