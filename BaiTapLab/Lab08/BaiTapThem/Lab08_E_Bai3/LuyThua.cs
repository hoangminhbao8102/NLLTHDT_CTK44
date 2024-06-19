using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_E_Bai3
{
    public class LuyThua : IBieuThuc
    {
        private IBieuThuc _soHang;
        private IBieuThuc _soMu;

        public LuyThua(IBieuThuc soHang, IBieuThuc soMu)
        {
            _soHang = soHang;
            _soMu = soMu;
        }

        public double TinhGiaTri()
        {
            return Math.Pow(_soHang.TinhGiaTri(), _soMu.TinhGiaTri());
        }
    }
}
