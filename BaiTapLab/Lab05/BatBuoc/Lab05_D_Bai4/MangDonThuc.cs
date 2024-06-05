using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_D_Bai4
{
    public class MangDonThuc
    {
        private List<DonThuc> donThucs = new List<DonThuc>();

        // Nhập cố định một danh sách đơn thức
        public void NhapCoDinh()
        {
            donThucs.Add(new DonThuc(new HeSoThuc(3), 5));
            donThucs.Add(new DonThuc(new HeSoThuc(10.75), 2));
            donThucs.Add(new DonThuc(new HeSoPhanSo(new PhanSo(3, 4)), 4));
        }

        // Thêm một đơn thức vào mảng
        public void ThemDonThuc(DonThuc donThuc)
        {
            donThucs.Add(donThuc);
        }

        // Xuất danh sách đơn thức ra màn hình
        public void XuatDanhSach()
        {
            foreach (var dt in donThucs)
            {
                Console.WriteLine($"Đơn thức: {dt.HeSo.LayGiaTri()}x^{dt.SoMu}");
            }
        }

        // Tính tổng giá trị tất cả các đơn thức tại giá trị x cho trước
        public double TinhTongGiaTri(double x)
        {
            double sum = 0;
            foreach (var dt in donThucs)
            {
                sum += dt.TinhGiaTri(x);
            }
            return sum;
        }

        // Tính giá trị trung bình cộng của tất cả các đơn thức tại giá trị x cho trước
        public double TinhGiaTriTrungBinh(double x)
        {
            return TinhTongGiaTri(x) / donThucs.Count;
        }

        // Đếm số lượng đơn thức có hệ số là phân số
        public int DemDonThucHeSoPhanSo()
        {
            int count = 0;
            foreach (var dt in donThucs)
            {
                if (dt.HeSo is HeSoPhanSo)
                    count++;
            }
            return count;
        }

        // Tìm số mũ lớn nhất trong các đơn thức
        public int TimSoMuLonNhat()
        {
            int maxExp = int.MinValue;
            foreach (var dt in donThucs)
            {
                if (dt.SoMu > maxExp)
                    maxExp = dt.SoMu;
            }
            return maxExp;
        }

        // Tìm đơn thức với hệ số có giá trị nhỏ nhất
        public DonThuc TimDonThucHeSoNhoNhat()
        {
            DonThuc minCoefDT = null;
            double minCoef = double.MaxValue;
            foreach (var dt in donThucs)
            {
                double coefValue = dt.HeSo.LayGiaTri();
                if (coefValue < minCoef)
                {
                    minCoef = coefValue;
                    minCoefDT = dt;
                }
            }
            return minCoefDT;
        }
    }
}
