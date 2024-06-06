using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_E_Bai1
{
    class HamDaThuc : HamSo
    {
        private double[] _cacHeSo;

        public HamDaThuc(string ten, double[] heSo) : base(ten)
        {
            this._cacHeSo = heSo;
        }

        public override double TinhGiaTri(double x)
        {
            double result = 0;
            for (int i = 0; i < _cacHeSo.Length; i++)
            {
                result += _cacHeSo[i] * Math.Pow(x, _cacHeSo.Length - 1 - i);
            }
            return result;
        }

        public override void Xuat()
        {
            Console.Write($"{Ten}: h(x) = ");
            for (int i = 0; i < _cacHeSo.Length; i++)
            {
                Console.Write($"{_cacHeSo[i]}x^{_cacHeSo.Length - 1 - i}");
                if (i < _cacHeSo.Length - 1) Console.Write(" + ");
            }
            Console.WriteLine();
        }

        // Method to get the degree of the polynomial
        public int Bac()
        {
            return _cacHeSo.Length - 1;
        }
    }
}
