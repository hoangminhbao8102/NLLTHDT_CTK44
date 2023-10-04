using System;
using System.Collections.Generic;
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
        }

        public BaoKhoaHoc(string maso, string tuade, int namxb, string hoiNghi, string[] cacTacGia)
        {
            _maSo = maso;
            _nhanDe = tuade;
            _namXb = namxb;
            _hoiNghi = hoiNghi;
            _tacGia = cacTacGia;
        }

        public override bool LaCongTrinhCua(string tenTacGia)
        {
            throw new NotImplementedException();
        }

        public void ThemTacGia(string tenTg)
        {

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
