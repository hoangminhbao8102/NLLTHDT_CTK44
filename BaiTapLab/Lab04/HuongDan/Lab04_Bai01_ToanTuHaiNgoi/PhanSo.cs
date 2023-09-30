using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_Bai01_ToanTuHaiNgoi
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

        public double GiaTri()
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

        public static PhanSo operator + (PhanSo x, PhanSo y)
        {
            int TuMoi = x.TuSo * y.MauSo + x.MauSo * y.TuSo;
            int MauMoi = x.MauSo * y.MauSo;
            PhanSo tong = new PhanSo(TuMoi, MauMoi);
            return tong.RutGon();
        }

        public static PhanSo operator +(PhanSo x, int k)
        {
            PhanSo y = new PhanSo(k, 1);
            return x + y;
        }

        public static PhanSo operator -(PhanSo x, PhanSo y)
        {
            int TuMoi = x.TuSo * y.MauSo - x.MauSo * y.TuSo;
            int MauMoi = x.MauSo * y.MauSo;
            return new PhanSo(TuMoi, MauMoi).RutGon();
        }

        public static PhanSo operator -(PhanSo x, int k)
        {
            return x + (-k);
        }

        public static PhanSo operator *(PhanSo x, PhanSo y)
        {
            int TuMoi = x.TuSo * y.TuSo;
            int MauMoi = x.MauSo * y.MauSo;
            return new PhanSo(TuMoi, MauMoi).RutGon();
        }

        public static PhanSo operator *(PhanSo x, int k)
        {
            int TuMoi = x.TuSo * k;
            return new PhanSo(TuMoi, x.MauSo).RutGon();
        }

        public static PhanSo operator /(PhanSo x, PhanSo y)
        {
            int TuMoi = x.TuSo * y.MauSo;
            int MauMoi = x.MauSo * y.TuSo;
            return new PhanSo(TuMoi, MauMoi).RutGon();
        }

        public static PhanSo operator /(PhanSo x, int k)
        {
            int MauMoi = x.MauSo * k;
            return new PhanSo(x.TuSo, MauMoi).RutGon();
        }

        public static bool operator ==(PhanSo x, PhanSo y)
        {
            return x.GiaTri() == y.GiaTri();
        }

        public static bool operator !=(PhanSo x, PhanSo y)
        {
            return x.GiaTri() != y.GiaTri();
        }

        public static bool operator >(PhanSo x, PhanSo y)
        {
            return x.GiaTri() > y.GiaTri();
        }

        public static bool operator <(PhanSo x, PhanSo y)
        {
            return x.GiaTri() < y.GiaTri();
        }

        public static bool operator >=(PhanSo x, PhanSo y)
        {
            return x.GiaTri() >= y.GiaTri();
        }

        public static bool operator <=(PhanSo x, PhanSo y)
        {
            return x.GiaTri() <= y.GiaTri();
        }

        public static PhanSo operator <<(PhanSo x, int n)
        {
            int TuMoi = x.TuSo << n;
            return new PhanSo(TuMoi, x.MauSo);
        }

        public static PhanSo operator >>(PhanSo x, int n)
        {
            int TuMoi = x.TuSo >> n;
            return new PhanSo(TuMoi, x.MauSo);
        }
    }
}
