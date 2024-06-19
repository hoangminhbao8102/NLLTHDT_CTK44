using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_E_Bai3
{
    public class HamCot : IBieuThuc
    {
        private IBieuThuc _soHang;

        public HamCot(IBieuThuc soHang)
        {
            _soHang = soHang;
        }

        public double TinhGiaTri()
        {
            return 1 / Math.Tan(_soHang.TinhGiaTri());
        }
    }
}
