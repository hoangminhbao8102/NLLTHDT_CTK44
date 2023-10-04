using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_QuanLySachBao_Lab07_HuongDan_
{
    public class BaoKhoaHoc : TaiLieu
    {
        private string _hoiNghi;
        private MangChuoi _tacGia;

        public string HoiNghi
        {
            get { return _hoiNghi; }
            set { _hoiNghi = value; }
        }

        public BaoKhoaHoc()
        {
            _maSo = "";
            _nhanDe = "";
            _namXb = 0;
            _hoiNghi = "";
            _tacGia = new MangChuoi();
        }

        public BaoKhoaHoc(string maso, string tuade, int namxb, string hoiNghi)
        {
            _maSo = maso;
            _nhanDe = tuade;
            _namXb = namxb;
            _hoiNghi = hoiNghi;
            _tacGia = new MangChuoi();
        }

        public BaoKhoaHoc(string maso, string tuade, int namxb, string hoiNghi, string[] cacTacGia)
        {
            _maSo = maso;
            _nhanDe = tuade;
            _namXb = namxb;
            _hoiNghi = hoiNghi;
            _tacGia = new MangChuoi(cacTacGia);
        }

        public override bool LaCongTrinhCua(string tenTacGia)
        {
            return _tacGia.ChuaChuoi(tenTacGia);
        }

        public void ThemTacGia(string tenTg)
        {
            _tacGia.Them(tenTg);
        }

        public override string ToString()
        {
            string result = $"Ma so: {_maSo}\nTua de: {_nhanDe}\nNam xuat ban: {_namXb}\nHoi nghi: {_hoiNghi}\nTac gia: {_tacGia.ToString()}";
            return result;
        }
    }
}
