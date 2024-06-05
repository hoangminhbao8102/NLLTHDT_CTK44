using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_E_Bai3
{
    public class DonThuc
    {
        private double _heSo;
        private int _soMu;

        public double HeSo
        {
            get { return _heSo; }
            set { _heSo = value; }
        }
        public int SoMu
        {
            get { return _soMu; }
            set { _soMu = value; }
        }

        public DonThuc()
        {
            _heSo = 0;
            _soMu = 0;
        }

        public DonThuc(double hs, int mu)
        {
            _heSo = hs;
            _soMu = mu;
        }

        public double TinhGiaTri(double x)
        {
            return _heSo * Math.Pow(x, _soMu);
        }

        public override string ToString()
        {
            return $"{_heSo}x^{_soMu}";
        }
    }
}
