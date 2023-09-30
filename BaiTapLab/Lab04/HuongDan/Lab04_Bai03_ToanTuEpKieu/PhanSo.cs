using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_Bai03_ToanTuEpKieu
{
    class PhanSo
    {
        private int _tu;
        private int _mau;

        public int TuSo
        {
            get { return _tu; }
            set { _tu = value; }
        }

        public int MauSo
        {
            get { return _mau; }
            set
            {
                if (value == 0)
                {
                    _mau = 1;
                }
                else
                {
                    _mau = value;
                }
            }
        }

        public PhanSo() { }

        public PhanSo(int tu, int mau)
        {
            TuSo = tu;
            MauSo = mau;
        }

        public double GiaTri
        {
            get { return TinhGiaTri(); }
        }

        public double TinhGiaTri()
        {
            return (double)TuSo / MauSo;
        }

        public PhanSo NghichDao()
        {
            return new PhanSo(MauSo, TuSo);
        }

        public PhanSo RutGon()
        {
            int uc = ToanHoc.UCLN(TuSo, MauSo);
            return new PhanSo(TuSo / uc, MauSo / uc);
        }

        public override string ToString()
        {
            return string.Format("{0}/{1}", TuSo, MauSo);
        }

        public static bool operator true(PhanSo x)
        {
            return x.TuSo != 0;
        }

        public static bool operator false(PhanSo x)
        {
            return x.TuSo == 0;
        }

        public static implicit operator PhanSo(int k)
        {
            return new PhanSo(k, 1);
        }

        public static implicit operator PhanSo(double k)
        {
            int MauMoi = 1;
            while (k - (int)k > 0.0000001)
            {
                k *= 10;
                MauMoi *= 10;
            }

            return new PhanSo((int)k, MauMoi);
        }

        public static explicit operator double(PhanSo x)
        {
            return x.TinhGiaTri();
        }
    }
}
