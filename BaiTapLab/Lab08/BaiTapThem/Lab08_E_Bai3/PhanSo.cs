using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_E_Bai3
{
    public class PhanSo : IBieuThuc
    {
        private IBieuThuc _soHang;
        private IBieuThuc _soMu;

        public PhanSo(IBieuThuc soHang, IBieuThuc soMu)
        {
            _soHang = soHang;
            _soMu = soMu;
        }

        public double TinhGiaTri()
        {
            double denominator = _soMu.TinhGiaTri();
            if (denominator == 0)
            {
                throw new DivideByZeroException("Denominator cannot be zero.");
            }
            return _soHang.TinhGiaTri() / denominator;
        }
    }
}
