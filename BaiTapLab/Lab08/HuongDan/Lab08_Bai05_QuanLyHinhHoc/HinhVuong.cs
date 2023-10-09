using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_Bai05_QuanLyHinhHoc
{
    public class HinhVuong : IHinhHoc
    {
        private double canh;

        public double Canh
        {
            get { return canh; }
        }

        public HinhVuong(double canh)
        {
            this.canh = canh;
        }

        public double TinhChuVi()
        {
            return canh * 4;
        }

        public double TinhDienTich()
        {
            return canh * canh;
        }

        public override string ToString() 
        {
            return string.Format("{0}{1}{2}{3}", "Hinh vuong".PadRight(20), canh.ToString().PadRight(20), TinhChuVi().ToString().PadRight(20), TinhDienTich().ToString().PadRight(20));
        }
    }
}
