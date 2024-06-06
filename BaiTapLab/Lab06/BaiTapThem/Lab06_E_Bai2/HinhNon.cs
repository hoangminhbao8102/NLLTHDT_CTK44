using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_E_Bai2
{
    class HinhNon : HinhHoc3D
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
            return Math.PI * BanKinh * BanKinh * ChieuCao / 3;
        }

        public override string ToString()
        {
            return $"Hình nón: Thể tích = {TinhTheTich()}";
        }
    }
}
