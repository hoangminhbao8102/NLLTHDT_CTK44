using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_E_Bai4
{
    public class MainBoard
    {
        private int _bus;
        private int _gia;
        private string _hang;

        public int Gia 
        { 
            get { return _gia; }
            set { _gia = value; }
        }
        public int TocDoBus 
        { 
            get { return _bus; }
            set { _bus = value; }
        }
        public string HangSX 
        { 
            get { return _hang; }
            set { _hang = value; }
        }

        public MainBoard()
        {
            _bus = 0;
            _gia = 0;
            _hang = string.Empty;
        }

        public override string ToString()
        {
            return $"MainBoard: Tốc độ bus={_bus}, Hãng sản xuất={_hang}, Giá={_gia}";
        }
    }
}
