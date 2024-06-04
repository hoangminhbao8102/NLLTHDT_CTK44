using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_E_Bai5
{
    public class KetQuaThi
    {
        private float _diem;
        private string _maMH;
        private int _soTC;
        private string _tenMh;

        public float Diem 
        {
            get { return _diem; }
            set { _diem = value; } 
        }
        public string MaMH 
        {
            get { return _maMH; }
            set { _maMH = value; } 
        }
        public int SoTC 
        {
            get { return _soTC; }
            set { _soTC = value; } 
        }
        public string TenMH 
        {
            get { return _tenMh; }
            set { _tenMh = value; } 
        }

        public KetQuaThi()
        {
            Diem = 0;
            MaMH = string.Empty;
            SoTC = 0;
            TenMH = string.Empty;
        }

        public override string ToString()
        {
            return $"Mã MH: {MaMH}, Tên MH: {TenMH}, Điểm: {Diem}, Số TC: {SoTC}";
        }
    }
}
