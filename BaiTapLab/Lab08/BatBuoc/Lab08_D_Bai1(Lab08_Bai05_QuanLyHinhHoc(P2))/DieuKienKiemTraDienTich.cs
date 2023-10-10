using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_D_Bai1_Lab08_Bai05_QuanLyHinhHoc_P2__
{
    public class DieuKienKiemTraDienTich : IDieuKienTimKiem
    {
        private double dienTich;

        public DieuKienKiemTraDienTich(double dienTich)
        {
            this.dienTich = dienTich;
        }

        public bool KiemTra(IHinhHoc hinh)
        {
            if (hinh.TinhDienTich() == dienTich)
            {
                return true;
            }
            return false;
        }
    }
}
