using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_QuanLySachBao_Lab07_HuongDan_
{
    public abstract class TaiLieu
    {
        protected string _maSo;
        protected int _namXb;
        protected string _nhanDe;

        public string MaSo
        {
            get { return _maSo; } 
            set { _maSo = value; }
        }

        public int NamXB
        {
            get { return _namXb; }
            set { _namXb = value; }
        }

        public string NhanDe
        {
            get { return _nhanDe; }
            set { _nhanDe = value; }
        }

        public abstract bool LaCongTrinhCua(string tenTacGia);

        public TaiLieu()
        {
            _maSo = "";
            _namXb = 0;
            _nhanDe = "";
        }

        public TaiLieu(string maso, string tuade, int namxb)
        {
            _maSo = maso;
            _namXb = namxb;
            _nhanDe = tuade;
        }
    }
}
