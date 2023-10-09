using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_Bai02_ThucThiNhieuGiaoDien
{
    public class HinhTron : IHinhHoc, IBienDoi
    {
        private double banKinh;
        private double x;
        private double y;

        public double BanKinh
        {
            get { return banKinh; }
        }

        public double X
        {
            get { return x; }
        }

        public double Y
        {
            get { return y; }
        }

        public HinhTron(double xc, double yc, double r)
        {
            x = xc;
            y = yc;
            banKinh = r;
        }

        public double TinhChuVi()
        {
            return 2 * banKinh * Math.PI;
        }

        public double TinhDienTich()
        {
            return banKinh * banKinh * Math.PI;
        }

        public void ThuPhong(double tyLe)
        {
            banKinh *= tyLe;
        }

        public void TinhTien(double dx, double dy)
        {
            x += dx;
            y += dy;
        }

        public override string ToString()
        {
            return string.Format("Hinh tron tam O({0}, {1}), Ban kinh = {2}", x, y, banKinh);
        }
    }
}
