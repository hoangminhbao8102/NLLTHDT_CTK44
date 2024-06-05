using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_E_Bai2
{
    public class HinhHopChuNhat : HinhHoc3D
    {
        public double ChieuDai { get; set; }
        public double ChieuRong { get; set; }
        public double ChieuCao { get; set; }

        public HinhHopChuNhat(double chieuDai, double chieuRong, double chieuCao)
        {
            ChieuDai = chieuDai;
            ChieuRong = chieuRong;
            ChieuCao = chieuCao;
        }

        public override double TinhTheTich()
        {
            return ChieuDai * ChieuRong * ChieuCao;
        }
    }
}
