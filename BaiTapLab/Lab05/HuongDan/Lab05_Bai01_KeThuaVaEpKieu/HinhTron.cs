using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_Bai01_KeThuaVaEpKieu
{
    class HinhTron
    {
        protected double _banKinh;

        public double BanKinh
        {
            get { return _banKinh; }
            set { _banKinh = value; }
        }

        public HinhTron()
        {
            _banKinh = 0;
        }

        public HinhTron(double r)
        {
            _banKinh = r;
        }

        public double TinhChuVi()
        {
            return 2 * Math.PI * _banKinh;
        }

        public double TinhDienTich()
        {
            return _banKinh * _banKinh * Math.PI;
        }
    }
}
