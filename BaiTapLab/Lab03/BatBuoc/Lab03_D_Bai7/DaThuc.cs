using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_D_Bai7
{
    public class DaThuc
    {
        private double[] _mangHeSo;

        public DaThuc(double[] heSo)
        {
            _mangHeSo = heSo;
        }

        public DaThuc(int bac)
        {
            _mangHeSo = new double[bac + 1];
        }

        public int DemSoDonThuc()
        {
            int count = 0;
            foreach (double hs in _mangHeSo)
            {
                if (hs != 0) count++;
            }
            return count;
        }

        public int TimBac()
        {
            return _mangHeSo.Length - 1;
        }

        public bool Them(double heSo, int soMu)
        {
            if (soMu < _mangHeSo.Length)
            {
                _mangHeSo[soMu] += heSo;
                return true;
            }
            return false;
        }

        public double TinhGiaTri(double x)
        {
            double result = 0;
            for (int i = 0; i < _mangHeSo.Length; i++)
            {
                result += _mangHeSo[i] * Math.Pow(x, i);
            }
            return result;
        }

        public DaThuc Cong(DaThuc dt)
        {
            int maxBac = Math.Max(this.TimBac(), dt.TimBac());
            double[] heSoMoi = new double[maxBac + 1];

            for (int i = 0; i <= maxBac; i++)
            {
                double heSoThis = i <= this.TimBac() ? this._mangHeSo[i] : 0;
                double heSoDt = i <= dt.TimBac() ? dt._mangHeSo[i] : 0;
                heSoMoi[i] = heSoThis + heSoDt;
            }

            return new DaThuc(heSoMoi);
        }

        public DaThuc Nhan(DaThuc dt)
        {
            int bacMoi = this.TimBac() + dt.TimBac();
            double[] heSoMoi = new double[bacMoi + 1];

            for (int i = 0; i <= this.TimBac(); i++)
            {
                for (int j = 0; j <= dt.TimBac(); j++)
                {
                    heSoMoi[i + j] += this._mangHeSo[i] * dt._mangHeSo[j];
                }
            }

            return new DaThuc(heSoMoi);
        }

        public void Xuat()
        {
            bool first = true;
            for (int i = _mangHeSo.Length - 1; i >= 0; i--)
            {
                if (_mangHeSo[i] != 0)
                {
                    if (!first && _mangHeSo[i] > 0) Console.Write("+");
                    Console.Write($"{_mangHeSo[i]}x^{i} ");
                    first = false;
                }
            }
            Console.WriteLine();
        }
    }
}
