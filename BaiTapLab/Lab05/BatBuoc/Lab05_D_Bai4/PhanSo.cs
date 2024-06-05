using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_D_Bai4
{
    public class PhanSo
    {
        private int _tu;
        private int _mau;

        public PhanSo(int tu, int mau)
        {
            this._tu = tu;
            this._mau = mau;
        }

        public double TinhGiaTri()
        {
            return (double)_tu / _mau;
        }
    }
}
