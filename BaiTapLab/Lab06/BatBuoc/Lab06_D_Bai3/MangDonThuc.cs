using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_D_Bai3
{
    class MangDonThuc
    {
        private List<DonThuc> donThucs = new List<DonThuc>();

        public void NhapCoDinh()
        {
            donThucs.Add(new DonThuc(new HeSoThuc(3), 5));
            donThucs.Add(new DonThuc(new HeSoThuc(10.75), 2));
            donThucs.Add(new DonThuc(new HeSoPhanSo(new PhanSo(3, 4)), 4));
        }

        public void ThemDonThuc(DonThuc dt)
        {
            donThucs.Add(dt);
        }

        public void Xuat()
        {
            foreach (var dt in donThucs)
            {
                Console.WriteLine($"Don thuc: {dt.HeSo.LayGiaTri()}x^{dt.SoMu}");
            }
        }

        public double TinhTongGiaTri(double x)
        {
            return donThucs.Sum(dt => dt.TinhGiaTri(x));
        }

        public double TinhGiaTriTrungBinh(double x)
        {
            return TinhTongGiaTri(x) / donThucs.Count;
        }

        public int DemDonThucPhanSo()
        {
            return donThucs.Count(dt => dt.HeSo is HeSoPhanSo);
        }

        public int TimSoMuLonNhat()
        {
            return donThucs.Max(dt => dt.SoMu);
        }

        public DonThuc TimDonThucHeSoNhoNhat()
        {
            return donThucs.OrderBy(dt => dt.HeSo.LayGiaTri()).FirstOrDefault();
        }
    }
}
