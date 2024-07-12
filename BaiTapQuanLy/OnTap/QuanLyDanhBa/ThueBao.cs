using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDanhBa
{
    class ThueBao
    {
        public string SoCMND { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public GioiTinh GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string SDT { get; set; }
        public DateTime NgayDangKy { get; set; }
        public DateTime? NgayLapDat { get; set; }
        public string NhaCungCap { get; set; }
        public ThueBaoType? LoaiThueBao { get; set; }
        public List<string> DanhSachSoDienThoai { get; set; } = new List<string>();

        public ThueBao() { }

        public ThueBao(string soCMND, string hoTen, string diaChi, GioiTinh gioiTinh, DateTime ngaySinh, string sDT, DateTime ngayDangKy, DateTime? ngayLapDat = null, string nhaCungCap = null, ThueBaoType? loaiThueBao = null)
        {
            SoCMND = soCMND;
            HoTen = hoTen;
            DiaChi = diaChi;
            GioiTinh = gioiTinh;
            NgaySinh = ngaySinh;
            SDT = sDT;
            NgayDangKy = ngayDangKy;
            NgayLapDat = ngayLapDat;
            NhaCungCap = nhaCungCap;
            LoaiThueBao = loaiThueBao;
        }

        public ThueBao(string line)
        {
            string[] parts = line.Split(',');
            SoCMND = parts[0].Trim();
            HoTen = parts[1].Trim();
            DiaChi = parts[2].Trim();
            GioiTinh = parts[3].Trim() == "Nam" ? GioiTinh.Nam : GioiTinh.Nu;
            NgaySinh = DateTime.Parse(parts[4]);
            SDT = parts[5].Trim();
            NgayDangKy = DateTime.Parse(parts[6]);

            if (Enum.TryParse(parts[7].Trim(), out ThueBaoType loaiThueBao))
            {
                LoaiThueBao = loaiThueBao;
            }

            if (LoaiThueBao == ThueBaoType.FixedLine)
            {
                NgayLapDat = DateTime.Parse(parts[8].Trim());
            }
            else if (LoaiThueBao == ThueBaoType.Mobile)
            {
                NhaCungCap = parts[8].Trim();
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
