using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_D_Bai3
{
    class DonThuc
    {
        private HeSo _heSo;
        private int _soMu;

        public HeSo HeSo
        {
            get { return _heSo; }
            set { _heSo = value; }
        }
        public int SoMu
        {
            get { return _soMu; }
            set { _soMu = value; }
        }

        public DonThuc(HeSo heSo, int soMu)
        {
            _heSo = heSo;
            _soMu = soMu;
        }

        public double TinhGiaTri(double x)
        {
            return _heSo.LayGiaTri() * Math.Pow(x, _soMu);
        }
    }
}
