using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_E_Bai4
{
    public class RAM
    {
        private int _dungLuong;
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

        public RAM()
        {
            _dungLuong = 0;
            _gia = 0;
        }

        public override string ToString()
        {
            return $"RAM: Dung lượng={_dungLuong} GB, Giá={_gia}";
        }
    }
}
