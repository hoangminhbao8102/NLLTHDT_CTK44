using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_E_Bai2
{
    public class HinhHopChuNhat : I3DShape, IMauSac
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public HinhHopChuNhat(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public double TinhTheTich()
        {
            return Length * Width * Height;
        }

        public void ToMau(Color mau)
        {
            Console.WriteLine($"Hình hộp chữ nhật được tô màu {mau.Name}");
        }
    }
}
