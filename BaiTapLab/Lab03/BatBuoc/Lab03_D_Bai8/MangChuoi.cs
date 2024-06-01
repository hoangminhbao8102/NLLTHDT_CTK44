using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_D_Bai8
{
    public class MangChuoi
    {
        private string[] _danhSach;
        private int _soLuong;

        public int SoLuong
        {
            get { return _soLuong; }
            set { _soLuong = value; }
        }

        public MangChuoi()
        {
            _danhSach = new string[1000];
            _soLuong = 0;
        }

        public void Them(string chuoi)
        {
            if (_soLuong < _danhSach.Length)
            {
                _danhSach[_soLuong++] = chuoi;
            }
            else
            {
                Console.WriteLine("Mảng đã đầy, không thể thêm mới");
            }
        }

        public bool KiemTraTrung(string chuoi)
        {
            for (int i = 0; i < _soLuong; i++)
            {
                if (_danhSach[i] == chuoi)
                    return true;
            }
            return false;
        }

        public override string ToString()
        {
            return String.Join(", ", _danhSach);
        }
    }
}
