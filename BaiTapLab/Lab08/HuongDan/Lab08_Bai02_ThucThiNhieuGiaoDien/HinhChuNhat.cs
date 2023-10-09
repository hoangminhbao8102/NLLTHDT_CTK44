using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_Bai02_ThucThiNhieuGiaoDien
{
    public class HinhChuNhat : IHinhHoc, IBienDoi
    {
        private double tren;
        private double trai;
        private double dai;
        private double rong;

        public double ChieuDai
        {
            get { return dai; }
        }

        public double ChieuRong
        {
            get { return rong; }
        }

        public double PhiaTren
        {
            get { return tren; }
        }

        public double BenTrai
        {
            get { return trai; }
        }

        public HinhChuNhat(int x, int y, double dai, double rong)
        {
            this.trai = x;
            this.tren = y;
            this.dai = dai;
            this.rong = rong;
        }

        public double TinhChuVi()
        {
            return 2 * (dai + rong);
        }

        public double TinhDienTich()
        {
            return dai * rong;
        }

        public void ThuPhong(double tyLe)
        {
            dai *= tyLe;
            rong *= tyLe;
        }

        public void TinhTien(double dx, double dy)
        {
            trai += dx;
            tren += dy;
        }

        public override string ToString()
        {
            return string.Format("Hinh chu nhat: Toa do ({0}, {1}), " + "Dai = {2}, Rong = {3}", trai, tren, dai, rong);
        }
    }
}
