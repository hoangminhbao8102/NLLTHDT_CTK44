using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_Bai01_GhiDePhuongThucAo
{
    class HinhTru : HinhTron
    {
        private double _chieuCao;

        public double ChieuCao
        {
            get { return _chieuCao; }
            set { _chieuCao = value; }
        }

        public HinhTru() : base()
        {
            _chieuCao = 0;
        }

        public HinhTru(double r, double h) : base(r)
        {
            _chieuCao = h;
        }

        public override double TinhDienTich()
        {
            double dtThan = base.TinhChuVi() * _chieuCao;
            return 2 * base.TinhDienTich() + dtThan;
        }

        public double TinhTheTich()
        {
            return base.TinhDienTich() * _chieuCao;
        }

        public override void Ve()
        {
            Console.WriteLine("Ve hinh tru cao : {0}", _chieuCao);
        }
    }
}
