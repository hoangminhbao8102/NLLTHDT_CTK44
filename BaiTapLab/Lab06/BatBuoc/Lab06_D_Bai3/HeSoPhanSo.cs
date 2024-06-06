using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_D_Bai3
{
    class HeSoPhanSo : HeSo
    {
        private PhanSo _phanSo;

        public HeSoPhanSo(PhanSo p)
        {
            _phanSo = p;
        }

        public override double LayGiaTri()
        {
            return _phanSo.TinhGiaTri();
        }
    }
}
