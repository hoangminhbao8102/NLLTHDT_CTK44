using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_D_Bai3
{
    class HeSoThuc : HeSo
    {
        private double _so;

        public HeSoThuc(double so)
        {
            _so = so;
        }

        public override double LayGiaTri()
        {
            return _so;
        }
    }
}
