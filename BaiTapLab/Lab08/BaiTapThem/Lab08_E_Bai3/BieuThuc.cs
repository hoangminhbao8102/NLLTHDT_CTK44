using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_E_Bai3
{
    public class BieuThuc : IBieuThuc
    {
        private IBieuThuc _soHangTrai;
        private IBieuThuc _soHangPhai;
        private char _phepToan;

        public BieuThuc(IBieuThuc trai, IBieuThuc phai, char phepToan)
        {
            _soHangTrai = trai;
            _soHangPhai = phai;
            _phepToan = phepToan;
        }

        public double TinhGiaTri()
        {
            switch (_phepToan)
            {
                case '+':
                    return _soHangTrai.TinhGiaTri() + _soHangPhai.TinhGiaTri();
                case '-':
                    return _soHangTrai.TinhGiaTri() - _soHangPhai.TinhGiaTri();
                case '*':
                    return _soHangTrai.TinhGiaTri() * _soHangPhai.TinhGiaTri();
                case '/':
                    return _soHangTrai.TinhGiaTri() / _soHangPhai.TinhGiaTri();
                default:
                    throw new ArgumentException("Unsupported operator: " + _phepToan);
            }
        }
    }
}
