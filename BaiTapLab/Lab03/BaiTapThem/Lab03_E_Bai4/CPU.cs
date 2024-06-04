using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_E_Bai4
{
    public class CPU
    {
        private int _gia;
        private int _soLoi;
        private float _tocDo;

        public int Gia 
        {
            get { return _gia; }
            set { _gia = value; }
        }
        public int SoLoi 
        { 
            get { return _soLoi; }
            set { _soLoi = value; }
        }
        public float TocDo 
        {
            get { return _tocDo; }
            set { _tocDo = value; }
        }

        public CPU()
        {
            _gia = 0;
            _soLoi = 0;
            _tocDo = 0;
        }

        public override string ToString()
        {
            return $"CPU: Giá={_gia}, Số lõi={_soLoi}, Tốc độ={_tocDo} GHz";
        }
    }
}
