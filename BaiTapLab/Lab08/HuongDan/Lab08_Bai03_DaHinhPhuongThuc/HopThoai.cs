using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_Bai03_DaHinhPhuongThuc
{
    public class HopThoai : ICuaSo, IKhungHinh
    {
        void ICuaSo.HienThi() 
        {
            Console.WriteLine("Hien thi cua so");
        }

        void IKhungHinh.HienThi()
        {
            Console.WriteLine("Hien thi khung hinh");
        }

        public void HienThi()
        {
            Console.WriteLine("Hien thi hop thoai");
        }
    }
}
