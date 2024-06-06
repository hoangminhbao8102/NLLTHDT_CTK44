using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_D_Bai3
{
    class PhanSo
    {
        private int _tu;
        private int _mau;

        public PhanSo(int tu, int mau)
        {
            _tu = tu;
            _mau = mau;
        }

        public double TinhGiaTri()
        {
            return (double)_tu / _mau;
        }
    }
}
