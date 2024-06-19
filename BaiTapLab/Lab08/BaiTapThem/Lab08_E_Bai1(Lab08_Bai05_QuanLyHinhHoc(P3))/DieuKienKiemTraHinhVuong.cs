using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_E_Bai1_Lab08_Bai05_QuanLyHinhHoc_P3__
{
    public class DieuKienKiemTraHinhVuong : IDieuKienTimKiem
    {
        public bool KiemTra(IHinhHoc hinh)
        {
            if (hinh.LayKieuHinh() == LoaiHinh.HinhVuong)
            {
                return true;
            }
            return false;
        }
    }
}
