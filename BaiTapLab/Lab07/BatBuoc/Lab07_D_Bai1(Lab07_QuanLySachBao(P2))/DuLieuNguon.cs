using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_D_Bai1_Lab07_QuanLySachBao_P2__
{
    public class DuLieuNguon
    {
        private static BoDocDuLieu _boDoc;

        static DuLieuNguon()
        {
            string cauHinh = System.IO.File.ReadAllText(@"Data\CauHinh.txt");

            switch (cauHinh)
            {
                case "taptin":
                    _boDoc = new BoDocDuLieuTuFile(@"Data\ThuVien.txt");
                    break;
                case "banphim":
                    _boDoc = new BoDocDuLieuTuBanPhim();
                    break;
                case "dulieugia":
                    _boDoc = new BoDocDuLieuGia();
                    break;
            }
        }

        public static DanhSachTaiLieu TaoDanhSach()
        {
            return _boDoc.DocDuLieu();
        }
    }
}
