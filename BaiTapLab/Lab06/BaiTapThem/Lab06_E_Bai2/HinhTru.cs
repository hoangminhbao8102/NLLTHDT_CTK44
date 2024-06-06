using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_E_Bai2
{
    class HinhTru : HinhHoc3D
    {
        public double BanKinh { get; set; }
        public double ChieuCao { get; set; }

        public HinhTru(double banKinh, double chieuCao)
        {
            BanKinh = banKinh;
            ChieuCao = chieuCao;
        }

        public override double TinhTheTich()
        {
            return Math.PI * BanKinh * BanKinh * ChieuCao;
        }

        public override string ToString()
        {
            return $"Hình trụ: Thể tích = {TinhTheTich()}";
        }
    }
}
