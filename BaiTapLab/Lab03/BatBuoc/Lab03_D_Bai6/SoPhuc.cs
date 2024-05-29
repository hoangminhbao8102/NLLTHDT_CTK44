using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_D_Bai6
{
    public class SoPhuc
    {
        private double _thuc;
        private double _ao;

        public double Thuc
        {
            get { return _thuc; }
            set { _thuc = value; }
        }

        public double Ao
        {
            get { return _ao; }
            set { _ao = value; }
        }

        public SoPhuc()
        {
            _thuc = 0.0;
            _ao = 0.0;
        }

        public SoPhuc(double phanThuc, double phanAo)
        {
            _thuc = phanThuc;
            _ao = phanAo;
        }

        public SoPhuc Cong(SoPhuc p)
        {
            return new SoPhuc(this._thuc + p._thuc, this._ao + p._ao);
        }

        public SoPhuc Tru(SoPhuc p)
        {
            return new SoPhuc(this._thuc - p._thuc, this._ao - p._ao);
        }

        public SoPhuc Nhan(SoPhuc p)
        {
            double thuc = this._thuc * p._thuc - this._ao * p._ao;
            double ao = this._thuc * p._ao + this._ao * p._thuc;
            return new SoPhuc(thuc, ao);
        }

        public SoPhuc Chia(SoPhuc p)
        {
            SoPhuc tu = this.Nhan(p.LienHop());
            double mau = p._thuc * p._thuc + p._ao * p._ao;
            return new SoPhuc(tu._thuc / mau, tu._ao / mau);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is SoPhuc))
                return false;
            SoPhuc other = (SoPhuc)obj;
            return this._thuc == other._thuc && this._ao == other._ao;
        }

        public bool LaSoKhong()
        {
            return _thuc == 0 && _ao == 0;
        }

        public bool LaSoThuanAo()
        {
            return _thuc == 0 && _ao != 0;
        }

        public bool LaSoThuc()
        {
            return _thuc != 0 && _ao == 0;
        }

        public SoPhuc LienHop()
        {
            return new SoPhuc(this._thuc, -this._ao);
        }

        public double TinhModun()
        {
            return Math.Sqrt(_thuc * _thuc + _ao * _ao);
        }

        public override string ToString()
        {
            return $"{_thuc} + {_ao}i";
        }
    }
}
