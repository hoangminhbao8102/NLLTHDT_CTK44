using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_E_Bai3
{
    public class HamFactorial : IBieuThuc
    {
        private IBieuThuc _soHang;

        public HamFactorial(IBieuThuc soHang)
        {
            _soHang = soHang;
        }

        public double TinhGiaTri()
        {
            int result = 1;
            int value = (int)_soHang.TinhGiaTri();
            for (int i = 2; i <= value; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
