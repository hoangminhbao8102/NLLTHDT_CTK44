using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_E_Bai1_Lab08_Bai05_QuanLyHinhHoc_P3__
{
    public class HinhVuong : IHinhHoc, IMauSac
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

        public LoaiHinh LayKieuHinh()
        {
            return LoaiHinh.HinhVuong;
        }

        public void ToMau(Color mau)
        {
            Console.WriteLine($"Hinh vuong duoc to mau {mau.Name}");
        }
    }
}
