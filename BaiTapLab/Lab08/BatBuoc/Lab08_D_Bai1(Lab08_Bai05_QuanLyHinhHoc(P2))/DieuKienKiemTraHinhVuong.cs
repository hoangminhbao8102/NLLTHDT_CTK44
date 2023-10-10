﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_D_Bai1_Lab08_Bai05_QuanLyHinhHoc_P2__
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
