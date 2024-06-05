using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_E_Bai1
{
    public class HamDaThuc : HamSo
    {
        private double[] _cacHeSo;

        // Add a property to get the degree of the polynomial
        public int Bac
        {
            get { return _cacHeSo.Length - 1; }
        }

        public HamDaThuc(string ten, double[] heSo) : base(ten)
        {
            _cacHeSo = heSo;
        }

        public override double TinhGiaTri(double x)
        {
            double result = 0;
            for (int i = 0; i < _cacHeSo.Length; i++)
            {
                result += _cacHeSo[i] * Math.Pow(x, _cacHeSo.Length - i - 1);
            }
            return result;
        }

        public override void Xuat()
        {
            Console.Write($"{Ten}: h(x) = ");
            for (int i = 0; i < _cacHeSo.Length; i++)
            {
                Console.Write($"{_cacHeSo[i]}x^{_cacHeSo.Length - i - 1}");
                if (i < _cacHeSo.Length - 1)
                    Console.Write(" + ");
            }
            Console.WriteLine();
        }
    }
}
