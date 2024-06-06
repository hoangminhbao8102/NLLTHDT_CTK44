using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_E_Bai2
{
    class HinhCau : HinhHoc3D
    {
        public double BanKinh { get; set; }

        public HinhCau(double banKinh)
        {
            BanKinh = banKinh;
        }

        public override double TinhTheTich()
        {
            return 4.0 / 3 * Math.PI * BanKinh * BanKinh * BanKinh;
        }

        public override string ToString()
        {
            return $"Hình cầu: Thể tích = {TinhTheTich()}";
        }
    }
}
