using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_D_Bai2_Lab05_Bai02_KeThuaKhongDaHinh_P3__
{
    class HinhVuong : HinhChuNhat
    {
        public HinhVuong(double canh) : base(canh, canh)
        {
        }

        public new void Xuat()
        {
            Console.WriteLine("Hinh vuong co canh {0}, " + "dien tich = {1}", canh, TinhDienTich());
        }
    }
}
