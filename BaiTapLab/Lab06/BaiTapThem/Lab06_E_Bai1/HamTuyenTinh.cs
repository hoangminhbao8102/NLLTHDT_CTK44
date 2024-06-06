using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_E_Bai1
{
    class HamTuyenTinh : HamSo
    {
        private double _a;
        private double _b;

        public HamTuyenTinh(string ten, double a, double b) : base(ten)
        {
            this._a = a;
            this._b = b;
        }

        public override double TinhGiaTri(double x)
        {
            return _a * x + _b;
        }

        public override void Xuat()
        {
            Console.WriteLine($"{Ten}: f(x) = {_a}x + {_b}");
        }
    }
}
