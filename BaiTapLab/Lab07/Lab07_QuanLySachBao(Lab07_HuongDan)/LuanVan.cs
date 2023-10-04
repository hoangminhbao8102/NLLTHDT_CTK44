using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_QuanLySachBao_Lab07_HuongDan_
{
    public class LuanVan : TaiLieu
    {
        private string _tacGia;

        public string TacGia
        {
            get { return _tacGia; } 
            set { _tacGia = value; }
        }

        public override bool LaCongTrinhCua(string tenTacGia)
        {
            throw new NotImplementedException();
        }

        public LuanVan() 
        {
            _maSo = "";
            _nhanDe = "";
            _namXb = 0;
            _tacGia = "";
        }

        public LuanVan(string maso, string tuade, int namxb, string tacGia)
        {
            _maSo = maso;
            _nhanDe = tuade;
            _namXb = namxb;
            _tacGia = tacGia;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
