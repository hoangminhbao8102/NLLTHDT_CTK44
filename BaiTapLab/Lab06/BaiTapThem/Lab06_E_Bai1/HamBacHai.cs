using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_E_Bai1
{
    class HamBacHai : HamSo
    {
        private double _a;
        private double _b;
        private double _c;

        public HamBacHai(string ten, double a, double b, double c) : base(ten)
        {
            this._a = a;
            this._b = b;
            this._c = c;
        }

        public override double TinhGiaTri(double x)
        {
            return _a * x * x + _b * x + _c;
        }

        public override void Xuat()
        {
            Console.WriteLine($"{Ten}: g(x) = {_a}x^2 + {_b}x + {_c}");
        }
    }
}
