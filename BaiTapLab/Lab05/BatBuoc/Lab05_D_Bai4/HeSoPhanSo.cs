using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_D_Bai4
{
    public class HeSoPhanSo : HeSo
    {
        private PhanSo _phanSo;

        public HeSoPhanSo(PhanSo phanSo)
        {
            this._phanSo = phanSo;
        }

        public override double LayGiaTri()
        {
            return _phanSo.TinhGiaTri();
        }
    }
}
