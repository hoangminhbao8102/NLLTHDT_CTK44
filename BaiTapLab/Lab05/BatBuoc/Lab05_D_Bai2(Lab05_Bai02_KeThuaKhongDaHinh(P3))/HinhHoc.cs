using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_D_Bai2_Lab05_Bai02_KeThuaKhongDaHinh_P3__
{
    class HinhHoc
    {
        protected double canh;

        public HinhHoc()
        {
            
        }

        protected HinhHoc(double cd)
        {
            canh = cd;
        }

        public double TinhDienTich()
        {
            return 0;
        }

        public double TinhChuVi()
        {
            return 0;
        }

        public void Xuat()
        {
            Console.WriteLine("Hinh hoc tong quat");
        }
    }
}
