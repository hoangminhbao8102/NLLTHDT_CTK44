using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_E_Bai2
{
    public class HinhTru : I3DShape, IMauSac
    {
        public double Radius { get; set; }
        public double Height { get; set; }

        public HinhTru(double radius, double height)
        {
            Radius = radius;
            Height = height;
        }

        public double TinhTheTich()
        {
            return Math.PI * Radius * Radius * Height;
        }

        public void ToMau(Color mau)
        {
            Console.WriteLine($"Hình trụ được tô màu {mau.Name}");
        }
    }
}
