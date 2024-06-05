using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_D_Bai6
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
            for (int i = _mangHeSo.Length - 1; i >= 0; i--)
            {
                if (_mangHeSo[i] != 0) return i;
            }
            return 0; // Trả về 0 nếu tất cả các hệ số đều là 0
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

        public static DaThuc operator +(DaThuc f, DaThuc g)
        {
            int maxBac = Math.Max(f.TimBac(), g.TimBac());
            double[] heSoMoi = new double[maxBac + 1];

            for (int i = 0; i <= maxBac; i++)
            {
                double heSoF = i <= f.TimBac() ? f._mangHeSo[i] : 0;
                double heSoG = i <= g.TimBac() ? g._mangHeSo[i] : 0;
                heSoMoi[i] = heSoF + heSoG;
            }

            return new DaThuc(heSoMoi);
        }

        public static DaThuc operator -(DaThuc f, DaThuc g)
        {
            int maxBac = Math.Max(f.TimBac(), g.TimBac());
            double[] heSoMoi = new double[maxBac + 1];

            for (int i = 0; i <= maxBac; i++)
            {
                double heSoF = i <= f.TimBac() ? f._mangHeSo[i] : 0;
                double heSoG = i <= g.TimBac() ? g._mangHeSo[i] : 0;
                heSoMoi[i] = heSoF - heSoG;
            }

            return new DaThuc(heSoMoi);
        }

        public static DaThuc operator *(DaThuc f, DaThuc g)
        {
            int bacMoi = f.TimBac() + g.TimBac();
            double[] heSoMoi = new double[bacMoi + 1];

            for (int i = 0; i <= f.TimBac(); i++)
            {
                for (int j = 0; j <= g.TimBac(); j++)
                {
                    heSoMoi[i + j] += f._mangHeSo[i] * g._mangHeSo[j];
                }
            }

            return new DaThuc(heSoMoi);
        }

        public static (DaThuc Thương, DaThuc Dư) Divide(DaThuc f, DaThuc g)
        {
            int bacF = f.TimBac();
            int bacG = g.TimBac();
            if (bacF < bacG) return (new DaThuc(new double[] { 0 }), new DaThuc(f._mangHeSo));

            double[] thuong = new double[bacF - bacG + 1];
            double[] du = (double[])f._mangHeSo.Clone();

            for (int i = bacF; i >= bacG; i--)
            {
                thuong[i - bacG] = du[i] / g._mangHeSo[bacG];
                for (int j = 0; j <= bacG; j++)
                {
                    du[i - j] -= thuong[i - bacG] * g._mangHeSo[bacG - j];
                }
            }

            return (new DaThuc(thuong), new DaThuc(du));
        }

        public static DaThuc operator /(DaThuc f, DaThuc g)
        {
            (DaThuc thuong, DaThuc du) = Divide(f, g);
            return thuong;
        }

        public static DaThuc operator %(DaThuc f, DaThuc g)
        {
            (DaThuc thuong, DaThuc du) = Divide(f, g);
            return du;
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
