using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_D_Bai4
{
    public class HeSoThuc : HeSo
    {
        private double _so;

        public HeSoThuc(double so)
        {
            this._so = so;
        }

        public override double LayGiaTri()
        {
            return _so;
        }
    }
}
