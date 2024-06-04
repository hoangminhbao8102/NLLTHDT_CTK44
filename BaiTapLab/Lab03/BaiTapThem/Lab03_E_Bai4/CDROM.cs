using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_E_Bai4
{
    public class CDROM
    {
        private int _gia;
        private string _tocDo;

        public int Gia 
        {
            get { return _gia; }
            set { _gia = value; }
        }
        public string TocDo 
        {
            get { return _tocDo; }
            set { _tocDo = value; }
        }

        public CDROM()
        {
            _gia = 0;
            _tocDo = null;
        }

        public override string ToString()
        {
            return $"CDROM: Giá={_gia}, Tốc độ={_tocDo}";
        }
    }
}
