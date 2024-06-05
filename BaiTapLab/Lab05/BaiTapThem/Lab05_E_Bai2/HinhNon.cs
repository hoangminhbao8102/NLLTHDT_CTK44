using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_E_Bai2
{
    public class HinhNon : HinhHoc3D
    {
        public double BanKinh { get; set; }
        public double ChieuCao { get; set; }

        public HinhNon(double banKinh, double chieuCao)
        {
            BanKinh = banKinh;
            ChieuCao = chieuCao;
        }

        public override double TinhTheTich()
        {
            return 1 / 3 * Math.PI * BanKinh * BanKinh * ChieuCao;
        }
    }
}
