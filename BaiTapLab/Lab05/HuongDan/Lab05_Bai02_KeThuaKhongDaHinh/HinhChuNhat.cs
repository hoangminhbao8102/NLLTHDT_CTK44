using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_Bai02_KeThuaKhongDaHinh
{
    class HinhChuNhat : HinhHoc
    {
        protected double rong;

        public double ChieuDai
        {
            get { return canh; }
        }

        public double ChieuRong
        {
            get { return rong; }
        }
        public HinhChuNhat(double dai, double rong) : base(dai)
        {
            this.rong = rong;
        }

        public new double TinhDienTich()
        {
            return canh * rong;
        }

        public new void Xuat()
        {
            Console.WriteLine("hinh chu nhat dai {0}, " + "rong {1}, dien tich = {2}", canh, rong, TinhDienTich());
        }
    }
}
