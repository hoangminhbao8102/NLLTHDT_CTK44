using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_D_Bai2_Lab05_Bai02_KeThuaKhongDaHinh_P3__
{
    class HinhTron : HinhHoc
    {
        public double BanKinh
        {
            get { return canh; }
        }

        public HinhTron(double banKinh) : base(banKinh)
        {
        }

        public new double TinhDienTich()
        {
            return canh * canh * Math.PI;
        }

        public new double TinhChuVi()
        {
            return canh * 2 * Math.PI;
        }

        public new void Xuat()
        {
            Console.WriteLine("Hinh tron ban kinh {0}, dien tich = {1}", canh, TinhDienTich());
        }
    }
}
