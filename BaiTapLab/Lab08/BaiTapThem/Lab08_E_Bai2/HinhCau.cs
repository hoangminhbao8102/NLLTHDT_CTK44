using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_E_Bai2
{
    public class HinhCau : I3DShape, IMauSac
    {
        public double Radius { get; set; }

        public HinhCau(double radius)
        {
            Radius = radius;
        }

        public double TinhTheTich()
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(Radius, 3);
        }

        public void ToMau(Color mau)
        {
            Console.WriteLine($"Hình cầu được tô màu {mau.Name}");
        }
    }
}
