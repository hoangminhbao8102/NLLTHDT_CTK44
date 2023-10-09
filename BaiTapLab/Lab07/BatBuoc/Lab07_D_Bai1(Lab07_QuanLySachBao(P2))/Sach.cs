using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_D_Bai1_Lab07_QuanLySachBao_P2__
{
    public class Sach : TaiLieu
    {
        private new string _nhaXb;
        private new MangChuoi _tacGia;

        public string NhaXB
        {
            get { return _nhaXb; }
            set { _nhaXb = value; }
        }

        public override bool LaCongTrinhCua(string tenTacGia)
        {
            return _tacGia.ChuaChuoi(tenTacGia);
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
            _tacGia = new MangChuoi();
        }

        public Sach(string maso, string tuade, int namxb, string nhaXb, string[] cacTacGia)
        {
            _maSo = maso;
            _nhanDe = tuade;
            _namXb = namxb;
            _nhaXb = nhaXb;
            _tacGia = new MangChuoi(cacTacGia);
        }

        public void ThemTacGia(string tenTg)
        {
            _tacGia.Them(tenTg);
        }

        public override string ToString()
        {
            return $"Ma so: {_maSo}, Tua de: {_nhanDe}, Nam xuat ban: {_namXb}, Nha xuat ban: {_nhaXb}, Tac gia: {_tacGia.ToString()}";
        }
    }
}
