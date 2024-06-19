﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_E_Bai3
{
    public class HamCosin : IBieuThuc
    {
        private IBieuThuc _soHang;

        public HamCosin(IBieuThuc soHang)
        {
            _soHang = soHang;
        }

        public double TinhGiaTri()
        {
            return Math.Cos(_soHang.TinhGiaTri());
        }
    }
}
