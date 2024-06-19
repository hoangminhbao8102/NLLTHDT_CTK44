using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_E_Bai1_Lab08_Bai05_QuanLyHinhHoc_P3__
{
    public class HinhChuNhat : IHinhHoc, IMauSac
    {
        private double dai;
        private double rong;

        public double ChieuDai
        {
            get { return dai; }
        }

        public double ChieuRong
        {
            get { return rong; }
        }

        public HinhChuNhat(double dai, double rong)
        {
            this.dai = dai;
            this.rong = rong;
        }

        public double TinhChuVi()
        {
            return 2 * (dai + rong);
        }

        public double TinhDienTich()
        {
            return dai * rong;
        }

        public override string ToString()
        {
            return string.Format("{0}{1}{2}{3}{4}", "Hinh chu nhat".PadRight(20), dai.ToString().PadRight(10), rong.ToString().PadRight(10), TinhChuVi().ToString().PadRight(20), TinhDienTich().ToString().PadRight(20));
        }

        public LoaiHinh LayKieuHinh()
        {
            return LoaiHinh.HinhChuNhat;
        }

        public void ToMau(Color mau)
        {
            Console.WriteLine($"Hinh chu nhat duoc to mau {mau.Name}");
        }
    }
}
