using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_D_Bai1
{
    public class SoPhuc
    {
        private double _phanAo;
        private double _phanThuc;

        public double Ao { get; set; }
        public double Thuc { get; set; }

        // Các constructors
        public SoPhuc()
        {
            Thuc = 0;
            Ao = 0;
        }

        public SoPhuc(double phanAo)
        {
            this.Thuc = 0;
            this.Ao = phanAo;
        }

        public SoPhuc(double phanThuc, double phanAo)
        {
            this.Thuc = phanThuc;
            this.Ao = phanAo;
        }

        // Implicit operators
        public static implicit operator SoPhuc(double k)
        {
            return new SoPhuc(k, 0);
        }

        public static implicit operator SoPhuc(int k)
        {
            return new SoPhuc(k, 0);
        }

        // Equality operators
        public static bool operator ==(SoPhuc x, SoPhuc y)
        {
            return x.Thuc == y.Thuc && x.Ao == y.Ao;
        }

        public static bool operator !=(SoPhuc x, SoPhuc y)
        {
            return !(x == y);
        }

        // Complex conjugate operator
        public static SoPhuc operator ~(SoPhuc x)
        {
            return new SoPhuc(x.Thuc, -x.Ao);
        }

        // Nạp chồng toán tử cộng
        public static SoPhuc operator +(SoPhuc a, SoPhuc b)
        {
            return new SoPhuc(a.Thuc + b.Thuc, a.Ao + b.Ao);
        }

        // Nạp chồng toán tử trừ
        public static SoPhuc operator -(SoPhuc a, SoPhuc b)
        {
            return new SoPhuc(a.Thuc - b.Thuc, a.Ao - b.Ao);
        }

        // Nạp chồng toán tử nhân
        public static SoPhuc operator *(SoPhuc a, SoPhuc b)
        {
            double newThuc = a.Thuc * b.Thuc - a.Ao * b.Ao;
            double newAo = a.Thuc * b.Ao + a.Ao * b.Thuc;
            return new SoPhuc(newThuc, newAo);
        }

        // Nạp chồng toán tử chia
        public static SoPhuc operator /(SoPhuc a, SoPhuc b)
        {
            double div = b.Thuc * b.Thuc + b.Ao * b.Ao;
            double newThuc = (a.Thuc * b.Thuc + a.Ao * b.Ao) / div;
            double newAo = (a.Ao * b.Thuc - a.Thuc * b.Ao) / div;
            return new SoPhuc(newThuc, newAo);
        }

        public override string ToString()
        {
            return $"({Thuc} + {Ao}i)";
        }

        public override bool Equals(object obj)
        {
            if (obj is SoPhuc)
            {
                SoPhuc sp = (SoPhuc)obj;
                return this == sp;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Ao.GetHashCode() ^ Thuc.GetHashCode();
        }
    }
}
