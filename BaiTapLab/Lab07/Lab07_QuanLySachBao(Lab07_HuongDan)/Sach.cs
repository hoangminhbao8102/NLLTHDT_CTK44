using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_QuanLySachBao_Lab07_HuongDan_
{
    public class Sach : TaiLieu
    {
        private string _nhaXb;
        private MangChuoi _tacGia;

        public string NhaXB
        {
            get { return _nhaXb; } 
            set {  _nhaXb = value; }
        }

        public override bool LaCongTrinhCua(string tenTacGia)
        {
            throw new NotImplementedException();
        }

        public Sach()
        {
            _maSo = "";
            _nhanDe = "";
            _namXb = 0;
            _nhaXb = "";
            _tacGia = new MangChuoi();
        }

        public Sach(string maso, string tuade, int namxb, string nhaXb) 
        {
            _maSo = maso;
            _nhanDe = tuade;
            _namXb = namxb;
            _nhaXb = nhaXb;
        }

        public Sach(string maso, string tuade, int namxb, string nhaXb, string[] cacTacGia)
        {
            _maSo = maso;
            _nhanDe = tuade;
            _namXb = namxb;
            _nhaXb = nhaXb;
            _tacGia = cacTacGia;
        }
    }
}
