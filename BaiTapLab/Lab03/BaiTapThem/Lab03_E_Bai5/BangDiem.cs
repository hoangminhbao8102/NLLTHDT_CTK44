using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_E_Bai5
{
    public class BangDiem
    {
        private KetQuaThi[] _danhSach;
        private int _soLuong;

        public int SoLuong 
        {
            get { return _soLuong; }
            set { _soLuong = value; }
        }
        public KetQuaThi this[int index] 
        {
            get { return _danhSach[index]; }
            set { _danhSach[index] = value; }
        }

        public BangDiem()
        {
            _danhSach = new KetQuaThi[100];
            _soLuong = 0;
        }

        public void Them(KetQuaThi kqt)
        {
            if (_soLuong < 100)
            {
                _danhSach[_soLuong++] = kqt;
            }
        }

        public float TinhDiemTBChiLuy()
        {
            float total = 0;
            int totalCredits = 0;
            for (int i = 0; i < _soLuong; i++)
            {
                total += _danhSach[i].Diem * _danhSach[i].SoTC;
                totalCredits += _danhSach[i].SoTC;
            }
            return totalCredits > 0 ? total / totalCredits : 0;
        }

        public float TinhDiemTrungBinh()
        {
            float total = 0;
            for (int i = 0; i < _soLuong; i++)
            {
                total += _danhSach[i].Diem;
            }
            return _soLuong > 0 ? total / _soLuong : 0;
        }

        public int TinhTongSoTC()
        {
            int totalCredits = 0;
            for (int i = 0; i < _soLuong; i++)
            {
                totalCredits += _danhSach[i].SoTC;
            }
            return totalCredits;
        }

        public override string ToString()
        {
            string result = "Bảng điểm:\n";
            foreach (var item in _danhSach)
            {
                if (item != null) result += item.ToString() + "\n";
            }
            return result;
        }
    }
}
