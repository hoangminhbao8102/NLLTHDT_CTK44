using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhanSo
{
    public class PhanSo
    {
        public int Tu { get; private set; }
        public int Mau { get; private set; }

        public PhanSo()
        {
            Mau = 1;
        }

        public PhanSo(int tu, int mau)
        {
            if (mau == 0)
            {
                throw new ArgumentException("Mẫu số không thể bằng 0.");
            }

            Tu = tu;
            Mau = mau;
            ToiGian();
        }

        public void Nhap()
        {
            Console.Write("Nhập tử: ");
            Tu = int.Parse(Console.ReadLine());
            Console.Write("Nhập mẫu: ");
            Mau = int.Parse(Console.ReadLine());

            if (Mau == 0)
            {
                throw new ArgumentException("Mẫu số không thể bằng 0.");
            }

            ToiGian();
        }

        public void Xuat()
        {
            Console.WriteLine("{0}/{1}", Tu, Mau);
        }

        private void ToiGian()
        {
            int gcd = UCLN(Tu, Mau);
            Tu /= gcd;
            Mau /= gcd;
        }

        private int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int t = b;
                b = a % b;
                a = t;
            }
            return a;
        }

        public PhanSo Cong(PhanSo b)
        {
            int tu = Tu * b.Mau + b.Tu * Mau;
            int mau = Mau * b.Mau;
            return new PhanSo(tu, mau);
        }

        public PhanSo Tru(PhanSo b)
        {
            int tu = Tu * b.Mau - b.Tu * Mau;
            int mau = Mau * b.Mau;
            return new PhanSo(tu, mau);
        }

        public PhanSo Nhan(PhanSo b)
        {
            int tu = Tu * b.Tu;
            int mau = Mau * b.Mau;
            return new PhanSo(tu, mau);
        }

        public PhanSo Chia(PhanSo b)
        {
            if (b.Tu == 0)
            {
                throw new ArgumentException("Không thể chia cho phân số có tử số bằng 0.");
            }

            int tu = Tu * b.Mau;
            int mau = Mau * b.Tu;
            return new PhanSo(tu, mau);
        }

        public PhanSo NghichDao()
        {
            if (Tu == 0)
            {
                throw new ArgumentException("Không thể nghịch đảo phân số với tử số bằng 0.");
            }

            return new PhanSo(Mau, Tu);
        }

        public static PhanSo operator +(PhanSo a, PhanSo b) => a.Cong(b);
        public static PhanSo operator -(PhanSo a, PhanSo b) => a.Tru(b);
        public static PhanSo operator *(PhanSo a, PhanSo b) => a.Nhan(b);
        public static PhanSo operator /(PhanSo a, PhanSo b) => a.Chia(b);

        public override string ToString()
        {
            return $"{Tu}/{Mau}";
        }
    }
}
