using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_E_Bai2
{
    class HinhHopChuNhat : HinhHoc3D
    {
        public double Dai { get; set; }
        public double Rong { get; set; }
        public double Cao { get; set; }

        public HinhHopChuNhat(double dai, double rong, double cao)
        {
            Dai = dai;
            Rong = rong;
            Cao = cao;
        }

        public override double TinhTheTich()
        {
            return Dai * Rong * Cao;
        }

        public override string ToString()
        {
            return $"Hình hộp chữ nhật: Thể tích = {TinhTheTich()}";
        }
    }
}
