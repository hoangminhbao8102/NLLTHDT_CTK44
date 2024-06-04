using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_E_Bai3_Lab03_D_Bai7_P2__
{
    public class DaThuc
    {
        private DonThuc[] _dsDonThuc; // Thay _mangHeSo thành _dsDonThuc
        private int _soLuong;

        public int SoDonThuc 
        { 
            get { return _soLuong; } 
        }

        public DaThuc Cong(DaThuc dt)
        {
            DaThuc result = new DaThuc();
            result._dsDonThuc = new DonThuc[this._soLuong + dt._soLuong];
            Array.Copy(this._dsDonThuc, result._dsDonThuc, this._soLuong);
            Array.Copy(dt._dsDonThuc, 0, result._dsDonThuc, this._soLuong, dt._soLuong);
            result._soLuong = this._soLuong + dt._soLuong;
            return result;
        }

        public DaThuc()
        {
            _dsDonThuc = new DonThuc[10]; 
            _soLuong = 0;
        }

        public DaThuc Nhan(DaThuc dt)
        {
            DaThuc result = new DaThuc();
            foreach (DonThuc d1 in this._dsDonThuc)
            {
                if (d1 != null)
                {
                    foreach (DonThuc d2 in dt._dsDonThuc)
                    {
                        if (d2 != null)
                        {
                            double newHeSo = d1.HeSo * d2.HeSo;
                            int newSoMu = d1.SoMu + d2.SoMu;
                            result.Them(newHeSo, newSoMu);
                        }
                    }
                }
            }
            return result;
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
