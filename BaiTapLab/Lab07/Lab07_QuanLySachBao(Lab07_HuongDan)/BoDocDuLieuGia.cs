using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_QuanLySachBao_Lab07_HuongDan_
{
    public class BoDocDuLieuGia : BoDocDuLieu
    {
        public override DanhSachTaiLieu DocDuLieu()
        {
            DanhSachTaiLieu thuVien = new DanhSachTaiLieu();

            thuVien.Them(new Sach("S001", "Lap trinh web", 2008, "Lao dong", new string[] { "Nguyen An, Dao Thi Bich" }));
            thuVien.Them(new Sach("S203", "Photoshop", 2011, "Lao dong", new string[] { "Phan Huy Duc" }));
            thuVien.Them(new LuanVan("L100", "Khai thac luat ket hop", 2010, "Nguyen Thanh Tai"));
            thuVien.Them(new BaoKhoaHoc("B440", "Hop chat Canxi cacbonat", 2013, "FACON2013", new string[] { "Hai Au", "Trinh Toan" }));

            return thuVien;
        }
    }
}
