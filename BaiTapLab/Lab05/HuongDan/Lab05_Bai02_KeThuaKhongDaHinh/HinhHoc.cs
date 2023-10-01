using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_Bai02_KeThuaKhongDaHinh
{
    class HinhHoc
    {
        protected double canh;

        protected HinhHoc(double cd)
        {
            canh = cd;
        }

        public double TinhDienTich()
        {
            return 0;
        }

        public void Xuat()
        {
            Console.WriteLine("Hinh hoc tong quat");
        }
    }
}
