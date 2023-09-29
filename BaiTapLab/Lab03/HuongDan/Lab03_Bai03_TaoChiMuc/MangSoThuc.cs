using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_Bai03_TaoChiMuc
{
    class MangSoThuc
    {
        private double[] mang;
        private int soLuong;

        public int SoLuong
        { 
            get { return soLuong; } 
        }

        public double this[int viTri]
        { 
            get { return mang[viTri]; } 

            set { mang[viTri] = value; }
        }

        public MangSoThuc()
        {
            mang = new double[1000];
            soLuong = 0;
        }

        public void Them(double so)
        {
            mang[soLuong] = so;
            soLuong++; 
        }

        public void NhapTay(int soPhanTu)
        {
            mang = new double[soPhanTu];
            Console.WriteLine("Nhap cac phan tu cua mang:");
            for (int i = 0; i < soPhanTu; i++)
            {
                Console.Write("Phan tu thu {0}: ", i + 1);
                mang[i] = double.Parse(Console.ReadLine());
            }
            soLuong = soPhanTu;
        }

        public void NhapCoDinh()
        {
            Console.WriteLine("Nhap so luong phan tu cua mang:");
            int soPhanTu = int.Parse(Console.ReadLine());
            mang = new double[soPhanTu];
            Console.WriteLine("Nhap các phan tu cua mang:");
            for (int i = 0; i < soPhanTu; i++)
            {
                Console.Write("Phan tu thu {0}: ", i + 1);
                mang[i] = double.Parse(Console.ReadLine());
            }
            soLuong = soPhanTu;
        }

        public void NhapNgauNhien(int soPhanTu)
        {
            mang = new double[soPhanTu];
            Random random = new Random();
            for (int i = 0; i < soPhanTu; i++)
            {
                mang[i] = random.NextDouble() * 100; // Giới hạn giá trị từ 0 đến 100
            }
            soLuong = soPhanTu;
        }

        public void XuatMang()
        {
            Console.WriteLine("Cac phan tu cua mang:");
            for (int i = 0; i < soLuong; i++)
            {
                Console.WriteLine(mang[i]);
            }
        }

        public MangSoThuc TimSoAm()
        {
            MangSoThuc mangSoAm = new MangSoThuc();
            for (int i = 0; i < soLuong; i++)
            {
                if (mang[i] < 0)
                {
                    mangSoAm.Them(mang[i]);
                }
            }
            return mangSoAm;
        }
    }
}
