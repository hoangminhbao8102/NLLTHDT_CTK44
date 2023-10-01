using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_D_Bai1_Lab05_Bai02_KeThuaKhongDaHinh_P2__
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
