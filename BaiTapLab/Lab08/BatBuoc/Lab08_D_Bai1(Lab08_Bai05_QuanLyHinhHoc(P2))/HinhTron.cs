using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_D_Bai1_Lab08_Bai05_QuanLyHinhHoc_P2__
{
    public class HinhTron : IHinhHoc
    {
        private double banKinh;

        public double BanKinh
        {
            get { return banKinh; }
        }

        public HinhTron(double r)
        {
            banKinh = r;
        }

        public double TinhChuVi()
        {
            return 2 * banKinh * Math.PI;
        }

        public double TinhDienTich()
        {
            return banKinh * banKinh * Math.PI;
        }

        public override string ToString()
        {
            return string.Format("{0}{1}{2}{3}", "Hinh tron".PadRight(20), banKinh.ToString().PadRight(20), TinhChuVi().ToString().PadRight(20), TinhDienTich().ToString().PadRight(20));
        }

        public LoaiHinh LayKieuHinh()
        {
            return LoaiHinh.HinhTron;
        }


        public bool CoTheNoiTiepHinhVuong(HinhVuong hinhVuong)
        {
            Console.WriteLine("Nhap ban kinh bat ky : ");
            double banKinh = double.Parse(Console.ReadLine());
            double canh = hinhVuong.Canh;

            double duongCheo = Math.Sqrt(2) * canh;
            if (banKinh >= duongCheo / 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
