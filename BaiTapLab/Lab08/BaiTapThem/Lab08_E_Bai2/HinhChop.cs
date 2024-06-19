using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_E_Bai2
{
    public class HinhChop : I3DShape, IMauSac
    {
        public double BaseArea { get; set; }
        public double Height { get; set; }

        public HinhChop(double baseArea, double height)
        {
            BaseArea = baseArea;
            Height = height;
        }

        public double TinhTheTich()
        {
            return (1.0 / 3.0) * BaseArea * Height;
        }

        public void ToMau(Color mau)
        {
            Console.WriteLine($"Hình chóp được tô màu {mau.Name}");
        }
    }
}
