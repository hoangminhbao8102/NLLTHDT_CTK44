using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_E_Bai2
{
    class DanhSachHinh3D
    {
        private List<HinhHoc3D> danhSachHinh = new List<HinhHoc3D>();

        public void ThemHinh(HinhHoc3D hinh)
        {
            danhSachHinh.Add(hinh);
        }

        public void XuatThongTin()
        {
            foreach (var hinh in danhSachHinh)
            {
                Console.WriteLine(hinh);
            }
        }

        public void SapXepGiamDanTheoTheTich()
        {
            danhSachHinh.Sort((h1, h2) => h2.TinhTheTich().CompareTo(h1.TinhTheTich()));
        }

        public HinhHoc3D TimHinhTheoLoai(string loaiHinh)
        {
            return danhSachHinh.FirstOrDefault(h => h.GetType().Name == loaiHinh);
        }

        public HinhCau TimHinhCauCoTheTichNhoNhat()
        {
            return danhSachHinh.OfType<HinhCau>().OrderBy(h => h.TinhTheTich()).FirstOrDefault();
        }

        public HinhHoc3D TimHinhCoTheTichLonNhatKhongPhaiLaNonHoacCau()
        {
            return danhSachHinh.Where(h => !(h is HinhNon || h is HinhCau))
                               .OrderByDescending(h => h.TinhTheTich())
                               .FirstOrDefault();
        }
    }
}
