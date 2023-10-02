using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_Bai01_GhiDePhuongThucAo
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

        public virtual double TinhChuVi()
        {
            return 2 * Math.PI * _banKinh;
        }

        public virtual double TinhDienTich() 
        {
            return _banKinh * _banKinh * Math.PI;
        }

        public virtual void Ve()
        {
            Console.WriteLine("Ve hinh tron ban kinh : {0}", _banKinh);
        }
    }
}
