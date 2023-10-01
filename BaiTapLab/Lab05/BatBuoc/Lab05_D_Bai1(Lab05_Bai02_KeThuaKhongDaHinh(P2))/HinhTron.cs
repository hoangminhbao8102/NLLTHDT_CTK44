using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_D_Bai1_Lab05_Bai02_KeThuaKhongDaHinh_P2__
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

        public new void Xuat()
        {
            Console.WriteLine("Hinh tron ban kinh {0}, dien tich = {1}", canh, TinhDienTich());
        }
    }
}
