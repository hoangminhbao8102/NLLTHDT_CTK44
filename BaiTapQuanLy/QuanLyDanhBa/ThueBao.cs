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

    enum ThueBaoType
    {
        Mobile,
        FixedLine
    }

    class ThueBao
    {
        public string SoCMND;
        public string HoTen;
        public string DiaChi;
        public GioiTinh GioiTinh;
        public DateTime NgaySinh;
        public string SDT;
        public DateTime NgayDangKy;        // Date of registration
        public DateTime? NgayLapDat;       // Installation date for fixed line (nullable)
        public string NhaCungCap;          // Service provider for mobile (nullable)
        public ThueBaoType? LoaiThueBao;   // Type of subscriber: mobile or fixed line
        public List<string> DanhSachSoDienThoai = new List<string>();  // Danh sách quản lý các số điện thoại

        public ThueBao()
        {
        }

        public ThueBao(string soCMND, string hoTen, string diaChi, GioiTinh gioiTinh, DateTime ngaySinh, string sDT, DateTime ngayDangKy, DateTime? ngayLapDat = null, string nhaCungCap = null, ThueBaoType? loaiThueBao = null)
        {
            this.SoCMND = soCMND;
            this.HoTen = hoTen;
            this.DiaChi = diaChi;
            this.GioiTinh = gioiTinh;
            this.NgaySinh = ngaySinh;
            this.SDT = sDT;
            this.NgayDangKy = ngayDangKy;
            this.NgayLapDat = ngayLapDat;
            this.NhaCungCap = nhaCungCap;
            this.LoaiThueBao = loaiThueBao;
        }

        public ThueBao(string line)
        {
            string[] parts = line.Split(',');
            this.SoCMND = parts[0].Trim();
            this.HoTen = parts[1].Trim();
            this.DiaChi = parts[2].Trim();
            this.GioiTinh = parts[3].Trim() == "Nam" ? GioiTinh.Nam : GioiTinh.Nu;
            this.NgaySinh = DateTime.Parse(parts[4]);
            this.SDT = parts[5].Trim();
            this.NgayDangKy = DateTime.Parse(parts[6]);
            this.LoaiThueBao = (ThueBaoType)Enum.Parse(typeof(ThueBaoType), parts[7].Trim());
            if (this.LoaiThueBao == ThueBaoType.FixedLine)
            {
                this.NgayLapDat = DateTime.Parse(parts[8].Trim());
            }
            else if (this.LoaiThueBao == ThueBaoType.Mobile)
            {
                this.NhaCungCap = parts[8].Trim();
            }
        }

        public void Xuat()
        {
            Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8}", SoCMND, HoTen, DiaChi, GioiTinh, NgaySinh.ToShortDateString(), SDT, NgayDangKy.ToShortDateString(), NgayLapDat.HasValue ? NgayLapDat.Value.ToShortDateString() : "N/A", NhaCungCap ?? "N/A");
        }

        public override string ToString()
        {
            string format = "{0} {1} {2} {3} {4} {5} {6} {7} {8} \r\n";
            return string.Format(format, SoCMND.PadRight(7), HoTen.PadRight(15), DiaChi.PadRight(40), GioiTinh, NgaySinh.ToShortDateString().PadRight(11), SDT.PadRight(10), NgayDangKy.ToShortDateString(), NgayLapDat.HasValue ? NgayLapDat.Value.ToShortDateString() : "N/A", NhaCungCap ?? "N/A");
        }
    }
}
