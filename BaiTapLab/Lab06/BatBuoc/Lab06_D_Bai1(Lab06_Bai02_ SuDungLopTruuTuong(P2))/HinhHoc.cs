using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_D_Bai1_Lab06_Bai02__SuDungLopTruuTuong_P2__
{
    public abstract class HinhHoc
    {
        protected double canh;
        
        protected HinhHoc(double cd)
        {
            canh = cd;
        }

        public abstract double TinhChuVi();

        public abstract double TinhDienTich();

        public abstract void Xuat();
    }
}
