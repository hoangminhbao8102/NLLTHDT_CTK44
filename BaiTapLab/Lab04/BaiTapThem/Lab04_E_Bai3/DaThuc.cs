using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_E_Bai3
{
    public class DaThuc
    {
        private DonThuc[] _dsDonThuc; // Thay _mangHeSo thành _dsDonThuc
        private int _soLuong;

        public int SoDonThuc
        {
            get { return _soLuong; }
        }

        public DaThuc()
        {
            _dsDonThuc = new DonThuc[10];
            _soLuong = 0;
        }

        public DaThuc(DonThuc[] dsDonThuc)
        {
            _dsDonThuc = dsDonThuc;
            _soLuong++;
        }

        public int DemSoDonThuc()
        {
            int count = 0;
            foreach (DonThuc dt in _dsDonThuc)
            {
                if (dt != null && dt.HeSo != 0)
                    count++;
            }
            return count;
        }

        public void Them(DonThuc d)
        {
            if (_soLuong < _dsDonThuc.Length)
            {
                _dsDonThuc[_soLuong++] = d;
            }
            else
            {
                // Resize the array, if needed
                Array.Resize(ref _dsDonThuc, _dsDonThuc.Length * 2);
                _dsDonThuc[_soLuong++] = d;
            }
        }

        public bool Them(double heSo, int soMu)
        {
            if (_soLuong < _dsDonThuc.Length)
            {
                _dsDonThuc[_soLuong++] = new DonThuc(heSo, soMu);
                return true;
            }
            return false;
        }

        public static DaThuc operator +(DaThuc a, DaThuc b)
        {
            DaThuc result = new DaThuc();
            foreach (var donThuc in a._dsDonThuc)
            {
                if (donThuc != null) result.Them(donThuc);
            }
            foreach (var donThuc in b._dsDonThuc)
            {
                if (donThuc != null) result.Them(donThuc);
            }
            return result;
        }

        public static DaThuc operator -(DaThuc a, DaThuc b)
        {
            DaThuc result = new DaThuc();
            foreach (var donThuc in a._dsDonThuc)
            {
                if (donThuc != null) result.Them(donThuc);
            }
            foreach (var donThuc in b._dsDonThuc)
            {
                if (donThuc != null) result.Them(new DonThuc(-donThuc.HeSo, donThuc.SoMu));
            }
            return result;
        }

        public static DaThuc operator *(DaThuc a, DaThuc b)
        {
            DaThuc result = new DaThuc();
            foreach (var d1 in a._dsDonThuc)
            {
                if (d1 != null)
                {
                    foreach (var d2 in b._dsDonThuc)
                    {
                        if (d2 != null)
                        {
                            result.Them(d1.HeSo * d2.HeSo, d1.SoMu + d2.SoMu);
                        }
                    }
                }
            }
            return result;
        }

        public static DaThuc operator /(DaThuc a, DaThuc b)
        {
            // Kiểm tra điều kiện chia hợp lệ (ví dụ: b không phải là đa thức không)
            if (b == null || b.SoDonThuc == 0 || b.TimBac() == 0 && Math.Abs(b._dsDonThuc[0].HeSo) < 1e-9)
            {
                throw new DivideByZeroException("Không thể chia cho đa thức không.");
            }

            DaThuc thuong = new DaThuc();
            DaThuc soDu = new DaThuc(a._dsDonThuc);  // Sao chép đa thức a
            int bacA = a.TimBac();
            int bacB = b.TimBac();

            while (soDu != null && soDu.TimBac() >= bacB)
            {
                // Tính tỷ số hệ số và số mũ giữa đơn thức cao nhất của soDu và b
                double heSoTh = soDu._dsDonThuc[soDu.TimBac()].HeSo / b._dsDonThuc[bacB].HeSo;
                int soMuTh = soDu.TimBac() - bacB;
                DaThuc donThucTh = new DaThuc(); // Đa thức mới chứa đơn thức này
                donThucTh.Them(heSoTh, soMuTh);
                thuong += donThucTh;
                // Trừ đa thức đã nhân ra khỏi soDu
                soDu -= (donThucTh * b);
            }

            return thuong;
        }

        public int TimBac()
        {
            int maxBac = 0;
            foreach (DonThuc dt in _dsDonThuc)
            {
                if (dt != null && dt.SoMu > maxBac)
                    maxBac = dt.SoMu;
            }
            return maxBac;
        }

        public double TinhGiaTri(double x)
        {
            double result = 0;
            foreach (DonThuc dt in _dsDonThuc)
            {
                if (dt != null)
                    result += dt.TinhGiaTri(x);
            }
            return result;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < _soLuong; i++)
            {
                if (i > 0 && _dsDonThuc[i].HeSo > 0) sb.Append("+");
                sb.Append(_dsDonThuc[i].ToString());
            }
            return sb.ToString();
        }

        public void Xuat()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
