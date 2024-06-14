using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_D_Bai2_QuanLyNhanVien_
{
    class DuLieuNguon
    {
        private static BoDocDuLieu _boDoc;

        static DuLieuNguon()
        {
            string cauHinh = System.IO.File.ReadAllText(@"Data\CauHinh.txt");

            switch (cauHinh)
            {
                case "taptin":
                    _boDoc = new BoDocDuLieuTuFile(@"Data\NhanVien.txt", @"Data\ChamCong.txt");
                    break;
                case "banphim":
                    _boDoc = new BoDocDuLieuTuBanPhim();
                    break;
            }
        }

        public static DanhSachNhanVien TaoDanhSachNhanVien()
        {
            return _boDoc.DocDuLieuNhanVien();
        }

        public static DanhSachChamCong TaoDanhSachChamCong()
        {
            return _boDoc.DocDuLieuChamCong();
        }
    }
}
