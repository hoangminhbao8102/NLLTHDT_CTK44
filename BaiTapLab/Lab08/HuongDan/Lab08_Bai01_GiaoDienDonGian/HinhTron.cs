using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_Bai01_GiaoDienDonGian
{
    public class HinhTron : IHinhHoc
    {
        private double banKinh;

        public double BanKinh
        {
            get { return banKinh; }
        }

        public HinhTron(double r)
        {
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
    }
}
