using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_E_Bai3
{
    public class SoHang : IBieuThuc
    {
        private double _giaTri;

        public SoHang(double giaTri)
        {
            _giaTri = giaTri;
        }

        public double TinhGiaTri()
        {
            return _giaTri;
        }
    }
}
