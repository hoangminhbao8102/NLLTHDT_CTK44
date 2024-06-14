using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_D_Bai2_QuanLyNhanVien_
{
    class BoDocDuLieuTuFile : BoDocDuLieu
    {
        private const char SEPARATOR = ',';

        private string _duongDanNhanVien;
        private string _duongDanChamCong;

        public BoDocDuLieuTuFile(string pathNhanVien, string pathChamCong)
        {
            _duongDanNhanVien = pathNhanVien;
            _duongDanChamCong = pathChamCong;
        }

        public override DanhSachChamCong DocDuLieuChamCong()
        {
            DanhSachChamCong danhSach = new DanhSachChamCong();
            using (var reader = new StreamReader(_duongDanChamCong))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(SEPARATOR);
                    if (parts.Length >= 3)
                    {
                        ChamCong cc = new ChamCong(
                            int.Parse(parts[0]),
                            int.Parse(parts[1]),
                            int.Parse(parts[2])
                        );
                        danhSach.Them(cc);
                    }
                }
            }
            return danhSach;
        }

        public override DanhSachNhanVien DocDuLieuNhanVien()
        {
            DanhSachNhanVien danhSach = new DanhSachNhanVien();
            using (var reader = new StreamReader(_duongDanNhanVien))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(SEPARATOR);
                    if (parts[0].ToUpper() == "HD")
                    {
                        var nv = new NhanVienHopDong(
                            int.Parse(parts[1]),
                            parts[2],
                            parts[3],
                            DateTime.Parse(parts[4]),
                            double.Parse(parts[5]),
                            int.Parse(parts[6])
                        );
                        danhSach.Them(nv);
                    }
                    else if (parts[0].ToUpper() == "TG")
                    {
                        var nv = new NhanVienTheoGio(
                            int.Parse(parts[1]),
                            parts[2],
                            parts[3],
                            DateTime.Parse(parts[4]),
                            int.Parse(parts[5])
                        );
                        danhSach.Them(nv);
                    }
                }
            }
            return danhSach;
        }
    }
}
