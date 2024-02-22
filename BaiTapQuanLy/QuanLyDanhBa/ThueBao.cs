using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDanhBa
{
    enum GioiTinh
    {
        Nam,
        Nu
    }
    class ThueBao
    {
        public string SoCMND;
        public string HoTen;
        public string DiaChi;
        public GioiTinh GioiTinh;
        public DateTime NgaySinh;
        public string SDT;
        public ThueBao()
        {
            
        }
        public ThueBao(string soCMND, string hoTen, string diaChi, GioiTinh gioiTinh, DateTime ngaySinh, string sDT)
        {
            this.SoCMND = soCMND;
            this.HoTen = hoTen;
            this.DiaChi = diaChi;
            this.GioiTinh = gioiTinh;
            this.NgaySinh = ngaySinh;
            this.SDT = sDT;
        }
        public ThueBao(string line)
        {
            string[] s = line.Split(',');

            this.SoCMND = s[0].Trim();
            this.HoTen = s[1].Trim();
            this.DiaChi = s[2].Trim();
            this.GioiTinh = s[3].Trim() == "Nam" ? GioiTinh.Nam : GioiTinh.Nu;
            this.NgaySinh = DateTime.Parse(s[4]);
            this.SDT = s[5];
        }
        public void Xuat()
        {
            Console.WriteLine("{0} {1} {2} {3} {4} {5}", SoCMND, HoTen, DiaChi, GioiTinh, NgaySinh, SDT);
        }
        public override string ToString()
        {
            string s = "{0} {1} {2} {3} {4} {5} \r\n";
            return string.Format(s, SoCMND.PadRight(7), HoTen.PadRight(15), DiaChi.PadRight(40), GioiTinh, NgaySinh.ToShortDateString().PadRight(11), SDT.PadRight(10));
        }
    }
}
