using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_E_Bai4
{
    public class HDD
    {
        private int _dungLuong;
        private int _tocDo;
        private int _gia;

        public int DungLuong 
        { 
            get { return _dungLuong; }
            set { _dungLuong = value; }
        }
        public int Gia 
        {
            get { return _gia; }
            set { _gia = value; }
        }
        public int TocDoQuay 
        { 
            get { return _tocDo; }
            set { _tocDo = value; }
        }

        public HDD()
        {
            _dungLuong = 0;
            _tocDo = 0;
            _gia = 0;
        }

        public override string ToString()
        {
            return $"HDD: Dung lượng={_dungLuong} GB, Tốc độ quay={_tocDo} RPM, Giá={_gia}";
        }
    }
}
