using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_E_Bai2
{
    public class HinhCau : HinhHoc3D
    {
        public double BanKinh { get; set; }

        public HinhCau(double banKinh)
        {
            BanKinh = banKinh;
        }

        public override double TinhTheTich()
        {
            return 4 / 3 * Math.PI * BanKinh * BanKinh * BanKinh;
        }
    }
}
